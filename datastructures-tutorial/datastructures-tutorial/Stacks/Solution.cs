namespace datastructures_tutorial.Stacks;

public class StackSolution
{ 
    // Create Stack to represent playlist
    static Stack<string> _playlist = new Stack<string>();

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
        // Add the song to the playlist stack
        _playlist.Push(song);
        Console.WriteLine($"Added '{song}' to the playlist.");
    }

    static void Play()
    {
        while (_playlist.Count > 0)
        {
            // Pop the latest added song from the playlist
            string songPlaying = _playlist.Pop();
            Console.WriteLine($"Playing: {songPlaying}");
        }
    }
}