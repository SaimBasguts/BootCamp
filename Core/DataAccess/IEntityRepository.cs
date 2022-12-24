using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //newlenebilir olmalı
    //çalışıcak type
    //IEntity türünde bir clas olmalı ya da implemente eden
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//bu genel hepsini getirir
        T Get(Expression<Func<T, bool>> filter);//bu özel filtreleme için
        
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
