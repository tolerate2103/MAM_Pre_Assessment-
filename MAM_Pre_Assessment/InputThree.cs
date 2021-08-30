using System;
using System.Collections.Generic;
using System.Text;

namespace MAM_Pre_Assessment
{
    public class InputThree : InputOne
    {
        private double Imported_bottle_of_perfume { get; set; }
        private double Bottle_of_perfume { get; set; }
        private double Packet_of_paracetamol { get; set; }
        private double Box_of_imported_chocolates { get; set; }

        public void Compute3()
        {
            try
            {
                Console.WriteLine("Input 3");

                Console.Write("Imported bottle of perfume at :");
                Imported_bottle_of_perfume = Convert.ToDouble(Console.ReadLine());

                Console.Write("Bottle of perfume at :");
                Bottle_of_perfume = Convert.ToDouble(Console.ReadLine());

                Console.Write("Packet of paracetamol at :");
                Packet_of_paracetamol = Convert.ToDouble(Console.ReadLine());

                Console.Write("Box of imported chocolates at :");
                Box_of_imported_chocolates = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("============================================");

            }
            catch (FormatException ex)
            {
                var message = ex.StackTrace.ToString();
                Console.WriteLine(message);
            }

            if (Imported_bottle_of_perfume != -1 && Bottle_of_perfume != -1 && Packet_of_paracetamol != -1)
            {
                double edditionalTax = Basic_Tax + Edditional_Tax;
                double temp1 = edditionalTax * Imported_bottle_of_perfume;
                double result1 = Math.Round(temp1, 2);


                double temp2 = Basic_Tax * Bottle_of_perfume;
                double result2 = Math.Round(temp2, 2);
                // 

                double temp3 = Edditional_Tax * Box_of_imported_chocolates;
                double result3 = Math.Round(temp3, 2);

                Sales_Tax = result1 + result2 + result3;

                Bottle_of_perfume += result2;
                Imported_bottle_of_perfume += result1;
                Box_of_imported_chocolates += result3;

                Total = Bottle_of_perfume + Imported_bottle_of_perfume + Packet_of_paracetamol + Box_of_imported_chocolates;

                Console.WriteLine("Output 3");
                Console.WriteLine("Imported bottle of perfume at :" + Math.Round(Imported_bottle_of_perfume, 2));
                Console.WriteLine("Bottle of perfume at :" + Math.Round(Bottle_of_perfume, 2));
                Console.WriteLine("Packet of paracetamol at :" + Math.Round(Packet_of_paracetamol, 2));
                Console.WriteLine("Box of imported chocolates at :" + Math.Round(Box_of_imported_chocolates, 2));

                Console.WriteLine("Sales Tax :" + Math.Round(Sales_Tax, 2));
                Console.WriteLine("Total : " + Math.Round(Total, 2));
            }
        }
    }
}
