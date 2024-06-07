namespace Elmah.Io.HResults
{
    /// <summary>
    /// Represents a parsed code.
    /// </summary>
    public class Code
    {
        internal Code(int identifier, string name, string? description = null, bool isMatch = true)
        {
            Identifier = identifier;
            Name = name;
            Description = description;
            IsMatch = isMatch;
        }

        /// <summary>
        /// The ID of the code. Example: 2
        /// </summary>
        public int Identifier { get; set; }

        /// <summary>
        /// The name of the code. Example: ERROR_FILE_NOT_FOUND
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A potential description of the code.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Indicate if Elmah.Io.HResults were able to find a known match to this code.
        /// In case no match is found, the integer code value will be used as the name.
        /// </summary>
        public bool IsMatch { get; set; }
    }
}
