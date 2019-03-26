[← Proxy](3-Proxy-EN.md) | Timeout[(中文)](4-Timeout-CN.md) | [Packages →](5-Packages-EN.md)
***

# Timeout
* Connect Time refers to the TCP connection establishment time from the SDK side to the server side;
* Read Time refers to the time after the connection is established, the SDK sends a request (request) to the completion of the response end (response end);
  
**Priority:** Request Settings -> Client Settings -> Default Settings, the priority is decremented.

The default Connect Timeout is 5 seconds and the default Read Timeout is 10 seconds.

```csharp
IClientProfile profile = DefaultProfile.GetProfile(
            "<your-region-id>",
            "<your-access-key-id>",
            "<your-access-key-secret>");

// Client level timeout setting, valid for all current requests
DefaultAcsClient client = new DefaultAcsClient(profile);
client.SetConnectTimeoutInMilliSeconds(1024);
client.SetReadTimeoutInMilliSeconds(2048);

// Request level timeout setting Take ECS DescribeInstancesRequest as an example, only valid for current request request
DescribeInstancesRequest request = new DescribeInstancesRequest();
request.SetConnectTimeoutInMilliSeconds(1024);
request.SetReadTimeoutInMilliSeconds(2048);
```

***
[← Proxy](3-Proxy-EN.md) | Timeout[(中文)](4-Timeout-CN.md) | [Packages →](5-Packages-EN.md)
