using System; 
using System.Globalization; 
using System.Threading;


class URI {

    static void Main(string[] args) { 

			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double X, Y;
            string Recebe = Console.ReadLine();

            string[] N = Recebe.Split(new char[] { ' ' });

            X = double.Parse(N[0]);
            Y = double.Parse(N[1]);

            if( X > 0 && Y > 0)
            {
                Console.Write("Q1\n");
            } 
            else if ( X > 0 && Y < 0)
            {
                Console.Write("Q4\n");
            }
            else if (X < 0 && Y < 0)
            {
                Console.Write("Q3\n");
            }
            else if (X < 0 && Y > 0)
            {
                Console.Write("Q2\n");
            }
            else if (X == 0 && Y != 0)
            {
                Console.Write("Eixo Y\n");
            }
            else if (Y == 0 && X != 0)
            {
                Console.Write("Eixo X\n");
            }
            else
            {
                Console.Write("Origem\n");
            }
            

    }

}