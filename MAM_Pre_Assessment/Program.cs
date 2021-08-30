using System;

namespace MAM_Pre_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            InputOne inputOne = new InputOne();
            InputTwo inputTwo = new InputTwo();
            InputThree inputThree = new InputThree();

            inputOne.Compute();
            inputTwo.Compute2();
            inputThree.Compute3();
        }
    }
}
