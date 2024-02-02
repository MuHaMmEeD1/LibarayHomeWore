using Model.Entitys.Abstructs;

namespace Model.Entitys.Concrets
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
