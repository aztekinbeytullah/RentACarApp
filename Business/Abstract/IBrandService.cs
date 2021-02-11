using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand car);
        void Update(Brand car);
        void Delete(Brand car);
        List<Brand> GetAll();
        Brand GetById(int BrandId);
    }
}
