using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResults Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                //var x = new ErrorResult("2den fazla karakter gir").Message;
                Console.WriteLine(new ErrorResult("2den fazla karakter gir").Message);
                return new ErrorResult("2den fazla karakter gir");

            }
            _carDal.Add(car);
            Console.WriteLine(new SuccessResult("Ekleme başarılı").Message);
            return new SuccessResult("ekleme başarılı");

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        //public IDataResult<List<Car>> GetAll()
        //{
        //    if (DateTime.Now.Hour != 18)
        //    {
        //        return new DataSuccessResult<List<Car>>(_carDal.GetAll(), Messages.CardListed);
        //    }
        //    return new DataErrorResult<List<Car>>(_carDal.GetAll(), Messages.MaintenanceTime);
        //}     
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour != 18)
            {
                return new DataSuccessResult<List<Car>>(_carDal.GetAll(), Messages.CardListed);
            }
            return new DataErrorResult<List<Car>>(_carDal.GetAll(), Messages.MaintenanceTime);
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

        public IDataResult<List<CarDetail>> GetCarDetails()
        {
            return new DataSuccessResult<List<CarDetail>>(_carDal.GetCarDetails(), "asdqwgqwg");
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
