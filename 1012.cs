using System; 

class URI {

    static void Main(string[] args) { 

            double Pi = 3.14159;
            string Numeros =  Console.ReadLine();

            string[] Areas = Numeros.Split(new char[] { ' ' });

            double A = double.Parse(Areas[0]);
            double B = double.Parse(Areas[1]);
            double C = double.Parse(Areas[2]);

            Console.Write("TRIANGULO: {0}\n", (A * C / 2).ToString("0.000"));
            Console.Write("CIRCULO: {0}\n", (Pi * (C * C)).ToString("0.000"));
            Console.Write("TRAPEZIO: {0}\n", ((A + B) / 2 * C).ToString("0.000"));
            Console.Write("QUADRADO: {0}\n", (B * B).ToString("0.000"));
            Console.Write("RETANGULO: {0}\n", (A * B).ToString("0.000"));
    }

}