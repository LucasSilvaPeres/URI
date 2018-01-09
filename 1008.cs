using System; 

class URI {

    static void Main(string[] args) { 

        int nFun, hTrab; 
            decimal vHora;
            nFun = int.Parse(Console.ReadLine());
            hTrab = int.Parse(Console.ReadLine());
            vHora = decimal.Parse(Console.ReadLine());
            

            Console.Write("NUMBER = {0}\n", nFun);
            Console.Write("SALARY = U$ {0}\n", (hTrab * vHora).ToString("0.00"));

    }

}