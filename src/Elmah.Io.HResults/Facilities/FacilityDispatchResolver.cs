namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityDispatchResolver : FacilityResolverBase
    {
        public FacilityDispatchResolver() : base(2, "FACILITY_DISPATCH")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                1 => new Code(code, "DISP_E_UNKNOWNINTERFACE", "Unknown interface."),
                3 => new Code(code, "DISP_E_MEMBERNOTFOUND", "Member not found."),
                4 => new Code(code, "DISP_E_PARAMNOTFOUND", "Parameter not found."),
                5 => new Code(code, "DISP_E_TYPEMISMATCH", "Type mismatch."),
                6 => new Code(code, "DISP_E_UNKNOWNNAME", "Unknown name."),
                7 => new Code(code, "DISP_E_NONAMEDARGS", "No named arguments."),
                8 => new Code(code, "DISP_E_BADVARTYPE", "Bad variable type."),
                9 => new Code(code, "DISP_E_EXCEPTION", "Exception occurred."),
                10 => new Code(code, "DISP_E_OVERFLOW", "Out of present range."),
                11 => new Code(code, "DISP_E_BADINDEX", "Invalid index."),
                12 => new Code(code, "DISP_E_UNKNOWNLCID", "Unknown language."),
                13 => new Code(code, "DISP_E_ARRAYISLOCKED", "Memory is locked."),
                14 => new Code(code, "DISP_E_BADPARAMCOUNT", "Invalid number of parameters."),
                15 => new Code(code, "DISP_E_PARAMNOTOPTIONAL", "Parameter not optional."),
                16 => new Code(code, "DISP_E_BADCALLEE", "Invalid callee."),
                17 => new Code(code, "DISP_E_NOTACOLLECTION", "Does not support a collection."),
                18 => new Code(code, "DISP_E_DIVBYZERO", "Division by zero."),
                19 => new Code(code, "DISP_E_BUFFERTOOSMALL", "Buffer too small."),
                32790 => new Code(code, "TYPE_E_BUFFERTOOSMALL", "Buffer too small."),
                32791 => new Code(code, "TYPE_E_FIELDNOTFOUND", "Field name not defined in the record."),
                32792 => new Code(code, "TYPE_E_INVDATAREAD", "Old format or invalid type library."),
                32793 => new Code(code, "TYPE_E_UNSUPFORMAT", "Old format or invalid type library."),
                32796 => new Code(code, "TYPE_E_REGISTRYACCESS", "Error accessing the OLE registry."),
                32797 => new Code(code, "TYPE_E_LIBNOTREGISTERED", "Library not registered."),
                32807 => new Code(code, "TYPE_E_UNDEFINEDTYPE", "Bound to unknown type."),
                32808 => new Code(code, "TYPE_E_QUALIFIEDNAMEDISALLOWED", "Qualified name disallowed."),
                32809 => new Code(code, "TYPE_E_INVALIDSTATE", "Invalid forward reference, or reference to uncompiled type."),
                32810 => new Code(code, "TYPE_E_WRONGTYPEKIND", "Type mismatch."),
                32811 => new Code(code, "TYPE_E_ELEMENTNOTFOUND", "Element not found."),
                32812 => new Code(code, "TYPE_E_AMBIGUOUSNAME", "Ambiguous name."),
                32813 => new Code(code, "TYPE_E_NAMECONFLICT", "Name already exists in the library."),
                32814 => new Code(code, "TYPE_E_UNKNOWNLCID", "Unknown language code identifier (LCID)."),
                32815 => new Code(code, "TYPE_E_DLLFUNCTIONNOTFOUND", "Function not defined in specified DLL."),
                35005 => new Code(code, "TYPE_E_BADMODULEKIND", "Wrong module kind for the operation."),
                35013 => new Code(code, "TYPE_E_SIZETOOBIG", "Size cannot exceed 64 KB."),
                35014 => new Code(code, "TYPE_E_DUPLICATEID", "Duplicate ID in inheritance hierarchy."),
                35023 => new Code(code, "TYPE_E_INVALIDID", "Incorrect inheritance depth in standard OLE hmember."),
                36000 => new Code(code, "TYPE_E_TYPEMISMATCH", "Type mismatch."),
                36001 => new Code(code, "TYPE_E_OUTOFBOUNDS", "Invalid number of arguments."),
                36002 => new Code(code, "TYPE_E_IOERROR", "I/O error."),
                36003 => new Code(code, "TYPE_E_CANTCREATETMPFILE", "Error creating unique .tmp file."),
                40010 => new Code(code, "TYPE_E_CANTLOADLIBRARY", "Error loading type library or DLL."),
                40067 => new Code(code, "TYPE_E_INCONSISTENTPROPFUNCS", "Inconsistent property functions."),
                40068 => new Code(code, "TYPE_E_CIRCULARTYPE", "Circular dependency between types and modules."),
                _ => Unknown(code),
            };
        }
    }
}
