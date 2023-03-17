public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotal()
    {
        double runningTotal = 0;
        foreach (Product i in _products)
        {
            runningTotal += i.CalculatePrice();
        }

        /* SHIPPING COST */
        if (_customer.IsLocal()) {
            return runningTotal + 5;
        }
        else {
            return runningTotal + 35;
        }
    }

    public string GetPackingLabel()
    {
        string packLabel = "Packing Label:\n";
        foreach(Product i in _products)
        {
            packLabel += $"•{i.GetProductName()} - #{i.GetId()}\n";
        }
        return packLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerName()} {_customer.GetAddress().GetStringAddress()}";
    }
}