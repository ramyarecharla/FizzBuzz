using PHMFizzTest.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PHMFizzTest.Core.Services
{
    class FizzBuzzModulusHandler : IFizzBuzzModulusHandler
    {
        //Retrieve all the handlers of type IFizzBuzzHandler.
        public IEnumerable<IFizzBuzzHandler> GetHandlers()
        {
            var handlers =
                Assembly.GetExecutingAssembly().GetExportedTypes().Where(
                    t => typeof(IFizzBuzzHandler).IsAssignableFrom(t) && t.IsClass)
                    .Select(Activator.CreateInstance)
                    .Cast<IFizzBuzzHandler>();

            return handlers;
        }
    }
}
