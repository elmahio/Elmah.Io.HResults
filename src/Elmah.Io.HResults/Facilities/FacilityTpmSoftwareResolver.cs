namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityTpmSoftwareResolver : FacilityResolverBase
    {
        public FacilityTpmSoftwareResolver() : base(41, "FACILITY_TPM_SOFTWARE")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                256 => new Code(code, "TPMAPI_E_INVALID_STATE", "The command buffer is not in the correct state."),
                257 => new Code(code, "TPMAPI_E_NOT_ENOUGH_DATA", "The command buffer does not contain enough data to satisfy the request."),
                258 => new Code(code, "TPMAPI_E_TOO_MUCH_DATA", "The command buffer cannot contain any more data."),
                259 => new Code(code, "TPMAPI_E_INVALID_OUTPUT_POINTER", "One or more output parameters was null or invalid."),
                260 => new Code(code, "TPMAPI_E_INVALID_PARAMETER", "One or more input parameters are invalid."),
                261 => new Code(code, "TPMAPI_E_OUT_OF_MEMORY", "Not enough memory was available to satisfy the request."),
                262 => new Code(code, "TPMAPI_E_BUFFER_TOO_SMALL", "The specified buffer was too small."),
                263 => new Code(code, "TPMAPI_E_INTERNAL_ERROR", "An internal error was detected."),
                264 => new Code(code, "TPMAPI_E_ACCESS_DENIED", "The caller does not have the appropriate rights to perform the requested operation."),
                265 => new Code(code, "TPMAPI_E_AUTHORIZATION_FAILED", "The specified authorization information was invalid."),
                266 => new Code(code, "TPMAPI_E_INVALID_CONTEXT_HANDLE", "The specified context handle was not valid."),
                267 => new Code(code, "TPMAPI_E_TBS_COMMUNICATION_ERROR", "An error occurred while communicating with the TBS."),
                268 => new Code(code, "TPMAPI_E_TPM_COMMAND_ERROR", "The TPM returned an unexpected result."),
                269 => new Code(code, "TPMAPI_E_MESSAGE_TOO_LARGE", "The message was too large for the encoding scheme."),
                270 => new Code(code, "TPMAPI_E_INVALID_ENCODING", "The encoding in the binary large object (BLOB) was not recognized."),
                271 => new Code(code, "TPMAPI_E_INVALID_KEY_SIZE", "The key size is not valid."),
                272 => new Code(code, "TPMAPI_E_ENCRYPTION_FAILED", "The encryption operation failed."),
                273 => new Code(code, "TPMAPI_E_INVALID_KEY_PARAMS", "The key parameters structure was not valid."),
                274 => new Code(code, "TPMAPI_E_INVALID_MIGRATION_AUTHORIZATION_BLOB", "The requested supplied data does not appear to be a valid migration authorization BLOB."),
                275 => new Code(code, "TPMAPI_E_INVALID_PCR_INDEX", "The specified PCR index was invalid."),
                276 => new Code(code, "TPMAPI_E_INVALID_DELEGATE_BLOB", "The data given does not appear to be a valid delegate BLOB."),
                277 => new Code(code, "TPMAPI_E_INVALID_CONTEXT_PARAMS", "One or more of the specified context parameters was not valid."),
                278 => new Code(code, "TPMAPI_E_INVALID_KEY_BLOB", "The data given does not appear to be a valid key BLOB."),
                279 => new Code(code, "TPMAPI_E_INVALID_PCR_DATA", "The specified PCR data was invalid."),
                280 => new Code(code, "TPMAPI_E_INVALID_OWNER_AUTH", "The format of the owner authorization data was invalid."),
                512 => new Code(code, "TBSIMP_E_BUFFER_TOO_SMALL", "The specified buffer was too small."),
                513 => new Code(code, "TBSIMP_E_CLEANUP_FAILED", "The context could not be cleaned up."),
                514 => new Code(code, "TBSIMP_E_INVALID_CONTEXT_HANDLE", "The specified context handle is invalid."),
                515 => new Code(code, "TBSIMP_E_INVALID_CONTEXT_PARAM", "An invalid context parameter was specified."),
                516 => new Code(code, "TBSIMP_E_TPM_ERROR", "An error occurred while communicating with the TPM."),
                517 => new Code(code, "TBSIMP_E_HASH_BAD_KEY", "No entry with the specified key was found."),
                518 => new Code(code, "TBSIMP_E_DUPLICATE_VHANDLE", "The specified virtual handle matches a virtual handle already in use."),
                519 => new Code(code, "TBSIMP_E_INVALID_OUTPUT_POINTER", "The pointer to the returned handle location was null or invalid."),
                520 => new Code(code, "TBSIMP_E_INVALID_PARAMETER", "One or more parameters are invalid."),
                521 => new Code(code, "TBSIMP_E_RPC_INIT_FAILED", "The RPC subsystem could not be initialized."),
                522 => new Code(code, "TBSIMP_E_SCHEDULER_NOT_RUNNING", "The TBS scheduler is not running."),
                523 => new Code(code, "TBSIMP_E_COMMAND_CANCELED", "The command was canceled."),
                524 => new Code(code, "TBSIMP_E_OUT_OF_MEMORY", "There was not enough memory to fulfill the request."),
                525 => new Code(code, "TBSIMP_E_LIST_NO_MORE_ITEMS", "The specified list is empty, or the iteration has reached the end of the list."),
                526 => new Code(code, "TBSIMP_E_LIST_NOT_FOUND", "The specified item was not found in the list."),
                527 => new Code(code, "TBSIMP_E_NOT_ENOUGH_SPACE", "The TPM does not have enough space to load the requested resource."),
                528 => new Code(code, "TBSIMP_E_NOT_ENOUGH_TPM_CONTEXTS", "There are too many TPM contexts in use."),
                529 => new Code(code, "TBSIMP_E_COMMAND_FAILED", "The TPM command failed."),
                530 => new Code(code, "TBSIMP_E_UNKNOWN_ORDINAL", "The TBS does not recognize the specified ordinal."),
                531 => new Code(code, "TBSIMP_E_RESOURCE_EXPIRED", "The requested resource is no longer available."),
                532 => new Code(code, "TBSIMP_E_INVALID_RESOURCE", "The resource type did not match."),
                533 => new Code(code, "TBSIMP_E_NOTHING_TO_UNLOAD", "No resources can be unloaded."),
                534 => new Code(code, "TBSIMP_E_HASH_TABLE_FULL", "No new entries can be added to the hash table."),
                535 => new Code(code, "TBSIMP_E_TOO_MANY_TBS_CONTEXTS", "A new TBS context could not be created because there are too many open contexts."),
                536 => new Code(code, "TBSIMP_E_TOO_MANY_RESOURCES", "A new virtual resource could not be created because there are too many open virtual resources."),
                537 => new Code(code, "TBSIMP_E_PPI_NOT_SUPPORTED", "The physical presence interface is not supported."),
                538 => new Code(code, "TBSIMP_E_TPM_INCOMPATIBLE", "TBS is not compatible with the version of TPM found on the system."),
                768 => new Code(code, "TPM_E_PPI_ACPI_FAILURE", "A general error was detected when attempting to acquire the BIOS response to a physical presence command."),
                769 => new Code(code, "TPM_E_PPI_USER_ABORT", "The user failed to confirm the TPM operation request."),
                770 => new Code(code, "TPM_E_PPI_BIOS_FAILURE", "The BIOS failure prevented the successful execution of the requested TPM operation (for example, invalid TPM operation request, BIOS communication error with the TPM)."),
                771 => new Code(code, "TPM_E_PPI_NOT_SUPPORTED", "The BIOS does not support the physical presence interface."),
                _ => Unknown(code),
            };
        }
    }
}
