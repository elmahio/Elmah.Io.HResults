namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityWindowsResolver : FacilityResolverBase
    {
        public FacilityWindowsResolver() : base(8, "FACILITY_WINDOWS")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            if (failure)
            {
                switch (code)
                {
                    case 1: return new Code(code, "CO_E_CLASS_CREATE_FAILED", "Attempt to create a class object failed.");
                    case 2: return new Code(code, "CO_E_SCM_ERROR", "OLE service could not bind object.");
                    case 3: return new Code(code, "CO_E_SCM_RPC_FAILURE", "RPC communication failed with OLE service.");
                    case 4: return new Code(code, "CO_E_BAD_PATH", "Bad path to object.");
                    case 5: return new Code(code, "CO_E_SERVER_EXEC_FAILURE", "Server execution failed.");
                    case 6: return new Code(code, "CO_E_OBJSRV_RPC_FAILURE", "OLE service could not communicate with the object server.");
                    case 7: return new Code(code, "MK_E_NO_NORMALIZED", "Moniker path could not be normalized.");
                    case 8: return new Code(code, "CO_E_SERVER_STOPPING", "Object server is stopping when OLE service contacts it.");
                    case 9: return new Code(code, "MEM_E_INVALID_ROOT", "An invalid root block pointer was specified.");
                    case 16: return new Code(code, "MEM_E_INVALID_LINK", "An allocation chain contained an invalid link pointer.");
                    case 17: return new Code(code, "MEM_E_INVALID_SIZE", "The requested allocation size was too large.");
                    case 21: return new Code(code, "CO_E_MISSING_DISPLAYNAME", "The activation requires a display name to be present under the class identifier (CLSID) key.");
                    case 22: return new Code(code, "CO_E_RUNAS_VALUE_MUST_BE_AAA", "The activation requires that the RunAs value for the application is Activate As Activator.");
                    case 23: return new Code(code, "CO_E_ELEVATION_DISABLED", "The class is not configured to support elevated activation.");
                }
            }
            else
            {
                switch (code)
                {
                    case 18: return new Code(code, "CO_S_NOTALLINTERFACES", "Not all the requested interfaces were available.");
                    case 19: return new Code(code, "CO_S_MACHINENAMENOTFOUND", "The specified machine name was not found in the cache.");
                }
            }

            return Unknown(code);
        }
    }
}
