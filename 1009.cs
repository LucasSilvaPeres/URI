using System; 

class URI {

    static void Main(string[] args) { 

        double sFixo, tVendas;

            string nVendedor = Console.ReadLine();
            sFixo = double.Parse(Console.ReadLine());
            tVendas = double.Parse(Console.ReadLine());
            Console.Write("TOTAL = R$ {0}\n", (sFixo + tVendas * 15/100).ToString("0.00"));

    }

}