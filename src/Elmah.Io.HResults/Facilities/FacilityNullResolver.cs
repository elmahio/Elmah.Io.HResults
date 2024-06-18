namespace Elmah.Io.HResults.Facilities
{
    // Sources:
    // - https://learn.microsoft.com/en-us/windows/win32/com/error-handling-strategies
    // - https://learn.microsoft.com/en-us/dotnet/api/system.reflection.ambiguousmatchexception
    internal class FacilityNullResolver : FacilityResolverBase
    {
        public FacilityNullResolver() : base(0, "FACILITY_NULL")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            if (!failure)
            {
                return code switch
                {
                    0 => new Code(code, "S_OK", "The method succeeded. If a boolean return value is expected, the returned value is TRUE."),
                    1 => new Code(code, "S_FALSE", "The method succeeded and returned the boolean value FALSE."),
                    _ => Unknown(code),
                };
            }

            return code switch
            {
                1 => new Code(code, "ERROR_AUDITING_DISABLED", "The specified event is currently not being audited."),
                2 => new Code(code, "ERROR_ALL_SIDS_FILTERED", "The SID filtering operation removed all SIDs."),
                3 => new Code(code, "ERROR_BIZRULES_NOT_ENABLED", "Business rule scripts are disabled for the calling application."),
                5 => new Code(code, "E_ACCESSDENIED", "A general access - denied error."),
                6 => new Code(code, "E_HANDLE", "An invalid handle was used."),
                10 => new Code(code, "E_PENDING", "The data necessary to complete the operation is not yet available."),
                14 => new Code(code, "E_OUTOFMEMORY", "The method failed to allocate necessary memory."),
                87 => new Code(code, "E_INVALIDARG", "One or more arguments are invalid."),
                8477 => new Code(code, "COR_E_AMBIGUOUSMATCH"),
                16385 => new Code(code, "E_NOTIMPL", "The method is not implemented."),
                16386 => new Code(code, "E_NOINTERFACE", "The QueryInterface method did not recognize the requested interface. The interface is not supported."),
                16387 => new Code(code, "E_POINTER", "An invalid pointer was used."),
                16388 => new Code(code, "E_ABORT", "The operation was aborted because of an unspecified error."),
                16389 => new Code(code, "E_FAIL", "An unspecified failure has occurred."),
                65535 => new Code(code, "E_UNEXPECTED", "A catastrophic failure has occurred."),
                _ => Unknown(code),
            };
        }
    }
}
