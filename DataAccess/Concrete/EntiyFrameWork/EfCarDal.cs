using DataAccess.Absract;
using Entites.Concerete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntiyFrameWork
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentACarContext context= new RentACarContext())  {
                var addenEntity = context.Entry(entity);
                addenEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Car entity)
        {
            using(RentACarContext context =new RentACarContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Added;

            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);

            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
