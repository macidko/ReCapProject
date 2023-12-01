using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        //    public void Add(Car entity)
        //    {
        //        using (ReCapProjectContext context = new ReCapProjectContext())
        //        {
        //            var addedEntity = context.Add(entity);
        //            addedEntity.State = EntityState.Added;
        //            context.SaveChanges();
        //        }
        //    }

        //    public void Delete(Car entity)
        //    {
        //        using (ReCapProjectContext context = new ReCapProjectContext())
        //        {
        //            var deletedEntity = context.Entry(entity);
        //            deletedEntity.State = EntityState.Deleted;
        //            context.SaveChanges();
        //        }
        //    }

        //    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //    {
        //        using (ReCapProjectContext context = new ReCapProjectContext())
        //        {
        //            return filter == null
        //                ? context.Set<Car>().ToList()
        //                : context.Set<Car>().Where(filter).ToList();
        //        }
        //    }

        //    public Car GetById(Expression<Func<Car, bool>> filter)
        //    {
        //        using (ReCapProjectContext context = new ReCapProjectContext())
        //        {
        //            return context.Set<Car>().SingleOrDefault(filter);
        //            //return (Car)context.Set<Car>().Where(filter);
        //        }
        //    }

        //    public void Update(Car entity)
        //    {
        //        using (ReCapProjectContext context = new ReCapProjectContext())
        //        {
        //            var updateEntity = context.Entry(entity);
        //            updateEntity.State = EntityState.Modified;
        //            context.SaveChanges();
        //        }
        //    }
        public List<CarDetail> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetail
                             {
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ColorName = co.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
