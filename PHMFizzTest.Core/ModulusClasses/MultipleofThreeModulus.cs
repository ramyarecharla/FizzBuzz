using PHMFizzTest.Core.Interfaces;
using System;

namespace PHMFizzTest.Core
{
    public class MultipleofThreeModulus : IFizzBuzzHandler
    {
        public bool CanHandle(int target)
        {
            return target % 3 == 0;
        }

        public string Handle()
        {
            //Console.WriteLine(Helpers.Helpers.MULTIPLEOFTHREE);
            return Helpers.Helpers.MULTIPLEOFTHREE;
        }
    }
}
