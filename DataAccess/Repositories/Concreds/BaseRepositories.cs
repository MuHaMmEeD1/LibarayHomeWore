using DataAccess.Contexts;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concreds
{
    public class BaseRepositories<T> : IBaseRepositories<T> where T : BaseEntity, new()
    {
        internal readonly LibaryHomeWork libaryHomeWork;
        internal readonly DbSet<T> table;
        public BaseRepositories()
        {

            libaryHomeWork = new LibaryHomeWork();
            table = libaryHomeWork.Set<T>();
        }

        public void Add(T entity)
        {
            if(entity is null) { throw new ArgumentNullException("Entiyi null"); }
            table.Add(entity);
            libaryHomeWork.SaveChanges();
        }

        public void Delete(int Id)
        {
            if (Id < 0) { throw new ArgumentNullException("Id menfi ola bilmez"); }
            var EntityVarmi = table.FirstOrDefault(e => e.Id == Id);
            if (EntityVarmi is null) { throw new ArgumentNullException("Bele bir entity yoxdu"); }
            table.Remove(EntityVarmi);
            libaryHomeWork.SaveChanges();

        }
    }
}
