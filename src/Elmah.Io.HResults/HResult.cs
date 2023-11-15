namespace Elmah.Io.HResults
{
    /// <summary>
    /// Represents a parsed HResult.
    /// </summary>
    public class HResult
    {
        /// <summary>
        /// Parse an integer to a HResult. The method will (unless an exception is thrown) always return a result.
        /// </summary>
        public static HResult Parse(int i)
        {
            var hresult = new HResult();
            var isFailure = (i & 0x80000000) != 0;
            hresult.IsFailure = isFailure;
            var facility = (i & 0x7FFF0000) >> 16;
            hresult.Facility = facility.ToFacility();
            hresult.Hex = $"0x{i.ToString("X8")}";
            var code = (i & 0xFFFF);
            hresult.Code = code.ToCode(isFailure, facility);
            return hresult;
        }

        /// <summary>
        /// Indicates if the HResult is a failure or not.
        /// </summary>
        public bool IsFailure { get; set; }

        /// <summary>
        /// Identifies the part of the system for which the HResult applies.
        /// </summary>
        public Facility Facility { get; set; }

        /// <summary>
        /// The parsed Hex code from the HResult.
        /// </summary>
        public string? Hex { get; set; }

        /// <summary>
        /// Identifies a particular condition in the context of the facility.
        /// </summary>
        public Code Code { get; set; }

    }
}
