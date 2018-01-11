double A = double.Parse(Console.ReadLine());

            if (A >= 0 && A <= 25)
            {
                Console.Write("Intervalo [0,25]\n");
            }
            else if(A >= 25 && A <= 50)
            {
                Console.Write("Intervalo (25,50]\n");
            }
            else if (A >= 50 && A <= 75)
            {
                Console.Write("Intervalo (50,75]\n");
            }
            else if (A >= 75 && A <= 100)
            {
                Console.Write("Intervalo (75,100]\n");
            }
            else
            {
                Console.Write("Fora de intervalo\n");
            }