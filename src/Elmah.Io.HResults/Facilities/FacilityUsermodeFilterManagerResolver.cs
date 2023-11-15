namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityUsermodeFilterManagerResolver : FacilityResolverBase
    {
        public FacilityUsermodeFilterManagerResolver() : base(31, "FACILITY_USERMODE_FILTER_MANAGER")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            if (failure)
            {
                switch (code)
                {
                    case 1: return new Code(code, "ERROR_FLT_NO_HANDLER_DEFINED", "A handler was not defined by the filter for this operation.");
                    case 2: return new Code(code, "ERROR_FLT_CONTEXT_ALREADY_DEFINED", "A context is already defined for this object.");
                    case 3: return new Code(code, "ERROR_FLT_INVALID_ASYNCHRONOUS_REQUEST", "Asynchronous requests are not valid for this operation.");
                    case 4: return new Code(code, "ERROR_FLT_DISALLOW_FAST_IO", "Disallow the Fast IO path for this operation.");
                    case 5: return new Code(code, "ERROR_FLT_INVALID_NAME_REQUEST", "An invalid name request was made. The name requested cannot be retrieved at this time.");
                    case 6: return new Code(code, "ERROR_FLT_NOT_SAFE_TO_POST_OPERATION", "Posting this operation to a worker thread for further processing is not safe at this time because it could lead to a system deadlock.");
                    case 7: return new Code(code, "ERROR_FLT_NOT_INITIALIZED", "The Filter Manager was not initialized when a filter tried to register. Be sure that the Filter Manager is being loaded as a driver.");
                    case 8: return new Code(code, "ERROR_FLT_FILTER_NOT_READY", "The filter is not ready for attachment to volumes because it has not finished initializing (FltStartFiltering has not been called).");
                    case 9: return new Code(code, "ERROR_FLT_POST_OPERATION_CLEANUP", "The filter must clean up any operation-specific context at this time because it is being removed from the system before the operation is completed by the lower drivers.");
                    case 10: return new Code(code, "ERROR_FLT_INTERNAL_ERROR", "The Filter Manager had an internal error from which it cannot recover; therefore, the operation has been failed. This is usually the result of a filter returning an invalid value from a preoperation callback.");
                    case 11: return new Code(code, "ERROR_FLT_DELETING_OBJECT", "The object specified for this action is in the process of being deleted; therefore, the action requested cannot be completed at this time.");
                    case 12: return new Code(code, "ERROR_FLT_MUST_BE_NONPAGED_POOL", "Nonpaged pool must be used for this type of context.");
                    case 13: return new Code(code, "ERROR_FLT_DUPLICATE_ENTRY", "A duplicate handler definition has been provided for an operation.");
                    case 14: return new Code(code, "ERROR_FLT_CBDQ_DISABLED", "The callback data queue has been disabled.");
                    case 15: return new Code(code, "ERROR_FLT_DO_NOT_ATTACH", "Do not attach the filter to the volume at this time.");
                    case 16: return new Code(code, "ERROR_FLT_DO_NOT_DETACH", "Do not detach the filter from the volume at this time.");
                    case 17: return new Code(code, "ERROR_FLT_INSTANCE_ALTITUDE_COLLISION", "An instance already exists at this altitude on the volume specified.");
                    case 18: return new Code(code, "ERROR_FLT_INSTANCE_NAME_COLLISION", "An instance already exists with this name on the volume specified.");
                    case 19: return new Code(code, "ERROR_FLT_FILTER_NOT_FOUND", "The system could not find the filter specified.");
                    case 20: return new Code(code, "ERROR_FLT_VOLUME_NOT_FOUND", "The system could not find the volume specified.");
                    case 21: return new Code(code, "ERROR_FLT_INSTANCE_NOT_FOUND", "The system could not find the instance specified.");
                    case 22: return new Code(code, "ERROR_FLT_CONTEXT_ALLOCATION_NOT_FOUND", "No registered context allocation definition was found for the given request.");
                    case 23: return new Code(code, "ERROR_FLT_INVALID_CONTEXT_REGISTRATION", "An invalid parameter was specified during context registration.");
                    case 24: return new Code(code, "ERROR_FLT_NAME_CACHE_MISS", "The name requested was not found in the Filter Manager name cache and could not be retrieved from the file system.");
                    case 25: return new Code(code, "ERROR_FLT_NO_DEVICE_OBJECT", "The requested device object does not exist for the given volume.");
                    case 26: return new Code(code, "ERROR_FLT_VOLUME_ALREADY_MOUNTED", "The specified volume is already mounted.");
                    case 27: return new Code(code, "ERROR_FLT_ALREADY_ENLISTED", "The specified Transaction Context is already enlisted in a transaction.");
                    case 28: return new Code(code, "ERROR_FLT_CONTEXT_ALREADY_LINKED", "The specified context is already attached to another object.");
                    case 32: return new Code(code, "ERROR_FLT_NO_WAITER_FOR_REPLY", "No waiter is present for the filter's reply to this message.");
                }
            }
            else
            {
                switch (code)
                {
                    case 1: return new Code(code, "ERROR_FLT_IO_COMPLETE", "The IO was completed by a filter.");
                }
            }

            return Unknown(code);
        }
    }
}
