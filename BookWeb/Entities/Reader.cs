using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWeb.Entities
{
    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FavouriteBook { get; set; }
        public string FavouriteAuthor { get; set; }
        public string FavouritePublisher { get; set; }
        public string FavouriteGenre { get; set; }
    }
}
