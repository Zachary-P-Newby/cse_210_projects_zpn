public class Order{
    
    private Customer _customer;
    private List<Product> _productList = new List<Product>(20);

    private double _totalPrice;

    public Order(Customer customer){
        _customer = customer;
        CalculateTotalPrice();
    }
    
    public Order(Customer customer, List<Product> productList){
        _customer = customer;
        _productList = productList;
        CalculateTotalPrice();
    }

    private void CalculateTotalPrice(){
        double TotalPrice = 0;

        _productList.ForEach(item =>{
            TotalPrice += item.GetTotalPrice();
        });

        if(_customer.IsUSA() == true){
            TotalPrice += 5;
        }
        else{
            TotalPrice += 35;
        }

        _totalPrice = Math.Round(TotalPrice, 2);
    }

    public void AddProduct(Product product){
        _productList.Add(product);
    }

    public string GetShippingLabel(){
        return $"{_customer.GetName()}: {_customer.GetAddress()}";
    }

    public string GetPackingLabel(){
        String packingLabel = $"Contents:\n";

        _productList.ForEach(item => {
            packingLabel += $"{item.GetName()}: {item.GetProductID()}\n";
        });

        return packingLabel;
        
    }

    public void SetProductList(List<Product> productList){
        _productList = productList;
        CalculateTotalPrice();
    }

    public double GetTotalPrice(){
        return _totalPrice;
    }
}