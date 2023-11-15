namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityScardResolver : FacilityResolverBase
    {
        public FacilityScardResolver() : base(16, "FACILITY_SCARD")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                1 => new Code(code, "SCARD_F_INTERNAL_ERROR", "An internal consistency check failed."),
                2 => new Code(code, "SCARD_E_CANCELLED", "The action was canceled by an SCardCancel request."),
                3 => new Code(code, "SCARD_E_INVALID_HANDLE", "The supplied handle was invalid."),
                4 => new Code(code, "SCARD_E_INVALID_PARAMETER", "One or more of the supplied parameters could not be properly interpreted."),
                5 => new Code(code, "SCARD_E_INVALID_TARGET", "Registry startup information is missing or invalid."),
                6 => new Code(code, "SCARD_E_NO_MEMORY", "Not enough memory available to complete this command."),
                7 => new Code(code, "SCARD_F_WAITED_TOO_LONG", "An internal consistency timer has expired."),
                8 => new Code(code, "SCARD_E_INSUFFICIENT_BUFFER", "The data buffer to receive returned data is too small for the returned data."),
                9 => new Code(code, "SCARD_E_UNKNOWN_READER", "The specified reader name is not recognized."),
                10 => new Code(code, "SCARD_E_TIMEOUT", "The user-specified time-out value has expired."),
                11 => new Code(code, "SCARD_E_SHARING_VIOLATION", "The smart card cannot be accessed because of other connections outstanding."),
                12 => new Code(code, "SCARD_E_NO_SMARTCARD", "The operation requires a smart card, but no smart card is currently in the device."),
                13 => new Code(code, "SCARD_E_UNKNOWN_CARD", "The specified smart card name is not recognized."),
                14 => new Code(code, "SCARD_E_CANT_DISPOSE", "The system could not dispose of the media in the requested manner."),
                15 => new Code(code, "SCARD_E_PROTO_MISMATCH", "The requested protocols are incompatible with the protocol currently in use with the smart card."),
                16 => new Code(code, "SCARD_E_NOT_READY", "The reader or smart card is not ready to accept commands."),
                17 => new Code(code, "SCARD_E_INVALID_VALUE", "One or more of the supplied parameters values could not be properly interpreted."),
                18 => new Code(code, "SCARD_E_SYSTEM_CANCELLED", "The action was canceled by the system, presumably to log off or shut down."),
                19 => new Code(code, "SCARD_F_COMM_ERROR", "An internal communications error has been detected."),
                20 => new Code(code, "SCARD_F_UNKNOWN_ERROR", "An internal error has been detected, but the source is unknown."),
                21 => new Code(code, "SCARD_E_INVALID_ATR", "An automatic terminal recognition (ATR) obtained from the registry is not a valid ATR string."),
                22 => new Code(code, "SCARD_E_NOT_TRANSACTED", "An attempt was made to end a nonexistent transaction."),
                23 => new Code(code, "SCARD_E_READER_UNAVAILABLE", "The specified reader is not currently available for use."),
                24 => new Code(code, "SCARD_P_SHUTDOWN", "The operation has been aborted to allow the server application to exit."),
                25 => new Code(code, "SCARD_E_PCI_TOO_SMALL", "The peripheral component interconnect (PCI) Receive buffer was too small."),
                26 => new Code(code, "SCARD_E_READER_UNSUPPORTED", "The reader driver does not meet minimal requirements for support."),
                27 => new Code(code, "SCARD_E_DUPLICATE_READER", "The reader driver did not produce a unique reader name."),
                28 => new Code(code, "SCARD_E_CARD_UNSUPPORTED", "The smart card does not meet minimal requirements for support."),
                29 => new Code(code, "SCARD_E_NO_SERVICE", "The smart card resource manager is not running."),
                30 => new Code(code, "SCARD_E_SERVICE_STOPPED", "The smart card resource manager has shut down."),
                31 => new Code(code, "SCARD_E_UNEXPECTED", "An unexpected card error has occurred."),
                32 => new Code(code, "SCARD_E_ICC_INSTALLATION", "No primary provider can be found for the smart card."),
                33 => new Code(code, "SCARD_E_ICC_CREATEORDER", "The requested order of object creation is not supported."),
                34 => new Code(code, "SCARD_E_UNSUPPORTED_FEATURE", "This smart card does not support the requested feature."),
                35 => new Code(code, "SCARD_E_DIR_NOT_FOUND", "The identified directory does not exist in the smart card."),
                36 => new Code(code, "SCARD_E_FILE_NOT_FOUND", "The identified file does not exist in the smart card."),
                37 => new Code(code, "SCARD_E_NO_DIR", "The supplied path does not represent a smart card directory."),
                38 => new Code(code, "SCARD_E_NO_FILE", "The supplied path does not represent a smart card file."),
                39 => new Code(code, "SCARD_E_NO_ACCESS", "Access is denied to this file."),
                40 => new Code(code, "SCARD_E_WRITE_TOO_MANY", "The smart card does not have enough memory to store the information."),
                41 => new Code(code, "SCARD_E_BAD_SEEK", "There was an error trying to set the smart card file object pointer."),
                42 => new Code(code, "SCARD_E_INVALID_CHV", "The supplied PIN is incorrect."),
                43 => new Code(code, "SCARD_E_UNKNOWN_RES_MNG", "An unrecognized error code was returned from a layered component."),
                44 => new Code(code, "SCARD_E_NO_SUCH_CERTIFICATE", "The requested certificate does not exist."),
                45 => new Code(code, "SCARD_E_CERTIFICATE_UNAVAILABLE", "The requested certificate could not be obtained."),
                46 => new Code(code, "SCARD_E_NO_READERS_AVAILABLE", "Cannot find a smart card reader."),
                47 => new Code(code, "SCARD_E_COMM_DATA_LOST", "A communications error with the smart card has been detected. Retry the operation."),
                48 => new Code(code, "SCARD_E_NO_KEY_CONTAINER", "The requested key container does not exist on the smart card."),
                49 => new Code(code, "SCARD_E_SERVER_TOO_BUSY", "The smart card resource manager is too busy to complete this operation."),
                101 => new Code(code, "SCARD_W_UNSUPPORTED_CARD", "The reader cannot communicate with the smart card, due to ATR configuration conflicts."),
                102 => new Code(code, "SCARD_W_UNRESPONSIVE_CARD", "The smart card is not responding to a reset."),
                103 => new Code(code, "SCARD_W_UNPOWERED_CARD", "Power has been removed from the smart card, so that further communication is not possible."),
                104 => new Code(code, "SCARD_W_RESET_CARD", "The smart card has been reset, so any shared state information is invalid."),
                105 => new Code(code, "SCARD_W_REMOVED_CARD", "The smart card has been removed, so that further communication is not possible."),
                106 => new Code(code, "SCARD_W_SECURITY_VIOLATION", "Access was denied because of a security violation."),
                107 => new Code(code, "SCARD_W_WRONG_CHV", "The card cannot be accessed because the wrong PIN was presented."),
                108 => new Code(code, "SCARD_W_CHV_BLOCKED", "The card cannot be accessed because the maximum number of PIN entry attempts has been reached."),
                109 => new Code(code, "SCARD_W_EOF", "The end of the smart card file has been reached."),
                110 => new Code(code, "SCARD_W_CANCELLED_BY_USER", "The action was canceled by the user."),
                111 => new Code(code, "SCARD_W_CARD_NOT_AUTHENTICATED", "No PIN was presented to the smart card."),
                _ => Unknown(code),
            };
        }
    }
}
