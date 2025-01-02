using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace _6_din_49
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int numwinn;
            int contor = 1;
            int[] numere = new int[6];
            int[] numGenerate = new int[6];
            int[] vf = new int[6];
            
            
            string stringnumere = Console.ReadLine();

           

                numwinn = int.Parse(Console.ReadLine());

            string[] SplitNumere = stringnumere.Split(' ');
                    
            for(int i = 0; i<6 ;i++)           
            {
                numere[i] = int.Parse(SplitNumere[i]);
                
            }

               
            while(true)
            { 
                Console.Write('c');
                Console.WriteLine(contor); 
                
                int k = 0;


                for (int i = 0; i <6; i++)
                {
                  numGenerate[i]  = random.Next(0, 49);
                }
                for (int o = 0; o < 6; o++)
                    {
                        Console.Write(numere[o]);
                        Console.Write(' ');
                        
                    }

                Console.WriteLine(' ');

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (numere[i] == numGenerate[j])
                        {
                            vf[j] = 1;
                        }
                        else
                        {
                            vf[j] = 0;
                        }
                         
                    }
                    
                }
                for(int i = 0;i < 6; i++)
                {
                    if (vf[i]==1)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(numGenerate[i]);
                        Console.Write(' ');
                        Console.ForegroundColor = ConsoleColor.White;

                        k++;
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(numGenerate[i]);
                        Console.Write(' ');
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }
                Console.WriteLine(' ');

                if (k >= numwinn) { break;}
                contor++;
               
            }
        
              
            Console.ReadLine();
            
        }
    }
}
