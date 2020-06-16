[← Client & Credentials](7-Client-EN.md) | Endpoint[(中文)](8-Endpoint-CN.md) | [Requirements →](0-Requirements-EN.md)
***

# Endpoint
Many times you will encounter an inability to find an Endpoint and you need to manually set an Endpoint. The format added is as follows:
```c#
//...
IClientProfile profile = DefaultProfile.GetProfile("<regionId>", "<ACCESS_KEY_ID>", "<ACCESS_KEY_SECRET>");
// global
profile.AddEndpoint("<endpointName>", "<regionId>", "<product>", "<domain>");
IAcsClient client = new DefaultAcsClient(profile);
DescribeRegionsRequest regionsRequest = new DescribeRegionsRequest();
// Only valid in the current request
regionsRequest.SetEndpoint("<your endpoint>");

var request = new AddLiveAppRecordConfigRequest();
// Splicing rules set the network; parameter:share、 inner、 vpc、 public
regionsRequest.ProductNetwork = "public";

var response = client.GetAcsResponse(regionsRequest);
```

拼接规则方式需要产品端支持并符合规范方可使用。

***
[← Client & Credentials](7-Client-EN.md) | Endpoint[(中文)](8-Endpoint-CN.md) | [Requirements →](0-Requirements-EN.md)
