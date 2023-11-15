namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityCertResolver : FacilityResolverBase
    {
        public FacilityCertResolver() : base(11, "FACILITY_CERT")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            return code switch
            {
                1 => new Code(code, "TRUST_E_PROVIDER_UNKNOWN", "Unknown trust provider."),
                2 => new Code(code, "TRUST_E_ACTION_UNKNOWN", "The trust verification action specified is not supported by the specified trust provider."),
                3 => new Code(code, "TRUST_E_SUBJECT_FORM_UNKNOWN", "The form specified for the subject is not one supported or known by the specified trust provider."),
                4 => new Code(code, "TRUST_E_SUBJECT_NOT_TRUSTED", "The subject is not trusted for the specified action."),
                5 => new Code(code, "DIGSIG_E_ENCODE", "Error due to problem in ASN.1 encoding process."),
                6 => new Code(code, "DIGSIG_E_DECODE", "Error due to problem in ASN.1 decoding process."),
                7 => new Code(code, "DIGSIG_E_EXTENSIBILITY", "Reading/writing extensions where attributes are appropriate, and vice versa."),
                8 => new Code(code, "DIGSIG_E_CRYPTO", "Unspecified cryptographic failure."),
                9 => new Code(code, "PERSIST_E_SIZEDEFINITE", "The size of the data could not be determined."),
                10 => new Code(code, "PERSIST_E_SIZEINDEFINITE", "The size of the indefinite-sized data could not be determined."),
                11 => new Code(code, "PERSIST_E_NOTSELFSIZING", "This object does not read and write self-sizing data."),
                256 => new Code(code, "TRUST_E_NOSIGNATURE", "No signature was present in the subject."),
                257 => new Code(code, "CERT_E_EXPIRED", "A required certificate is not within its validity period when verifying against the current system clock or the time stamp in the signed file."),
                258 => new Code(code, "CERT_E_VALIDITYPERIODNESTING", "The validity periods of the certification chain do not nest correctly."),
                259 => new Code(code, "CERT_E_ROLE", "A certificate that can only be used as an end entity is being used as a CA or vice versa."),
                260 => new Code(code, "CERT_E_PATHLENCONST", "A path length constraint in the certification chain has been violated."),
                261 => new Code(code, "CERT_E_CRITICAL", "A certificate contains an unknown extension that is marked \"critical\"."),
                262 => new Code(code, "CERT_E_PURPOSE", "A certificate is being used for a purpose other than the ones specified by its CA."),
                263 => new Code(code, "CERT_E_ISSUERCHAINING", "A parent of a given certificate did not issue that child certificate."),
                264 => new Code(code, "CERT_E_MALFORMED", "A certificate is missing or has an empty value for an important field, such as a subject or issuer name."),
                265 => new Code(code, "CERT_E_UNTRUSTEDROOT", "A certificate chain processed, but terminated in a root certificate that is not trusted by the trust provider."),
                266 => new Code(code, "CERT_E_CHAINING", "A certificate chain could not be built to a trusted root authority."),
                267 => new Code(code, "TRUST_E_FAIL", "Generic trust failure."),
                268 => new Code(code, "CERT_E_REVOKED", "A certificate was explicitly revoked by its issuer. If the certificate is Microsoft Windows PCA 2010, then the driver was signed by a certificate no longer recognized by Windows.<3>"),
                269 => new Code(code, "CERT_E_UNTRUSTEDTESTROOT", "The certification path terminates with the test root that is not trusted with the current policy settings."),
                270 => new Code(code, "CERT_E_REVOCATION_FAILURE", "The revocation process could not continue—the certificates could not be checked."),
                271 => new Code(code, "CERT_E_CN_NO_MATCH", "The certificate's CN name does not match the passed value."),
                272 => new Code(code, "CERT_E_WRONG_USAGE", "The certificate is not valid for the requested usage."),
                273 => new Code(code, "TRUST_E_EXPLICIT_DISTRUST", "The certificate was explicitly marked as untrusted by the user."),
                274 => new Code(code, "CERT_E_UNTRUSTEDCA", "A certification chain processed correctly, but one of the CA certificates is not trusted by the policy provider."),
                275 => new Code(code, "CERT_E_INVALID_POLICY", "The certificate has invalid policy."),
                276 => new Code(code, "CERT_E_INVALID_NAME", "The certificate has an invalid name. The name is not included in the permitted list or is explicitly excluded."),
                _ => Unknown(code),
            };
        }
    }
}
