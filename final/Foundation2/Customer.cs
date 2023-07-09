public class Customer{

    private String _name;
    private Address _address;

    public Customer(string name, Address address){

        _name = name;
        _address = address;
    }

    public bool IsUSA(){
        return _address.IsUSA();
    }

    public String GetName(){
        return _name;
    }

    public void SetName(String name){
       _name = name;
    }

    public String GetAddress(){
        return _address.GetFullAddress();
    }

    public void SetAddress(Address address){{
        _address = address;
    }}

}