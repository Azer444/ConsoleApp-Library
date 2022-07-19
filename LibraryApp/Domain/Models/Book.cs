using Domain.Common;

namespace Domain
{
    public class Book : BaseEntity
    {
        public string Name{ get; set; }

        public string Author { get; set; }

        public Library library { get; set; }
    }
}
