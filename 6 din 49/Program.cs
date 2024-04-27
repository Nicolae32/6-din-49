using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_din_49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numere = new int[6];
            
            string stringnumere = Console.ReadLine();

            string[] SplitNumere = stringnumere.Split(' ');
                    
            for(int i = 0;i<6 ;i++)           
            {
                numere[i] = int.Parse(SplitNumere[i]);
                
            }

        
            Console.WriteLine(numere[1]+4);
          
            Console.ReadLine();
            
        }
    }
}
