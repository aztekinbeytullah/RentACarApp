using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Abstract.Results;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(Car))]
        public IResult Add(Car car)
        {
            //Eklenen arabaların günlük kira bedelleri 150 Tlnin üstünde olsun.

            IResult result = BusinessRules.Run(
                                CheckIfCarDailyPriceMinPrice(car.DailyPrice)
                             );

            if (result != null)
            {
                return result;
            }
            _carDal.Add(car);
                return new SuccessResult(Message.InsertSuccess);

        }

       

        public IResult Delete(Car car)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _carDal.Delete(car);
            return new SuccessResult(Message.InsertSuccess);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(b => b.Id == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarList()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetail());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IResult Update(Car car)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _carDal.Update(car);
            return new SuccessResult(Message.UpdateSuccess);
        }


        private IResult CheckIfCarDailyPriceMinPrice(decimal dailyPrice)
        {
            if (dailyPrice<150)
            {
                return new ErrorResult(Message.DailyPriceUnderMinPrice);
            }
            return new SuccessResult();
        }



    }
}
