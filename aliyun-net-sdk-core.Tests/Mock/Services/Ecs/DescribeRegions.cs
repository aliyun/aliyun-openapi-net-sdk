using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Tests.Mock.Services.Ecs
{
    public class DescribeRegionsRequest : RpcAcsRequest<DescribeRegionsResponse>
    {
        public DescribeRegionsRequest() : base("Ecs", "2014-05-26", "DescribeRegions", "ecs", "openAPI") { }

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private string acceptLanguage;

        private string action;

        private long? ownerId;

        private string instanceChargeType;

        private string resourceType;

        public long? ResourceOwnerId
        {
            get
            {
                return resourceOwnerId;
            }
            set
            {
                resourceOwnerId = value;
                DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
            }
        }

        public string ResourceOwnerAccount
        {
            get
            {
                return resourceOwnerAccount;
            }
            set
            {
                resourceOwnerAccount = value;
                DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
            }
        }

        public string OwnerAccount
        {
            get
            {
                return ownerAccount;
            }
            set
            {
                ownerAccount = value;
                DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
            }
        }

        public string AcceptLanguage
        {
            get
            {
                return acceptLanguage;
            }
            set
            {
                acceptLanguage = value;
                DictionaryUtil.Add(QueryParameters, "AcceptLanguage", value);
            }
        }

        public string Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
                DictionaryUtil.Add(QueryParameters, "Action", value);
            }
        }

        public long? OwnerId
        {
            get
            {
                return ownerId;
            }
            set
            {
                ownerId = value;
                DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
            }
        }

        public string InstanceChargeType
        {
            get
            {
                return instanceChargeType;
            }
            set
            {
                instanceChargeType = value;
                DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
            }
        }

        public string ResourceType
        {
            get
            {
                return resourceType;
            }
            set
            {
                resourceType = value;
                DictionaryUtil.Add(QueryParameters, "ResourceType", value);
            }
        }

        public override DescribeRegionsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeRegionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }

    }

    public class DescribeRegionsResponse : AcsResponse
    {

        private string requestId;

        private List<DescribeRegions_Region> regions;

        public new string RequestId
        {
            get
            {
                return requestId;
            }
            set
            {
                requestId = value;
            }
        }

        public List<DescribeRegions_Region> Regions
        {
            get
            {
                return regions;
            }
            set
            {
                regions = value;
            }
        }

        public class DescribeRegions_Region
        {

            private string regionId;

            private string localName;

            private string regionEndpoint;

            private string status;

            public string RegionId
            {
                get
                {
                    return regionId;
                }
                set
                {
                    regionId = value;
                }
            }

            public string LocalName
            {
                get
                {
                    return localName;
                }
                set
                {
                    localName = value;
                }
            }

            public string RegionEndpoint
            {
                get
                {
                    return regionEndpoint;
                }
                set
                {
                    regionEndpoint = value;
                }
            }

            public string Status
            {
                get
                {
                    return status;
                }
                set
                {
                    status = value;
                }
            }
        }
    }

    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

            describeRegionsResponse.HttpResponse = context.HttpResponse;
            describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");

            List<DescribeRegionsResponse.DescribeRegions_Region> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_Region>();
            for (int i = 0; i < context.Length("DescribeRegions.Regions.Length"); i++)
            {
                DescribeRegionsResponse.DescribeRegions_Region region = new DescribeRegionsResponse.DescribeRegions_Region();
                region.RegionId = context.StringValue("DescribeRegions.Regions[" + i + "].RegionId");
                region.LocalName = context.StringValue("DescribeRegions.Regions[" + i + "].LocalName");
                region.RegionEndpoint = context.StringValue("DescribeRegions.Regions[" + i + "].RegionEndpoint");
                region.Status = context.StringValue("DescribeRegions.Regions[" + i + "].Status");

                describeRegionsResponse_regions.Add(region);
            }
            describeRegionsResponse.Regions = describeRegionsResponse_regions;

            return describeRegionsResponse;
        }
    }
}
