namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityFwpResolver : FacilityResolverBase
    {
        public FacilityFwpResolver() : base(50, "FACILITY_FWP")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                1 => new Code(code, "FWP_E_CALLOUT_NOT_FOUND", "The callout does not exist."),
                2 => new Code(code, "FWP_E_CONDITION_NOT_FOUND", "The filter condition does not exist."),
                3 => new Code(code, "FWP_E_FILTER_NOT_FOUND", "The filter does not exist."),
                4 => new Code(code, "FWP_E_LAYER_NOT_FOUND", "The layer does not exist."),
                5 => new Code(code, "FWP_E_PROVIDER_NOT_FOUND", "The provider does not exist."),
                6 => new Code(code, "FWP_E_PROVIDER_CONTEXT_NOT_FOUND", "The provider context does not exist."),
                7 => new Code(code, "FWP_E_SUBLAYER_NOT_FOUND", "The sublayer does not exist."),
                8 => new Code(code, "FWP_E_NOT_FOUND", "The object does not exist."),
                9 => new Code(code, "FWP_E_ALREADY_EXISTS", "An object with that GUID or LUID already exists."),
                10 => new Code(code, "FWP_E_IN_USE", "The object is referenced by other objects and, therefore, cannot be deleted."),
                11 => new Code(code, "FWP_E_DYNAMIC_SESSION_IN_PROGRESS", "The call is not allowed from within a dynamic session."),
                12 => new Code(code, "FWP_E_WRONG_SESSION", "The call was made from the wrong session and, therefore, cannot be completed."),
                13 => new Code(code, "FWP_E_NO_TXN_IN_PROGRESS", "The call must be made from within an explicit transaction."),
                14 => new Code(code, "FWP_E_TXN_IN_PROGRESS", "The call is not allowed from within an explicit transaction."),
                15 => new Code(code, "FWP_E_TXN_ABORTED", "The explicit transaction has been forcibly canceled."),
                16 => new Code(code, "FWP_E_SESSION_ABORTED", "The session has been canceled."),
                17 => new Code(code, "FWP_E_INCOMPATIBLE_TXN", "The call is not allowed from within a read-only transaction."),
                18 => new Code(code, "FWP_E_TIMEOUT", "The call timed out while waiting to acquire the transaction lock."),
                19 => new Code(code, "FWP_E_NET_EVENTS_DISABLED", "Collection of network diagnostic events is disabled."),
                20 => new Code(code, "FWP_E_INCOMPATIBLE_LAYER", "The operation is not supported by the specified layer."),
                21 => new Code(code, "FWP_E_KM_CLIENTS_ONLY", "The call is allowed for kernel-mode callers only."),
                22 => new Code(code, "FWP_E_LIFETIME_MISMATCH", "The call tried to associate two objects with incompatible lifetimes."),
                23 => new Code(code, "FWP_E_BUILTIN_OBJECT", "The object is built in and, therefore, cannot be deleted."),
                24 => new Code(code, "FWP_E_TOO_MANY_BOOTTIME_FILTERS", "The maximum number of boot-time filters has been reached."),
                25 => new Code(code, "FWP_E_NOTIFICATION_DROPPED", "A notification could not be delivered because a message queue is at its maximum capacity."),
                26 => new Code(code, "FWP_E_TRAFFIC_MISMATCH", "The traffic parameters do not match those for the security association context."),
                27 => new Code(code, "FWP_E_INCOMPATIBLE_SA_STATE", "The call is not allowed for the current security association state."),
                28 => new Code(code, "FWP_E_NULL_POINTER", "A required pointer is null."),
                29 => new Code(code, "FWP_E_INVALID_ENUMERATOR", "An enumerator is not valid."),
                30 => new Code(code, "FWP_E_INVALID_FLAGS", "The flags field contains an invalid value."),
                31 => new Code(code, "FWP_E_INVALID_NET_MASK", "A network mask is not valid."),
                32 => new Code(code, "FWP_E_INVALID_RANGE", "An FWP_RANGE is not valid."),
                33 => new Code(code, "FWP_E_INVALID_INTERVAL", "The time interval is not valid."),
                34 => new Code(code, "FWP_E_ZERO_LENGTH_ARRAY", "An array that must contain at least one element that is zero-length."),
                35 => new Code(code, "FWP_E_NULL_DISPLAY_NAME", "The displayData.name field cannot be null."),
                36 => new Code(code, "FWP_E_INVALID_ACTION_TYPE", "The action type is not one of the allowed action types for a filter."),
                37 => new Code(code, "FWP_E_INVALID_WEIGHT", "The filter weight is not valid."),
                38 => new Code(code, "FWP_E_MATCH_TYPE_MISMATCH", "A filter condition contains a match type that is not compatible with the operands."),
                39 => new Code(code, "FWP_E_TYPE_MISMATCH", "An FWP_VALUE or FWPM_CONDITION_VALUE is of the wrong type."),
                40 => new Code(code, "FWP_E_OUT_OF_BOUNDS", "An integer value is outside the allowed range."),
                41 => new Code(code, "FWP_E_RESERVED", "A reserved field is nonzero."),
                42 => new Code(code, "FWP_E_DUPLICATE_CONDITION", "A filter cannot contain multiple conditions operating on a single field."),
                43 => new Code(code, "FWP_E_DUPLICATE_KEYMOD", "A policy cannot contain the same keying module more than once."),
                44 => new Code(code, "FWP_E_ACTION_INCOMPATIBLE_WITH_LAYER", "The action type is not compatible with the layer."),
                45 => new Code(code, "FWP_E_ACTION_INCOMPATIBLE_WITH_SUBLAYER", "The action type is not compatible with the sublayer."),
                46 => new Code(code, "FWP_E_CONTEXT_INCOMPATIBLE_WITH_LAYER", "The raw context or the provider context is not compatible with the layer."),
                47 => new Code(code, "FWP_E_CONTEXT_INCOMPATIBLE_WITH_CALLOUT", "The raw context or the provider context is not compatible with the callout."),
                48 => new Code(code, "FWP_E_INCOMPATIBLE_AUTH_METHOD", "The authentication method is not compatible with the policy type."),
                49 => new Code(code, "FWP_E_INCOMPATIBLE_DH_GROUP", "The Diffie-Hellman group is not compatible with the policy type."),
                50 => new Code(code, "FWP_E_EM_NOT_SUPPORTED", "An Internet Key Exchange (IKE) policy cannot contain an Extended Mode policy."),
                51 => new Code(code, "FWP_E_NEVER_MATCH", "The enumeration template or subscription will never match any objects."),
                52 => new Code(code, "FWP_E_PROVIDER_CONTEXT_MISMATCH", "The provider context is of the wrong type."),
                53 => new Code(code, "FWP_E_INVALID_PARAMETER", "The parameter is incorrect."),
                54 => new Code(code, "FWP_E_TOO_MANY_SUBLAYERS", "The maximum number of sublayers has been reached."),
                55 => new Code(code, "FWP_E_CALLOUT_NOTIFICATION_FAILED", "The notification function for a callout returned an error."),
                56 => new Code(code, "FWP_E_INCOMPATIBLE_AUTH_CONFIG", "The IPsec authentication configuration is not compatible with the authentication type."),
                57 => new Code(code, "FWP_E_INCOMPATIBLE_CIPHER_CONFIG", "The IPsec cipher configuration is not compatible with the cipher type."),
                _ => Unknown(code),
            };
        }
    }
}
