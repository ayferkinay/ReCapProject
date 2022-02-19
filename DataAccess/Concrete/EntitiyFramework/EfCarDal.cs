﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarContext context =new CarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Remove(Car entity)
        {
            using (CarContext context =new CarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public void Update(Car entity)
        {
           using(CarContext context =new CarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified; 
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarContext context =new CarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null 
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

      
    }
}
