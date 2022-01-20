public class Drinks {



public static Dictionary<int,string> _drinkOrder = new Dictionary<int,string>();

public static void _addDrinks() {
    _drinkOrder.Add(1, "fanta");
    _drinkOrder.Add(2, "coke");
    _drinkOrder.Add(3, "iced tea");
    _drinkOrder.Add(4, "elephantPoopInfusedWater");
}

public static void desiredDrink(int _num) {
    
    Console.WriteLine("Your drink is : " + _drinkOrder[_num]);
}

public static void _displayDrinks() {
    foreach (KeyValuePair<int,string> value in _drinkOrder)
    {
       Console.WriteLine("Option for drink " + value.Key + " is " + value.Value);  
    }
    
}

public static void _removeElement(int _numb) {
   Console.WriteLine("We will remove " + _numb + " from our menu.");
    _drinkOrder.Remove(_numb);
    Console.WriteLine("The updated Drink menu is:");
    foreach (KeyValuePair<int,string> item in _drinkOrder)
    {
       Console.WriteLine("Drink order " + item.Key + " is " + item.Value); 
    }
}

public static void _searchDrink(string _possDrink) {
    bool isThere = false;

    foreach (KeyValuePair<int,string> item in _drinkOrder)
    {
        if(_possDrink == item.Value) {
           Console.WriteLine("The order number for drink " + _possDrink + " is " + item.Key); 
           isThere = true;
        }
   
    }
    if(!isThere) {
        Console.WriteLine("Sorry, drink " + _possDrink + " was not found.");
    }
}
}