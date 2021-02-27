using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract.Results;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var isCarRental = _rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate >= DateTime.Now).Any();

            if (isCarRental)
                return new ErrorResult(Message.ThisCarIsNotRental);

            _rentalDal.Add(rental);
            return new SuccessResult(Message.GeneralSuccess);
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Message.Listed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
