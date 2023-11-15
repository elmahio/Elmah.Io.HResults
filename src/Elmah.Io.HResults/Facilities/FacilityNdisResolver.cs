namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityNdisResolver : FacilityResolverBase
    {
        public FacilityNdisResolver() : base(52, "FACILITY_NDIS")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            if (failure)
            {
                switch (code)
                {
                    case 2: return new Code(code, "ERROR_NDIS_INTERFACE_CLOSING", "The binding to the network interface is being closed.");
                    case 4: return new Code(code, "ERROR_NDIS_BAD_VERSION", "An invalid version was specified.");
                    case 5: return new Code(code, "ERROR_NDIS_BAD_CHARACTERISTICS", "An invalid characteristics table was used.");
                    case 6: return new Code(code, "ERROR_NDIS_ADAPTER_NOT_FOUND", "Failed to find the network interface, or the network interface is not ready.");
                    case 7: return new Code(code, "ERROR_NDIS_OPEN_FAILED", "Failed to open the network interface.");
                    case 8: return new Code(code, "ERROR_NDIS_DEVICE_FAILED", "The network interface has encountered an internal unrecoverable failure.");
                    case 9: return new Code(code, "ERROR_NDIS_MULTICAST_FULL", "The multicast list on the network interface is full.");
                    case 10: return new Code(code, "ERROR_NDIS_MULTICAST_EXISTS", "An attempt was made to add a duplicate multicast address to the list.");
                    case 11: return new Code(code, "ERROR_NDIS_MULTICAST_NOT_FOUND", "At attempt was made to remove a multicast address that was never added.");
                    case 12: return new Code(code, "ERROR_NDIS_REQUEST_ABORTED", "The network interface aborted the request.");
                    case 13: return new Code(code, "ERROR_NDIS_RESET_IN_PROGRESS", "The network interface cannot process the request because it is being reset.");
                    case 15: return new Code(code, "ERROR_NDIS_INVALID_PACKET", "An attempt was made to send an invalid packet on a network interface.");
                    case 16: return new Code(code, "ERROR_NDIS_INVALID_DEVICE_REQUEST", "The specified request is not a valid operation for the target device.");
                    case 17: return new Code(code, "ERROR_NDIS_ADAPTER_NOT_READY", "The network interface is not ready to complete this operation.");
                    case 20: return new Code(code, "ERROR_NDIS_INVALID_LENGTH", "The length of the buffer submitted for this operation is not valid.");
                    case 21: return new Code(code, "ERROR_NDIS_INVALID_DATA", "The data used for this operation is not valid.");
                    case 22: return new Code(code, "ERROR_NDIS_BUFFER_TOO_SHORT", "The length of the buffer submitted for this operation is too small.");
                    case 23: return new Code(code, "ERROR_NDIS_INVALID_OID", "The network interface does not support this OID.");
                    case 24: return new Code(code, "ERROR_NDIS_ADAPTER_REMOVED", "The network interface has been removed.");
                    case 25: return new Code(code, "ERROR_NDIS_UNSUPPORTED_MEDIA", "The network interface does not support this media type.");
                    case 26: return new Code(code, "ERROR_NDIS_GROUP_ADDRESS_IN_USE", "An attempt was made to remove a token ring group address that is in use by other components.");
                    case 27: return new Code(code, "ERROR_NDIS_FILE_NOT_FOUND", "An attempt was made to map a file that cannot be found.");
                    case 28: return new Code(code, "ERROR_NDIS_ERROR_READING_FILE", "An error occurred while the NDIS tried to map the file.");
                    case 29: return new Code(code, "ERROR_NDIS_ALREADY_MAPPED", "An attempt was made to map a file that is already mapped.");
                    case 30: return new Code(code, "ERROR_NDIS_RESOURCE_CONFLICT", "An attempt to allocate a hardware resource failed because the resource is used by another component.");
                    case 31: return new Code(code, "ERROR_NDIS_MEDIA_DISCONNECTED", "The I/O operation failed because network media is disconnected or the wireless access point is out of range.");
                    case 34: return new Code(code, "ERROR_NDIS_INVALID_ADDRESS", "The network address used in the request is invalid.");
                    case 42: return new Code(code, "ERROR_NDIS_PAUSED", "The offload operation on the network interface has been paused.");
                    case 43: return new Code(code, "ERROR_NDIS_INTERFACE_NOT_FOUND", "The network interface was not found.");
                    case 44: return new Code(code, "ERROR_NDIS_UNSUPPORTED_REVISION", "The revision number specified in the structure is not supported.");
                    case 45: return new Code(code, "ERROR_NDIS_INVALID_PORT", "The specified port does not exist on this network interface.");
                    case 46: return new Code(code, "ERROR_NDIS_INVALID_PORT_STATE", "The current state of the specified port on this network interface does not support the requested operation.");
                    case 187: return new Code(code, "ERROR_NDIS_NOT_SUPPORTED", "The network interface does not support this request.");
                    case 8192: return new Code(code, "ERROR_NDIS_DOT11_AUTO_CONFIG_ENABLED", "The wireless local area network (LAN) interface is in auto-configuration mode and does not support the requested parameter change operation.");
                    case 8193: return new Code(code, "ERROR_NDIS_DOT11_MEDIA_IN_USE", "The wireless LAN interface is busy and cannot perform the requested operation.");
                    case 8194: return new Code(code, "ERROR_NDIS_DOT11_POWER_STATE_INVALID", "The wireless LAN interface is shutting down and does not support the requested operation.");
                }
            }
            else
            {
                switch (code)
                {
                    case 1: return new Code(code, "ERROR_NDIS_INDICATION_REQUIRED", "The request will be completed later by a Network Driver Interface Specification (NDIS) status indication.");
                }
            }

            return Unknown(code);
        }
    }
}
