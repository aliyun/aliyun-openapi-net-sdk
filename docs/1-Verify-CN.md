[← 环境要求](0-Requirements-CN.md) | SSL 验证[(English)](1-Verify-EN.md) | [调试 →](2-Debug-CN.md)
***

# 忽略HTTPS证书校验

当您想要在客户端关掉 HTTPS 证书的校验时，你可以在 Client 或 Request 级别进行设置

```c#
// client级别的证书忽略校验
client.SetHttpsInsecure(true);

// request级别的证书忽略校验
request.SetHttpsInsecure(true);
```

***
[← 环境要求](0-Requirements-CN.md) | SSL 验证[(English)](1-Verify-EN.md) | [调试 →](2-Debug-CN.md)
