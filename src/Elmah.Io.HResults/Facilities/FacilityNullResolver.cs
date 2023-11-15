namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityNullResolver : FacilityResolverBase
    {
        public FacilityNullResolver() : base(0, "FACILITY_NULL")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                1 => new Code(code, "ERROR_AUDITING_DISABLED", "The specified event is currently not being audited."),
                2 => new Code(code, "ERROR_ALL_SIDS_FILTERED", "The SID filtering operation removed all SIDs."),
                3 => new Code(code, "ERROR_BIZRULES_NOT_ENABLED", "Business rule scripts are disabled for the calling application."),
                _ => Unknown(code),
            };
        }
    }
}
