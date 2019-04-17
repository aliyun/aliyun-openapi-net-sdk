[← 客户端](7-Client-CN.md) | Endpoint[(English)](8-Endpoint-EN.md) | [环境要求 →](0-Requirements-CN.md)
***

# 添加 Endpoint
很多时候会遇到无法找到 Endpoint，需要手动添加 Endpoint 的情况。
添加的格式如下：
```c#
//...
DefaultProfile.AddEndpoint("<endpointName>", "<regionId>", "<product>", "<domain>")
```

下面以 `dyvmsapi` 为例 手动添加 `Endpoint`
```c#
//...
DefaultProfile.AddEndpoint("cn-hangzhou", "cn-hangzhou", "Dyvmsapi", "dyvmsapi.aliyuncs.com");
```

***
[← 客户端](7-Client-CN.md) | Endpoint[(English)](8-Endpoint-EN.md) | [环境要求 →](0-Requirements-CN.md)
