using System; 

class URI {

    static void Main(string[] args) { 

            int[] A = { 3600, 60, 1 };
            int[] B = new int[3];
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                B[i] = N / A[i];
                N = N % A[i];
            }
            Console.Write("{0}:{1}:{2}\n", B[0], B[1], B[2]);

    }

}