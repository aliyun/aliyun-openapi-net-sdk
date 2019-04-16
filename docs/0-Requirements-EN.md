[← Home](../README.md) | Requirements[(中文)](0-Requirements-CN.md) | [Verify →](1-Verify-EN.md)
***

# Requirements
Make sure you have the relevant [.NET SDK][.net sdk] and [.NET RunTime][.net runtime] installed.
- **`.NET Framework 4.6.1`** and above
- **`.NET Standard 2.0`** and above

# Recommendations
- Recommended use of **.NET Standard 2.0** and above target framework
- It is recommended to use **Visual Studio 2017** or **Visual Studio Code** for development

# The target framework is SDK Core Dll file generation for .net framework 45 or .net framework 4.6.1
If the target framework is `.net framework 4.5` and `.net framework 4.6.1` you need to use the package by referring to `dll assembly`:

- First clone the [Github repository] of the latest version of `aliyun-openapi-net-sdk` (https://github.com/aliyun/aliyun-openapi-net-sdk)

- Next enter the project root directory, open `aliyun-net-sdk-core.net45.sln` or `aliyun-net-sdk-core.net461.sln` and then install the corresponding Nuget package after the Build project, so in the project bin 
The project's dll file is available in the folder.

- Add a reference to the above `dll assembly` file by right-clicking `Add Reference` in the project's `References`

# Product Dll file generation for .net framework 45 or .net framework 4.6.1
If the target framework is `.net framework 4.5` and `.net framework 4.6.1` you need to use the package by referring to `dll assembly`, the following has  `alimt` as an example:

- Open the `aliyun-net-sdk-alimt.vs2010.csproj` file in the product root directory using `Visual Studio`.

- Right-click on the project's Target Framework to change to `net 4.5` or `4.6.1` and add a reference to the compiled Core dll file above.

***
[← Home](../README.md) | Requirements[(中文)](0-Requirements-CN.md) | [Verify →](1-Verify-EN.md)

[.net sdk]: https://dotnet.microsoft.com/download/visual-studio-sdks
[.net runtime]: https://dotnet.microsoft.com/download
