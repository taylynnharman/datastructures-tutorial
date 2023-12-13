namespace datastructures_tutorial.Sets
{
    public class Solution
    {
        // Do NOT alter the Run method. It is there for testing purposes.
        public static void Run()
        {
            // Create two Christmas playlists
            HashSet<string> playlist1 = new HashSet<string> { "Jingle Bells", "Deck the Halls", "Shake It Off", "Silent Night", "Winter Wonderland", "Let It Snow" };
            HashSet<string> playlist2 = new HashSet<string> { "Jingle Bells", "White Christmas", "Joy to the World", "Sunshine", "Frosty the Snowman", "Santa Claus Is Coming to Town" };

            // Merge and filter Christmas playlists
            HashSet<string> mergedChristmasPlaylist = MergeChristmasPlaylists(playlist1, playlist2);

            // Display the original playlists, and merged playlist.
            Console.WriteLine("Christmas Playlist 1: " + string.Join(", ", playlist1));
            Console.WriteLine("Christmas Playlist 2: " + string.Join(", ", playlist2));
            Console.WriteLine("Merged Christmas Playlist: " + string.Join(", ", mergedChristmasPlaylist));
        }

        static HashSet<string> MergeChristmasPlaylists(HashSet<string> playlist1, HashSet<string> playlist2)
        {
            // Merge playlists using Union
            HashSet<string> mergedChristmasPlaylist = new HashSet<string>(playlist1.Union(playlist2));

            // Remove non-Christmas songs using Remove
            mergedChristmasPlaylist.Remove("Shake It Off");
            mergedChristmasPlaylist.Remove("Sunshine");

            return mergedChristmasPlaylist;
        }
    }
}