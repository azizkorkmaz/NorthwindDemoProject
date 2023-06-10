
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entiity)
        {
            //IDisposable patern implementation of c#
            using (NorthwindContex contex = new NorthwindContex())
            {
                var addedEntity = contex.Entry(entiity);
                addedEntity.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(Product entiity)
        {
            using (NorthwindContex contex = new NorthwindContex())
            {
                var deletedEntity = contex.Entry(entiity);
                deletedEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContex contex = new NorthwindContex())
            {
                return contex.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContex contex = new NorthwindContex())
            {
                return filter == null ? contex.Set<Product>().ToList() : contex.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entiity)
        {
            using (NorthwindContex contex = new NorthwindContex())
            {
                var updateedEntity = contex.Entry(entiity);
                updateedEntity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }
    }
}
