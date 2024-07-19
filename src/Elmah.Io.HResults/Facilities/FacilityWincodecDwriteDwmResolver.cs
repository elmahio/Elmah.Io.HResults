using System;
using System.Collections.Generic;
using System.Text;

namespace Elmah.Io.HResults.Facilities
{
    // Sources:
    // - https://learn.microsoft.com/en-us/troubleshoot/developer/dotnet/framework/general/wpf-render-thread-failures
    internal class FacilityWincodecDwriteDwmResolver : FacilityResolverBase
    {
        public FacilityWincodecDwriteDwmResolver() : base(2200, "FACILITY_WINCODEC_DWRITE_DWM")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                1030 => new Code(code, "UCEERR_RENDERTHREADFAILURE"),
                _ => Unknown(code),
            };
        }
    }
}
