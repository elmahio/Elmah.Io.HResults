using System;
using System.Collections.Generic;
using System.Text;

namespace Elmah.Io.HResults.Facility
{
    internal class FacilityWin32 : FacilityBase
    {
        public FacilityWin32() : base("FACILITY_WIN32")
        {
        }

        internal override string? ErrorCodeToString(int errorCode)
        {
            switch (errorCode)
            {
                case 2: return "ERROR_FILE_NOT_FOUND";
            }

            return $"{errorCode}";
        }
    }
}