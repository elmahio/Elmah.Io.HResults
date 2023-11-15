namespace Elmah.Io.HResults
{
    /// <summary>
    /// Represents a parsed facility.
    /// </summary>
    public class Facility
    {
        internal Facility(int identifier, string name)
        {
            Identifier = identifier;
            Name = name;
        }

        /// <summary>
        /// The ID of the facility. Example: 7
        /// </summary>
        public int Identifier { get; set; }

        /// <summary>
        /// The name of the facility: Example: FACILITY_WIN32
        /// </summary>
        public string? Name { get; set; }
    }
}
