using static System.Console;

namespace Movie;

public class Movie : IMovie
{

    public void Play()
    {
        WriteLine("Disney представляет...");
        WriteLine("Начинается кино!");
    }
}
