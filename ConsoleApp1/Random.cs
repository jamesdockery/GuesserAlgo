using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RAlgo : Algorithm
    {
        public int input;
        Random m = new Random();
        private int steps;
        private int guess;
        public override int Run(int input)
        {
            while (true)
            {
                
                guess = m.Next(0, 101);
                if(guess == input)
                {
                    return steps;
                }
                steps++;
            
            }
        }

       
    }
}
