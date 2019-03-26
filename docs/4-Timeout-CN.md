[← 代理](3-Proxy-CN.md) | 超时[(English)](4-Timeout-EN.md) | [产品Nuget包 →](5-Packages-CN.md)
***

# 超时设置
* Connect Time 是指 SDK 端到服务端的 TCP 连接建立时间；

* Read Time 是指连接建立之后，SDK 发送请求（request）到接受到响应完成（response end）的时间；
  
**优先级：** Request 设置 -> Client 设置 -> 默认设置，优先级依次递减。

默认Connect Timeout 为 5 秒，默认 Read Timeout 为 10 秒。

```csharp
IClientProfile profile = DefaultProfile.GetProfile(
            "<your-region-id>",
            "<your-access-key-id>",
            "<your-access-key-secret>");

// Client 级别的超时设置，对当前所有 request 有效
DefaultAcsClient client = new DefaultAcsClient();
client.SetConnectTimeoutInMilliSeconds(1024);
client.SetReadTimeoutInMilliSeconds(2048);

// Request 级别的超时设置 以 ECS 的 DescribeInstancesRequest 为例，仅对当前 request请求有效
DescribeInstancesRequest request = new DescribeInstancesRequest();
request.SetConnectTimeoutInMilliSeconds(1024);
request.SetReadTimeoutInMilliSeconds(2048);
```

***
[← 代理](3-Proxy-CN.md) | 超时[(English)](4-Timeout-EN.md) | [产品Nuget包 →](5-Packages-CN.md)
