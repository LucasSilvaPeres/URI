using System; 

class URI {

    static void Main(string[] args) { 

            double A, B, C;
            double[] Cres = new double[3];

            string Recebe = Console.ReadLine();
            string[] N = Recebe.Split(new char[] { ' ' });

            Cres[0] = double.Parse(N[0]);
            Cres[1] = double.Parse(N[1]);
            Cres[2] = double.Parse(N[2]);

            Array.Sort(Cres);

            A = Cres[2];
            B = Cres[1];
            C = Cres[0];

            double A2, B2, C2;
            A2 = A * A;
            B2 = B * B;
            C2 = C * C;
            double ENTRA = B + C;
            if (A >= ENTRA)
            {
                Console.Write("NAO FORMA TRIANGULO\n");
            }
            else
            {
                if(A2 == B2 + C2)
                {
                Console.Write("TRIANGULO RETANGULO\n");
                }
                if(A2 > B2 + C2)
                {
                    Console.Write("TRIANGULO OBTUSANGULO\n");
                }
                if(A2 < B2 + C2)
                {
                    Console.Write("TRIANGULO ACUTANGULO\n");
                }

                if(A == B && B == C && C == A)
                {
                    Console.Write("TRIANGULO EQUILATERO\n");
                }
                else if (A == B)
                {
                    Console.Write("TRIANGULO ISOSCELES\n");
                }
                else if (B == C)
                {
                    Console.Write("TRIANGULO ISOSCELES\n");
                }
                else if (A == C)
                {
                    Console.Write("TRIANGULO ISOSCELES\n");
                }
            }
    }

}