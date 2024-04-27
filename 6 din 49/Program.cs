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

            Random random = new Random();
            int w = 3;
            int[] numere = new int[6];
            int[] numGenerate = new int[6];


            string stringnumere = Console.ReadLine();

            string[] SplitNumere = stringnumere.Split(' ');
                    
            for(int i = 0; i<6 ;i++)           
            {
                numere[i] = int.Parse(SplitNumere[i]);
                
            }


            while(true)
            {

                for (int i = 1; i <= 6; i++)
                {
                  numGenerate[i]  = random.Next(1, 49);
                }

            }
        
     
          
            Console.ReadLine();
            
        }
    }
}
