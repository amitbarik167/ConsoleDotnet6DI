namespace ConsoleDotnet6DI
{
    /// <summary>
    /// Interface for Age Handlers
    /// </summary>
    public interface IAgeHandler
    {
        /// <summary>
        /// Method signature for Direction method
        /// </summary>
        /// <param name="person"><see cref="Person"/></param>
        void Direction(Person person);
    }
}
