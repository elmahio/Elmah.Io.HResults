using System.Collections.Generic;

namespace Elmah.Io.HResults.Facility
{
    internal class Facilities
    {
        private static readonly Dictionary<int, FacilityBase> facilities = new Dictionary<int, FacilityBase>
        {
            { 19, new FacilityUrt() }, { 7, new FacilityWin32() }
        };

        internal static string? ErrorCodeToString(int facility, int errorCode)
        {
            if (!facilities.ContainsKey(facility)) return $"{errorCode}";

            return facilities[facility].ErrorCodeToString(errorCode);
        }

        internal static string? FacilityToString(int facility)
        {
            if (facilities.ContainsKey(facility)) return facilities[facility].Name;

            switch (facility)
            {
                case 0: return "FACILITY_NULL";
                case 1: return "FACILITY_RPC";
                case 2: return "FACILITY_DISPATCH";
                case 3: return "FACILITY_STORAGE";
                case 4: return "FACILITY_ITF";
                case 8: return "FACILITY_WINDOWS";
                case 9: return "FACILITY_SECURITY";
                case 10: return "FACILITY_CONTROL";
                case 11: return "FACILITY_CERT";
                case 12: return "FACILITY_INTERNET";
                case 13: return "FACILITY_MEDIASERVER";
                case 14: return "FACILITY_MSMQ";
                case 15: return "FACILITY_SETUPAPI";
                case 16: return "FACILITY_SCARD";
                case 17: return "FACILITY_COMPLUS";
                case 18: return "FACILITY_AAF";
                case 20: return "FACILITY_ACS";
                case 21: return "FACILITY_DPLAY";
                case 22: return "FACILITY_UMI";
                case 23: return "FACILITY_SXS";
                case 24: return "FACILITY_WINDOWS_CE";
                case 25: return "FACILITY_HTTP";
                case 26: return "FACILITY_USERMODE_COMMONLOG";
                case 31: return "FACILITY_USERMODE_FILTER_MANAGER";
                case 32: return "FACILITY_BACKGROUNDCOPY";
                case 33: return "FACILITY_CONFIGURATION";
                case 34: return "FACILITY_STATE_MANAGEMENT";
                case 35: return "FACILITY_METADIRECTORY";
                case 36: return "FACILITY_WINDOWSUPDATE";
                case 37: return "FACILITY_DIRECTORYSERVICE";
                case 38: return "FACILITY_GRAPHICS";
                case 39: return "FACILITY_SHELL";
                case 40: return "FACILITY_TPM_SERVICES";
                case 41: return "FACILITY_TPM_SOFTWARE";
                case 48: return "FACILITY_PLA";
                case 49: return "FACILITY_FVE";
                case 50: return "FACILITY_FWP";
                case 51: return "FACILITY_WINRM";
                case 52: return "FACILITY_NDIS";
                case 53: return "FACILITY_USERMODE_HYPERVISOR";
                case 54: return "FACILITY_CMI";
                case 55: return "FACILITY_USERMODE_VIRTUALIZATION";
                case 56: return "FACILITY_USERMODE_VOLMGR";
                case 57: return "FACILITY_BCD";
                case 58: return "FACILITY_USERMODE_VHD";
                case 60: return "FACILITY_SDIAG";
                case 61: return "FACILITY_WEBSERVICES";
                case 80: return "FACILITY_WINDOWS_DEFENDER";
                case 81: return "FACILITY_OPC";
            }

            return "FACILITY_NULL";
        }
    }
}
