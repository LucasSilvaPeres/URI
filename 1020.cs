using System; 

class URI {

    static void Main(string[] args) { 

            int[] Anos = { 365, 30, 1 };
            int[] Resultado = new int[3];
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                Resultado[i] = N / Anos[i];
                N = N % Anos[i];
            }
            for (int j = 0; j < 3; j++)
            {
                string[] B = { "ano(s)", "mes(es)", "dia(s)" };
                Console.Write("{0} {1}\n", Resultado[j], B[j]);
            }

    }

}