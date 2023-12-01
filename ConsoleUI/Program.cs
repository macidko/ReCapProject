using Business.Concrete;
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
            //Car car1 = new Car
            //{
            //    CarId = 1,
            //    BrandId = 2,
            //    ColorId = 3,
            //    DailyPrice = 4,
            //    Description = "test",
            //    ModelYear = new DateTime(2000)
            //};
            //CarManager cars = new CarManager(new InMemoryCarDal());
            //cars.Add(car1);
            //cars.Delete(1);
            //cars.Update(car1);
            //Console.WriteLine(cars.GetById(4).CarId);

            //foreach (var car in cars.GetAll())
            //{
            //    Console.WriteLine("Car Id:" + car.CarId + " " + "Brand Id:" + car.BrandId);
            //}


            //CarManager car = new CarManager(new EfCarDal());
            //foreach (var item in car.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(item.CarId);
            //}  
            //Car test = new Car { BrandId = 1 };

            Car car = new Car
            {
                CarName = "Nisa",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 1,
                ModelYear = new DateTime(2015),
                Description = "BMW 2015"
            };

            CarManager cars = new CarManager(new EfCarDal());

            cars.Add(car);

            //Car car = new Car
            //{
            //    CarId = 1004
            //};

            //CarManager cars = new CarManager(new EfCarDal());
            //cars.Delete(car);

            //foreach (var item in cars.GetAll())
            //{
            //    Console.WriteLine(item.CarName);
            //}
        }
    }
}