using System; 

class URI {

    static void Main(string[] args) { 

            double Nota1, Nota2, Media;
            Nota1 = double.Parse(Console.ReadLine());
            Nota2 = double.Parse(Console.ReadLine());

            Media = (Nota1*3.5) + (Nota2 * 7.5);

            Console.Write("MEDIA = {0}\n", (Media / 11).ToString("0.00000"));
    }

}