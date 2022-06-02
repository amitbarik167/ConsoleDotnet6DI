namespace ConsoleDotnet6DI
{
    /// <summary>
    /// Handler class for Youths (between 18 and 20)
    /// </summary>
    public class YouthHandler : IAgeHandler
    {
        /// <summary>
        /// This method will hold the directional message for Youths.
        /// </summary>
        /// <param name="person"><see cref="Person"/></param>
        public void Direction(Person person)
        {
            var nameSegment = person?.Name?.Split(' ');
            Console.WriteLine("Name: {0}", person?.Name);
            Console.WriteLine("Age: {0}", person?.Age);

            if ((21 - person?.Age) == 1)
            {
                Console.WriteLine("Soda drinking Message: {0}, you're almost there! Comeback in {1} year.", nameSegment?[1], 21 - person?.Age);
            }
            else
            {
                Console.WriteLine("Soda drinking Message: {0}, you're almost there! Come back in {1} years. ", nameSegment?[1], 21 - person?.Age);
            }
            Console.WriteLine();
        }
    }
}
