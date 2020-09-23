using System;

namespace soma2valores
{
    class Program
    {
        static void Main(string[] args)
        {
             int v1,v2,res;
             

            
 
            Console.Clear();            
            Console.WriteLine("+-------------------+\n");
            Console.WriteLine("| SOMA DOIS VALORES |\n");
            Console.WriteLine("+-------------------+\n");

            Console.Write("primeiro valor---- :");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("segundo valor----- :");

            v2 = Convert.ToInt32(Console.ReadLine());
            res=v1+v2;

          Console.WriteLine($"\n A soma dos numeros é {res}:");

          Console.ReadKey();
          Console.Clear();


        }
    }
}
