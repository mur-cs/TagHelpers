namespace TagHelpers.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public LaptopBrand Brand { get; set; }
        public string Name { get; set; }
        public int Threads { get; set; }
        public int RAM { get; set; }
        public decimal ScreenSize { get; set; }
        public string Description { get; set; }
        public Laptop() { }
    }
}
