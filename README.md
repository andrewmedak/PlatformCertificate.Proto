This lightweight library attempts to capture sequences from the TCG Platform Certificate 2.0 Information Model into Google's Protobuf format. Those protobuf messages are compiled as C# Objects and made available by referencing this package in a project.  

The library is available via Nuget https://www.nuget.org/packages/PlatformCertificate.Proto for inclusion into .NET projects.

The [proto source files are available on GitHub](https://github.com/andrewmedak/PlatformCertificate.Proto/blob/main/PlatformCertificate.Proto/Resources/) and can be compiled into any language supported by Protobuf.

They are also available in a follow-on Nuget package: https://www.nuget.org/packages/PlatformCertificate.Proto.ProtoFiles. This ProtoFiles package will allow others to import the original protobuf files into subsequent projects. 


#### Usage
Reference this library in your .NET project. Then you can use the objects.
```
using PlatformCertificateFromProto;

namespace YourNamespace {
    public class YourClass {
	    public void YourMethod {
			ComponentIdentifierTrait trait = new();
			...
			trait.ToString();  // Each object can be serialized to JSON
		}
	}
}
```

Read information from a JSON file:
```
using PlatformCertificateFromProto;

namespace YourNamespace {
    public class YourClass {
	    public void YourMethod {
			string json = File.ReadAllText(PLATFORMATTRIBUTECERTIFICATE_A1_TRAITS_PATH);
			PlatformAttributeCertificate result = PlatformAttributeCertificate.Parser.WithDiscardUnknownFields(true).ParseJson(json);
			...
		}
	}
}
```

Oids.proto is a reference for many Oids, and the full OID can be queried and returned as a string.
```
using OidsProto;
using PlatformCertificateFromProto;

namespace YourNamespace {
    public class YourClass {
	    public void YourMethod {
			ObjectIdentifier oid = OidsUtils.Find(TCG_TR_ID_NODE.TcgTrIdBoolean); // oid.Oid = 2.23.133.19.1.1
		}
	}
}
```

#### Compile
The .NET project should compile the C# files from the proto files on every build and pack them into a nuget package.

#### Useful Links
https://trustedcomputinggroup.org/resource/tcg-platform-certificate-profile/