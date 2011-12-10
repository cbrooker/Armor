using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Armor.Data;

//using RichmondDay.Helpers;

using SubSonic.Repository;
using System.Configuration;

namespace Armor.Web
{
    public abstract class ServiceBase<T> where T :class, new() {
        protected virtual double CacheExpiry {
            get { return 60;}
        } // time in seconds the cache should live for

        protected abstract string CacheKey {
            get;
        } // a unique way to identify the item in the cache

        

        protected ArmorDB db;

        public ServiceBase() {
            if (db == null) db = new ArmorDB();
        }

        protected SubSonicRepository<T> GetRepository<T>() where T : class, new() {
            return new SubSonicRepository<T>(db);
        }


        public Expression<Func<TElement, bool>> IsSameDate<TElement>(Expression<Func<TElement, DateTime>> valueSelector, DateTime value)
        {
            ParameterExpression p = valueSelector.Parameters.Single();

            var antes = Expression.GreaterThanOrEqual(valueSelector.Body, Expression.Constant(value.Date, typeof(DateTime)));

            var despues = Expression.LessThan(valueSelector.Body, Expression.Constant(value.AddDays(1).Date, typeof(DateTime)));

            Expression body = Expression.And(antes, despues);

            return Expression.Lambda<Func<TElement, bool>>(body, p);
        }

        protected virtual List<T> GetData()
        {
            List<T> data = null;

            if (data == null)
            {
                data = GetRepository<T>().GetAll().ToList();
            }

            return data;
        }


        protected virtual List<T> GetData(Expression<Func<T, bool>> expression)
        {
            List<T> data = null;

            if (data == null)
            {
                data = GetRepository<T>().Find(expression).ToList();
            }

            return data;
        }


    }
}