# 阿里云开发者C#工具套件

[![Travis CI Build Status](https://travis-ci.org/aliyun/aliyun-openapi-net-sdk.svg?branch=master)](https://travis-ci.org/aliyun/aliyun-openapi-net-sdk)
[![Appveyor CI Build Status](https://ci.appveyor.com/api/projects/status/l6a4r74matmhwqf3?svg=true)](https://ci.appveyor.com/project/AxiosCros/aliyun-openapi-net-sdk-6xumj)
[![codecov](https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk/branch/master/graph/badge.svg)](https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk)
[![Nuget Download](https://img.shields.io/nuget/dt/aliyun-net-sdk-core.svg?label=Nuget%20Download&style=flat)](https://www.nuget.org/packages/aliyun-net-sdk-core/)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://github.com/aliyun/aliyun-openapi-net-sdk/blob/master/LICENSE)


欢迎使用阿里云开发者工具套件（SDK），适用于阿里云的 C# SDK 让您不用复杂编程即可访问云服务器、云监控等多个阿里云服务。

如果您在使用SDK的过程中遇到任何问题，欢迎前往[阿里云SDK问答社区](https://yq.aliyun.com/tags/type_ask-tagid_23350)提问，提问前请阅读[提问引导](https://help.aliyun.com/document_detail/93957.html)。亦可在当前GitHub提交Issues。

## 环境准备

1. 阿里云 C# SDK 适用于 .NET Framework 4.0 及以上版本。
2. 要使用阿里云 C# SDK，您需要一个云账号以及一对 Access Key ID 和 Access Key Secret。请在阿里云控制台中的 [AccessKey 管理页面]([https://usercenter.console.aliyun.com/#/manage/ak](https://usercenter.console.aliyun.com/#/manage/ak))上创建和查看您的 Access Key，或者联系您的系统管理员。
3. 要使用阿里云 SDK 访问某个产品的 API，您需要事先在[阿里云控制台](https://home.console.aliyun.com/new#/)中开通这个产品。


## SDK 获取和安装

进入[阿里云 C# SDK](https://develop.aliyun.com/tools/sdk#/dotnet)页面，查看已发布的阿里云产品 SDK 模块列表。

> **注意：** 部分阿里云产品的 SDK 未收录到这个列表中，例如对象存储（OSS），表格存储（Table Store），请前往这些产品的详情页获取相应的 SDK。

要成功地调用一个产品的 SDK，您至少需要首先安装 `SDK 核心库`。例如，对云服务器 SDK 的调用，您需要获取和安装 2 个 SDK，分别是`SDK 核心库`和`云服务器`的 SDK。

您可以通过 NuGet 程序包管理器来安装：

* 打开您的 `Visual Studio` 选择`文件->新建->项目`菜单，在弹出的新建项目对话框中选择`控制台应用(.NET Framework)`，然后点击**确定**按钮。

* 在`解决方案资源管理器面板`中右击您的项目选择`管理 NuGet 程序包`菜单，在打开的 NuGet 管理面板中点击`浏览`选项卡输入 `aliyun-net-sdk`，在下方列表中将显示由 `Alibaba Cloud` 发布的各产品模块，选择您期望的模块点击**安装**即可。

## 开始调用

以下这个代码示例向您展示了调用阿里云 SDK 的 3 个主要步骤：

1. 创建 DefaultAcsClient 实例并初始化；
2. 创建 API 请求并设置参数；
3. 发起请求并处理返回。

```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Ecs.Model.V20140526;

class TestProgram
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

在创建 DefaultAcsClient 实例并初始化时，您需要填写 3 个参数：`Region ID`、`Access Key ID` 和 `Access Key Secret`。`Access Key ID` 和 `Access Key Secret` 可以从控制台获得；而 `Region ID` 可以从[地域列表](https://help.aliyun.com/document_detail/40654.html)中获得。

## API参考

要知道您想访问的产品提供的 API 以及它们的参数，请参考开放了 API 的[产品列表](https://develop.aliyun.com/tools/openapilist)。

## 开放授权

源码基于 [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0.html) 许可协议开放授权
