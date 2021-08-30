using System;
using System.Collections.Generic;
using System.Text;

namespace MAM_Pre_Assessment
{
    public class InputTwo : InputOne
    {
        private double Imported_box_of_chocolate { get; set; }
        private double Imported_bottle_of_perfume { get; set; }

        public void Compute2()
        {
            try
            {
                Console.WriteLine("Input 2");

                Console.Write("Imported box of chocolate :");
                Imported_box_of_chocolate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Imported bottle of perfume at :");
                Imported_bottle_of_perfume = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("============================================");
            }
            catch (FormatException ex)
            {
                var message = ex.StackTrace.ToString();
                Console.WriteLine(message);
            }


            if (Imported_bottle_of_perfume != -1 && Imported_box_of_chocolate != -1)
            {
                // tax for box of chocalate
                double temp1 = Edditional_Tax * Imported_box_of_chocolate;
                double result1 = Math.Round(temp1, 2);

                // tax for bottle of perfume 
                double editionalTax = Math.Round(Edditional_Tax + Basic_Tax, 2);
                double temp2 = editionalTax * Imported_bottle_of_perfume;
                double result2 = Math.Round(temp2, 2);

                Sales_Tax = result1 + result2;

                Imported_box_of_chocolate += result1;
                Imported_bottle_of_perfume += result2;

                Total = Imported_box_of_chocolate + Imported_bottle_of_perfume;

                Console.WriteLine("Output 2");
                Console.WriteLine("Imported box of chocolates at :" + Math.Round(Imported_box_of_chocolate, 2));
                Console.WriteLine("Imported bottle of perfume at :" + Math.Round(Imported_bottle_of_perfume, 2));

                Console.WriteLine("Sale Taxes :" + Math.Round(Sales_Tax, 2));
                Console.WriteLine("Total :" + Total);
                Console.WriteLine("============================================");
            }
        }
    }
}
