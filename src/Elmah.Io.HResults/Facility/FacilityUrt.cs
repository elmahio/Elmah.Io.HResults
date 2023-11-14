namespace Elmah.Io.HResults.Facility
{
    internal class FacilityUrt : FacilityBase
    {
        public FacilityUrt() : base("FACILITY_URT")
        {
        }

        internal override string? ErrorCodeToString(int errorCode)
        {
            switch (errorCode)
            {
                case 5632: return "COR_E_APPLICATION";
            }

            return $"{errorCode}";
        }
    }
}
