﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Entities
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }

        /*
    "Id": "1",
    "Title" : "Queen",
    "Name": "Stephanie",
    "CreatedBy" : "Stephanie",
    "DateCreated": "6/14/2020"

         */
    }
}
