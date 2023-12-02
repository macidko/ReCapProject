using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
            //}

            //Car newCar = new Car
            //{
            //    BrandId = 1,
            //    CarName = "q",
            //    ColorId = 1,
            //    DailyPrice = 0,
            //    Description = "Test",
            //    ModelYear = new DateTime(1998)
            //};
            ////carManager.Add(newCar);
            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetAll();

            //foreach (var car in carManager.GetAll())
            //{

            //}

            CarManager cm = new CarManager(new EfCarDal());
            var result = cm.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}