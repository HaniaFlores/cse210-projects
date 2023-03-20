public class Product
{
    private string _productName;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string productName, int id, double price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice() {return _price * _quantity;}

    public int GetId() {return _id;}

    public string GetProductName() {return _productName;}

    public int GetQuantity() { return _quantity; }
}