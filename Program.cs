namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herzlich willkommen in Cidr Netzerk Rechner");
            Console.WriteLine(" ");


            Console.WriteLine("Bitte geben Sie das erste Oktett der IP-Adresse ein.");
            string? o1 = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie das zweite Oktett der IP-Adresse ein.");
            string? o2 = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie das driete Oktett der IP-Adresse ein.");
            string? o3 = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie das vierte Oktett der IP-Adresse ein.");
            string? o4 = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie das CIDR Index ein.");
            string? strCidr = Console.ReadLine();
            masske(o1, o2, o3, o4, strCidr);
           // masske(o1 ,o2,o3, o4,strCidr);
            Console.ReadLine();
        }

        private static int [] masske(string? o1, string? o2, string? o3, string? o4, string? strCidr)
        {
            int oktet1 = Convert.ToInt32(o1);
            int oktet2 = Convert.ToInt32(o2);
            int oktet3 = Convert.ToInt32(o3);
            int oktet4 = Convert.ToInt32(o4);
            int cidr = Convert.ToInt32(strCidr);
            int[] maske = new int[4];
            //maske[0].maske[1].maske[2].maske[3]
            int helpvar = cidr / 8;
            int helpvar2= cidr % 8;

            if (helpvar2 == 0) { }
            if (helpvar2 == 1) { }
            if (helpvar2 == 2) { }
            if (helpvar2 == 3) { }
            if (helpvar2 == 4) { }
            if (helpvar2 == 5) { }
            if (helpvar2 == 6) { }
            if (helpvar2 == 7) { }

            if (helpvar >= 1) { maske[0] = 255; }
            if (helpvar >= 2) { maske[0] = 255; maske[1] = 255; }
            if (helpvar >= 3) { maske[0] = 255; maske[1] = 255; maske[2] = 255; }
            if (helpvar == 4) { maske[0] = 255; maske[1] = 255; maske[2] = 255;  maske[3] = 255; }




            Console.WriteLine("Deine Netzwermaske: " + maske[0] + "." + maske[1] + "." + maske[2] + "." + maske[3]);
            return maske;
        }
    }
}
