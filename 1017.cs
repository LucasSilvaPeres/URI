using System; 

class URI {

    static void Main(string[] args) { 

            int Tempo, Vel;
            Tempo = int.Parse(Console.ReadLine());
            Vel = int.Parse(Console.ReadLine());
            double Distancia = Tempo * Vel;

            Console.Write("{0}\n", (Distancia/12).ToString("0.000"));

    }

}