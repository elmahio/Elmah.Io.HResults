using Elmah.Io.HResults.Facilities;
using System.Collections.Generic;
using System.Linq;

namespace Elmah.Io.HResults
{
    internal static class IntExtensions
    {
        private static readonly List<FacilityResolverBase> facilityResolvers = new List<FacilityResolverBase>
        {
            new FacilityCertResolver(), new FacilityComplusResolver(), new FacilityDispatchResolver(),
            new FacilityFveResolver(), new FacilityFwpResolver(), new FacilityGraphicsResolver(),
            new FacilityItfResolver(), new FacilityMediaserverResolver(), new FacilityNdisResolver(),
            new FacilityNullResolver(), new FacilityPlaResolver(), new FacilityRpcResolver(),
            new FacilityScardResolver(), new FacilitySecurityResolver(), new FacilitySetupapiResolver(),
            new FacilityStorageResolver(), new FacilityTpmServicesResolver(), new FacilityTpmSoftwareResolver(),
            new FacilityUrtResolver(), new FacilityUsermodeFilterManagerResolver(), new FacilityWin32Resolver(),
            new FacilityWindowsResolver(),
        };

        internal static Code ToCode(this int code, bool failure, int facility)
        {
            var resolver = facilityResolvers.FirstOrDefault(fr => fr.Identifier == facility);
            if (resolver != null) return resolver.Resolve(failure, code);

            return new Code(code, $"{code}");
        }

        internal static Facility ToFacility(this int facility)
        {
            var resolver = facilityResolvers.FirstOrDefault(fr => fr.Identifier == facility);
            if (resolver != null) return resolver.Facility();

            switch (facility)
            {
                case 10: return new Facility(facility, "FACILITY_CONTROL");
                case 12: return new Facility(facility, "FACILITY_INTERNET");
                case 14: return new Facility(facility, "FACILITY_MSMQ");
                case 18: return new Facility(facility, "FACILITY_AAF");
                case 20: return new Facility(facility, "FACILITY_ACS");
                case 21: return new Facility(facility, "FACILITY_DPLAY");
                case 22: return new Facility(facility, "FACILITY_UMI");
                case 23: return new Facility(facility, "FACILITY_SXS");
                case 24: return new Facility(facility, "FACILITY_WINDOWS_CE");
                case 25: return new Facility(facility, "FACILITY_HTTP");
                case 26: return new Facility(facility, "FACILITY_USERMODE_COMMONLOG");
                case 32: return new Facility(facility, "FACILITY_BACKGROUNDCOPY");
                case 33: return new Facility(facility, "FACILITY_CONFIGURATION");
                case 34: return new Facility(facility, "FACILITY_STATE_MANAGEMENT");
                case 35: return new Facility(facility, "FACILITY_METADIRECTORY");
                case 36: return new Facility(facility, "FACILITY_WINDOWSUPDATE");
                case 37: return new Facility(facility, "FACILITY_DIRECTORYSERVICE");
                case 39: return new Facility(facility, "FACILITY_SHELL");
                case 51: return new Facility(facility, "FACILITY_WINRM");
                case 53: return new Facility(facility, "FACILITY_USERMODE_HYPERVISOR");
                case 54: return new Facility(facility, "FACILITY_CMI");
                case 55: return new Facility(facility, "FACILITY_USERMODE_VIRTUALIZATION");
                case 56: return new Facility(facility, "FACILITY_USERMODE_VOLMGR");
                case 57: return new Facility(facility, "FACILITY_BCD");
                case 58: return new Facility(facility, "FACILITY_USERMODE_VHD");
                case 60: return new Facility(facility, "FACILITY_SDIAG");
                case 61: return new Facility(facility, "FACILITY_WEBSERVICES");
                case 80: return new Facility(facility, "FACILITY_WINDOWS_DEFENDER");
                case 81: return new Facility(facility, "FACILITY_OPC");
            }

            return facilityResolvers.First(fr => fr.Identifier == 0).Facility();
        }
    }
}
