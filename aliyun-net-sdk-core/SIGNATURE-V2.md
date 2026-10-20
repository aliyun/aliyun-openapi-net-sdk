# Signature V2 signing

AccessKey and STS credentials now use `HMAC-SHA256` by default for both RPC and ROA requests. The protocol field `SignatureVersion` (and ROA `x-acs-signature-version`) remains `1.0`. Canonicalization, UTF-8 encoding, Base64, RPC's `&` key suffix and ROA body MD5 are unchanged. RSA and bearer token signers are unchanged.

To send a compatibility request using SHA1, pass the existing signer overload on `DefaultAcsClient`:

```csharp
request.ProductDomain = new ProductDomain(request.Product, endpoint);
HttpResponse response = client.DoAction(request, false, 0, regionId,
    credentials, new HmacSHA1Signer(), request.AcceptFormat, null);
```

Here `credentials` is an `AlibabaCloudCredentials` instance (for example `BasicCredentials` or `BasicSessionCredentials`). The overload returns the raw HTTP response. This choice applies to that request; independently created Location and STS AssumeRole requests continue to use their default signer.

SDK log templates, `DEBUG=sdk` output and exception messages redact named credential and signature values. Actual requests and response objects retain their original data.

## Offline verification

Run from the repository root. No AccessKey or network API calls are needed for the filtered tests below. NuGet access may be required to restore build and test dependencies.

Build the original production targets, including the configured C# 4 language level:

```sh
dotnet restore aliyun-net-sdk-core/aliyun-net-sdk-core.vs2017.csproj
dotnet build aliyun-net-sdk-core/aliyun-net-sdk-core.vs2017.csproj --no-restore
```

The test project targets `netcoreapp2.0`; running it requires a compatible .NET Core 2 test SDK/runtime and test host (the repository CI installs AltCover before testing). On that environment:

```sh
dotnet test aliyun-net-sdk-core.Tests/aliyun-net-sdk-core-unit-tests.csproj --filter 'FullyQualifiedName~SignatureV2Test|FullyQualifiedName~LogRedactorTest|FullyQualifiedName~SignerTest|FullyQualifiedName~SignatureComposerTest|FullyQualifiedName~CommonLogTest'
```

On a machine with .NET 8 but no .NET Core 2 runtime, use an external temporary test host to run the same test source files. This does not change either production target or the repository test project:

```sh
repo_root="$(pwd)"
test_dir="$(mktemp -d)"
cat > "$test_dir/Tests.csproj" <<EOF
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <IsPackable>false</IsPackable>
    <AssemblyName>aliyun-net-sdk-core.Tests</AssemblyName>
    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
    <GenerateAssemblyInfo>false</GenerateAssemblyInfo>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="$repo_root/aliyun-net-sdk-core.Tests/**/*.cs" Exclude="$repo_root/aliyun-net-sdk-core.Tests/**/obj/**/*.cs;$repo_root/aliyun-net-sdk-core.Tests/Units/Http/HttpResponse.cs" />
    <ProjectReference Include="$repo_root/aliyun-net-sdk-core/aliyun-net-sdk-core.vs2017.csproj" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.10.0" />
    <PackageReference Include="xunit" Version="2.3.1" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.8.1" />
    <PackageReference Include="Moq" Version="4.10.1" />
  </ItemGroup>
</Project>
EOF
dotnet test "$test_dir/Tests.csproj" --filter 'FullyQualifiedName~SignatureV2Test|FullyQualifiedName~LogRedactorTest|FullyQualifiedName~SignerTest|FullyQualifiedName~SignatureComposerTest|FullyQualifiedName~CommonLogTest'
```

The temporary host excludes the unrelated legacy `Units/Http/HttpResponse.cs` test source because its `HttpWebResponse` constructor is unsupported on .NET 8. The original test project is unchanged.

The filtered tests cover default credential selection, transport capture through `DefaultAcsClient`, independent HMAC verification of final RPC GET/POST and ROA GET/body requests, STS tokens, explicit SHA1, unchanged algorithm/version parameters, and redaction of URL/header/form/JSON/XML/encoded diagnostics without mutating requests or responses. Existing explicit SHA1 and RSA/bearer signer tests are included by the filter.

Before release, separately verify read-only RPC and ROA calls against actual service endpoints with AK and STS credentials, then repeat with explicit SHA1. Verify an STS AssumeRole exchange and a Location lookup if those features are used. Confirm that consuming applications actually resolve the new Core package version, including applications with locked NuGet versions.
