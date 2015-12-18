## Welcome to Aliyun SDK

Aliyun SDK 2.0 aimed to provide a unified and full stack SDK solution for you to build applications on aliyun.

(新版的阿里云SDK，提供一套统一的、全产品的阿里云API编程套件，方便开发者快速的在阿里云上搭建自己的应用。)

### Requirements
- framework 2.0+

### License

licensed under the [Apache License 2.0](https://www.apache.org/licenses/

### How to insall (如何获得SDK) ###
We provide different installing ways for different programming language.（不同的语言有不同的下载和安装方式)：

**Download Source Codes(下载源代码)**

- Download Source Codes（下载C# SDK的源代码）：[https://github.com/aliyun/aliyun-openapi-net-sdk](https://github.com/aliyun/aliyun-openapi-net-sdk "https://github.com/aliyun/aliyun-openapi-net-sdk")

**Installation steps(安装步骤)**

- 1.从[源码下载链接](https://github.com/aliyun/aliyun-openapi-net-sdk "源码下载链接")下载相应产品C# SDK的源代码，并编译成为.dll文件；


- 2.在你的Visual Studio项目上右键点击 -> 添加引用 -> 浏览（如果你用的是MonoDevelop，请自行按照相应导入dll的方法导入这个.dll文件）；


- 3.选择上述的.dll文件，点击“确定”按钮，经过以上步骤，你就可以在工程中使用阿里云C# SDK了。
	    

### Initialization AliyunClient（初始化AliyunClient） ###

	
    private static string serverUrl = "<serverUrl>";//http://slb.aliyuncs.com/
    private static string accessKeyId = "<accessKeyId>";
    private static string accessKeySecret = "<accessKeySecret>";

    private static IAliyunClient client = new DefaultAliyunClient(serverUrl, accessKeyId, accessKeySecret);
        

### A simple c# request（一个简单的API调用示例） ###

	public static void CreateLoadBalancer(){
        CreateLoadBalancerRequest request = new CreateLoadBalancerRequest();
        request.RegionId = "<RegionId>";
        request.AddressType = "<AddressType>";
        request.Bandwidth = <Bandwidth>
        request.InternetChargeType = "<InternetChargeType>";

        try
        {
                CreateLoadBalancerResponse response = client.Execute(request);
                if (string.IsNullOrEmpty(response.Code))
                {
                String loadBlancerId = response.LoadBalancerId;
                }
                else
                {
                String errorCode = response.Code;
                String message = response.Message;
                }
        }
        catch (Exception e)
        {
                //TODO: handle exception
        }
    }


### Usage Tips (使用提示) ###

- Classes retated to Aliyun SDK are under namespace Aliyun.Api.
(与阿里云SDK相关的类都在名称空间Aliyun.Api下)
- AliyunClient is an interface, interact with the Open API, SDK operations are done through IAliyunClient.
(AliyunClient 是与 Open API 交互的接口，SDK 的操作都是通过 IAliyunClient 完成的；)
- AliyunClient can be reused, it is recommended to set a globally unique AliyunClient.;
（AliyunClient 可以复用，建议设置成应用程序全局唯一的；）
- Users can invoke method SetTimeout to set timeout of SDK call.
(用户可以调用 SetTimeout 方法来设置SDK调用接口的连接超时时间。)

### Namespace (命名空间) ###

- Request(请求类名称空间)：Aliyun.Api.[PPP].[PPP][yyyymmdd].Request
- Response(响应类命名空间)：Aliyun.Api.[PPP].[PPP][yyyymmdd].Response
- [PPP] stands for uppercase acronym of product name.([PPP]为产品名称缩写大写；)
- [yyyymmdd] stands for the version of API.([yyyymmdd]为API版本号)
- Examples:
Request(请求类名称空间)：Aliyun.Api.SLB.SLB20140515.Request
Response(响应类命名空间)：Aliyun.Api.SLB.SLB20140515.Response

