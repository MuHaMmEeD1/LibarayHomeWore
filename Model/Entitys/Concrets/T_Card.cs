using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitys.Concrets
{
    public class T_Card : BaseEntity
    {
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int LibId { get; set; }
        public virtual Lib Lib { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
