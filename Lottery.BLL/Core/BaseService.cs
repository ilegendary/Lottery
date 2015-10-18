using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery.BLL
{
    public abstract class BaseService<T> where T : class,new()
    {
        /// <summary>
        /// 获取DbSession
        /// </summary>
        public IDAL.IDBSession GetCurrentDbSession
        {
            get
            {
                return DALFactory.DBSessionFactory.CreateDbSession();
            }

        }
        public IDAL.IBaseDAL<T> CurrentDAL { get; set; }

        /// <summary>
        /// 虚方法
        /// </summary>
        public abstract void SetCurretnDAL();

        public BaseService()
        {
            SetCurretnDAL();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDAL.LoadEntities(whereLambda);
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="pageIdex"></param>
        /// <param name="pageSize"></param>
        /// <param name="toalCount"></param>
        /// <param name="whereLambda"></param>
        /// <param name="orderbyLambda"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public IQueryable<T> LoadPageEntities<s>(int pageIdex, int pageSize, out int toalCount, System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            return CurrentDAL.LoadPageEntities<s>(pageIdex, pageSize, out toalCount, whereLambda, orderbyLambda, isAsc);
        }
        public bool DeleteEntity(T entity)
        {
            CurrentDAL.DeleteEntity(entity);
            return this.GetCurrentDbSession.SaveChanges();
        }
        public bool EditEntity(T entity)
        {
            CurrentDAL.EditEntity(entity);
            return this.GetCurrentDbSession.SaveChanges();
        }
        public T AddEntity(T entity)
        {
            CurrentDAL.AddEntity(entity);
            this.GetCurrentDbSession.SaveChanges();
            return entity;
        }
    }
}
