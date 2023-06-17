
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint //kısıtlar
    //class : referans tip olmalı
    //IEntity : IEntity olabilir veya IEntity den implemente eden bir nesne olmalı
    //new(): newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtre zorunlu değil
        T Get(Expression<Func<T,bool>> filter);//filtre zorunlu
        void Add(T entiity);
        void Update(T entiity);
        void Delete(T entiity);
    }
}
