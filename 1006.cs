using System; 

class URI {

    static void Main(string[] args) { 

            double NotaA, NotaB, NotaC, Media;
            NotaA = double.Parse(Console.ReadLine());
            NotaB = double.Parse(Console.ReadLine());
            NotaC = double.Parse(Console.ReadLine());


            Media = (NotaA * 2) + (NotaB * 3) + (NotaC * 5);

            Console.Write("MEDIA = {0}\n", (Media / 10).ToString("0.0"));
    }

}