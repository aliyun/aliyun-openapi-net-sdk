[English](./README.md) | 简体中文

<p align="center">
<a href=" https://www.alibabacloud.com"><img src="https://aliyunsdk-pages.alicdn.com/icons/Aliyun.svg"></a>
</p>

<h1 align="center">Alibaba Cloud SDK for .NET</h1>

[![.NET CI](https://github.com/aliyun/aliyun-openapi-net-sdk/actions/workflows/ci.yml/badge.svg)](https://github.com/aliyun/aliyun-openapi-net-sdk/actions/workflows/ci.yml)
[![codecov](https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk/graph/badge.svg?token=TiTJg3ch1j)](https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk)
[![Nuget Version](https://badge.fury.io/nu/aliyun-net-sdk-core.svg)](https://www.nuget.org/packages/aliyun-net-sdk-core/)
[![Nuget Download](https://img.shields.io/nuget/dt/aliyun-net-sdk-core.svg?label=Nuget%20Download&style=flat)](https://www.nuget.org/packages/aliyun-net-sdk-core/)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://github.com/aliyun/aliyun-openapi-net-sdk/blob/master/LICENSE)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Faliyun%2Faliyun-openapi-net-sdk.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Faliyun%2Faliyun-openapi-net-sdk?ref=badge_shield)

阿里云 V1.0 .NET SDK 已进入终止支持状态，不再建议使用。新用户请直接使用 [V2.0 .NET SDK](https://github.com/aliyun/alibabacloud-csharp-sdk)；已经集成 V1.0 .NET SDK 的用户也建议迁移至 [V2.0 .NET SDK](https://github.com/aliyun/alibabacloud-csharp-sdk)。V2.0 .NET SDK 使用方式请参见[帮助中心文档](https://www.alibabacloud.com/help/zh/sdk/developer-reference/v2-net-integrated-sdk)以及[阿里云 OpenAPI 开发者门户](https://api.alibabacloud.com/)。

## 使用诊断

[Troubleshoot](https://api.aliyun.com/troubleshoot?source=github_sdk) 提供 OpenAPI 使用诊断服务，通过 `RequestID` 或 `报错信息` ，帮助开发者快速定位，为开发者提供解决方案。

## 使用Demo及其示例

您可以在 [阿里云 OpenAPI 开发者门户](https://api.aliyun.com/) 中查看您所使用的产品代码示例。

## 环境要求

Alibaba Cloud SDK for .NET 适用于:

- **.NET Framework 4.5** 及其以上版本
- **.NET Standard 2.0** 及其以上版本。
- **C# 4.0** 及其以上版本

## 安装

进入 [Alibaba Cloud SDK for .NET Nuget Package](https://www.nuget.org/profiles/aliyun-openapi-sdk) 页面，查看已发布的阿里云产品 SDK 模块列表。

> **注意：** 部分阿里云产品的 SDK 未收录到这个列表中，例如对象存储（OSS），表格存储（Table Store），请前往这些产品的详情页获取相应的 SDK。

使用ECS产品时，应安装 [ECS Nuget Package](https://www.nuget.org/packages/aliyun-net-sdk-ecs/)。
如果要安装特定版本，请添加`--version`，否则它将安装此软件包的最新版本。

您可以通过 NuGet 程序包管理器来安装：

- 在 `解决方案资源管理器面板` 中右击您的项目选择 `管理 NuGet 程序包` 菜单，在打开的 `NuGet 管理面板` 中点击 `浏览` 选项卡输入 `aliyun-net-sdk`，在下方列表中选择 `Authors` 为 `Alibaba Cloud` 由官方发布的各产品模块，选择您期望的模块点击 **安装** 即可。

或者通过 .NET CLI 工具来安装（以安装 ECS为例）

    dotnet add package aliyun-net-sdk-ecs

## 快速开始

- 要使用 Alibaba Cloud SDK for .NET，您需要一个云账号以及一对 Access Key ID 和 Access Key Secret。请在阿里云控制台中的 [AccessKey 管理页面](https://usercenter.console.aliyun.com/#/manage/ak) 上创建和查看您的 Access Key，或者联系您的系统管理员。

- 要使用 Alibaba Cloud SDK for .NET 访问某个产品的 API，您需要事先在 [阿里云控制台](https://home.console.aliyun.com/new#/) 中开通这个产品。

以下这个代码示例向您展示了调用阿里云 .NET SDK 的 3 个主要步骤：

1. 创建 `DefaultAcsClient` 实例并初始化；
2. 创建 API 请求并设置参数；
3. 发起请求并处理返回。

```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Ecs.Model.V20140526;

class Program
{
    static void Main(string[] args)
    {
        // 构建一个 Client，用于发起请求
        IClientProfile profile = DefaultProfile.GetProfile(
            "<your-region-id>",
            "<your-access-key-id>",
            "<your-access-key-secret>");
        DefaultAcsClient client = new DefaultAcsClient(profile);

        try
        {
            // 构造请求
            DescribeInstancesRequest request = new DescribeInstancesRequest();
            request.PageSize = 10;

            // 发起请求，并得到 Response
            DescribeInstancesResponse response = client.GetAcsResponse(request);
            System.Console.WriteLine(response.TotalCount);
        }
        catch (ServerException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
        catch (ClientException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }
}
```

在创建 DefaultAcsClient 实例并初始化时，您需要填写 3 个参数：`Region ID`、`Access Key ID` 和 `Access Key Secret`。`Access Key ID` 和 `Access Key Secret` 可以从控制台获得；而 `Region ID` 可以从 [地域列表](https://help.aliyun.com/document_detail/40654.html) 中获得。

### 使用 BearerToken 调用 [CCC](https://www.nuget.org/packages/aliyun-net-sdk-ccc/) 产品

首先需要保证您已经安装了相应的 Nuget 包依赖。

```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.CCC.Model.V20170705;

class Program
{
    static void Main(string[] args)
    {
        // 构建一个 Client，用于发起请求
        var profile = DefaultProfile.GetProfile("<your-region-id>");
        var bearerTokenCredentialProvider = new BearerTokenCredentialProvider("<your-bearertoken>");

        var client = new DefaultAcsClient(profile, bearerTokenCredentialProvider);

        try
        {
            // 构造请求
            var request = new ListPhoneNumbersRequest();

            // 发起请求，并得到 Response
            var response = client.GetAcsResponse(request);

            // Do something as you want below
        }
        catch (ServerException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
        catch (ClientException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }
}
```

## 文档

- [环境要求](docs/0-Requirements-CN.md)
- [SSL 验证](docs/1-Verify-CN.md)
- [调试](docs/2-Debug-CN.md)
- [代理](docs/3-Proxy-CN.md)
- [超时](docs/4-Timeout-CN.md)
- [产品Nuget包](docs/5-Packages-CN.md)
- [日志](docs/6-Log-CN.md)
- [客户端与凭证](docs/7-Client-CN.md)
- [Endpoint](docs/8-Endpoint-CN.md)

## 问题

[提交Issue](https://github.com/aliyun/aliyun-openapi-net-sdk/issues/new)，不符合指南的问题可能会立即关闭。

## 发行说明

每个版本的详细更改记录在 [发行说明](aliyun-net-sdk-core/ChangeLog.md) 中。

## API参考

要知道您想访问的产品提供的 API 以及它们的参数，请参考开放 API 的 [产品列表](https://develop.aliyun.com/tools/openapilist)。

## 许可证

源码基于 [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0.html) 许可协议开放授权

[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Faliyun%2Faliyun-openapi-net-sdk.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Faliyun%2Faliyun-openapi-net-sdk?ref=badge_large)
