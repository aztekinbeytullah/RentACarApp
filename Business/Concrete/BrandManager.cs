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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal BrandDal)
        {
            _brandDal = BrandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Message.InsertSuccess);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Message.DeleteSuccess);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll()); 
        }

        public IDataResult<Brand> GetById(int BrandId)
        {
                return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.Id==BrandId));
        }

        public IResult Update(Brand brand)
        {
           _brandDal.Update(brand);
           return new SuccessResult(Message.UpdateSuccess);
        }
    }
}
