using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            int num1,num2,suma;
            Console.WriteLine("ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            num2 = int.Parse(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("la suma es "+suma);


        }
    }
}