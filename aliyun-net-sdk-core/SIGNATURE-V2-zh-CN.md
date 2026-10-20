# 签名 V2 升级与复测说明

[English](SIGNATURE-V2.md)

AccessKey 和 STS 凭据的 RPC、ROA 请求默认使用 `HMAC-SHA256`。协议字段 `SignatureVersion`（ROA 为 `x-acs-signature-version`）仍为 `1.0`。规范化规则、UTF-8 编码、Base64、RPC 密钥末尾的 `&`、ROA 请求体 MD5 均保持原有行为，RSA 和 Bearer Token 签名方式也保持原有行为。

需要兼容 SHA1 时，通过 `DefaultAcsClient` 的现有重载显式传入签名器：

```csharp
request.ProductDomain = new ProductDomain(request.Product, endpoint);
HttpResponse response = client.DoAction(request, false, 0, regionId,
    credentials, new HmacSHA1Signer(), request.AcceptFormat, null);
```

其中 `credentials` 为 `AlibabaCloudCredentials` 实例，例如 `BasicCredentials` 或 `BasicSessionCredentials`；该重载返回原始 HTTP 响应。显式签名器只作用于这次请求，独立创建的 Location、STS AssumeRole 请求仍使用各自的默认签名器。

SDK 日志模板、`DEBUG=sdk` 输出和异常消息会遮盖凭据、签名字段中的敏感值；实际请求和响应对象保留原始数据。

## 离线复测

以下命令均在仓库根目录执行。筛选后的测试不需要 AccessKey，也不会调用真实云端 API；恢复 NuGet 构建和测试依赖时可能需要联网。

先构建生产项目，验证原有目标框架以及项目配置的 C# 4 语言级别：

```sh
dotnet restore aliyun-net-sdk-core/aliyun-net-sdk-core.vs2017.csproj
dotnet build aliyun-net-sdk-core/aliyun-net-sdk-core.vs2017.csproj --no-restore
```

原测试项目的目标框架为 `netcoreapp2.0`，需要兼容的 .NET Core 2 测试 SDK、运行时和测试宿主；仓库 CI 会在测试前安装 AltCover。环境满足要求时执行：

```sh
dotnet test aliyun-net-sdk-core.Tests/aliyun-net-sdk-core-unit-tests.csproj --filter 'FullyQualifiedName~SignatureV2Test|FullyQualifiedName~LogRedactorTest|FullyQualifiedName~SignerTest|FullyQualifiedName~SignatureComposerTest|FullyQualifiedName~CommonLogTest'
```

如果本机只有 .NET 8，没有 .NET Core 2 运行时，可以创建仓库外的临时测试项目，复用原测试源码运行以下回归测试：

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

临时项目排除了无关的旧测试源码 `Units/Http/HttpResponse.cs`，因为其中使用的 `HttpWebResponse` 构造函数不受 .NET 8 支持。生产项目和仓库原测试项目均保持原有目标框架。

测试覆盖默认凭据对应的签名器选择、经 `DefaultAcsClient` 捕获最终 HTTP 请求、独立计算 HMAC 校验 RPC GET/POST 和 ROA GET/带请求体请求、STS Token、显式 SHA1、算法与版本字段，以及 URL/Header/表单/JSON/XML/编码后诊断信息的敏感值遮盖。测试同时验证请求和响应对象不被修改；筛选范围也包含已有的显式 SHA1、RSA 和 Bearer Token 签名器测试。

## 发布前联调

使用 AK 和 STS 凭据，分别对真实服务执行只读 RPC、ROA API，检查默认 SHA256 请求成功，再用显式 SHA1 重复验证。使用 STS AssumeRole 或 Location 的应用还需验证凭据交换和端点查询。

本次离线验证不替代真实服务联调。发布后还需确认消费方实际解析到升级后的 Core 包版本，特别是锁定了 NuGet 版本的应用。
