using PHMFizzTest.Core.Interfaces;
using System;

namespace PHMFizzTest.Core
{
    public class MultipleofFiveModulus : IFizzBuzzHandler
    {
        public bool CanHandle(int target)
        {
            return target % 5 == 0;
        }

        public string Handle()
        {
            // Console.WriteLine(Helpers.Helpers.MULTIPLEOFFIVE);
            return Helpers.Helpers.MULTIPLEOFFIVE;
        }
    }
}
