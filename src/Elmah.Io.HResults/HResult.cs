using Elmah.Io.HResults.Facility;

namespace Elmah.Io.HResults
{
    public class HResult
    {
        public static HResult Parse(int i)
        {
            var hresult = new HResult();
            hresult.IsFailure = (i & 0x80000000) != 0;
            var facility = (i & 0x7FFF0000) >> 16;
            hresult.Facility = Facilities.FacilityToString(facility);
            hresult.Hex = $"0x{i.ToString("X8")}";
            var errorCode = (i & 0xFFFF);
            hresult.ErrorCode = Facilities.ErrorCodeToString(facility, errorCode);
            return hresult;
        }

        public bool IsFailure { get; set; }
        public string? Facility { get; set; }
        public string? Hex { get; set; }
        public string? ErrorCode { get; set; }
    }
}
