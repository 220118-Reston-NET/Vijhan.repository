using System.Text.Json;
public class Serialize {
    private static string _filepath = "./Serialize.json";


    public static List<Person> listOfPeople = new List<Person>();
    public static void _makeObjects(){
        Person person0 = new Person()
        {
            gender = "girl",
            age = 25
        };

        Person person2 = new Person()
        {
            gender = "boy",
            age = 24
        };
        Person person3 = new Person()
        {
            gender = "girl",
            age = 21
        };
    }

    public static void _addElement() {
        List<Person> listOfPeople = new List<Person>();
        Console.WriteLine("Please type the gender and age of person you would like to convert to json file.");
        Console.WriteLine("Gender: girl or boy");
        string _gender = Console.ReadLine();
        Console.WriteLine("Age:");
        int _age = Convert.ToInt32(Console.ReadLine());
        Person person1 = new Person()
        {Gender = _gender,
         Age = _age
        };
        
        listOfPeople.Add(person1);
        
        string jsonString = JsonSerializer.Serialize(listOfPeople, new JsonSerializerOptions {WriteIndented = true});
        Console.WriteLine(jsonString);
        File.WriteAllText(_filepath, jsonString);
        
        Console.WriteLine("Now the object will be removed from jSON file and converted to C# object");

        string jsonString2 = File.ReadAllText(_filepath);
        List<Person> listOfPeople2 = JsonSerializer.Deserialize<List<Person>>(jsonString2);   
        Console.WriteLine(listOfPeople2[0].Gender);
        Console.WriteLine(listOfPeople2[0].Age);   

        Console.WriteLine("Please type the number for the object you would like to search for.");
        Console.WriteLine("1 is for Person 1");
        int _objectSearch = Convert.ToInt32(Console.ReadLine());

        foreach (Person ob in listOfPeople2)
        {
         if (_objectSearch == 1)
         {
             Console.WriteLine("The object is " + listOfPeople2[0]);
             Console.WriteLine(listOfPeople2[0] + " object has a gender of " + listOfPeople2[0].Gender + " and an age of " + listOfPeople2[0].Age);
         }   else
         {
             Console.WriteLine("No element found");
         }

        }
    }

    /*public static void _removeElement() {
        Console.WriteLine("Please type the number for the object to remove from json file.");
        for(int i = 0; i < listOfPeople.Count; i++) {
            Console.WriteLine("Object " + i + "is " + listOfPeople[i]);
        }
        }*/
    }



