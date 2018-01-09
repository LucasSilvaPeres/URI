using System; 

class URI {

    static void Main(string[] args) { 

              int A, B, C, D;

            string Recebe = Console.ReadLine();
            string[] N = Recebe.Split(new char[] { ' ' });

            A = int.Parse(N[0]);
            B = int.Parse(N[1]);
            C = int.Parse(N[2]);
            D = int.Parse(N[3]);

            if (B > C && D > A && (C+D) > (A+B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.Write("Valores aceitos\n");

            }
            else
            {
                Console.Write("Valores nao aceitos\n");
            }

    }

}