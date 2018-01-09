using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C, D;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            int Diferenca = A*B - C*D;
            Console.Write("DIFERENCA = {0}\n", Diferenca);
    }

}