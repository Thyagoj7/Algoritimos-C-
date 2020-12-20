using System;

namespace Algoritimos
{
    class Program
    {
        static void Main(string[] args)
        {

            bool[] itenscozinha = new bool[3] {true, false, true}; 
            
            bool frigideira = itenscozinha[0]; 
            bool oleo = itenscozinha[1];
            bool ovo = itenscozinha[2];

            

            if (frigideira==true)
            {
                Console.WriteLine("Ja tenho a frigideira");

                if(oleo==true)
                {
                    Console.WriteLine("Ja tenho o oleo");

                    if(ovo==true)
                    {
                        Console.WriteLine("Ja tenho o ovo em mãos");
                    }else{
                         Console.WriteLine("Esta faltando ovo");
                        }
                }else{
                    Console.WriteLine("Esta faltando oleo");
                    }
            }else{
                    Console.WriteLine("Estou sem frigideira");
                }
        }
    }   
}
