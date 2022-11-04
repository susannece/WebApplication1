using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class Doctor
    {
        public static string TestFever(double temp)
        {
            return (temp > 37)? "Sorry, you have a fever": "You have no fever";
        }
    }
}
