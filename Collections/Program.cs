using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //lists are the "arrays" of C#
            //lists take in a single generic type parameter; classes are custom-made types
            var things = new List<string>();

            things.Add("this is a string");
            things.Remove("this is a string");
            things.AddRange(new List<string> { "asdf", "rewqg", "hrewlq" });
            var shouldBeFalse = things.Contains("this is a string");
            var thing = things[2]; //this gives the thing at index 2

            // Dictionary (similar to objects in JS) has to have a string as the key and value (does not have to be an int)
            var myDictionary = new Dictionary<string,int>();
            myDictionary.Add("firstKey", 1234432);
            var myValue = myDictionary["firstKey"];

            var myDictionary1 = new Dictionary<string, Food>();
            {
                myDictionary1.Add("firstKey", new Food { Name = "Carrots", GlutenFree = true });
                myDictionary1.Add("second", new Food { Name = "Bread", GlutenFree = false });
                myDictionary1.Add("third", new Food { Name = "Meat", GlutenFree = true });
                var myValue1 = myDictionary1["firstKey"];
            };

            if (myDictionary1.ContainsKey("lfdashr"))
            {
                Console.WriteLine("Never going to get here");
            }
            

           

            foreach (var food in myDictionary1.Values)
            {
                Console.WriteLine($"Food is {food.Name}");
            }

            foreach (var key in myDictionary1.Keys)
            {
                Console.WriteLine($"Key is {key}");
            }

            foreach (var item in myDictionary1)
            {
                Console.WriteLine($"{item.Key} is the key for {item.Value.Name}");
            }

            var newFoodThing = new Food { Name = "Pizza", GlutenFree = false };
            newFoodThing.GetHashCode();
            var sameThing = newFoodThing;

            if (newFoodThing == sameThing)
            {
                Console.WriteLine("Yes, they are the same.");
            }

            if (newFoodThing.GetHashCode() == sameThing.GetHashCode())
            {
                Console.WriteLine("Told you so.");
            }

            var hashset = new HashSet<Food>();
            hashset.Add(new Food { Name = "Broccoli", GlutenFree = false });
           

        }
    }
}
