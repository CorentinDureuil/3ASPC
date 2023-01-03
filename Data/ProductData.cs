using FirstPages.Models;

namespace FirstPages.Data;

public static class ProductData
{
    public static List<Product> Products { get; set; } = new List<Product>
    {
        new Product(1, "MacBook Pro", "Mon premier produit", 2474.10,
            "~/images/macbook_pro.jpeg"),
        new Product(2, "Iphone", "Mon deuxième produit", 1000.00,
            "~/images/iphone-13.jpeg")
    };

}