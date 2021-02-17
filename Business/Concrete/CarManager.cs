using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract.Results;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IResult Add(Car car)
        {
            if (car.Name.Length>=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccessResult(Message.InsertSuccess);
            }
            return new ErrorResult(Message.InsertError);

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

        
    }
}
