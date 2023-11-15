namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityPlaResolver : FacilityResolverBase
    {
        public FacilityPlaResolver() : base(48, "FACILITY_PLA")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            if (failure)
            {
                switch (code)
                {
                    case 2: return new Code(code, "PLA_E_DCS_NOT_FOUND", "A Data Collector Set was not found.");
                    case 69: return new Code(code, "PLA_E_TOO_MANY_FOLDERS", "Unable to start Data Collector Set because there are too many folders.");
                    case 112: return new Code(code, "PLA_E_NO_MIN_DISK", "Not enough free disk space to start Data Collector Set.");
                    case 170: return new Code(code, "PLA_E_DCS_IN_USE", "Data Collector Set is in use.");
                    case 183: return new Code(code, "PLA_E_DCS_ALREADY_EXISTS", "Data Collector Set already exists.");
                    case 257: return new Code(code, "PLA_E_PROPERTY_CONFLICT", "Property value conflict.");
                    case 258: return new Code(code, "PLA_E_DCS_SINGLETON_REQUIRED", "The current configuration for this Data Collector Set requires that it contain exactly one Data Collector.");
                    case 259: return new Code(code, "PLA_E_CREDENTIALS_REQUIRED", "A user account is required to commit the current Data Collector Set properties.");
                    case 260: return new Code(code, "PLA_E_DCS_NOT_RUNNING", "Data Collector Set is not running.");
                    case 261: return new Code(code, "PLA_E_CONFLICT_INCL_EXCL_API", "A conflict was detected in the list of include and exclude APIs. Do not specify the same API in both the include list and the exclude list.");
                    case 262: return new Code(code, "PLA_E_NETWORK_EXE_NOT_VALID", "The executable path specified refers to a network share or UNC path.");
                    case 263: return new Code(code, "PLA_E_EXE_ALREADY_CONFIGURED", "The executable path specified is already configured for API tracing.");
                    case 264: return new Code(code, "PLA_E_EXE_PATH_NOT_VALID", "The executable path specified does not exist. Verify that the specified path is correct.");
                    case 265: return new Code(code, "PLA_E_DC_ALREADY_EXISTS", "Data Collector already exists.");
                    case 266: return new Code(code, "PLA_E_DCS_START_WAIT_TIMEOUT", "The wait for the Data Collector Set start notification has timed out.");
                    case 267: return new Code(code, "PLA_E_DC_START_WAIT_TIMEOUT", "The wait for the Data Collector to start has timed out.");
                    case 268: return new Code(code, "PLA_E_REPORT_WAIT_TIMEOUT", "The wait for the report generation tool to finish has timed out.");
                    case 269: return new Code(code, "PLA_E_NO_DUPLICATES", "Duplicate items are not allowed.");
                    case 270: return new Code(code, "PLA_E_EXE_FULL_PATH_REQUIRED", "When specifying the executable to trace, you must specify a full path to the executable and not just a file name.");
                    case 271: return new Code(code, "PLA_E_INVALID_SESSION_NAME", "The session name provided is invalid.");
                    case 272: return new Code(code, "PLA_E_PLA_CHANNEL_NOT_ENABLED", "The Event Log channel Microsoft-Windows-Diagnosis-PLA/Operational must be enabled to perform this operation.");
                    case 273: return new Code(code, "PLA_E_TASKSCHED_CHANNEL_NOT_ENABLED", "The Event Log channel Microsoft-Windows-TaskScheduler must be enabled to perform this operation.");
                }
            }
            else
            {
                switch (code)
                {
                    case 256: return new Code(code, "PLA_S_PROPERTY_IGNORED", "Property value will be ignored.");
                }
            }

            return Unknown(code);
        }
    }
}
