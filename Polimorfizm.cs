using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DotFooter dotfooter = new DotFooter();
            DashFooter dashfooter = new DashFooter();
            StarFooter starfooter = new StarFooter();
            Klasa(dotfooter);
            Klasa(dashfooter);
            Klasa(starfooter);

            Console.ReadKey();

        }
        private static void Klasa(IPrintable printable)
        {
            string footerText = "footerText";
            printable.PrintFooterFormatted(footerText);

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
        string b = "------";
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
