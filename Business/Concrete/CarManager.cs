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
            _carDal.Add(car);
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
            return _carDal.GetById(Id);
        }

        public void Update(Car car)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _carDal.Update(car);
        }
    }
}
