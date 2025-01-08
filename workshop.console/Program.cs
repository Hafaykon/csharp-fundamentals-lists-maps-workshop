#region Comments

//comments

/* 
 * multiple lines of code 
 
 */

// single line of code

#endregion

#region Dictionary

//1
using System.Text.Encodings.Web;

Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("fish", "a water animal");
dictionary.Add("lion", "a fierce animal from the jungle");
Console.WriteLine(dictionary["fish"]);

//2
var zoo = new Dictionary<string, int>
{
    {"cat", 2},
    {"snake", 5},
    {"llama", 3 }
};

zoo.ToList().ForEach(x =>
{
    Console.WriteLine(x);
    Console.WriteLine(x.GetType());
    Console.WriteLine($"{x.Key} - {x.Value}");
});

#endregion

#region Lists

List<string> csharpers = new List<string>();
csharpers.Add("Alice");
csharpers.Add("Bob");
csharpers.ForEach(x => Console.WriteLine(x));
//foreach(string name in csharpers)
//{
//    Console.WriteLine(name);
//}


List<string> javaers = new List<string> { "Charlie", "Diana" };
var both = new List<string>();
both.AddRange(csharpers);
both.AddRange(javaers);
both.ForEach(x => Console.WriteLine(x));

#endregion

#region Queries

//querying strings
Dictionary<string, int> Fridge = new Dictionary<string, int>();
Fridge.Add("Carrots", 5);
Fridge.Add("Potatoes", 8);
Fridge.Add("Peppers", 5);
Fridge.Add("Beetroot", 4);
Fridge.Add("Cucumber", 2);
Fridge.Add("Broccoli", 1);
Fridge.Add("Onions", 8);
Fridge.Add("Shallots", 8);


#endregion

