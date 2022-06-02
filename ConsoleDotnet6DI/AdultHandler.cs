namespace ConsoleDotnet6DI
{

    /// <summary>
    /// Handler class for Adults (>20)
    /// </summary>
    public class AdultHandler : IAgeHandler
    {
        /// <summary>
        /// This method will hold the directional message for Adults
        /// </summary>
        /// <param name="person"><see cref="Person"/></param>
        public void Direction(Person person)
        {
            var nameSegment = person?.Name?.Split(' ');
            Console.WriteLine("Name:{0}", person?.Name);
            Console.WriteLine("Age:{0}", person?.Age);
            Console.WriteLine("Soda drinking Message: Cheers {0}!", nameSegment?[0]);
            Console.WriteLine();
        }
    }
}
