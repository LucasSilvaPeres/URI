using System; 

class URI {

    static void Main(string[] args) { 

            double Km, Litros, Distancia;
            Km = double.Parse(Console.ReadLine());
            Litros = double.Parse(Console.ReadLine());
            Distancia = Km / Litros;

            Console.Write("{0} km/l\n", Distancia.ToString("0.000"));
    }

}