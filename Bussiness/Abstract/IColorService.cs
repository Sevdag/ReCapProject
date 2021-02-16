using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        IDataResul<List<Color>> GetAll();
        IDataResult<List<Color>> GetCarsByBrandId(int id);
        IDataResult<List<Color>> GetCarsByColorId(int id);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        IResult<Color> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}
