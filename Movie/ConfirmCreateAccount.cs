using static System.Console;

namespace Movie;

public class ConfirmCreateAccount : IHandler
{
    private IHandler next;

    public ConfirmCreateAccount(IHandler next)
    {
        this.next = next;
    }

    public void Handle(IMovie movie)
    {
        WriteLine("РЕГИСТРАЦИЯ!");
        WriteLine("Введите логин: ");
        string login = ReadLine();
        WriteLine("Введите пароль: ");
        string password = ReadLine();

        if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
        {
            WriteLine($"Регистрация пользователя {login} c паролем {password}");
            // next?.Handle(movie);
            if (next != null)
            {
                next?.Handle(movie);
            }
            else
            {
                movie.Play();
            }
        }
        else
        {
            WriteLine("Ошибка!");
        }
    }
}
