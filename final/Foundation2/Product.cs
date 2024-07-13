
public class Product {
    private string _name;
    private int _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, decimal price, int quantity) {
        _name = name;
        _productId = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public decimal TotalCost() {
        return _pricePerUnit * _quantity;
    }

    public string GetProductDetails() {
        return _name + " (ID: " + _productId + ")";
    }

}