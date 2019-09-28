using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Elimination : Algorithm
    {
        List<int> Numbers { get; set; }
        private int guess;
        Random m = new Random();
        private int steps;


        public Elimination()
        {
            Numbers = new List<int>();
        }
        public override int Run(int input)
        {
            while (true)
            {

                if (Numbers.Contains(guess))
                {
                    guess = m.Next(0, 101);
                }
                else
                {
                    Numbers.Add(guess);
                }
               

                if(guess == input)
                {
                    return steps;
                    
                }
                



                steps++;

            }
        }
    }
}
