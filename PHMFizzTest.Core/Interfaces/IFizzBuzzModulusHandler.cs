using System.Collections.Generic;

namespace PHMFizzTest.Core.Interfaces
{
    interface IFizzBuzzModulusHandler
    {
        IEnumerable<IFizzBuzzHandler> GetHandlers();
    }
}
