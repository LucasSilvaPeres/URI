using System; 
using System.Globalization; 
using System.Threading;


class URI {

    static void Main(string[] args) { 

			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double A, B, C;

            string Recebe = Console.ReadLine();
            string[] N = Recebe.Split(new char[] { ' ' });
            A = double.Parse(N[0]);
            B = double.Parse(N[1]);
            C = double.Parse(N[2]);
			
            if (A + B > C && A + C > B && B + C > A)
            {
                Console.WriteLine("Perimetro = {0}", (A + B + C).ToString("0.0"));
            }
            else
            {
                Console.WriteLine("Area = {0}", (((A + B) * C) / 2).ToString("0.0"));
            }
            

    }

}