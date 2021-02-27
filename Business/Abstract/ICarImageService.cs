using Core.Utilities.Abstract.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file,CarImage carimage);
        IResult Update(CarImage carimage);
        IResult Delete(CarImage carimage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int carImageId);
        IDataResult<List<CarImage>> GetImagesByCarId(int CarId);
    }
}
