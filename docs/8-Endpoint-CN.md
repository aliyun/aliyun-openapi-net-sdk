[← 客户端与凭证](7-Client-CN.md) | Endpoint[(English)](8-Endpoint-EN.md) | [环境要求 →](0-Requirements-CN.md)
***

# Endpoint
很多时候会遇到无法找到 Endpoint，需要手动设置 Endpoint 的情况。
添加的格式如下：
```c#
//...
IClientProfile profile = DefaultProfile.GetProfile("<regionId>", "<ACCESS_KEY_ID>", "<ACCESS_KEY_SECRET>");
// 全局生效
profile.AddEndpoint("<endpointName>", "<regionId>", "<product>", "<domain>");
IAcsClient client = new DefaultAcsClient(profile);
DescribeRegionsRequest regionsRequest = new DescribeRegionsRequest();
// 只对当前request生效
regionsRequest.SetEndpoint("<your endpoint>");

var request = new AddLiveAppRecordConfigRequest();
// 拼接规则设置网络,参数：share、 inner、 vpc、 public
regionsRequest.ProductNetwork = "public";

var response = client.GetAcsResponse(regionsRequest);
```

拼接规则方式需要产品端支持并符合规范方可使用。

***
[← 客户端与凭证](7-Client-CN.md) | Endpoint[(English)](8-Endpoint-EN.md) | [环境要求 →](0-Requirements-CN.md)
