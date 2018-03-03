using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class UnitOfWork
    {
        internal EventManagerDbContext DbContext { get; set; }
        private DbContextTransaction Transaction { get; set; }

        public UnitOfWork()
        {
            DbContext = new EventManagerDbContext();
        }

        public void Start()
        {
            Transaction = DbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (Transaction != null)
                Transaction.Commit();
        }

        public void Rollback()
        {
            if (Transaction != null)
                Transaction.Rollback();
        }

        public void Transation(Action obj)
        {
            this.Start();
            obj.Invoke();
            this.Commit();
        }
    }
}
