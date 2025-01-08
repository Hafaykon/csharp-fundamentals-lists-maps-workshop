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
Dictionary<string, int> fridgeDictionary = new Dictionary<string, int>();
fridgeDictionary.Add("Carrots", 5);
fridgeDictionary.Add("Potatoes", 8);
fridgeDictionary.Add("Peppers", 5);
fridgeDictionary.Add("Beetroot", 4);
fridgeDictionary.Add("Cucumber", 2);
fridgeDictionary.Add("Broccoli", 1);
fridgeDictionary.Add("Onions", 8);
fridgeDictionary.Add("Shallots", 8);

//lamda collection
var lamdalowveg = fridgeDictionary.Where(x => x.Value < 5);

//linq collection
var linqlowveg = from veg in fridgeDictionary
                 where veg.Value < 5
                 select veg;

//lamda returning single item
var lamdaSingle = fridgeDictionary.FirstOrDefault(x => x.Key == "Carrots");
var lamda_carrot = fridgeDictionary.Where(item => item.Key=="Carrots").FirstOrDefault();
var lamda_danger = fridgeDictionary.First(item => item.Key == "Carrots");

//lamda p items
var lamda_p_items = fridgeDictionary.Where(item => item.Key.ToLower().StartsWith("p")).ToList();

//linq p items
var linq_p_items = from item in fridgeDictionary
                   where item.Key.ToLower().StartsWith("p")
                   select item;




#endregion

