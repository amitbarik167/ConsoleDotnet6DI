using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotnet6DI.Factory
{
    /// <summary>
    /// Interface for AgeHandlerFactory
    /// </summary>
    public interface IAgeHandlerFactory
    {
        IAgeHandler GetAgeHandler(Person person);
    }
}
