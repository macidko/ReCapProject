using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car {CarId = 1, BrandId = 1, ColorId = 1, ModelYear = new DateTime(1998), DailyPrice = 241, Description="asdqwgqwg" },
                new Car {CarId = 2, BrandId = 1, ColorId = 1, ModelYear = new DateTime(1998), DailyPrice = 241, Description="asdqwgqwg" },
                new Car {CarId = 3, BrandId = 1, ColorId = 1, ModelYear = new DateTime(1998), DailyPrice = 241, Description="asdqwgqwg" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("eklendi");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(p => p.CarId == id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetail> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
