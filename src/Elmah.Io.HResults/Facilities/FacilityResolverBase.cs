namespace Elmah.Io.HResults.Facilities
{
    // Thank you https://learn.microsoft.com/en-us/openspecs/windows_protocols/ms-erref/705fb797-2175-4a90-b5a3-3918024b10b8
    internal abstract class FacilityResolverBase
    {
        public int Identifier { get; set; }

        public string Name { get; set; }

        protected FacilityResolverBase(int identifier, string name)
        {
            Identifier = identifier;
            Name = name;
        }

        internal Facility Facility()
        {
            return new Facility(Identifier, Name);
        }

        internal virtual Code Resolve(bool failure, int code)
        {
            return Unknown(code);
        }

        protected static Code Unknown(int code)
        {
            return new Code(code, $"{code}", isMatch: false);
        }
    }
}
