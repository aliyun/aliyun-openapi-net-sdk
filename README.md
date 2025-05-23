English | [简体中文](./README-CN.md)

<p align="center">
<a href=" https://www.alibabacloud.com"><img src="https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg"></a>
</p>

<h1 align="center">Alibaba Cloud SDK for .NET</h1>

[![.NET CI](https://github.com/aliyun/aliyun-openapi-net-sdk/actions/workflows/ci.yml/badge.svg)](https://github.com/aliyun/aliyun-openapi-net-sdk/actions/workflows/ci.yml)
[![codecov](https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk/graph/badge.svg?token=TiTJg3ch1j)](https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk)
[![Nuget Version](https://badge.fury.io/nu/aliyun-net-sdk-core.svg)](https://www.nuget.org/packages/aliyun-net-sdk-core/)
[![Nuget Download](https://img.shields.io/nuget/dt/aliyun-net-sdk-core.svg?label=Nuget%20Download&style=flat)](https://www.nuget.org/packages/aliyun-net-sdk-core/)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://github.com/aliyun/aliyun-openapi-net-sdk/blob/master/LICENSE)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Faliyun%2Faliyun-openapi-net-sdk.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Faliyun%2Faliyun-openapi-net-sdk?ref=badge_shield)

The Alibaba Cloud V1.0 SDK will soon enter the Basic Security Maintenance phase and is no longer recommended for use. It is suggested to use the V2.0 SDK instead.

## Troubleshoot

[Troubleshoot](https://api.aliyun.com/troubleshoot?source=github_sdk) Provide OpenAPI diagnosis service to help developers locate quickly and provide solutions for developers through `RequestID` or `error message`.

## Online Demo

[Alibaba Cloud OpenAPI Developer Portal](https://api.aliyun.com) provides the ability to call the cloud product OpenAPI online, generates SDK Example code dynamically and retrieves interface quickly, which can lessen the difficultly of using the Alibaba Cloud API significantly.

## Requirements

- The Alibaba Cloud SDK for .NET requires：
  - **.NET Framework 4.5** and above
  - **.NET Standard 2.0** and above
  - **C# 4.0** and above

## Installation

You should install [ECS Nuget Package](https://www.nuget.org/packages/aliyun-net-sdk-ecs/) when you are using ECS Product. If you want to install a specific version, please add `--version` or it will install the latest version of this package.  

Use .NET CLI ( Recommand )

    dotnet add package aliyun-net-sdk-ecs

Use Package Manager

    Install-Package aliyun-net-sdk-ecs

## Quick Examples

At the beginning, you need to sign up for an Alibaba Cloud account and retrieve your [Credentials](https://usercenter.console.aliyun.com/#/manage/ak).
>**Note:** To increase the security of your account, we recommend that you can use the AccessKey of the RAM user to access Alibaba Cloud services.

### Initiate a call

The following code example show three main steps to use the Alibaba Cloud SDK for .NET:

- Create and initialize a `DefaultAcsClient` instance.

- Create a `request` and set parameters.

- Initiate the `request` and handle the `response`.

```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Ecs.Model.V20140526;

class Program
{
    static void Main(string[] args)
    {
        // Create a client used for initiating a request
        IClientProfile profile = DefaultProfile.GetProfile(
            "<your-region-id>",
            "<your-access-key-id>",
            "<your-access-key-secret>");
        DefaultAcsClient client = new DefaultAcsClient(profile);

        try
        {
            // Create the request
            DescribeInstancesRequest request = new DescribeInstancesRequest();
            request.PageSize = 10;

            // Initiate the request and get the response
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

### Use BearerToken to invoke [CCC](https://www.nuget.org/packages/aliyun-net-sdk-ccc/) Product

You should install the [CCC Product Nuget Package](https://www.nuget.org/packages/aliyun-net-sdk-ccc/) if you want to run the below demo in your local machine.

```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.CCC.Model.V20170705;

class Program
{
    static void Main(string[] args)
    {
        // Create a client used for initiating a request
        var profile = DefaultProfile.GetProfile("<your-region-id>");
        var bearerTokenCredentialProvider = new BearerTokenCredentialProvider("<your-bearertoken>");

        var client = new DefaultAcsClient(profile, bearerTokenCredentialProvider);

        try
        {
            // Create the request
            var request = new ListPhoneNumbersRequest();

            // Initiate the request and get the response
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

## Documentation

- [Requirements](docs/0-Requirements-EN.md)
- [SSL Verify](docs/1-Verify-EN.md)
- [Debug](docs/2-Debug-EN.md)
- [Proxy](docs/3-Proxy-EN.md)
- [Timeout](docs/4-Timeout-EN.md)
- [Product Nuget Package](docs/5-Packages-EN.md)
- [Log](docs/6-Log-EN.md)
- [Client & Credentials](docs/7-Client-EN.md)
- [Endpoint](docs/8-Endpoint-EN.md)

## Issues

[Opening an Issue](https://github.com/aliyun/aliyun-openapi-net-sdk/issues/new), Issues not conforming to the guidelines may be closed immediately.

## Changelog

Detailed changes for each release are documented in the [release notes](aliyun-net-sdk-core/ChangeLog.md).

## API Reference

You can visit the API and its parameters in [Product List](https://www.alibabacloud.com).

## License

[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)

[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Faliyun%2Faliyun-openapi-net-sdk.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Faliyun%2Faliyun-openapi-net-sdk?ref=badge_large)
