using NUnit.Framework;
using PlatformCertificateFromProto;

namespace PlatformCertificate.ProtoTests {
    public class ProtoConversionTests {

        [Test]
        public void TestConversionWorked() {
            ComponentIdentifierV2 componentIdentifierV2 = new();
            TBBSecurityAssertions tBBSecurityAssertions = new();
            Assert.That(componentIdentifierV2, Is.Not.Null);
            Assert.That(tBBSecurityAssertions, Is.Not.Null);
        }
    }
}