using static System.Console;
namespace Movie;

public  class Program
{
    static void Main(string[] args)
    {
        IMovie movie = new Movie();
        IHandler start = new ConfirmPeople(
            new ConfirmCookies(
                new ConfirmCreateAccount(
                    new ConfirmCloseBanner(null
                )
             )    
           )
        );

        start?.Handle(movie);
        
    }
}
