using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemorySimulation
{
    public class InMemoryCarDal : ICarDal
    {
        #region Fake Veri Seti Oluşturma
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=180,Description="1. Numaralı Araç Açıklaması"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=200,Description="2. Numaralı Araç Açıklaması"},
                new Car{Id=3,BrandId=1,ColorId=2,ModelYear=2011,DailyPrice=220,Description="3. Numaralı Araç Açıklaması"},
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear=2011,DailyPrice=240,Description="4. Numaralı Araç Açıklaması"},
                new Car{Id=5,BrandId=1,ColorId=3,ModelYear=2012,DailyPrice=250,Description="5. Numaralı Araç Açıklaması"},
            };
        }
        #endregion

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar= _cars.Where(c => c.Id == car.Id).SingleOrDefault();
            _cars.Remove(deletedCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).SingleOrDefault();
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.Where(c => c.Id == car.Id).SingleOrDefault();
            updatedCar.Id = car.Id;
            updatedCar.ColorId = car.ColorId;
            updatedCar.BrandId = car.BrandId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            updatedCar.ModelYear = car.ModelYear;
        }
    }



}
