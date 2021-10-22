using Enitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
   public interface IRepository<T> where T:IEntity
    {
        bool Create(T entity);
        bool Uptade(T entity);
        bool Delete(T entity);
        List<T> Getall(Predicate<T> filter=null);
        T Get(Predicate<T> filter=null);


    }
}
