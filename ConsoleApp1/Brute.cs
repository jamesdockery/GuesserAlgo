using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Brute : Algorithm
    {
        
        int steps;
       

   

        public override int Run(int input)
        {
            
            for (int i = 100; i > 0; i--)
            {
                if (i == input)
                {
                    return steps;
                }
                steps++;
                
            }
            return -1;
        }
    }
    }
