﻿using System.ComponentModel.DataAnnotations;

namespace Self_ordaring_sys.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }



    }
}
