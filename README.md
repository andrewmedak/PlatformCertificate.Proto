This lightweight library offers a selection of sequences from the TCG Platform Certificate compiled as C# Objects. The sequences are compiled after I attempted to capture their ASN.1 definition into Google's Protobuf (Proto3) format. 

This project may be useful for you to encapsulate a subset of Platform Certificate v1.0 and v1.1 information. The [proto source files are also available on GitHub](https://github.com/andrewmedak/PlatformCertificate.Proto/blob/main/PlatformCertificate.Proto/Resources/) and can be compiled into any language supported by Protobuf.

The library is available via Nuget https://www.nuget.org/packages/PlatformCertificate.Proto for inclusion into .NET projects.

#### Usage
Reference this library in your .NET project. Then you can use the objects.
```
using PlatformCertificateFromProto;

namespace YourNamespace {
    public class YourClass {
	    public void YourMethod {
			ComponentIdentifierV2 componentIdentifier;
			...
		}
	}
}
```

#### Compile
The .NET project will compile the C# files from the proto files on every build.

#### Useful Links
https://trustedcomputinggroup.org/resource/tcg-platform-certificate-profile/