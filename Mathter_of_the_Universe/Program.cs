using System;

class Program
{

    static void Main(string[] args)
    {

        if (args.Length > 0) Console.WriteLine(args[args.Length - 1]);

        int X = 0;
        string input = "";
        int ii = 0;
        int poäng = 0;


        //första frågan
        while (ii < 1)
        {
            Console.WriteLine("x * 6 = 42");
            Console.WriteLine("Vad är x");
            input = Console.ReadLine();

            //testar om sifra 
            bool lyckad = int.TryParse(input, out X);
            if (lyckad == true)
            {
                if (X == 7)
                {
                    System.Console.WriteLine("Du hade rätt");
                    poäng++;
                }
                else
                {
                    System.Console.WriteLine("Du hade fel");
                    System.Console.WriteLine(X * 6);
                    if (X < 7){System.Console.WriteLine("Din gisning var för låg");
                    } else { System.Console.WriteLine("din gisning är för hög"); }
                }
                ii++;
            }
        }

        //avslut 
        System.Console.WriteLine($"du fick {poäng} poäng");
        Console.ReadLine();
        
    }
}