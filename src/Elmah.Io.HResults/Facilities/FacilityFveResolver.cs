namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityFveResolver : FacilityResolverBase
    {
        public FacilityFveResolver() : base(49, "FACILITY_FVE")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                0 => new Code(code, "FVE_E_LOCKED_VOLUME", "The volume must be unlocked before it can be used."),
                1 => new Code(code, "FVE_E_NOT_ENCRYPTED", "The volume is fully decrypted and no key is available."),
                2 => new Code(code, "FVE_E_NO_TPM_BIOS", "The firmware does not support using a TPM during boot."),
                3 => new Code(code, "FVE_E_NO_MBR_METRIC", "The firmware does not use a TPM to perform initial program load (IPL) measurement."),
                4 => new Code(code, "FVE_E_NO_BOOTSECTOR_METRIC", "The master boot record (MBR) is not TPM-aware."),
                5 => new Code(code, "FVE_E_NO_BOOTMGR_METRIC", "The BOOTMGR is not being measured by the TPM."),
                6 => new Code(code, "FVE_E_WRONG_BOOTMGR", "The BOOTMGR component does not perform expected TPM measurements."),
                7 => new Code(code, "FVE_E_SECURE_KEY_REQUIRED", "No secure key protection mechanism has been defined."),
                8 => new Code(code, "FVE_E_NOT_ACTIVATED", "This volume has not been provisioned for encryption."),
                9 => new Code(code, "FVE_E_ACTION_NOT_ALLOWED", "Requested action was denied by the full-volume encryption (FVE) control engine."),
                10 => new Code(code, "FVE_E_AD_SCHEMA_NOT_INSTALLED", "The Active Directory forest does not contain the required attributes and classes to host FVE or TPM information."),
                11 => new Code(code, "FVE_E_AD_INVALID_DATATYPE", "The type of data obtained from Active Directory was not expected."),
                12 => new Code(code, "FVE_E_AD_INVALID_DATASIZE", "The size of the data obtained from Active Directory was not expected."),
                13 => new Code(code, "FVE_E_AD_NO_VALUES", "The attribute read from Active Directory has no (zero) values."),
                14 => new Code(code, "FVE_E_AD_ATTR_NOT_SET", "The attribute was not set."),
                15 => new Code(code, "FVE_E_AD_GUID_NOT_FOUND", "The specified GUID could not be found."),
                16 => new Code(code, "FVE_E_BAD_INFORMATION", "The control block for the encrypted volume is not valid."),
                17 => new Code(code, "FVE_E_TOO_SMALL", "Not enough free space remaining on volume to allow encryption."),
                18 => new Code(code, "FVE_E_SYSTEM_VOLUME", "The volume cannot be encrypted because it is required to boot the operating system."),
                19 => new Code(code, "FVE_E_FAILED_WRONG_FS", "The volume cannot be encrypted because the file system is not supported."),
                20 => new Code(code, "FVE_E_FAILED_BAD_FS", "The file system is inconsistent. Run CHKDSK."),
                21 => new Code(code, "FVE_E_NOT_SUPPORTED", "This volume cannot be encrypted."),
                22 => new Code(code, "FVE_E_BAD_DATA", "Data supplied is malformed."),
                23 => new Code(code, "FVE_E_VOLUME_NOT_BOUND", "Volume is not bound to the system."),
                24 => new Code(code, "FVE_E_TPM_NOT_OWNED", "TPM must be owned before a volume can be bound to it."),
                25 => new Code(code, "FVE_E_NOT_DATA_VOLUME", "The volume specified is not a data volume."),
                26 => new Code(code, "FVE_E_AD_INSUFFICIENT_BUFFER", "The buffer supplied to a function was insufficient to contain the returned data."),
                27 => new Code(code, "FVE_E_CONV_READ", "A read operation failed while converting the volume."),
                28 => new Code(code, "FVE_E_CONV_WRITE", "A write operation failed while converting the volume."),
                29 => new Code(code, "FVE_E_KEY_REQUIRED", "One or more key protection mechanisms are required for this volume."),
                30 => new Code(code, "FVE_E_CLUSTERING_NOT_SUPPORTED", "Cluster configurations are not supported."),
                31 => new Code(code, "FVE_E_VOLUME_BOUND_ALREADY", "The volume is already bound to the system."),
                32 => new Code(code, "FVE_E_OS_NOT_PROTECTED", "The boot OS volume is not being protected via FVE."),
                33 => new Code(code, "FVE_E_PROTECTION_DISABLED", "All protection mechanisms are effectively disabled (clear key exists)."),
                34 => new Code(code, "FVE_E_RECOVERY_KEY_REQUIRED", "A recovery key protection mechanism is required."),
                35 => new Code(code, "FVE_E_FOREIGN_VOLUME", "This volume cannot be bound to a TPM."),
                36 => new Code(code, "FVE_E_OVERLAPPED_UPDATE", "The control block for the encrypted volume was updated by another thread. Try again."),
                37 => new Code(code, "FVE_E_TPM_SRK_AUTH_NOT_ZERO", "The SRK authentication of the TPM is not zero and, therefore, is not compatible."),
                38 => new Code(code, "FVE_E_FAILED_SECTOR_SIZE", "The volume encryption algorithm cannot be used on this sector size."),
                39 => new Code(code, "FVE_E_FAILED_AUTHENTICATION", "BitLocker recovery authentication failed."),
                40 => new Code(code, "FVE_E_NOT_OS_VOLUME", "The volume specified is not the boot OS volume."),
                41 => new Code(code, "FVE_E_AUTOUNLOCK_ENABLED", "Auto-unlock information for data volumes is present on the boot OS volume."),
                42 => new Code(code, "FVE_E_WRONG_BOOTSECTOR", "The system partition boot sector does not perform TPM measurements."),
                43 => new Code(code, "FVE_E_WRONG_SYSTEM_FS", "The system partition file system must be NTFS."),
                44 => new Code(code, "FVE_E_POLICY_PASSWORD_REQUIRED", "Group policy requires a recovery password before encryption can begin."),
                45 => new Code(code, "FVE_E_CANNOT_SET_FVEK_ENCRYPTED", "The volume encryption algorithm and key cannot be set on an encrypted volume."),
                46 => new Code(code, "FVE_E_CANNOT_ENCRYPT_NO_KEY", "A key must be specified before encryption can begin."),
                48 => new Code(code, "FVE_E_BOOTABLE_CDDVD", "A bootable CD/DVD is in the system. Remove the CD/DVD and reboot the system."),
                49 => new Code(code, "FVE_E_PROTECTOR_EXISTS", "An instance of this key protector already exists on the volume."),
                50 => new Code(code, "FVE_E_RELATIVE_PATH", "The file cannot be saved to a relative path."),
                _ => Unknown(code),
            };
        }
    }
}
