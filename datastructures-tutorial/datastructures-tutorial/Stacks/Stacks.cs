namespace datastructures_tutorial.Stacks
{
    public class Stack
    {
        // Create Stack to represent playlist
        static Stack<string> _playlist = new Stack<string>();

        // Don't alter the Run() function. It is in place to test the functions AddToPlayList() and Play() altered below.
        public static void Run()
        {
            Console.WriteLine("\n=========== TEST ===========");
            // Add songs to playlist
            AddToPlaylist("American Honey");
            AddToPlaylist("Sunshine");
            AddToPlaylist("Shotgun Rider");
            AddToPlaylist("Winter Wonderland");

            // Play songs
            Play();
            // Output should be:
            // Playing: Winter Wonderland
            // Playing: Shotgun Rider
            // Playing: Sunshine
            // Playing: American Honey
        }

        static void AddToPlaylist(string song)
        {
            // Add the song to the _playlist stack
            
            Console.WriteLine($"Added '{song}' to the playlist.");
        }

        static void Play()
        {
            while (_playlist.Count > 0)
            {
                // Uncomment out the next 2 lines before attempting to run
                // string songPlaying = Complete with syntax that will play the last added song (*Hint pop)
                // Console.WriteLine($"Playing: {songPlaying}");
            }
        }
    }
}