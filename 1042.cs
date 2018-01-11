using System; 
using System.Globalization; 
using System.Threading;


class URI {

    static void Main(string[] args) { 

			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int[] ABC = new int[3];
            int[] Sorted = new int[3];

            string Recebe = Console.ReadLine();
            string[] N = Recebe.Split(new char[] { ' ' });

            for (int i = 0; i < 3; i++)
            {
                ABC[i] = int.Parse(N[i]);
                Sorted[i] = int.Parse(N[i]);
            }

            Array.Sort(ABC);
            Console.Write("{0}\n{1}\n{2}\n\n", ABC[0], ABC[1], ABC[2]);
            Console.Write("{0}\n{1}\n{2}\n", Sorted[0], Sorted[1], Sorted[2]);
            

    }

}