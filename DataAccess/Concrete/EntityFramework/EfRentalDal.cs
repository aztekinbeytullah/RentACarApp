using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentacarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentacarContext context=new RentacarContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id
                             join customer in context.Customers on rental.CustomerId equals customer.Id
                             //join user in context.Users on 
                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarId = car.Id,
                                 CarName = car.CarName,
                                 Brand = brand.BrandName,
                                 Color = color.ColorName,
                                 CompanyName = customer.CompanyName,
                                 CustomerId = customer.Id,
                                 RentDate=rental.RentDate,
                                 ReturnDate=rental.ReturnDate
                             };

            }


            return null;
        }

    }
}
