namespace Elmah.Io.HResults
{
    /// <summary>
    /// Represents a parsed facility.
    /// </summary>
    public class Facility
    {
        internal Facility(int identifier, string name, bool isMatch = true)
        {
            Identifier = identifier;
            Name = name;
            IsMatch = isMatch;
        }

        /// <summary>
        /// The ID of the facility. Example: 7
        /// </summary>
        public int Identifier { get; set; }

        /// <summary>
        /// The name of the facility: Example: FACILITY_WIN32
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Indicate if Elmah.Io.HResults were able to find a known match to this facility.
        /// In case no match is found, the integer code value will be used as the name.
        /// </summary>
        public bool IsMatch { get; set; }
    }
}
