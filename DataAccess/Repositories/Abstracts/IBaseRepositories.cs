using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IBaseRepositories<T> where T : BaseEntity, new()
    {
        void Add(T entity);
        void Delete(int Id);



    }
}
