namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1()
        {

            Console.WriteLine("Mennyien értékelték?");
            Console.Write(":  ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Mennyi pozitív?");
            Console.Write(":");
            int p = int.Parse(Console.ReadLine());

            double d = ((double)p / r) * 100;
            int rp = (int)Math.Round(d);

            if (d > 90) Console.WriteLine("Nagyon pozitív");
            else if (d >= 75) Console.WriteLine("Pozitív");
            else if (d >= 55) Console.WriteLine("Többnyire pozitív");
            else if (d >= 45) Console.WriteLine("Vegyes");
            else if (d >= 25) Console.WriteLine("Többnyire negatív");
            else if (d >= 10) Console.WriteLine("Negatív");
            else if (d >= 9) Console.WriteLine("Nagyon Negatív");



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            feladat1();
        }




    }


        }







            
    

