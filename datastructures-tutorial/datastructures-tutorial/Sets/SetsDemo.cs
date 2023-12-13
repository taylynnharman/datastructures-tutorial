namespace datastructures_tutorial.Sets;

public class SetsDemo
{
    public static void Run()
    {
        string[] allPlayers = {
            "Babe Ruth", "Hank Aaron", "Willie Mays", "Ty Cobb", "Lou Gehrig",
            "Mickey Mantle", "Jackie Robinson", "Ted Williams", "Ken Griffey Jr.", "Derek Jeter",
        };

        HashSet<string> originalCollection = new HashSet<string>(allPlayers);
        HashSet<string> boughtCollection = new HashSet<string>();

        Console.WriteLine("Welcome to the Baseball Card Collector Program!");

        // Bought Cards 
        boughtCollection.Add("Babe Ruth");
        boughtCollection.Add("Tug McGraw");
        boughtCollection.Add("Ken Griffey Jr.");


        Console.WriteLine("\nOriginal Collection:");
        foreach (var player in originalCollection)
        {
            Console.WriteLine(player);
        }

        Console.WriteLine("\nBought Collection:");
        foreach (var player in boughtCollection)
        {
            Console.WriteLine(player);
        }

        // Detect duplicates and display
        HashSet<string> duplicateCards = new HashSet<string>(boughtCollection);
        duplicateCards.IntersectWith(originalCollection);

        Console.WriteLine("\nDuplicate Cards:");
        foreach (var duplicateCard in duplicateCards)
        {
            Console.WriteLine(duplicateCard);
        }
        
        //Create List of unique cards and display
        HashSet<string> collection = new HashSet<string>(originalCollection);
        collection.UnionWith(boughtCollection);
        Console.WriteLine("\nNew Collection:");
        foreach (var card in collection)
        {
            Console.WriteLine(card);
        }
    }
}