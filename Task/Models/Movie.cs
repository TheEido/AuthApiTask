using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public int NumberInStock { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }
    }
}
