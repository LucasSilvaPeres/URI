using System; 

class URI {

    static void Main(string[] args) { 

            string A, B;
            A = Console.ReadLine();
            B = Console.ReadLine();

            string[] piecesA = A.Split(new char[] { ' ' });
            string[] piecesB = B.Split(new char[] { ' ' });

            double nPecasA = double.Parse(piecesA[1]);
            double vPecasA = double.Parse(piecesA[2]);
            double nPecasB = double.Parse(piecesB[1]);
            double vPecasB = double.Parse(piecesB[2]);

            double Valor = nPecasA * vPecasA + nPecasB * vPecasB;

            Console.Write("VALOR A PAGAR: R$ {0}\n", Valor.ToString("0.00"));
    }

}