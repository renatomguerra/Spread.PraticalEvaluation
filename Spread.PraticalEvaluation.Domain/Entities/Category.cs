using System;

namespace Spread.PraticalEvaluation.Domain.Entities
{
    public class Category: BaseEntity<short>
    {
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
