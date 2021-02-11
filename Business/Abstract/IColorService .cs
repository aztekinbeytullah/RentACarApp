using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color car);
        void Update(Color car);
        void Delete(Color car);
        List<Color> GetAll();
        Color GetById(int ColorId);

    }
}
