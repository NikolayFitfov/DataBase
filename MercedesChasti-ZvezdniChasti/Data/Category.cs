﻿namespace MercedesChasti_ZvezdniChasti.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
