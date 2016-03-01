using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            int[,] arr = new int[20, 20];
            //Add some random values to the array  
            Random R = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = R.Next(20);
                int y = R.Next(20);
                arr[x, y] = 1;
            }
            while (true)
            {
                Console.Clear();
                game.Print(arr);
                //Process the array and get a modified array back  
                arr = game.ProcessGame(arr);
                Console.ReadKey();
            }
        }
    }
}
}
