using System; 

class URI {

    static void Main(string[] args) { 

            int A, B, Resto1;

            string Recebe = Console.ReadLine();
            string[] N = Recebe.Split(new char[] { ' ' });
            A = int.Parse(N[0]);
            B = int.Parse(N[1]);
            Resto1 = B % A; 
            int Resto2 = A % B;


            if (Resto1 == 0 || Resto2 == 0)
            {
                Console.Write("Sao Multiplos\n");
            }
            else
            {
                Console.Write("Nao sao Multiplos\n");

            }

    }

}