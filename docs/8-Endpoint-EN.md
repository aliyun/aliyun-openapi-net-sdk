[← Client](7-Client-CN.md) | Endpoint[(中文)](8-Endpoint-CN.md) | [Requirements →](0-Requirements-CN.md)
***

# Add Endpoint
Many times you will encounter an inability to find an Endpoint and you need to manually add an Endpoint.The format added is as follows:
```c#
//...
DefaultProfile.AddEndpoint("<endpointName>", "<regionId>", "<product>", "<domain>")
```

Let's add `Endpoint` manually by taking `dyvmsapi` as an example.
```c#
//...
DefaultProfile.AddEndpoint("cn-hangzhou", "cn-hangzhou", "Dyvmsapi", "dyvmsapi.aliyuncs.com");
```

***
[← Client](7-Client-CN.md) | Endpoint[(中文)](8-Endpoint-CN.md) | [Requirements →](0-Requirements-CN.md)
