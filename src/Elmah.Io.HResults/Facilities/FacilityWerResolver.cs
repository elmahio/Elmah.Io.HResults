namespace Elmah.Io.HResults.Facilities
{
    // Sources:
    // - https://github.com/googleprojectzero/sandbox-attacksurface-analysis-tools/blob/852b1586b8c4527f8be3f486801e4830220c76d0/NtCoreLib/Win32/Win32Error.cs#L6088C5-L6108C50
    internal class FacilityWerResolver : FacilityResolverBase
    {
        public FacilityWerResolver() : base(27, "FACILITY_WER")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                0 => new Code(code, "WER_S_REPORT_DEBUG"),
                1 => new Code(code, "WER_S_REPORT_UPLOADED"),
                2 => new Code(code, "WER_S_REPORT_QUEUED"),
                3 => new Code(code, "WER_S_DISABLED"),
                4 => new Code(code, "WER_S_SUSPENDED_UPLOAD"),
                5 => new Code(code, "WER_S_DISABLED_QUEUE"),
                6 => new Code(code, "WER_S_DISABLED_ARCHIVE"),
                7 => new Code(code, "WER_S_REPORT_ASYNC"),
                8 => new Code(code, "WER_S_IGNORE_ASSERT_INSTANCE"),
                9 => new Code(code, "WER_S_IGNORE_ALL_ASSERTS"),
                10 => new Code(code, "WER_S_ASSERT_CONTINUE"),
                11 => new Code(code, "WER_S_THROTTLED"),
                12 => new Code(code, "WER_S_REPORT_UPLOADED_CAB"),
                32768 => new Code(code, "WER_E_CRASH_FAILURE"),
                32769 => new Code(code, "WER_E_CANCELED"),
                32770 => new Code(code, "WER_E_NETWORK_FAILURE"),
                32771 => new Code(code, "WER_E_NOT_INITIALIZED"),
                32772 => new Code(code, "WER_E_ALREADY_REPORTING"),
                32773 => new Code(code, "WER_E_DUMP_THROTTLED"),
                32774 => new Code(code, "WER_E_INSUFFICIENT_CONSENT"),
                32775 => new Code(code, "WER_E_TOO_HEAVY"),
                _ => Unknown(code),
            };
        }
    }
}
