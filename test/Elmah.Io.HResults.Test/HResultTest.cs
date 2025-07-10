using NUnit.Framework;
using System.Globalization;

namespace Elmah.Io.HResults.Test
{
    public class HResultTest
    {
        [TestCase(-2003303418, "0x88980406", 2200, "FACILITY_WINCODEC_DWRITE_DWM", 1030, "UCEERR_RENDERTHREADFAILURE")]
        [TestCase(-2147024894, "0x80070002", 7, "FACILITY_WIN32", 2, "ERROR_FILE_NOT_FOUND")]
        [TestCase(-2146232832, "0x80131600", 19, "FACILITY_URT", 5632, "COR_E_APPLICATION")]
        [TestCase(-2146828283, "0x800A0005", 10, "FACILITY_CONTROL", 5, "CTL_E_ILLEGALFUNCTIONCALL")]
        [TestCase(-1072896680, "0xC00CE558", 12, "FACILITY_INTERNET", 58712, "XML_E_MISSINGROOT")]
        [TestCase(-2145067009, "0x8024DFFF", 36, "FACILITY_WINDOWSUPDATE", 57343, "WU_E_SETUP_UNEXPECTED")]
        [TestCase(-2147024534, "0x8007016A", 7, "FACILITY_WIN32", 362, "ERROR_CLOUD_FILE_PROVIDER_NOT_RUNNING")]
        public void CanParseKnownFailure(int hresult, string expectedHex, int expectedFacilityCode, string expectedFacilityName, int expectedCode, string expectedName)
        {
            var res = HResult.Parse(hresult);
            AssertHResult(expectedHex, true, expectedFacilityCode, expectedFacilityName, expectedCode, expectedName, res);
        }

        [TestCase(2359297, "0x00240001", 36, "FACILITY_WINDOWSUPDATE", 1, "WU_S_SERVICE_STOP")]
        public void CanParseKnownSuccess(int hresult, string expectedHex, int expectedFacilityCode, string expectedFacilityName, int expectedCode, string expectedName)
        {
            var res = HResult.Parse(hresult);
            AssertHResult(expectedHex, false, expectedFacilityCode, expectedFacilityName, expectedCode, expectedName, res);
        }

        private static void AssertHResult(string expectedHex, bool expectedIsFailure, int expectedFacilityCode, string expectedFacilityName, int expectedCode, string expectedName, HResult res)
        {
            Assert.That(res, Is.Not.Null);
            Assert.That(res.Hex, Is.EqualTo(expectedHex));
            Assert.That(res.IsFailure, Is.EqualTo(expectedIsFailure));
            Assert.That(res.Facility, Is.Not.Null);
            Assert.That(res.Facility.Identifier, Is.EqualTo(expectedFacilityCode));
            Assert.That(res.Facility.Name, Is.EqualTo(expectedFacilityName));
            Assert.That(res.Facility.IsMatch, Is.True);
            Assert.That(res.Code, Is.Not.Null);
            Assert.That(res.Code.Identifier, Is.EqualTo(expectedCode));
            Assert.That(res.Code.Name, Is.EqualTo(expectedName));
            Assert.That(res.Code.IsMatch, Is.True);
        }

        [Test]
        public void CanParseUnknown()
        {
            var res = HResult.Parse(-2137124863);
            Assert.That(res, Is.Not.Null);
            Assert.That(res.Hex, Is.EqualTo("0x809E1001"));
            Assert.That(res.IsFailure, Is.True);
            Assert.That(res.Facility, Is.Not.Null);
            Assert.That(res.Facility.Identifier, Is.EqualTo(158));
            Assert.That(res.Facility.Name, Is.EqualTo("158"));
            Assert.That(res.Facility.IsMatch, Is.False);
            Assert.That(res.Code, Is.Not.Null);
            Assert.That(res.Code.Identifier, Is.EqualTo(4097));
            Assert.That(res.Code.Name, Is.EqualTo("4097"));
            Assert.That(res.Code.IsMatch, Is.False);
        }

        [Test]
        public void CanParseSuccess()
        {
            var p = int.Parse("00040000", NumberStyles.HexNumber);
            var res = HResult.Parse(p);
            Assert.That(res.IsFailure, Is.False);
        }
    }
}