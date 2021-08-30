using System;
using System.Collections.Generic;
using System.Text;

namespace MAM_Pre_Assessment
{
    public class InputOne
    {
        public InputOne()
        {
            Basic_Tax = 0.1;
            Edditional_Tax = 0.05;
        }
        public double Basic_Tax { get; set; }
        public double Edditional_Tax { get; set; }
        public double Sales_Tax { get; set; }
        public double Total { get; set; }




        private double Book { get; set; }
        private double MusicCd { get; set; }
        private double Chocolate_Bar { get; set; }

        public void Compute()
        {
            try
            {
                Console.WriteLine("Input 1");
                Console.Write("Book at :");
                Book = Convert.ToDouble(Console.ReadLine());

                Console.Write("Music CD at :");
                MusicCd = Convert.ToDouble(Console.ReadLine());

                Console.Write("Chocolate Bar :");
                Chocolate_Bar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===========================================");
            }
            catch (FormatException ex)
            {
                var message = ex.StackTrace.ToString();
                Console.WriteLine(message);
            }

            /// Compute Tax and disply output
            if (MusicCd != -1)
            {
                double temp = Basic_Tax * MusicCd;
                double result = Math.Round(temp, 2);
                Sales_Tax = result;

                result += MusicCd;
                Total = Book + result + Chocolate_Bar;

                Console.WriteLine("Output 1");
                Console.WriteLine("Book at :" + Book);
                Console.WriteLine("Music CD at :" + Math.Round(result, 2));
                Console.WriteLine("Chocolate Bar :" + Chocolate_Bar);
                Console.WriteLine("Sales Tax :" + Math.Round(Sales_Tax, 2));
                Console.WriteLine("Total :" + Math.Round(Total, 2));
                Console.WriteLine("============================================");
            }
        }

    }
}
