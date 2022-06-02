namespace ConsoleDotnet6DI
{

    /// <summary>
    /// Handler class for Minors (<18)
    /// </summary>
    public class MinorHandler : IAgeHandler
    {
        /// <summary>
        /// This method will hold the directional message for Minors
        /// </summary>
        /// <param name="person"><see cref="Person"/></param>
        public void Direction(Person person)
        {
            Console.WriteLine("Name:{0}", person.Name);
            Console.WriteLine("Age:{0}", person.Age);
            Console.WriteLine("Soda drinking Message: {0}! Don't even try. Come back in {1} years.", person.Name, (21 - person.Age));
            Console.WriteLine();
        }
    }
}
