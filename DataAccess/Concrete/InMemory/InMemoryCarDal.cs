using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150, Description = "BMW F30 Red", ModelYear = 2015, Name = "BMW" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 300, Description = "Mercedes C180 Silver", ModelYear = 2020, Name = "Mercedes" },
                new Car { Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 350, Description = "Audi RS7 Dark Blue", ModelYear = 2019, Name = "Audi" },
                new Car { Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 450, Description = "Rolls Royce Cullinan Pox Rengi", ModelYear = 2013, Name = "Rolls Royce" },
                new Car { Id = 5, BrandId = 5, ColorId = 5, DailyPrice = 550, Description = "Nissan GTR Silver", ModelYear = 2003, Name = "Nissan" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Name = car.Name;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
