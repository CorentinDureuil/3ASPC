namespace FirstPages.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }

    public Product(int id, string name, string description, double price, string imageUrl)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        ImageUrl = imageUrl;
    }
}