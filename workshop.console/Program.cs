//comments

/* 
 * multiple lines of code 
 
 */

// single line of code



#region Dictionary

//1
Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("fish", "a water animal");
dictionary.Add("lion", "a fierce animal from the jungle");
//Console.WriteLine(dictionary["fish"]);

//2
var zoo = new Dictionary<string, int>
{
    {"cat", 2},
    {"snake", 5},
    {"llama", 3 }
};

//zoo.ToList().ForEach(x => { 
//    Console.WriteLine(x);
//    Console.WriteLine(x.GetType());
//    Console.WriteLine($"{x.Key} - {x.Value}");
//});

#endregion



List<string> csharpers = new List<string>();
csharpers.Add("Alice");
csharpers.Add("Bob");

csharpers.ForEach(x => Console.WriteLine(x));

foreach(string name in csharpers)
{
    Console.WriteLine(name);
}


List<string> javaers = new List<string> { "Charlie", "Diana" };


var both = new List<string>();
both.AddRange(csharpers);
both.AddRange(javaers);


#region Lists









#endregion