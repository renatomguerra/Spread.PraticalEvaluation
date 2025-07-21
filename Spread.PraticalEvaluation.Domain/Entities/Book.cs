using System;

namespace Spread.PraticalEvaluation.Domain.Entities
{
    public class Book : BaseEntity<int>
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public short CategoryId { get; set; }
        public Category Category {get; set;}

    }
}
