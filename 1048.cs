using System; 
using System.Globalization; 
using System.Threading;


class URI {

    static void Main(string[] args) { 

			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            decimal Salario = decimal.Parse(Console.ReadLine());

            if(Salario > 0m && Salario <= 400m)
            {
                Console.Write("Novo salario: {0}\n", (Salario * 1.15m).ToString("0.00"));
                Console.Write("Reajuste ganho: {0}\n", (Salario * 0.15m).ToString("0.00"));
                Console.Write("Em percentual: 15 %\n");
            }
            else if(Salario > 400m && Salario <= 800m)
            {
                Console.Write("Novo salario: {0}\n", (Salario * 1.12m).ToString("0.00"));
                Console.Write("Reajuste ganho: {0}\n", (Salario * 0.12m).ToString("0.00"));
                Console.Write("Em percentual: 12 %\n");
            }
            else if (Salario > 800m && Salario <= 1200m)
            {
                Console.Write("Novo salario: {0}\n", (Salario * 1.10m).ToString("0.00"));
                Console.Write("Reajuste ganho: {0}\n", (Salario * 0.10m).ToString("0.00"));
                Console.Write("Em percentual: 10 %\n");
            }
            else if (Salario > 1200m && Salario <= 2000m)
            {
                Console.Write("Novo salario: {0}\n", (Salario * 1.07m).ToString("0.00"));
                Console.Write("Reajuste ganho: {0}\n", (Salario * 0.07m).ToString("0.00"));
                Console.Write("Em percentual: 7 %\n");
            }
            else
            {
                Console.Write("Novo salario: {0}\n", (Salario * 1.04m).ToString("0.00"));
                Console.Write("Reajuste ganho: {0}\n", (Salario * 0.04m).ToString("0.00"));
                Console.Write("Em percentual: 4 %\n");
            }
 
            

    }

}