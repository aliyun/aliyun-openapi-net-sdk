[← Home](../README.md) | Requirements[(中文)](0-Requirements-CN.md) | [Verify →](1-Verify-EN.md)
***

# Requirements
Make sure you have the relevant [.NET SDK][.net sdk] and [.NET RunTime][.net runtime] installed.
- **`.NET Framework 4.6.1`** and above
- **`.NET Standard 2.0`** and above

# Recommendations
- Recommended use of **.NET Standard 2.0** and above target framework
- It is recommended to use **Visual Studio 2017** or **Visual Studio Code** for development

# The target framework is .net framework 45 or .net framework 4.6.1
If the target framework is `.net framework 4.5` and `.net framework 4.6.1` you need to use the package by referring to `dll assembly`, let's take the example of `Visual Studio 2015`:

- First clone the latest version of aliyun-openapi-net-sdk [Github repository] (https://github.com/aliyun/aliyun-openapi-net-sdk)

- Then go to the aliyun-net-sdk-alimt directory. 
Run `dotnet build aliyun-net-sdk-alimt.vs2017.csproj`

- Next, go to the aliyun-net-sdk-core directory and run `dotnet build aliyun-net-sdk-core.vs2017.csproj `.

- Add a reference to the above two `dll assembly` files by right-clicking `Add Reference` in the project's `References`

- Add `packages.config` to your project

```xml
<?xml version="1.0" encoding="utf-8"?>
<packages>  
<package id="Serilog" version="2.5.0" targetFramework="net45" />
<package id="Serilog.Exceptions" version="4.0.0" targetFramework="net45" />
<package id="Serilog.Sinks.File" version="4.0.0" targetFramework="net45" />
</packages>
```
- Rebuild your project

***
[← Home](../README.md) | Requirements[(中文)](0-Requirements-CN.md) | [Verify →](1-Verify-EN.md)

[.net sdk]: https://dotnet.microsoft.com/download/visual-studio-sdks
[.net runtime]: https://dotnet.microsoft.com/download
