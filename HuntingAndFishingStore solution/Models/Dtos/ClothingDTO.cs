﻿namespace Models.Dtos
{
    using System.Web;

    public class ClothingDTO
    {
        public HttpPostedFileBase Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public char Size { get; set; }

        public int Quantity { get; set; }

        public string Category { get; set; }
    }

    
}
