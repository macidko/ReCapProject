using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{ 
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car GetById(int id);
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);

        List<CarDetail> GetCarDetails();
    }
}
