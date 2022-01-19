// See https://aka.ms/new-console-template for more information

bool repeat = true;
while(repeat){
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
    repeat = false;
} else {
    Console.WriteLine("Invalid Number..Try again.");
    Console.WriteLine("");
}


}