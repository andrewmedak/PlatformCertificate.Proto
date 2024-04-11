using Google.Protobuf.Reflection;
using NUnit.Framework;
using OidsProto;
using PlatformCertificateProto;

namespace PlatformCertificate.ProtoTests {
    public class ProtoConversionTests
    {
        public static readonly string EMPTY = "{}";

        public static readonly string SIMPLE_PLATFORMATTRIBUTECERTIFICATE =
            "{" +
            "   \"tCGCredentialType\": {" +
            "     \"certificateType\": {" +
            "       \"oid\": \"2.23.133.8.2\"" +
            "     }" +
            "   }" +
            "}";

        public static readonly string PLATFORMATTRIBUTECERTIFICATE_A1_TRAITS_PATH = Path.Combine("Resources", "PlatformAttributeCertificate_11r19_A1_w_Traits.json");
        
        [Test]
        public void TestReadEmpty()
        {
            var settings = Google.Protobuf.JsonParser.Settings.Default.WithIgnoreUnknownFields(true);
            var t = new Google.Protobuf.JsonParser(settings).Parse<PlatformAttributeCertificate>(EMPTY);
            Assert.That(t, Is.Not.Null);
        }

        [Test]
        public void TestReadSimplePlatformAttributeCertificate()
        {
            var settings = Google.Protobuf.JsonParser.Settings.Default.WithIgnoreUnknownFields(true);
            var t = new Google.Protobuf.JsonParser(settings).Parse<PlatformAttributeCertificate>(SIMPLE_PLATFORMATTRIBUTECERTIFICATE);
            Assert.That(t.TCGCredentialType, Is.Not.Null);
            Assert.That(t.TCGCredentialType.CertificateType, Is.Not.Null);
            Assert.That(t.TCGCredentialType.CertificateType.Oid, Is.EqualTo("2.23.133.8.2"));
        }

        [Test]
        public void TestReadPlatformAttributeCertificate_1()
        {
            string json = File.ReadAllText(PLATFORMATTRIBUTECERTIFICATE_A1_TRAITS_PATH);
            PlatformAttributeCertificate result = PlatformAttributeCertificate.Parser.WithDiscardUnknownFields(true).ParseJson(json);
            Assert.That(result.TCGCredentialType.CertificateType, Is.Not.Null);
            Assert.That(result.TCGCredentialType.CertificateType.Oid, Is.EqualTo("2.23.133.8.2"));
            Console.WriteLine(result);
        }

        [Test]
        public void TestOids()
        {
            ObjectIdentifier result = OidsUtils.Find(TCG_ADDRESS_NODE.TcgAddressBluetoothmac);
            Console.WriteLine(result);
        }
    }
}