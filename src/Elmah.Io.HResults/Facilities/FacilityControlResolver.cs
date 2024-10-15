using System;
using System.Collections.Generic;
using System.Text;

namespace Elmah.Io.HResults.Facilities
{
    // Sources:
    // - https://github.com/tpn/winsdk-10/blob/master/Include/10.0.14393.0/um/OleCtl.h
    internal class FacilityControlResolver : FacilityResolverBase
    {
        public FacilityControlResolver() : base(10, "FACILITY_CONTROL")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                5 => new Code(code, "CTL_E_ILLEGALFUNCTIONCALL"),
                6 => new Code(code, "CTL_E_OVERFLOW"),
                7 => new Code(code, "CTL_E_OUTOFMEMORY"),
                11 => new Code(code, "CTL_E_DIVISIONBYZERO"),
                14 => new Code(code, "CTL_E_OUTOFSTRINGSPACE"),
                28 => new Code(code, "CTL_E_OUTOFSTACKSPACE"),
                52 => new Code(code, "CTL_E_BADFILENAMEORNUMBER"),
                53 => new Code(code, "CTL_E_FILENOTFOUND"),
                54 => new Code(code, "CTL_E_BADFILEMODE"),
                55 => new Code(code, "CTL_E_FILEALREADYOPEN"),
                57 => new Code(code, "CTL_E_DEVICEIOERROR"),
                58 => new Code(code, "CTL_E_FILEALREADYEXISTS"),
                59 => new Code(code, "CTL_E_BADRECORDLENGTH"),
                61 => new Code(code, "CTL_E_DISKFULL"),
                63 => new Code(code, "CTL_E_BADRECORDNUMBER"),
                64 => new Code(code, "CTL_E_BADFILENAME"),
                67 => new Code(code, "CTL_E_TOOMANYFILES"),
                68 => new Code(code, "CTL_E_DEVICEUNAVAILABLE"),
                70 => new Code(code, "CTL_E_PERMISSIONDENIED"),
                71 => new Code(code, "CTL_E_DISKNOTREADY"),
                75 => new Code(code, "CTL_E_PATHFILEACCESSERROR"),
                76 => new Code(code, "CTL_E_PATHNOTFOUND"),
                93 => new Code(code, "CTL_E_INVALIDPATTERNSTRING"),
                94 => new Code(code, "CTL_E_INVALIDUSEOFNULL"),
                321 => new Code(code, "CTL_E_INVALIDFILEFORMAT"),
                380 => new Code(code, "CTL_E_INVALIDPROPERTYVALUE"),
                381 => new Code(code, "CTL_E_INVALIDPROPERTYARRAYINDEX"),
                382 => new Code(code, "CTL_E_SETNOTSUPPORTEDATRUNTIME"),
                383 => new Code(code, "CTL_E_SETNOTSUPPORTED"),
                385 => new Code(code, "CTL_E_NEEDPROPERTYARRAYINDEX"),
                387 => new Code(code, "CTL_E_SETNOTPERMITTED"),
                393 => new Code(code, "CTL_E_GETNOTSUPPORTEDATRUNTIME"),
                394 => new Code(code, "CTL_E_GETNOTSUPPORTED"),
                422 => new Code(code, "CTL_E_PROPERTYNOTFOUND"),
                460 => new Code(code, "CTL_E_INVALIDCLIPBOARDFORMAT"),
                481 => new Code(code, "CTL_E_INVALIDPICTURE"),
                482 => new Code(code, "CTL_E_PRINTERERROR"),
                735 => new Code(code, "CTL_E_CANTSAVEFILETOTEMP"),
                744 => new Code(code, "CTL_E_SEARCHTEXTNOTFOUND"),
                746 => new Code(code, "CTL_E_REPLACEMENTSTOOLONG"),
                1004 => Unknown(code), // Typically a COM exception when dealing with Excel. It's not documented anywhere so return Unknown.
                50290 => new Code(code, "VBA_E_IGNORE", "This error is specific to interactions with Visual Basic for Applications (VBA) and typically indicates that the error is being ignored by the system or the automation process."), // https://learn.microsoft.com/en-us/archive/msdn-technet-forums/9168f9f2-e5bc-4535-8d7d-4e374ab8ff09
                _ => Unknown(code),
            };
        }
    }
}
