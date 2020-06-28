using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWeb.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        

    }
}
