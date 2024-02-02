using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitys.Concrets
{
    public class Facultise : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
