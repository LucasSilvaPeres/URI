decimal Money;
            string R = Console.ReadLine();
            string[] N = R.Split(new char[] { ' ' });
            int Cod = int.Parse(N[0]);
            int Qtd = int.Parse(N[1]);
            switch (Cod)
            {
                case 1:
                    {
                        Money = 4.00m;
                        Console.Write("Total: R$ {0}\n", (Money * Qtd).ToString("0.00"));

                        break;
                    }
                case 2:
                    {
                        Money = 4.50m;
                        Console.Write("Total: R$ {0}\n", (Money * Qtd).ToString("0.00"));

                        break;
                    }
                case 3:
                    {
                        Money = 5.00m;
                        Console.Write("Total: R$ {0}\n", (Money * Qtd).ToString("0.00"));

                        break;
                    }
                case 4:
                    {
                        Money = 2.00m;
                        Console.Write("Total: R$ {0}\n", (Money * Qtd).ToString("0.00"));

                        break;
                    }
                case 5:
                    {
                        Money = 1.50m;
                        Console.Write("Total: R$ {0}\n", (Money * Qtd).ToString("0.00"));

                        break;
                    }
            }