# Alibaba Cloud C# Software Development Kit
[中文文档](./README_zh.md)

[![Travis CI Build Status](https://travis-ci.org/aliyun/aliyun-openapi-net-sdk.svg?branch=master)](https://travis-ci.org/aliyun/aliyun-openapi-net-sdk)
[![Appveyor CI Build Status](https://ci.appveyor.com/api/projects/status/l6a4r74matmhwqf3?svg=true)](https://ci.appveyor.com/project/AxiosCros/aliyun-openapi-net-sdk-6xumj)
[![codecov](https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk/branch/master/graph/badge.svg)](https://codecov.io/gh/aliyun/aliyun-openapi-net-sdk)


The Alibaba Cloud C# Software Development Kit (SDK) allows you to access Alibaba Cloud services such as Elastic Compute Service (ECS), Server Load Balancer (SLB), and CloudMonitor. You can access Alibaba Cloud services without the need to handle API related tasks, such as signing and constructing your requests.

This document introduces how to install and use Alibaba Cloud C# SDK.

If you have any problem while using Java SDK, please join the **DingTalk group: 11771185 (the official SDK customer service group of Alibaba Cloud)** for consultation.

## Prerequisites

- To use Alibaba Cloud C# SDK, you must have an Alibaba Cloud account and an AccessKey.

	The AccessKey is required when initializing the client. You can create an AccessKey in the Alibaba Cloud console. For more information, see [Create an AccessKey]([https://usercenter.console.aliyun.com/#/manage/ak](https://usercenter.console.aliyun.com/#/manage/ak)).

	>**Note:** To increase the security of your account, we recommend that you use the AccessKey of the RAM user to access Alibaba Cloud services.

- To use Alibaba Cloud Java SDK to access the APIs of a product, you must first activate the product on the [Alibaba Cloud console](https://home.console.aliyun.com/?spm=5176.doc52740.2.4.QKZk8w) if required.

- The Alibaba Cloud C# SDK is requires .NET Framework 4.0 or later.

## Install C# SDK

You must install the SDK core library for any SDK you use. For example, to call the ECS SDK, you must install both the ECS SDK and the SDK core library.

Install the Alibaba Cloud C# SDK using one of the following methods:

- Add DLL reference

	1. Download the DLL package from [.NET SDK](https://develop.aliyun.com/tools/sdk#/dotnet********).

	2. Right click your project in the **Solution Explorer** of Visual Studio and click **Reference**.

	3. In the displayed menu, click **Add Reference**.

	4. In the displayed dialog box, click **Browse**. Then select the downloaded DLL file and click **Confirm**.

- Add project reference

	1. Run the following command to clone the SDK source codes from GitHub.

	```
	git clone https://github.com/aliyun/aliyun-openapi-net-sdk.git
	```

	There are many folders prefixed with`aliyun-net-openapi-`in the cloned directory. Each folder contains `\\*.csproj` file, which is the project file**. For example, there is an `aliyun-net-sdk-ecs.csproj` file under the `aliyun-net-openapi-ecs` subfolder.

	2. In Visual Studio, right click your solution.

	3. Click **Add > Existing Project**.

	4. In the displayed dialogue box, select the project file, for example, `aliyun-net-sdk-ecs.csproj`, and click then **Open**.

	5. Right click your project and click **Reference > Add Reference**.

	6. In the displayed dialog box, click the **Project ** tab, select the opened project and click **Confirm**.

## Initiate a call

The following code example shows the three main steps to use the Alibaba Cloud C# SDK:

- Create and initialize a DefaultAcsClient instance.

- Create a request and set parameters.

- Initiate the request and handle the response.

```
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Ecs.Model.V20140526;

class TestProgram
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