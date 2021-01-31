using Business.Concrete;
using DataAccess.Concrete.InMemorySimulation;
using Entities.Concrete;
using System;

namespace RentACarAppConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager(new InMemoryCarDal());

            //--------------------------------------------------------------
            Console.WriteLine("--- Tüm Araçların Listesi ---");
            foreach (var car in _carManager.GetAll())
            {
                Console.WriteLine("CarID: " + car.Id + " MarkaID: " + car.BrandId + " Model Year:" + car.ModelYear +
                    " Günlük Kirası:" + car.DailyPrice + " Açıklama:" + car.Description);
            }

            //--------------------------------------------------------------
            Console.WriteLine(" ");
            Console.WriteLine(" Yeni Aracın Eklenmesi ve Tüm Araçların Yeniden Listelenmesi");
            Car car1 = new Car()
            {
                Id = 6,
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 330, 
                Description = "Yeni Eklenen Araç", 
                ModelYear = 2021
            };
            _carManager.Add(car1);
            foreach (var car in _carManager.GetAll())
            {
                Console.WriteLine("CarID: " + car.Id + " MarkaID: " + car.BrandId + " Model Year:" + car.ModelYear +
                    " Günlük Kirası:" + car.DailyPrice + " Açıklama:" + car.Description);
            }

            //--------------------------------------------------------------
            Console.WriteLine(" ");
            Console.WriteLine(" ID numarası 2 Olan Aracın Açıklamasının Güncellenmesi ve Tüm Araçların Yeniden Listelenmesi");
            Car car2 = new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 200, Description = "Değiştirilen Açıklama" };
            _carManager.Update(car2);
            foreach (var car in _carManager.GetAll())
            {
                Console.WriteLine("CarID: " + car.Id + " MarkaID: " + car.BrandId + " Model Year:" + car.ModelYear +
                    " Günlük Kirası:" + car.DailyPrice + " Açıklama:" + car.Description);
            }

            //--------------------------------------------------------------
            Console.WriteLine(" ");
            Console.WriteLine(" ID numarası 5 Olan Aracın Silinmesi ve Tüm Araçların Yeniden Listelenmesi");
            Car car5 = new Car { Id = 5};
            _carManager.Delete(car5);
            foreach (var car in _carManager.GetAll())
            {
                Console.WriteLine("CarID: " + car.Id + " MarkaID: " + car.BrandId + " Model Year:" + car.ModelYear +
                    " Günlük Kirası:" + car.DailyPrice + " Açıklama:" + car.Description);
            }

            //--------------------------------------------------------------
            Console.WriteLine(" ");
            Console.WriteLine(" ID numarası 3 Olan Aracın Bilgilerinin Getirilmesi");
             Car car3= _carManager.GetById(3);      
            Console.WriteLine("CarID: " + car3.Id + " MarkaID: " + car3.BrandId + " Model Year:" + car3.ModelYear +
                    " Günlük Kirası:" + car3.DailyPrice + " Açıklama:" + car3.Description);
          
        }
    }
}
