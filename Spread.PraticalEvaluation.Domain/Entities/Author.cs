using System;

namespace Spread.PraticalEvaluation.Domain.Entities
{
    public class Author: BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
