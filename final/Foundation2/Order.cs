
public class Order {
    
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer) {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }

    public decimal TotalCost() {
        decimal total = 0;
        foreach (var product in _products) {
            total += product.TotalCost();
        }
        decimal shippingCost = _customer.USResident() ? 5 : 35;
        return total + shippingCost;
    }
    public string GetPackingLabel() {
        string label = "Packing Label:\n";
        foreach (var product in _products) {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }
    public string GetShippingLabel() {
        return "Shipping Label:\n" + _customer.GetName() + "\n" + _customer.GetAddress().ReturnAddress();
    }
}

