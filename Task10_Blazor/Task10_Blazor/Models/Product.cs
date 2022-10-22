using System;
using System.Collections.Generic;

namespace Task10_Blazor.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public int? Price { get; set; }
    }
}
