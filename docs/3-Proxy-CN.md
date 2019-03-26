[← 调试](2-Test-EN.md) | 代理[(English)](3-Proxy-EN.md) | [超时 →](4-Timeout-CN.md)
***

# HTTP 代理

如果您想使用 http，https 代理或者代理白名单，您可以设置环境变量 HTTP_PROXY ，HTTPS_PROXY 和 NO_PROXY，或者您也可以通过客户端来配置。

```csharp
//客户端优先级高于环境变量

//设置 http 代理
client.SetHttpProxy("http://localhost.com");
//获取 http 代理
client.GetHttpProxy();

//设置 https 代理
client.SetHttpsProxy("https://localhost.com");
client.SetHttpsProxy("http://username:password@localhost.com:10");
//获取 https 代理
client.GetHttpsProxy();

//设置代理白名单
client.SetNoProxy("localhost.com,localtest.com");
//获取代理白名单
client.GetNoProxy();
```

***
[← 调试](2-Test-CN.md) | 代理[(English)](3-Proxy-EN.md) | [超时 →](4-Timeout-CN.md)
