using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        } 
        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Ekleme Başarılı");

            }
            else { Console.WriteLine("İsim 2 karakterden uzun olmalı ve fiyat 0'dan büyük olmalı."); }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(p => p.CarId == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetCarsByBrandId2(Car car)
        {
            return _carDal.GetAll(p => p.BrandId == car.BrandId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<CarDetail> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        //ICarDal _carDal;

        //public CarManager(ICarDal carDal)
        //{
        //    _carDal = carDal;
        //}

        //public void Add(Car car)
        //{
        //    _carDal.Add(car);
        //}

        //public void Delete(int id)
        //{
        //    _carDal.Delete(id);
        //}

        //public List<Car> GetAll()
        //{
        //    return _carDal.GetAll();
        //}

        //public Car GetById(int id)
        //{
        //    return _carDal.GetById(id);
        //}

        //public void Update(Car car)
        //{
        //    _carDal.Update(car);
        //}
    }
}
