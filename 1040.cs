using System; 
using System.Globalization; 
using System.Threading;


class URI {

    static void Main(string[] args) { 

			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double N1, N2, N3, N4;
            string Recebe = Console.ReadLine();

            string[] N = Recebe.Split(new char[] { ' ' });

            N1 = double.Parse(N[0]);
            N1 = N1 * 2 / 10 ;

            N2 = double.Parse(N[1]);
            N2 = N2 * 3 / 10;

            N3 = double.Parse(N[2]);
            N3 = N3 * 4 / 10;

            N4 = double.Parse(N[3]);
            N4 = N4 * 1 / 10;

            double media = Convert.ToDouble(N1 + N2 + N3 + N4);
            media *= 10;
            media = Math.Floor(media);
            media /= 10;
            string split = media.ToString();

            double Media = Convert.ToDouble(split);

            if(Media >= 7)
            {
                Console.Write("Media: {0}\n", Media.ToString("0.0"));
                Console.Write("Aluno aprovado.\n");
            }
            else if (Media >= 5 && Media < 7)
            {
                Console.Write("Media: {0}\n", Media.ToString("0.0"));
                Console.Write("Aluno em exame.\n");

                double Exame = double.Parse(Console.ReadLine());
                //string exame = Exame.ToString("0.0");
                //Exame = double.Parse(exame);
                

                Console.Write("Nota do exame: {0}\n", Exame.ToString("0.0"));

                double MediaFinal = (Media + Exame) / 2;
                if (MediaFinal >= 5)
                {
                    Console.Write("Aluno aprovado.\n");
                }
                else
                {
                    Console.Write("Aluno reprovado.\n");
                }
                Console.Write("Media final: {0}\n", MediaFinal.ToString("0.0"));

            }
            else
            {
                Console.Write("Media: {0}\n", Media.ToString("0.0"));
                Console.Write("Aluno reprovado.\n");
            }
            

    }

}