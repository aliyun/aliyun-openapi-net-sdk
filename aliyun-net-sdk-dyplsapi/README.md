## Demo

``` c#
using System;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Dyplsapi.Model.V20170525;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultProfile.AddEndpoint("cn-hangzhou", "cn-hangzhou", "Dyplsapi", "dyplsapi.aliyuncs.com"); //*Must
            
            IClientProfile profile = DefaultProfile.GetProfile(
                "cn-hangzhou", 
                <your-access-key-id>, 
                <your-access-key-secret>
            );
            DefaultAcsClient client = new DefaultAcsClient(profile);
            
            QuerySubscriptionDetailRequest request = new QuerySubscriptionDetailRequest();
            try
            {
                QuerySubscriptionDetailResponse response = client.GetAcsResponse(request);
                Console.WriteLine(System.Text.Encoding.Default.GetString(response.HttpResponse.Content));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
```
