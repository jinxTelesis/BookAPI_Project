using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI_Project.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public string ReviewTest { get; set; }

        public int Rating { get; set; }

    }
}
