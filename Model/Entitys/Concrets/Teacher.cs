using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitys.Concrets
{
    public class Teacher : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<T_Card> T_Cards { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }  
    }
}
