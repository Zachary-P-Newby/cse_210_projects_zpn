public class Address{
    private int _streetNumber; //Learned this from a team mate
    private string _streetName;
    private string _city;
    private string _stateProvince;
    private string _country = "USA";

    public Address(int streetNumber, string  streetName, string city, string stateProvince){

        _streetNumber = streetNumber;
        _streetName = streetName;
        _city = city;
        _stateProvince = stateProvince;

    }
    
    public Address(int streetNumber, string  streetName, string city, string stateProvince, string country){

        _streetNumber = streetNumber;
        _streetName = streetName;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;

    }

    public string GetFullAddress(){
        return $"{_streetNumber} {_streetName}, {_city}, {_stateProvince}, {_country}";
    }

    /* I see no need for all the getters and setters with this class.
    } */

    public bool IsUSA(){
        if(_country == "USA"){
            return true;
        }
        else{
            return false;
        }
    }
<<<<<<< HEAD
=======

    public string GetShortAddress(){
        return $"{_streetNumber} {_streetName}, {_city}";
    }
>>>>>>> parent of 752f081 (Created New Sandbox)
}