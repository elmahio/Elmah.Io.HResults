using NUnit.Framework;
using System;
using System.Globalization;

namespace Elmah.Io.HResults.Test
{
    public class HResultTest
    {
        [TestCase("FACILITY_CONTROL", "CTL_E_ILLEGALFUNCTIONCALL", -2146828283)]
        public void CanParseFacility(string expectedFacitliy, string expectedCode, int hresult)
        {
            var res = HResult.Parse(hresult);
            Assert.That(res.Facility.IsMatch);
            Assert.That(res.Facility.Name, Is.EqualTo(expectedFacitliy));
            Assert.That(res.Code.IsMatch);
            Assert.That(res.Code.Name, Is.EqualTo(expectedCode));
        }

        [Test]
        public void CanParseKnownUrt()
        {
            var ex = new ApplicationException();
            var res = HResult.Parse(ex.HResult);
            Assert.IsNotNull(res);
            Assert.That(res.Hex, Is.EqualTo("0x80131600"));
            Assert.That(res.IsFailure, Is.True);
            Assert.That(res.Facility, Is.Not.Null);
            Assert.That(res.Facility.Identifier, Is.EqualTo(19));
            Assert.That(res.Facility.Name, Is.EqualTo("FACILITY_URT"));
            Assert.That(res.Facility.IsMatch, Is.True);
            Assert.That(res.Code, Is.Not.Null);
            Assert.That(res.Code.Identifier, Is.EqualTo(5632));
            Assert.That(res.Code.Name, Is.EqualTo("COR_E_APPLICATION"));
            Assert.That(res.Code.IsMatch, Is.True);
        }

        [Test]
        public void CanParseKnownWin32()
        {
            var res = HResult.Parse(-2147024894);
            Assert.IsNotNull(res);
            Assert.That(res.Hex, Is.EqualTo("0x80070002"));
            Assert.That(res.IsFailure, Is.True);
            Assert.That(res.Facility, Is.Not.Null);
            Assert.That(res.Facility.Identifier, Is.EqualTo(7));
            Assert.That(res.Facility.Name, Is.EqualTo("FACILITY_WIN32"));
            Assert.That(res.Facility.IsMatch, Is.True);
            Assert.That(res.Code, Is.Not.Null);
            Assert.That(res.Code.Identifier, Is.EqualTo(2));
            Assert.That(res.Code.Name, Is.EqualTo("ERROR_FILE_NOT_FOUND"));
            Assert.That(res.Code.IsMatch, Is.True);
        }

        [Test]
        public void CanParseUnknown()
        {
            var res = HResult.Parse(-2137124863);
            Assert.IsNotNull(res);
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