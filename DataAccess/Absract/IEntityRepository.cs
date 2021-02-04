﻿using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Absract
{
   
        public interface IEntityRepository<T> where T : class, IEntity ,new()// sınırlandırmaları yapıyoruz
            //generic constraint
        {
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
            List<T> GetAll(Expression<Func<T, bool>> filter = null);
            T Get(Expression<Func<T, bool>> filter);

        }
    
}