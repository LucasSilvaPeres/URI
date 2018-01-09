using System; 
using System.Globalization; 
using System.Threading;


class URI {

    static void Main(string[] args) { 

        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int[] iiCedula = { 100, 50, 20, 10, 5, 2, 1 };
            decimal[] Moeda = { 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };

            int[] dCedula = new int[7];
            decimal[] nMoeda = new decimal[5];
            int[] iMoeda = new int[7];

            string Dinheiro = Console.ReadLine();
            decimal teste = Convert.ToDecimal(Dinheiro);
            string Teste = teste.ToString("0.00");

            string[] N = Teste.Split(new char[] { '.' });

            int iCedula = int.Parse(N[0]);
            decimal dMoeda = decimal.Parse(N[1]);

            for (int i = 0; i < 7; i++)
            {
                dCedula[i] = iCedula / iiCedula[i];
                iCedula %= iiCedula[i];

            }
            dMoeda /= 100;
            string testando;
            for (int j = 0; j < 5; j++)
            {
                testando = Convert.ToString(dMoeda / Moeda[j]);
                string[] N1 = testando.Split(new char[] { '.' });
                nMoeda[j] = decimal.Parse(N1[0]);

                dMoeda %= Moeda[j];
                if (nMoeda[j] < 1)
                {
                    nMoeda[j] = 0;

                }
            }
            Console.Write("NOTAS:\n");
            for (int g = 0; g < 7; g++)
            {
                if (g == 6)
                {
                    Console.Write("MOEDAS:\n");
                    Console.Write("{0} moeda(s) de R$ {1}.00\n", dCedula[g].ToString("0"), iiCedula[g]);
                }
                else
                {
                    Console.Write("{0} nota(s) de R$ {1}.00\n", dCedula[g].ToString("0"), iiCedula[g]);
                }
            }
            for (int h = 0; h < 5; h++)
            {
                Console.Write("{0} moeda(s) de R$ {1}\n", nMoeda[h].ToString("0"), Moeda[h]);
            }

    }

}