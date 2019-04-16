[← 首页](../README-CN.md) | 环境要求[(English)](0-Requirements-EN.md) | [SSL 验证 →](1-Verify-CN.md)
***

# 要求
首先要保证您安装了相关 [.NET SDK][.net sdk] 和 [.NET RunTime][.net runtime]
- **`.NET Framework 4.6.1`** 及其以上版本
- **`.NET Standard 2.0`** 及其以上版本

# 建议
- 建议使用 **.NET Standard 2.0** 及以上目标框架
- 建议使用 **Visual Studio 2017** 或者 **Visual Studio Code** 来进行开发

# 目标框架为 .net framework 45 或 .net framework 4.6.1 的 SDK Core Dll 文件生成

如果目标框架是 `.net framework 4.5`和 `.net framework 4.6.1` 需要通过引用 `dll程序集` 来使用包：

- 首先克隆 最新版的 `aliyun-openapi-net-sdk` 的 [Github 仓库](https://github.com/aliyun/aliyun-openapi-net-sdk)

- 其次进入项目根目录，打开 `aliyun-net-sdk-core.net45.sln` 或者 `aliyun-net-sdk-core.net461.sln` 然后安装相应的Nuget包后 Build 项目，这样在项目的 bin 文件夹里 就得到了项目的 dll 文件。

- 在项目的 `References` 中右键 `Add Reference` 添加上述 `dll程序集` 文件的引用

# 产品  .net framework 45 或 .net framework 4.6.1 的 SDK Core Dll 文件生成
如果目标框架是 `.net framework 4.5`和 `.net framework 4.6.1` 需要通过引用 `dll程序集` 来使用包，下面已 alimt 为例：
- 使用 Visual Studio 打开产品根目录下的 aliyun-net-sdk-alimt.vs2010.csproj 文件。
- 右键修改项目的 Target Framework 改为 net 4.5 或 4.6.1，然后添加上面编译好的 Core dll 文件的引用。

***
[← 首页](../README-CN.md) | 环境要求[(English)](0-Requirements-EN.md) | [SSL 验证 →](1-Verify-CN.md)

[.net sdk]: https://dotnet.microsoft.com/download/visual-studio-sdks
[.net runtime]: https://dotnet.microsoft.com/download
