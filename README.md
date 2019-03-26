English | [简体中文](./README-CN.md)


<p align="center">
<a href=" https://www.alibabacloud.com"><img src="https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg"></a>
</p>

<h1 align="center">Alibaba Cloud SDK for C#</h1>

<p align="center">
<a href="https://travis-ci.org/aliyun/aliyun-openapi-net-sdk"><img src="https://travis-ci.org/aliyun/aliyun-openapi-net-sdk.svg?branch=master" alt="Travis Build Status"></a>
<a href="https://ci.appveyor.com/project/aliyun/aliyun-openapi-net-sdk"><img src="https://ci.appveyor.com/api/projects/status/32r7s2skrgm9ubva?svg=true" alt="Appveyor Build Status"></a>
<a href="https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk"><img src="https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk/branch/master/graph/badge.svg" alt="Codecov"></a>
<a href="https://badge.fury.io/nu/aliyun-net-sdk-core"><img src="https://badge.fury.io/nu/aliyun-net-sdk-core.svg" alt="Nuget Version"></a>
<a href="https://www.nuget.org/packages/aliyun-net-sdk-core/"><img src="https://img.shields.io/nuget/dt/aliyun-net-sdk-core.svg?label=Nuget%20Download&style=flat" alt="Nuget Version"></a>
<a href="https://github.com/aliyun/aliyun-openapi-net-sdk/blob/master/LICENSE"><img src="https://img.shields.io/badge/License-Apache%202.0-blue.svg" alt="Nuget Version"></a>
</p>


The Alibaba Cloud Client for C# (SDK) allows you to access Alibaba Cloud services such as Elastic Compute Service (ECS), Server Load Balancer (SLB), and CloudMonitor. You can access Alibaba Cloud services without the need to handle API related tasks, such as signing and constructing your requests.


## Online Demo
[OpenAPI Explorer](https://api.aliyun.com/#/?product=Ecs&api=DescribeAccessPoints&params={}&tab=DEMO&lang=CSHARP) provides the ability to call the cloud product OpenAPI online, and dynamically generate SDK Example code and quick retrieval interface, which can significantly reduce the difficulty of using the cloud API.


## Requirements
- The Alibaba Cloud C# SDK is requires：
    - **`.NET Framework 4.6.1`** or later
    - **`.NET Standard 2.0`** or later


## Installation
You must install the SDK core Nuget Package for any SDK you use. For example, to call the ECS product, you must install both the [ECS Nuget Package](https://www.nuget.org/packages/aliyun-net-sdk-ecs/) and the [SDK core Nuget Package](https://www.nuget.org/packages/aliyun-net-sdk-core/).

Use Package Manager

    Install-Package aliyun-net-sdk-core
    Install-Package aliyun-net-sdk-ecs

Use .NET CLI

    dotnet add package aliyun-net-sdk-core
    dotnet add package aliyun-net-sdk-ecs


## Quick Examples
Before you begin, you need to sign up for an Alibaba Cloud account and retrieve your [Credentials](https://usercenter.console.aliyun.com/#/manage/ak).
>**Note:** To increase the security of your account, we recommend that you use the AccessKey of the RAM user to access Alibaba Cloud services.

### Initiate a call

The following code example shows the three main steps to use the Alibaba Cloud C# SDK:

- Create and initialize a DefaultAcsClient instance.

- Create a request and set parameters.

- Initiate the request and handle the response.

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
You should install the relative Nuget Package, as it said before, when you are running the test demo in your local machine.

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
        IClientProfile profile = DefaultProfile.GetProfile("<your-region-id>");
        BearerTokenCredential bearerTokenCredential = new BearerTokenCredential("<your-bearertoken>");

        DefaultAcsClient client = new DefaultAcsClient(profile, bearerTokenCredential);

        try
        {
            // Create the request
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest();

            // Initiate the request and get the response
            var response = client.GetAcsResponse(request);
            
            //Do something as you want below
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
* [Requirements](docs/0-Requirements-EN.md)
* [SSL Verify](docs/1-Verify-EN.md)
* [Debug](docs/2-Debug-EN.md)
* [Proxy](docs/3-Proxy-EN.md)
* [Timeout](docs/4-Timeout-EN.md)
* [Product Nuget Package](docs/5-Packages-EN.md)


## Issues
[Opening an Issue](https://github.com/aliyun/aliyun-openapi-net-sdk/issues/new), Issues not conforming to the guidelines may be closed immediately.


## Changelog
Detailed changes for each release are documented in the [release notes](aliyun-net-sdk-core/ChangeLog.txt).


## API Reference
You can visit the API and its parameters in [Product List](https://www.alibabacloud.com/en?spm=5176.10609282.1280361.9.62e538011pDOUG)


## License
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)
