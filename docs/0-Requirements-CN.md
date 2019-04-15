[← 首页](../README-CN.md) | 环境要求[(English)](0-Requirements-EN.md) | [SSL 验证 →](1-Verify-CN.md)
***

# 要求
首先要保证您安装了相关 [.NET SDK][.net sdk] 和 [.NET RunTime][.net runtime]
- **`.NET Framework 4.6.1`** 及其以上版本
- **`.NET Standard 2.0`** 及其以上版本

# 建议
- 建议使用 **.NET Standard 2.0** 及以上目标框架
- 建议使用 **Visual Studio 2017** 或者 **Visual Studio Code** 来进行开发

# 目标框架为 .net framework 45 或 .net framework 4.6.1

如果目标框架是 `.net framework 4.5`和 `.net framework 4.6.1` 需要通过引用 `dll程序集` 来使用包，下面以 `Visual Studio 2015` 为例：

- 首先克隆 最新版的 aliyun-openapi-net-sdk 的 [Github 仓库](https://github.com/aliyun/aliyun-openapi-net-sdk)

- 然后进入 aliyun-net-sdk-alimt 目录。 运行 `dotnet build aliyun-net-sdk-alimt.vs2017.csproj` 

- 其次进入 aliyun-net-sdk-core 目录，运行 `dotnet build aliyun-net-sdk-core.vs2017.csproj `。

- 在项目的 `References` 中右键 `Add Reference` 添加上述两个 `dll程序集` 文件的引用

- 在项目中添加 `packages.config`
```xml
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Serilog" version="2.5.0" targetFramework="net45" />
  <package id="Serilog.Exceptions" version="4.0.0" targetFramework="net45" />
  <package id="Serilog.Sinks.File" version="4.0.0" targetFramework="net45" />
</packages>
```
- Rebuild 你的项目。

***
[← 首页](../README-CN.md) | 环境要求[(English)](0-Requirements-EN.md) | [SSL 验证 →](1-Verify-CN.md)

[.net sdk]: https://dotnet.microsoft.com/download/visual-studio-sdks
[.net runtime]: https://dotnet.microsoft.com/download
