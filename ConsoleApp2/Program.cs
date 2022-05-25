using System;
namespace ConsoleApp2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string footerText = "footerText";
            DotFooter dotfooter = new DotFooter();
            dotfooter.PrintFooterFormatted(footerText);

            DashFooter dashfooter = new DashFooter();
            dashfooter.PrintFooterFormatted(footerText);

            StarFooter starfooter = new StarFooter();
            starfooter.PrintFooterFormatted(footerText);
            Console.ReadKey();
        }

    }


    public class DotFooter : IPrintable
    {
        public void PrintFooterFormatted(string footerText)
        {
            string a = ".....";
                Console.WriteLine(a + footerText + a);

        }
    }


    public class DashFooter : IPrintable
    {
        string b = "-----";
       public  void PrintFooterFormatted(string footerText)
        {
            Console.WriteLine(b + footerText+ b);
        }
    }


    public class StarFooter : IPrintable
    {
        string c = "*****";
        public void PrintFooterFormatted(string footerText)
        {
            Console.WriteLine(c + footerText + c);
        }
    }
}
