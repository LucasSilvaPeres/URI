using System; 

class URI {

    static void Main(string[] args) { 

            int N;
            int[] Ce = { 100, 50, 20, 10, 5, 2, 1 };
            int[] nCe = new int[7];
            N = int.Parse(Console.ReadLine());
            Console.Write("{0}\n", N.ToString());

            for (int i = 0; i < 7; i++)
            {
                nCe[i] = N / Ce[i];
                N = N % Ce[i];
            }

            for (int j = 0; j < 7; j++)
            {
                Console.Write("{0} nota(s) de R$ {1},00\n", nCe[j], Ce[j]);
            }
    }

}