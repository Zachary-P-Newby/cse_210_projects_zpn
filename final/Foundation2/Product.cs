public class Product{
    private String _name;
    private String _productID;
    //Changed ints to doubles to account for cents
    private double _basePrice;
    private int _quantity = 1;
    private double _totalPrice;


    public Product(String name, string productID, double basePrice){
        _name = name;
        _productID = productID;
        _basePrice = basePrice;
        CalculateTotalPrice();
    }

    public Product(String name, string productID, double basePrice, int quantity){
        _name = name;
        _productID = productID;
        _basePrice = basePrice;
        _quantity = quantity;
        CalculateTotalPrice();
    }

    private void CalculateTotalPrice(){
        _totalPrice = Math.Round(_basePrice * _quantity, 2);
    }

    public string GetName(){
        return _name;
    }

    public string GetProductID(){
        return _productID;
    }
    

    public double GetBasePrice(){
        return _basePrice;
    }

    public int GetQuantity(){
        return _quantity;
    }

    public double GetTotalPrice(){
        return _totalPrice;
    }
    
}