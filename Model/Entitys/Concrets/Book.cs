using Model.Entitys.Abstructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitys.Concrets
{
    public class Book :BaseEntity
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public string Comment { get; set; }
        public int Quantty { get; set; }


        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int CategoriseId { get; set; }
        public virtual Categorise Categorise { get; set; }

        public int PresId { get; set; }
        public virtual Pres Pres { get; set; }

        public int ThemeId { get; set; }
        public virtual Theme Theme { get; set; }

        public virtual ICollection<S_Card> S_Cards { get; set; }
        public virtual ICollection<T_Card> T_Cards { get; set; }

  
    }


}
