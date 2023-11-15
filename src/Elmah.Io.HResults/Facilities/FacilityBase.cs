namespace Elmah.Io.HResults.Facilities
{
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

        protected Code Unknown(int code)
        {
            return new Code(code, $"{code}");
        }
    }
}
