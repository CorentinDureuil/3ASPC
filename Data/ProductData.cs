using FirstPages.Models;

namespace FirstPages.Data;

public static class ProductData
{
    public static List<Product> Products { get; set; } = new List<Product>
    {
        new Product(1, "MacBook Pro", "Mon premier produit", 2474.10,
            "https://www.apple.com/v/macbook-pro-14-and-16/a/images/overview/hero/intro__ewz1ro7xs14y_large.jpg"),
        new Product(2, "Iphone", "Mon deuxième produit", 1000.00,
            "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-13-model-unselect-gallery-1-202207?wid=5120&hei=2880&fmt=p-jpg&qlt=80&.v=1654893619853")
    };

}