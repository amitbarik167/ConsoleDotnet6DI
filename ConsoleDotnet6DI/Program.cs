using ConsoleDotnet6DI;
using ConsoleDotnet6DI.Factory;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDotnet6DIT
{ 
 class Program
    {
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            services
                .BuildServiceProvider()
                .GetService<PersonDrink>()
                .Drink();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        }


        /// <summary>
        /// Configure the class/handlers for Dependency Injection
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        private static void ConfigureServices(IServiceCollection services)
        {
#pragma warning disable CS8603 // Possible null reference return.
            services
                .AddSingleton<PersonDrink, PersonDrink>()
                .AddSingleton<IAgeHandlerFactory, AgeHandlerFactory>()
                .AddSingleton<MinorHandler>().AddSingleton<IAgeHandler, MinorHandler>(s => s.GetService<MinorHandler>())
                .AddSingleton<YouthHandler>().AddSingleton<IAgeHandler, YouthHandler>(s => s.GetService<YouthHandler>())
                .AddSingleton<AdultHandler>().AddSingleton<IAgeHandler, AdultHandler>(s => s.GetService<AdultHandler>());
#pragma warning restore CS8603 // Possible null reference return.

        }

    }

    /// <summary>
    /// PersonDrink class 
    /// </summary>
    public class PersonDrink
    {
        private readonly IAgeHandlerFactory _ageHandlerFactory;

        /// <summary>
        /// Constructor injection
        /// </summary>
        /// <param name="ageHandlerFactory"><see cref="IAgeHandlerFactory"/></param>
        public PersonDrink(IAgeHandlerFactory ageHandlerFactory)
        {
            _ageHandlerFactory = ageHandlerFactory;
        }


        /// <summary>
        /// Drink method
        /// </summary>
        internal void Drink()
        {
            var p = new List<Person>
            {
        new Person
        {
            Name = "Claire Bennet",
            Age = 16
        },
        new Person
        {
            Name = "Hiro Nakamura",
            Age = 20
        },
        new Person
        {
            Name = "Kensei Takezo",
            Age = 351
        }
            };

            for (var i = 0; i < p.Count; i++)
            {
                var ageHandlerFactory = _ageHandlerFactory.GetAgeHandler(p[i]);
                ageHandlerFactory.Direction(p[i]);
            }
        }

    }

}

