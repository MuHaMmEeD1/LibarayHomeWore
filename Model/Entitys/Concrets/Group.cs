using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitys.Concrets
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }

        public int FacultiseId { get; set; }
        public virtual Facultise Facultise { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
