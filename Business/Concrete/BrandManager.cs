using Business.Abstract;
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

        public void Add(Brand Brand)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>


            _brandDal.Add(Brand);
            
        }

        public void Delete(Brand Brand)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _brandDal.Delete(Brand);
        }

        public List<Brand> GetAll()
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            return _brandDal.GetAll();
        }

        public Brand GetById(int Id)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            return null;
        }

        public void Update(Brand Brand)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _brandDal.Update(Brand);
        }
    }
}
