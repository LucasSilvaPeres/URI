using System; 

class URI {

    static void Main(string[] args) { 

                    double Raio;

            Raio = double.Parse(Console.ReadLine());

            double Pi = 3.14159;
            double Resultado = (4.0 / 3) * Pi * (Raio * Raio * Raio);

            Console.Write("VOLUME = {0}\n", Resultado.ToString("0.000"));

    }

}