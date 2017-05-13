using PHMFizzTest.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PHMFizzTest.Core.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
         readonly IEnumerable<IFizzBuzzHandler> HandlerCache;
         readonly FizzBuzzModulusHandler ModulusHandler;

        public FizzBuzzService()
        {
            //Retrieve the list of handlers.
            ModulusHandler = new FizzBuzzModulusHandler();
            HandlerCache = ModulusHandler.GetHandlers().ToList();
        }
        //Process the Fizz Buzz based on numbers. 
        public string Process(int number)
        {
            string result= string.Empty;
            var handlers = HandlerCache.Where(h => h.CanHandle(number)).ToList();
            foreach (var item in handlers)
            {
                result =  item.Handle() + result;
            }
            return result;
        }
    }
}
