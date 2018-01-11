using System; 

class URI {

    static void Main(string[] args) { 

            int A, B, C;

            string Recebe = Console.ReadLine();
            string[] N = Recebe.Split(new char[] { ' ' });

            A = int.Parse(N[0]);
            B = int.Parse(N[1]);
            
            if(A > B)
            {
                B += 24;
                C = B - A;
            }
            else if ( A < B)
            {
                C = B - A;
            }
            else
            {
                C = 24;
            }
            Console.Write("O JOGO DUROU {0} HORA(S)\n", C);

    }

}