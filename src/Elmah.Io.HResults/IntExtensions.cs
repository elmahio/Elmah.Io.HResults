using Elmah.Io.HResults.Facilities;
using System.Collections.Generic;

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
            var resolver = facilityResolvers.Find(fr => fr.Identifier == facility);
            if (resolver != null) return resolver.Resolve(failure, code);

            return new Code(code, $"{code}", isMatch: false);
        }

        internal static Facility ToFacility(this int facility)
        {
            var resolver = facilityResolvers.Find(fr => fr.Identifier == facility);
            if (resolver != null) return resolver.Facility();

            return facility switch
            {
                10 => new Facility(facility, "FACILITY_CONTROL"),
                12 => new Facility(facility, "FACILITY_INTERNET"),
                14 => new Facility(facility, "FACILITY_MSMQ"),
                18 => new Facility(facility, "FACILITY_AAF"),
                20 => new Facility(facility, "FACILITY_ACS"),
                21 => new Facility(facility, "FACILITY_DPLAY"),
                22 => new Facility(facility, "FACILITY_UMI"),
                23 => new Facility(facility, "FACILITY_SXS"),
                24 => new Facility(facility, "FACILITY_WINDOWS_CE"),
                25 => new Facility(facility, "FACILITY_HTTP"),
                26 => new Facility(facility, "FACILITY_USERMODE_COMMONLOG"),
                32 => new Facility(facility, "FACILITY_BACKGROUNDCOPY"),
                33 => new Facility(facility, "FACILITY_CONFIGURATION"),
                34 => new Facility(facility, "FACILITY_STATE_MANAGEMENT"),
                35 => new Facility(facility, "FACILITY_METADIRECTORY"),
                36 => new Facility(facility, "FACILITY_WINDOWSUPDATE"),
                37 => new Facility(facility, "FACILITY_DIRECTORYSERVICE"),
                39 => new Facility(facility, "FACILITY_SHELL"),
                51 => new Facility(facility, "FACILITY_WINRM"),
                53 => new Facility(facility, "FACILITY_USERMODE_HYPERVISOR"),
                54 => new Facility(facility, "FACILITY_CMI"),
                55 => new Facility(facility, "FACILITY_USERMODE_VIRTUALIZATION"),
                56 => new Facility(facility, "FACILITY_USERMODE_VOLMGR"),
                57 => new Facility(facility, "FACILITY_BCD"),
                58 => new Facility(facility, "FACILITY_USERMODE_VHD"),
                60 => new Facility(facility, "FACILITY_SDIAG"),
                61 => new Facility(facility, "FACILITY_WEBSERVICES"),
                80 => new Facility(facility, "FACILITY_WINDOWS_DEFENDER"),
                81 => new Facility(facility, "FACILITY_OPC"),
                _ => new Facility(facility, $"{facility}", isMatch: false),
            };
        }
    }
}
