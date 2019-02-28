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


## SDK获取和安装

进入[阿里云 C# SDK](https://develop.aliyun.com/tools/sdk#/dotnet)页面，查看已发布的阿里云产品 SDK 模块列表。

> **注意：** 部分阿里云产品的 SDK 未收录到这个列表中，例如对象存储（OSS），表格存储（Table Store），请前往这些产品的详情页获取相应的 SDK。

要成功地调用一个产品的 SDK，您至少需要首先安装 `SDK 核心库`。例如，对云服务器 SDK 的调用，您需要获取和安装 2 个 SDK，分别是`SDK 核心库`和`云服务器`的 Nuget 包。

您可以通过 NuGet 程序包管理器来安装：

* 打开您的 `Visual Studio` 选择`文件->新建->项目`菜单，在弹出的新建项目对话框中选择`控制台应用(.NET Framework)`，然后点击**确定**按钮。

* 在`解决方案资源管理器面板`中右击您的项目选择`管理 NuGet 程序包`菜单，在打开的 NuGet 管理面板中点击`浏览`选项卡输入 `aliyun-net-sdk`，在下方列表中将显示由 `Alibaba Cloud` 发布的各产品模块，选择您期望的模块点击**安装**即可。

或者通过 .NET CLI 工具来安装（以安装 ECS为例）

    dotnet add package aliyun-net-sdk-core --version 1.2.0
    dotnet add package aliyun-net-sdk-ecs --version 4.16.1

Aliyun C# SDK已发布的Nuget包：

- [aliyun-net-sdk-alidns](https://www.nuget.org/packages/aliyun-net-sdk-alidns/)
  - 云解析DNS（Domain Name System，简称DNS） 云解析DNS是一种安全、快速、稳定、可靠的权威DNS解析管理服务，为企业和开发者将易于 管理识别的域名转换为计算机用于互连通信的数字IP地址，从而将用户的访问路由到相应的网 站或应用服务器。
- [aliyun-net-sdk-alimt](https://www.nuget.org/packages/aliyun-net-sdk-alimt/)
  - 阿里巴巴机器翻译是由阿里巴巴匠心打造的在线智能机器翻译服务。依托领先的自然语言处理技术和海量的互联网数据优势，阿里巴巴成功上线基于注意力机制的深层神经网络翻译系统（NMT），帮助用户跨越语言鸿沟，畅享交流和获取信息，实现无障碍沟通。凭借海量数据积累及关键技术创新，在电商领域翻译质量独具优势。 现在购买资源包，享受梯度优惠的同时，每日还有10万字符免费调用额度。
- [aliyun-net-sdk-arms](https://www.nuget.org/packages/aliyun-net-sdk-arms/)
  - 业务实时监控服务 (Application Real-Time Monitoring Service, 简称ARMS) 是一款APM类的监控产品。 用户可基于 ARMS 的前端、应用、自定义监控，快速构建实时的应用性能和业务监控能力。ARMS 让所有性能问题“一屏了然”，不遗余力提升每一秒用户体验，驱动业务快速发展
- [aliyun-net-sdk-arms4finance](https://www.nuget.org/packages/aliyun-net-sdk-arms4finance/)
- [aliyun-net-sdk-baas](https://www.nuget.org/packages/aliyun-net-sdk-baas/)
  - 阿里云区块链服务（Blockchain as a Service，简称BaaS）是一种基于主流区块链技术的企业级PaaS（Platform as a Service）平台服务，帮助您快速构建更稳定、安全的生产级区块链环境，减少在区块链部署、运维、管理、应用开发等方面的挑战，使您更专注于核心业务创新，并实现业务快速上链。
- [aliyun-net-sdk-bssopenapi](https://www.nuget.org/packages/aliyun-net-sdk-bssopenapi/)
  - 阿里云交易和账单管理OpenAPI为用户提供管理阿里云产品售卖和财资能力，目前已经结束公测、正式对外开放，用户无需申请可以直接使用
- [aliyun-net-sdk-cbn](https://www.nuget.org/packages/aliyun-net-sdk-cbn/)
- [aliyun-net-sdk-ccc](https://www.nuget.org/packages/aliyun-net-sdk-ccc/)
  - 阿里云呼叫中心（Cloud Call Center）是基于云端的呼叫中心服务，所有企业都可以借助该服务以更低的成本获得更可靠和灵活的热线服务，从而提升企业的客户服务质量。云呼叫中心配备了交互式语音应答（IVR），自动呼叫分配（ACD）和大量提升效率的应用，例如100%覆盖的智能质检，简单易用且功能强大的商业智能，以及灵活多变的CRM集成方式。云呼叫中心联合云通信提供一站式服务，您可以自助开通呼叫中心号码，通过灵活简单的操作页面，任何用户都可以轻松设置呼叫中心流程而无需其他技术支持。
- [aliyun-net-sdk-ccs](https://www.nuget.org/packages/aliyun-net-sdk-ccs/) 
- [aliyun-net-sdk-cdn](https://www.nuget.org/packages/aliyun-net-sdk-cdn/)
  - 阿里云内容分发网络（Alibaba Cloud Content Delivery Network，简称CDN）将您源站资源缓存至阿里云遍布全球的加速节点上。当终端用户请求访问和获取这些资源时，无需回源，系统将就近调用CDN节点上已经缓存的资源。
- [aliyun-net-sdk-chatbot](https://www.nuget.org/packages/aliyun-net-sdk-chatbot/)
  - 云小蜜（Intelligent Service Robot）是一款基于自然语言处理（NLP）和人工智能（AI）技术提供智能会话能力的云服务。无需亲自掌握NLP、AI等技术，您就可以使用云小蜜创建自己的会话机器人，将机器人部署在不同终端上（如网站、移动APP、智能硬件等），为您的客户提供服务。
- [aliyun-net-sdk-cloudapi](https://www.nuget.org/packages/aliyun-net-sdk-cloudapi/)
  - API 网关为您提供完整的 API 托管服务，辅助用户将能力、服务、数据以 API 的形式开放给合作伙伴，也可以发布到 API 市场供更多的开发者采购使用。
- [aliyun-net-sdk-cloudauth](https://www.nuget.org/packages/aliyun-net-sdk-cloudauth/)
  - 实人认证服务是指依托活体检测、人脸比对等生物识别技术、证件OCR识别技术等进行的自然人真实身份的校验服务。
- [aliyun-net-sdk-cloudesl](https://www.nuget.org/packages/aliyun-net-sdk-cloudesl/)
- [aliyun-net-sdk-cloudphoto](https://www.nuget.org/packages/aliyun-net-sdk-cloudphoto/)
  - 智能云相册（Cloud Photos）是阿里云为影像类应用提供的一站式解决方案。智能云相册除了提供影像文件存储、管理等基础功能以外，还支持对影像内容进行分类打标、面孔识别等智能分析，并提供基于自然语言理解的智能搜索服务。
- [aliyun-net-sdk-cloudwf](https://www.nuget.org/packages/aliyun-net-sdk-cloudwf/)
- [aliyun-net-sdk-cms](https://www.nuget.org/packages/aliyun-net-sdk-cms/)
  - 云监控（CloudMonitor） 是一项针对阿里云资源和互联网应用进行监控的服务。云监控服务可用于收集获取阿里云资源的监控指标，探测互联网服务可用性，以及针对指标设置警报。
- [aliyun-net-sdk-core](https://www.nuget.org/packages/aliyun-net-sdk-core/)
  - SDK核心依赖包，使用每个产品必须依赖该Package
- [aliyun-net-sdk-cs](https://www.nuget.org/packages/aliyun-net-sdk-cs/) 
  - 容器服务（Container Service）提供了高性能可伸缩的容器应用管理服务，支持在一组云服务器上通过 Docker 容器来进行应用生命周期管理。容器服务极大地简化了用户对容器管理集群的搭建工作，无缝整合了阿里云虚拟化、存储、网络和安全能力，打造 Docker 云端最优化的运行环境。
- [aliyun-net-sdk-csb](https://www.nuget.org/packages/aliyun-net-sdk-csb/)
  - 云服务总线（Cloud Service Bus, 简称 CSB）用于实现专有云和混合云场景下的跨系统、跨协议的服务互通。主要针对需要对系统间服务访问和对外开放进行管理和控制，包括安全授权、流量限制。
- [aliyun-net-sdk-dcdn](https://www.nuget.org/packages/aliyun-net-sdk-dcdn/)
  - 阿里云自主研发的全站加速产品（Dynamic Route for Content Delivery Network），是融合了动态加速和静态加速技术的CDN产品。该产品一站式解决了页面动静态资源混杂、跨运营商、网络不稳定、单线源站、突发流量、网络拥塞等诸多因素导致的响应慢、丢包、服务不稳定的问题，提升全站性能和用户体验。
- [aliyun-net-sdk-dds](https://www.nuget.org/packages/aliyun-net-sdk-dds/)
- [aliyun-net-sdk-dms-enterprise](https://www.nuget.org/packages/aliyun-net-sdk-dms-enterprise/)
- [aliyun-net-sdk-domain](https://www.nuget.org/packages/aliyun-net-sdk-domain/)
  - 阿里云域名服务是集域名注册、交易、解析、监控和保护为一体的综合域名管理平台。
- [aliyun-net-sdk-drds](https://www.nuget.org/packages/aliyun-net-sdk-drds/)
  - 分布式关系型数据库服务（Distributed Relational Database Service，简称 DRDS）专注于解决单机关系型数据库扩展性问题，具备轻量（无状态）、灵活、稳定、高效等特性，是阿里巴巴集团自主研发的中间件产品。DRDS 兼容 MySQL 协议和语法，支持分库分表、平滑扩容、服务升降配、透明读写分离和分布式事务等特性，具备分布式数据库全生命周期的运维管控能力。
- [aliyun-net-sdk-dysms](https://www.nuget.org/packages/aliyun-net-sdk-dysms/)
- [aliyun-net-sdk-dyvmsapi](https://www.nuget.org/packages/aliyun-net-sdk-dyvmsapi/)
- [aliyun-net-sdk-ecs](https://www.nuget.org/packages/aliyun-net-sdk-ecs/)
  - 云服务器Elastic Compute Service（ECS）是阿里云提供的一种基础云计算服务。使用云服务器ECS就像使用水、电、煤气等资源一样便捷、高效。您无需提前采购硬件设备，而是根据业务需要，随时创建所需数量的云服务器ECS实例。在使用过程中，随着业务的扩展，您可以随时扩容磁盘、增加带宽。如果不再需要云服务器，也能随时释放资源，节省费用。
- [aliyun-net-sdk-ehpc](https://www.nuget.org/packages/aliyun-net-sdk-ehpc/)
- [aliyun-net-sdk-ess](https://www.nuget.org/packages/aliyun-net-sdk-ess/)
  - 弹性伸缩（Auto Scaling），是根据用户的业务需求和策略，经济地自动调整弹性计算资源的管理服务。弹性伸缩不仅适合业务量不断波动的应用程序， 同时也适合业务量稳定的应用程序。
- [aliyun-net-sdk-green](https://www.nuget.org/packages/aliyun-net-sdk-green/)
- [aliyun-net-sdk-hpc](https://www.nuget.org/packages/aliyun-net-sdk-hpc/)
  - HPC（High Performance Computing，高性能计算）通常指将计算能力积聚，用并行计算方式解决更大规模的科学，工程和商业问题。如今，高性能计算已在不知不觉中渗透到人类生活的方方面面。从材料科学到石油勘探、金融市场、应急管理、医学和互联网等领域，高性能计算无一不大显身手，帮助快速攻克各种疑难问题。
- [aliyun-net-sdk-hsm](https://www.nuget.org/packages/aliyun-net-sdk-hsm/)
- [aliyun-net-sdk-httpdns](https://www.nuget.org/packages/aliyun-net-sdk-httpdns/)
- [aliyun-net-sdk-imm](https://www.nuget.org/packages/aliyun-net-sdk-imm/)
- [aliyun-net-sdk-industry-brain](https://www.nuget.org/packages/aliyun-net-sdk-industry-brain/)
- [aliyun-net-sdk-iot](https://www.nuget.org/packages/aliyun-net-sdk-iot/)
- [aliyun-net-sdk-jarvis](https://www.nuget.org/packages/aliyun-net-sdk-jarvis/)
- [aliyun-net-sdk-kms](https://www.nuget.org/packages/aliyun-net-sdk-kms/)
- [aliyun-net-sdk-linkface](https://www.nuget.org/packages/aliyun-net-sdk-linkface/)
- [aliyun-net-sdk-live](https://www.nuget.org/packages/aliyun-net-sdk-live/)
- [aliyun-net-sdk-lubancloud](https://www.nuget.org/packages/aliyun-net-sdk-lubancloud/)
- [aliyun-net-sdk-mopen](https://www.nuget.org/packages/aliyun-net-sdk-mopen/)
- [aliyun-net-sdk-mts](https://www.nuget.org/packages/aliyun-net-sdk-mts/)
- [aliyun-net-sdk-nas](https://www.nuget.org/packages/aliyun-net-sdk-nas/)
  - 阿里云文件存储NAS是一个可共享访问，弹性扩展，高可靠，高性能的分布式文件系统。它基于 POSIX 文件接口，天然适配原生操作系统，提供共享访问，同时保证数据一致性和锁互斥
- [aliyun-net-sdk-ons](https://www.nuget.org/packages/aliyun-net-sdk-ons/)
- [aliyun-net-sdk-ots](https://www.nuget.org/packages/aliyun-net-sdk-ots/)
- [aliyun-net-sdk-push](https://www.nuget.org/packages/aliyun-net-sdk-push/)
- [aliyun-net-sdk-pvtz](https://www.nuget.org/packages/aliyun-net-sdk-pvtz/)
- [aliyun-net-sdk-ram](https://www.nuget.org/packages/aliyun-net-sdk-ram/)
- [aliyun-net-sdk-rds](https://www.nuget.org/packages/aliyun-net-sdk-rds/)
- [aliyun-net-sdk-r-kvstore](https://www.nuget.org/packages/aliyun-net-sdk-r-kvstore/)
- [aliyun-net-sdk-ros](https://www.nuget.org/packages/aliyun-net-sdk-ros/)
- [aliyun-net-sdk-ros](https://www.nuget.org/packages/aliyun-net-sdk-ros/)
- [aliyun-net-sdk-saf](https://www.nuget.org/packages/aliyun-net-sdk-saf/)
- [aliyun-net-sdk-sas-api](https://www.nuget.org/packages/aliyun-net-sdk-sas-api/)
- [aliyun-net-sdk-scdn](https://www.nuget.org/packages/aliyun-net-sdk-scdn/)
- [aliyun-net-sdk-slb](https://www.nuget.org/packages/aliyun-net-sdk-slb/)
- [aliyun-net-sdk-smartag](https://www.nuget.org/packages/aliyun-net-sdk-smartag/)
- [aliyun-net-sdk-sms](https://www.nuget.org/packages/aliyun-net-sdk-sms/)
- [aliyun-net-sdk-sts](https://www.nuget.org/packages/aliyun-net-sdk-sts/)
- [aliyun-net-sdk-tag-inner](https://www.nuget.org/packages/aliyun-net-sdk-tag-inner/)
- [aliyun-net-sdk-tesladam](https://www.nuget.org/packages/aliyun-net-sdk-tesladam/)
- [aliyun-net-sdk-teslamaxcompute](https://www.nuget.org/packages/aliyun-net-sdk-teslamaxcompute/)
- [aliyun-net-sdk-teslastream](https://www.nuget.org/packages/aliyun-net-sdk-teslastream/)
- [aliyun-net-sdk-vod](https://www.nuget.org/packages/aliyun-net-sdk-vod/)
- [aliyun-net-sdk-vpc](https://www.nuget.org/packages/aliyun-net-sdk-vpc/)



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
