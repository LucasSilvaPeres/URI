using System; 
using System.Globalization; 
using System.Threading;


class URI {

    static void Main(string[] args) { 

			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int A, B, C, D, M, H;

            string Recebe = Console.ReadLine();
            string[] N = Recebe.Split(new char[] { ' ' });

            A = int.Parse(N[0]);
            B = int.Parse(N[1]);
            C = int.Parse(N[2]);
            D = int.Parse(N[3]);

            if (A < C)
            {
                if (B < D)
                {
                    H = C - A;
                    M = D - B;
                }
                else if (B > D)
                {
                    H = C - A - 1;
                    M = D - B + 60;
                }
                else
                {
                    H = C - A;
                    M = 0;
                }
            }
            else if (A > C)
            {
                C += 24;
                if (B < D)
                {
                    H = C - A;
                    M = D - B;
                }
                else if (B > D)
                {
                    H = C - A;
                    M = D - B;
                    H -= 1;
                    M += 60;
                }
                else
                {
                    H = C - A;
                    M = 0;
                }
            }
            else
            {
                H = 24;
                if (B < D)
                {
                    M = D - B;
                }
                else if (B > D)
                {
                    H -= 1;
                    M = (D + 60) - B;
                }
                else
                {
                    M = 0;
                }
            }
            Console.Write("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)\n", H, M);
            Console.ReadLine();
            

    }

}