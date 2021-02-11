using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal ColorDal)
        {
            _colorDal = ColorDal;
        }

        public void Add(Color Color)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>


            _colorDal.Add(Color);
            
        }

        public void Delete(Color Color)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _colorDal.Delete(Color);
        }

        public List<Color> GetAll()
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            return _colorDal.GetAll();
        }

        public Color GetById(int Id)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            return null;
        }

        public void Update(Color Color)
        {
            //Gerekli İş kodları ve kontrolleri sağlandıktan sonra...>
            _colorDal.Update(Color);
        }
    }
}
