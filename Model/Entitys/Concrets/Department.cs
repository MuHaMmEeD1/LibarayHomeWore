using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitys.Concrets
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
