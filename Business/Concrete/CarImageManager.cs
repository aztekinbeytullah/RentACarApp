using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Abstract.Results;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(IFormFile file, CarImage carImage)
        { 
            IResult result = BusinessRules.Run(
                                CheckIfCarPhotosMax(carImage.CarId)
                                );
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Message.InsertSuccess);
        }

      

        public IResult Delete(CarImage carImage)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _carImageDal.Delete(carImage);
            return new SuccessResult(Message.DeleteSuccess);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());

        }

        public IDataResult<CarImage> GetById(int carImageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id ==carImageId));
        }

        public IResult Update(CarImage carImage)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _carImageDal.Update(carImage);
            return new SuccessResult(Message.UpdateSuccess);
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int CarId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(CarId));
        }

        private List<CarImage> CheckIfCarImageNull(int carId)
        {
            string path = @"\Resources\CarResources\logo.jpg";
            var result = _carImageDal.GetAll(x => x.CarId == carId);
            if (result.Count==0)
            {
                return new List<CarImage> { new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now }};
            }
            return result;
        }

        private IResult CheckIfCarPhotosMax(int carId)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carId).Count;
            if (result < 5)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Message.MaxPhotosForThisCar);
        }


    }
}
