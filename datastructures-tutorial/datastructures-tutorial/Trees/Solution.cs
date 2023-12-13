namespace datastructures_tutorial.Trees;

public class Solution
{ 
    public static void Run()
    {
        // Create an instance of the SongOrganizer
        SongOrganizer organizer = new SongOrganizer();

        // Adding songs to the organizer

        organizer.AddSong("Jingle Bells");
        organizer.AddSong("Deck the Halls");
        organizer.AddSong("Shake it Off");
        organizer.AddSong("Silent Night");
        organizer.AddSong("Winter Wonderland");
        organizer.AddSong("Let it Snow");
        organizer.AddSong("White Christmas");
        organizer.AddSong("Joy to the World");
        organizer.AddSong("Sunshine");
        organizer.AddSong("Frosty the Snowman");

        // Displaying songs
        organizer.DisplaySongs();
        // Output should be:
        // Deck the Halls
        // Frosty the Snowman
        // Jingle Bells
        // Joy to the World
        // Let it Snow
        // Shake it Off
        // Silent Night
        // Sunshine 
        // White Christmas 
        // Winter Wonderland


    }
    
    // Define a class to represent a song
    public class Song
    {
        public string Name;
        public Song Left;
        public Song Right;

        public Song(string name)
        {
            Name = name;
            Left = null;
            Right = null;
        }
    }

    // Define a class for organizing songs using a binary search tree
    public class SongOrganizer
    {
        private Song root;

        public SongOrganizer()
        {
            root = null;
        }

        // Public method to add a new song to the organizer
        public void AddSong(string name)
        {
            root = Insert(root, name);
        }

        // Private helper method for recursive insertion
        private Song Insert(Song current, string name)
        {
            // If the current node is null, create a new node with the given song name
            if (current == null)
            {
                return new Song(name);
            }

            // Compare the new song name with the current node's song name
            // If the new song name is less, go to the left subtree
            if (string.Compare(name, current.Name, StringComparison.OrdinalIgnoreCase) < 0)
            {
                current.Left = Insert(current.Left, name);
            }
            // If the new song name is greater, go to the right subtree
            else if (string.Compare(name, current.Name, StringComparison.OrdinalIgnoreCase) > 0)
            {
                current.Right = Insert(current.Right, name);
            }

            // Return the current node after insertion
            return current;
        }

        // Public method to display the songs in alphabetical order
        public void DisplaySongs()
        {
            Console.WriteLine("Songs:");
            InOrderTraversal(root);
        }

        // Private helper method for in-order traversal
        private void InOrderTraversal(Song current)
        {
            if (current != null)
            {
                // Recursively traverse the left subtree
                InOrderTraversal(current.Left);
                // Display the song name of the current node
                Console.WriteLine(current.Name);
                // Recursively traverse the right subtree
                InOrderTraversal(current.Right);
            }
        }
    }
}
