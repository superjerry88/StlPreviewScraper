namespace _3dImageDownloader
{
    public partial class CgntData
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public Product Product { get; set; }
        public string Price { get; set; }
        public string DefaultPrice { get; set; }
        public Partner Partner { get; set; }
        public long Inventory { get; set; }
        public bool BackordersEnabled { get; set; }
        public bool IsPreorder { get; set; }
        public ButtonStatus ButtonStatus { get; set; }
    }
    public partial class ButtonStatus
    {
        public string Text { get; set; }
        public bool Enabled { get; set; }
    }

    public partial class Partner
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public double InStoreTaxRate { get; set; }
    }

    public partial class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}