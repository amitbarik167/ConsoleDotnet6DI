using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotnet6DI.Factory
{
    public class AgeHandlerFactory : IAgeHandlerFactory
    {
        private readonly IServiceProvider serviceProvider;

        public AgeHandlerFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <summary>
        /// This method will return the required Age handler.
        /// </summary>
        /// <param name="person"><see cref="Person"/></param>
        /// <returns><see imp of cref="IAgeHandler"/>Will retrun the required implemented handler</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IAgeHandler GetAgeHandler(Person person)
        {
#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            return person.Age switch
            {
                int i when i < 18 => (IAgeHandler)serviceProvider.GetService(typeof(MinorHandler)),
                int i when i >= 18 & i <= 20 => (IAgeHandler)serviceProvider.GetService(typeof(YouthHandler)),
                int i when i > 20 => (IAgeHandler)serviceProvider.GetService(typeof(AdultHandler)),
                _ => throw new NotImplementedException($"Action:{person.Age} not implemented in method :{nameof(GetAgeHandler)}")
            };
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
