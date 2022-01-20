// See https://aka.ms/new-console-template for more information

//bool repeat = true;

Console.WriteLine("Hello, Welcome to Panda Express.");
Console.WriteLine("Type 1 for orange chicken and fried rice");
Console.WriteLine("Type 2 for teriyaki chicken and fried rice");
Console.WriteLine("Type 0 for can't afford anything");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) {
    Console.WriteLine("Here is your orange chicken and fried rice");
    Console.WriteLine("");
} else if (num == 2) {
    Console.WriteLine("Here is your teriyaki chicken and fried rice");
    Console.WriteLine("");
} else if (num == 0) {
    Console.WriteLine("GoodBye");
    //repeat = false;
} else {
    Console.WriteLine("Invalid Number..Try again.");
    Console.WriteLine("");
}

Console.WriteLine("What drink would you like?");
Drinks._addDrinks();
Drinks._displayDrinks();
Console.WriteLine("Please type the number for the drink you want.");
int _choosenDrink = Convert.ToInt32(Console.ReadLine());
Drinks.desiredDrink(_choosenDrink);
Console.WriteLine("Please type the drink you would like to search for and we will return the order number for that drink");
string _drinkToSearch = Console.ReadLine();
Drinks._searchDrink(_drinkToSearch);
Console.WriteLine("Please type the number for the drink you would like remove");
int _drinkToRemove = Convert.ToInt32(Console.ReadLine());
Drinks._removeElement(_drinkToRemove);




