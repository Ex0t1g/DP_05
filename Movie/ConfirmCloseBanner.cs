using static System.Console;
namespace Movie;

public class ConfirmCloseBanner : IHandler
{
    private IHandler next;

    

    public ConfirmCloseBanner(IHandler next)
    {
       
    }

    public void Handle(IMovie movie)
    {
        WriteLine("Нажми любую клавишу чтобы пропустить рекламный баннер");
        ReadKey();
        if (next != null)
        {
            next.Handle(movie);
        }
        else
        {
            movie.Play();
        }
    }
}
