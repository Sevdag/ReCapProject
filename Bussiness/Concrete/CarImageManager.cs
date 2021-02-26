using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(IFormFile file, CarImages carImage)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CarImages carImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImages> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImages>> GetImagesByCarId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile file, CarImages carImage)
        {
            throw new NotImplementedException();
        }
    }
}
