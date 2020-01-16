using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Git_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 0 and 100");
            Random random = new Random();
            int NumToGuess = random.Next(0, 100);
            int UserGuess = 0;
            while(UserGuess != NumToGuess)
            {
                Console.Write("Enter Guess Here: ");
                UserGuess = Convert.ToInt32(Console.ReadLine());

                if(UserGuess < NumToGuess)
                {
                    Console.WriteLine("Too Low");

                }
                else if(UserGuess > NumToGuess)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("You Have Guessed Correctly!");
                }
            }
        }
    }
}
