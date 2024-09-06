using System.Runtime.InteropServices;
using static System.Console;
namespace Movie;

public class ConfirmPeople : IHandler
{
    private IHandler next;

    public ConfirmPeople(IHandler next)
    {
        this.next = next;
    }

    public void Handle(IMovie movie)
    {
        WriteLine("ПРОВЕРКА НА ЧЕЛОВЕКА!");
        WriteLine("Решите пример 2+5 = 7");
        WriteLine("Выберите правильный ответ: ");
        WriteLine("1 - 5");
        WriteLine("2 - 7");
        WriteLine("3 - 4");

        int choice = int.Parse(ReadLine()!);

        if (choice != 2)
            WriteLine("Вы не прошли проверку на человека!");
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
