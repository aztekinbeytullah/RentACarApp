using Business.Abstract;
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

        public void Add(Car car)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            //YEni araç eklendiğinde
            if (car.Name.Length>=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            
        }

        public void Delete(Car car)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            return _carDal.GetAll();
        }

        public Car GetById(int Id)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            return null;
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
           return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _carDal.Update(car);
        }
    }
}
