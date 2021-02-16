using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>>GetAll();
        IDataResult<List<Brand>>GetCarsByBrandId(int id);
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
        IResult< Brand> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
