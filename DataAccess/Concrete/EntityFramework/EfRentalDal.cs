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
                var result= from rental in context.Rentals
                            join car in context.Cars
                            on rental.CarId equals car.Id

                            join 

            }


            return null;
        }

    }
}
