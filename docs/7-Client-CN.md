[← 日志](6-Log-CN.md) | 客户端[(English)](7-Client-EN.md) | [Endpoint →](8-Endpoint-CN.md)
***

# 使用 AccessKey 调用
```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Ecs.Model.V20140526;

class Program
{
    static void Main(string[] args)
    {
        // 构建一个 Client，用于发起请求
        IClientProfile profile = DefaultProfile.GetProfile(
            "<your-region-id>",
            "<your-access-key-id>",
            "<your-access-key-secret>");
        DefaultAcsClient client = new DefaultAcsClient(profile);

        try
        {
            // 构造请求
            DescribeInstancesRequest request = new DescribeInstancesRequest();
            request.PageSize = 10;

            // 发起请求，并得到 Response
            DescribeInstancesResponse response = client.GetAcsResponse(request);
            System.Console.WriteLine(response.TotalCount);
        }
        catch (ServerException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
        catch (ClientException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }
}
```

# 使用默认凭证提供链
默认凭证提供程序链查找可用的凭证，寻找顺序如下：

## 1. 环境凭证
在环境变量里寻找环境凭证，如果定义了 `ALIBABA_CLOUD_ACCESS_KEY_ID` 和 `ALIBABA_CLOUD_ACCESS_KEY_SECRET` 环境变量且不为空，程序将使用它们创建默认凭证。

## 2. 配置文件
如果用户主目录存在默认文件 `~/.alibabacloud/credentials （Windows 为 C:\Users\USER_NAME\.alibabacloud\credentials）`，程序会自动创建指定类型和名称的凭证。默认文件可以不存在，但解析错误会抛出异常。配置名小写。不同的项目、工具之间可以共用这个配置文件，因为不在项目之内，也不会被意外提交到版本控制。
可以通过定义 `ALIBABA_CLOUD_CREDENTIALS_FILE` 环境变量修改默认文件的路径。不配置则使用默认配置 `default`，也可以设置环境变量 `ALIBABA_CLOUD_PROFILE` 使用配置。 

```ini
[default]                          # 默认配置
enable = true                      # 启用，没有该选项默认不启用
type = access_key                  # 认证方式为 access_key
access_key_id = foo                # Key
access_key_secret = bar            # Secret

[client1]                          # 命名为 `client1` 的配置
type = ecs_ram_role                # 认证方式为 ecs_ram_role
role_name = EcsRamRoleTest         # Role Name

[client2]                          # 命名为 `client2` 的配置
enable = false                     # 不启用
type = ram_role_arn                # 认证方式为 ram_role_arn
region_id = cn-test                # 获取session用的region
policy = test                      # 选填 指定权限
access_key_id = foo
access_key_secret = bar
role_arn = role_arn
role_session_name = session_name   # 选填

[client3]                          # 命名为 `client4` 的配置
type = rsa_key_pair                # 认证方式为 rsa_key_pair
public_key_id = publicKeyId        # Public Key ID
private_key_file = /your/pk.pem    # Private Key 文件
```

## 3. 实例 RAM 角色
如果定义了环境变量 `ALIBABA_CLOUD_ECS_METADATA` 且不为空，程序会将该环境变量的值作为角色名称，请求 <http://100.100.100.200/latest/meta-data/ram/security-credentials/> 获取临时安全凭证。

# 使用 Bearertoken 调用 [CCC](https://www.nuget.org/packages/aliyun-net-sdk-ccc/) 产品

```csharp
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.CCC.Model.V20170705;

class Program
{
    static void Main(string[] args)
    {
        // 构建一个 Client，用于发起请求
        var profile = DefaultProfile.GetProfile("<your-region-id>");
        var bearerTokenCredentialProvider = new BearerTokenCredentialProvider("<your-bearertoken>");

        var client = new DefaultAcsClient(profile, bearerTokenCredentialProvider);

        try
        {
            // 构造请求
            var request = new ListPhoneNumbersRequest();

            // 发起请求，并得到 Response
            var response = client.GetAcsResponse(request);

            // Do something as you want below
        }
        catch (ServerException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
        catch (ClientException ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }
}
```

***
[← 日志](6-Log-CN.md) | 客户端[(English)](7-Client-EN.md) | [Endpoint →](8-Endpoint-CN.md)