using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(p => p.ColorId == id);
        }

        public List<Color> GetCarsByBrandId(int id)
        {
            return _colorDal.GetAll(p => p.ColorId == id);
        }

        public List<Color> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
