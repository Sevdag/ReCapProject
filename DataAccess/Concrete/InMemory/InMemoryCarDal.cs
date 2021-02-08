using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 2, DailyPrice= 550, ModelYear=2016, Description="...................."},
                new Car{CarId = 2, BrandId = 1, ColorId = 3, DailyPrice= 600, ModelYear=2017, Description="...................."},
                new Car{CarId = 3, BrandId = 2, ColorId = 3, DailyPrice= 800, ModelYear=2018, Description="..................."},
                new Car{CarId = 4, BrandId = 2, ColorId = 1, DailyPrice= 1000, ModelYear=2019, Description="..........................."},
                new Car{CarId = 5, BrandId = 3, ColorId = 2, DailyPrice= 1200, ModelYear=2020, Description=".................."},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
