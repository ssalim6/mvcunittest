﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcunittest.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product()
        {

        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}