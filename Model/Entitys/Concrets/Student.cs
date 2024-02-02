using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitys.Concrets
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Term { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }    

        public virtual ICollection<S_Card> S_Cards { get; set; }



    }
}
