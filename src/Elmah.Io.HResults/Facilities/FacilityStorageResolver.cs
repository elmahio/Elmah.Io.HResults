namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityStorageResolver : FacilityResolverBase
    {
        public FacilityStorageResolver() : base(3, "FACILITY_STORAGE")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            if (failure)
            {
                switch (code)
                {
                    case 1: return new Code(code, "STG_E_INVALIDFUNCTION", "Unable to perform requested operation.");
                    case 2: return new Code(code, "STG_E_FILENOTFOUND", "%1 could not be found.");
                    case 3: return new Code(code, "STG_E_PATHNOTFOUND", "The path %1 could not be found.");
                    case 4: return new Code(code, "STG_E_TOOMANYOPENFILES", "There are insufficient resources to open another file.");
                    case 5: return new Code(code, "STG_E_ACCESSDENIED", "Access denied.");
                    case 6: return new Code(code, "STG_E_INVALIDHANDLE", "Attempted an operation on an invalid object.");
                    case 8: return new Code(code, "STG_E_INSUFFICIENTMEMORY", "There is insufficient memory available to complete operation.");
                    case 9: return new Code(code, "STG_E_INVALIDPOINTER", "Invalid pointer error.");
                    case 18: return new Code(code, "STG_E_NOMOREFILES", "There are no more entries to return.");
                    case 19: return new Code(code, "STG_E_DISKISWRITEPROTECTED", "Disk is write-protected.");
                    case 25: return new Code(code, "STG_E_SEEKERROR", "An error occurred during a seek operation.");
                    case 29: return new Code(code, "STG_E_WRITEFAULT", "A disk error occurred during a write operation.");
                    case 30: return new Code(code, "STG_E_READFAULT", "A disk error occurred during a read operation.");
                    case 32: return new Code(code, "STG_E_SHAREVIOLATION", "A share violation has occurred.");
                    case 33: return new Code(code, "STG_E_LOCKVIOLATION", "A lock violation has occurred.");
                    case 80: return new Code(code, "STG_E_FILEALREADYEXISTS", "%1 already exists.");
                    case 87: return new Code(code, "STG_E_INVALIDPARAMETER", "Invalid parameter error.");
                    case 112: return new Code(code, "STG_E_MEDIUMFULL", "There is insufficient disk space to complete operation.");
                    case 240: return new Code(code, "STG_E_PROPSETMISMATCHED", "Illegal write of non-simple property to simple property set.");
                    case 250: return new Code(code, "STG_E_ABNORMALAPIEXIT", "An application programming interface (API) call exited abnormally.");
                    case 251: return new Code(code, "STG_E_INVALIDHEADER", "The file %1 is not a valid compound file.");
                    case 252: return new Code(code, "STG_E_INVALIDNAME", "The name %1 is not valid.");
                    case 253: return new Code(code, "STG_E_UNKNOWN", "An unexpected error occurred.");
                    case 254: return new Code(code, "STG_E_UNIMPLEMENTEDFUNCTION", "That function is not implemented.");
                    case 255: return new Code(code, "STG_E_INVALIDFLAG", "Invalid flag error.");
                    case 256: return new Code(code, "STG_E_INUSE", "Attempted to use an object that is busy.");
                    case 257: return new Code(code, "STG_E_NOTCURRENT", "The storage has been changed since the last commit.");
                    case 258: return new Code(code, "STG_E_REVERTED", "Attempted to use an object that has ceased to exist.");
                    case 259: return new Code(code, "STG_E_CANTSAVE", "Cannot save.");
                    case 260: return new Code(code, "STG_E_OLDFORMAT", "The compound file %1 was produced with an incompatible version of storage.");
                    case 261: return new Code(code, "STG_E_OLDDLL", "The compound file %1 was produced with a newer version of storage.");
                    case 262: return new Code(code, "STG_E_SHAREREQUIRED", "Share.exe or equivalent is required for operation.");
                    case 263: return new Code(code, "STG_E_NOTFILEBASEDSTORAGE", "Illegal operation called on non-file based storage.");
                    case 264: return new Code(code, "STG_E_EXTANTMARSHALLINGS", "Illegal operation called on object with extant marshalings.");
                    case 265: return new Code(code, "STG_E_DOCFILECORRUPT", "The docfile has been corrupted.");
                    case 272: return new Code(code, "STG_E_BADBASEADDRESS", "OLE32.DLL has been loaded at the wrong address.");
                    case 273: return new Code(code, "STG_E_DOCFILETOOLARGE", "The compound file is too large for the current implementation.");
                    case 274: return new Code(code, "STG_E_NOTSIMPLEFORMAT", "The compound file was not created with the STGM_SIMPLE flag.");
                    case 513: return new Code(code, "STG_E_INCOMPLETE", "The file download was aborted abnormally. The file is incomplete.");
                    case 514: return new Code(code, "STG_E_TERMINATED", "The file download has been terminated.");
                    case 773: return new Code(code, "STG_E_STATUS_COPY_PROTECTION_FAILURE", "Generic Copy Protection Error.");
                    case 774: return new Code(code, "STG_E_CSS_AUTHENTICATION_FAILURE", "Copy Protection Error—DVD CSS Authentication failed.");
                    case 775: return new Code(code, "STG_E_CSS_KEY_NOT_PRESENT", "Copy Protection Error—The given sector does not have a valid CSS key.");
                    case 776: return new Code(code, "STG_E_CSS_KEY_NOT_ESTABLISHED", "Copy Protection Error—DVD session key not established.");
                    case 777: return new Code(code, "STG_E_CSS_SCRAMBLED_SECTOR", "Copy Protection Error—The read failed because the sector is encrypted.");
                    case 778: return new Code(code, "STG_E_CSS_REGION_MISMATCH", "Copy Protection Error—The current DVD's region does not correspond to the region setting of the drive.");
                    case 779: return new Code(code, "STG_E_RESETS_EXHAUSTED", "Copy Protection Error—The drive's region setting might be permanent or the number of user resets has been exhausted.");
                }
            }
            else
            {
                switch (code)
                {
                    case 512: return new Code(code, "STG_S_CONVERTED", "The underlying file was converted to compound file format.");
                    case 513: return new Code(code, "STG_S_BLOCK", "The storage operation should block until more data is available.");
                    case 514: return new Code(code, "STG_S_RETRYNOW", "The storage operation should retry immediately.");
                    case 515: return new Code(code, "STG_S_MONITORING", "The notified event sink will not influence the storage operation.");
                    case 516: return new Code(code, "STG_S_MULTIPLEOPENS", "Multiple opens prevent consolidated (commit succeeded).");
                    case 517: return new Code(code, "STG_S_CONSOLIDATIONFAILED", "Consolidation of the storage file failed (commit succeeded).");
                    case 518: return new Code(code, "STG_S_CANNOTCONSOLIDATE", "Consolidation of the storage file is inappropriate (commit succeeded).");
                }
            }

            return Unknown(code);
        }
    }
}
