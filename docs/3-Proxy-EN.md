[← Debug](2-Debug-EN.md) | Proxy[(中文)](3-Proxy-CN.md) | [Timeout →](4-Timeout-EN.md)
***

# Http Proxy
If you want to use the http, https proxy or proxy whitelist, you can set the environment variables HTTP_PROXY , HTTPS_PROXY and NO_PROXY , or you can configure them via the client.

```c#
// Client priority is higher than environment variable

// Set up the http proxy
client.SetHttpProxy("http://localhost.com");
// Get http proxy
client.GetHttpProxy();

// Set up the https proxy
client.SetHttpsProxy("https://localhost.com");
client.SetHttpsProxy("http://username:password@localhost.com:10");
// Get https proxy
client.GetHttpsProxy();

// Set proxy whitelist
client.SetNoProxy("localhost.com,localtest.com");
// Get the agent white list
client.GetNoProxy();
```

***
[← Debug](2-Debug-EN.md) | Proxy[(中文)](3-Proxy-CN.md) | [Timeout →](4-Timeout-EN.md)
