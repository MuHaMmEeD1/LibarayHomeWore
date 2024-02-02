using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitys.Concrets
{
    public class Theme : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
