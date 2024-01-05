﻿namespace BlazorMemoriesApplication.Models
{
    public class MyMemory
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; }=string.Empty;
        public string Image {  get; set; }=string.Empty;
    }
}
