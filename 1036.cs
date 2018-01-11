double A, B, C;
            string Recebe = Console.ReadLine();
            string[] N = Recebe.Split(new char[] { ' ' });

            A = double.Parse(N[0]);
            B = double.Parse(N[1]);
            C = double.Parse(N[2]);
            if (A == 0)
            {
                Console.Write("Impossivel calcular\n");

            }
            else
            {
                double delta = (B * B) - (4 * A * C);
                if (delta <= 0)
                {
                    Console.Write("Impossivel calcular\n");
                }
                else
                {
                    double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
                    double R2 = (-B - Math.Sqrt(delta)) / (2 * A);

                    Console.Write("R1 = {0}\n", R1.ToString("0.00000"));
                    Console.Write("R2 = {0}\n", R2.ToString("0.00000"));
                }
            }