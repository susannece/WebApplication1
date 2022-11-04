namespace WebApplication1.Models
{
    public class Game
    {
       public static string CheckNumber(int num)
       {
            if (num >= 1 && num <= 100)
            {
               return ("The number " + num + " is valid. ");
            }
            else
            {
               return ("The number " + num + " is invalid. ");
            }
       }


    }
}
