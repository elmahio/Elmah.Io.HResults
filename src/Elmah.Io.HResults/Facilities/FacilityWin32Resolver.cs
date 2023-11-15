namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityWin32Resolver : FacilityResolverBase
    {
        public FacilityWin32Resolver() : base(7, "FACILITY_WIN32")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                2 => new Code(code, "ERROR_FILE_NOT_FOUND"),
                5 => new Code(code, "E_ACCESSDENIED", "General access denied error."),
                14 => new Code(code, "E_OUTOFMEMORY", "The server does not have enough memory for the new channel."),
                50 => new Code(code, "ERROR_NOT_SUPPORTED", "The server cannot support a client request for a dynamic virtual channel."),
                87 => new Code(code, "E_INVALIDARG", "One or more arguments are invalid."),
                112 => new Code(code, "ERROR_DISK_FULL", "There is not enough space on the disk."),
                _ => Unknown(code),
            };
        }
    }
}
