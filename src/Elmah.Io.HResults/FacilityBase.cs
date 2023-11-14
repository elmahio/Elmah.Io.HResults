namespace Elmah.Io.HResults
{
    internal abstract class FacilityBase
    {
        public string Name { get; set; }

        protected FacilityBase(string name)
        {
            Name = name;
        }

        internal abstract string? ErrorCodeToString(int errorCode);
    }
}
