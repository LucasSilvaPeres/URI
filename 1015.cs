using System; 

class URI {

    static void Main(string[] args) { 

            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();

            string[] ponto1 = p1.Split(new char[] { ' ' });
            string[] ponto2 = p2.Split(new char[] { ' ' });

            double x1 = double.Parse(ponto1[0]);
            double y1 = double.Parse(ponto1[1]);
            double x2 = double.Parse(ponto2[0]);
            double y2 = double.Parse(ponto2[1]);

            double X = (x2 - x1);
            double Y = (y2 - y1);
            double Distancia = X * X + Y * Y;
            double rDistancia = Math.Sqrt(Distancia);

            Console.Write("{0}\n", rDistancia.ToString("0.0000"));

    }

}