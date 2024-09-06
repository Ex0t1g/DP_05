using static System.Console;
namespace Movie;

public class ConfirmCookies : IHandler
{
    private IHandler next;

    public ConfirmCookies(IHandler next)
    {
        this.next = next;
    }

    public void Handle(IMovie movie)
    {
        WriteLine("Наш сайт испоьзует Cookie файлы пожалуйста примите их!");
        WriteLine("Нажмите 1 чтобы принять куки файлы");

        int cookeschoice = int.Parse(ReadLine()!);

        if (cookeschoice != 1)
            WriteLine("Доступ запрещен");
        else
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
