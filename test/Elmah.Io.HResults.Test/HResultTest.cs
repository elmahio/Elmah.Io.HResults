using NUnit.Framework;
using System;

namespace Elmah.Io.HResults.Test
{
    public class HResultTest
    {
        [Test]
        public void CanParseKnown()
        {
            var ex = new ApplicationException();
            var res = HResult.Parse(ex.HResult);
            Assert.IsNotNull(res);
            Assert.That(res.Hex, Is.EqualTo("0x80131600"));
            Assert.That(res.IsFailure, Is.True);
            Assert.That(res.Facility, Is.EqualTo("FACILITY_URT"));
            Assert.That(res.ErrorCode, Is.EqualTo("COR_E_APPLICATION"));
        }

        [Test]
        public void CanParseUnknown()
        {
            var res = HResult.Parse(-2147467259);
            Assert.IsNotNull(res);
            Assert.That(res.Hex, Is.EqualTo("0x80004005"));
            Assert.That(res.IsFailure, Is.True);
            Assert.That(res.Facility, Is.EqualTo("FACILITY_NULL"));
            Assert.That(res.ErrorCode, Is.EqualTo("16389"));
        }
    }
}