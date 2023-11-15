namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityUrtResolver : FacilityResolverBase
    {
        public FacilityUrtResolver() : base(19, "FACILITY_URT")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                5632 => new Code(code, "COR_E_APPLICATION"),
                _ => Unknown(code),
            };
        }
    }
}
