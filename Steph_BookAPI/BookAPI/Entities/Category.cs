using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }

        /*
      "Id": "1",
    "CategoryName" : "I don't know",
    "Location": "Paris",
    "CreatedBy" : "Stephanie",
    "DateCreated": "6/14/2020"
         */
    }
}
