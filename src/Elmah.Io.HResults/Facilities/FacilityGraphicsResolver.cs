namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityGraphicsResolver : FacilityResolverBase
    {
        public FacilityGraphicsResolver() : base(38, "FACILITY_GRAPHICS")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            if (failure)
            {
                switch (code)
                {
                    case 1: return new Code(code, "ERROR_HUNG_DISPLAY_DRIVER_THREAD", "{Display Driver Stopped Responding} The %hs display driver has stopped working normally. Save your work and reboot the system to restore full display functionality. The next time you reboot the machine a dialog will be displayed giving you a chance to report this failure to Microsoft.");
                    case 4097: return new Code(code, "ERROR_MONITOR_NO_DESCRIPTOR", "Monitor descriptor could not be obtained.");
                    case 4098: return new Code(code, "ERROR_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT", "Format of the obtained monitor descriptor is not supported by this release.");
                    case 12289: return new Code(code, "DWM_E_COMPOSITIONDISABLED", "{Desktop Composition is Disabled} The operation could not be completed because desktop composition is disabled.");
                    case 12290: return new Code(code, "DWM_E_REMOTING_NOT_SUPPORTED", "{Some Desktop Composition APIs Are Not Supported While Remoting} Some desktop composition APIs are not supported while remoting. The operation is not supported while running in a remote session.");
                    case 12291: return new Code(code, "DWM_E_NO_REDIRECTION_SURFACE_AVAILABLE", "{No DWM Redirection Surface is Available} The Desktop Window Manager (DWM) was unable to provide a redirection surface to complete the DirectX present.");
                    case 12292: return new Code(code, "DWM_E_NOT_QUEUING_PRESENTS", "{DWM Is Not Queuing Presents for the Specified Window} The window specified is not currently using queued presents.");
                }
            }
            else
            {
                switch (code)
                {
                    case 8967: return new Code(code, "ERROR_GRAPHICS_MODE_NOT_PINNED", "No mode is pinned on the specified VidPN source or target.");
                    case 8990: return new Code(code, "ERROR_GRAPHICS_NO_PREFERRED_MODE", "Specified mode set does not specify preference for one of its modes.");
                    case 9035: return new Code(code, "ERROR_GRAPHICS_DATASET_IS_EMPTY", "Specified data set (for example, mode set, frequency range set, descriptor set, and topology) is empty.");
                    case 9036: return new Code(code, "ERROR_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET", "Specified data set (for example, mode set, frequency range set, descriptor set, and topology) does not contain any more elements.");
                    case 9041: return new Code(code, "ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED", "Specified content transformation is not pinned on the specified VidPN present path.");
                }
            }

            return Unknown(code);
        }
    }
}
