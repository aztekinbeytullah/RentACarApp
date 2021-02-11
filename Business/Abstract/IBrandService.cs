using Core.Utilities.Abstract.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand car);
        IResult Update(Brand car);
        IResult Delete(Brand car);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int BrandId);
    }
}
