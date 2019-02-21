using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Http;

namespace Aliyun.Acs.Core.Tests.Mock.Services.Ecs
{
    public class DescribeAccessPointsRequest : RpcAcsRequest<DescribeAccessPointsResponse>
    {
        public DescribeAccessPointsRequest() : base("Ecs", "2014-05-26", "DescribeAccessPoints", "ecs", "openAPI") { }

        private List<Filter> filters;

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private string regionId;

        private int? pageSize;

        private string action;

        private long? ownerId;

        private string type;

        private int? pageNumber;

        public List<Filter> Filters
        {
            get
            {
                return filters;
            }

            set
            {
                filters = value;
                for (int i = 0; i < filters.Count; i++)
                {
                    for (int j = 0; j < filters[i].Values.Count; j++)
                    {
                        DictionaryUtil.Add(QueryParameters, "Filter." + (i + 1) + ".Value." + (j + 1), filters[i].Values[j]);
                    }
                    DictionaryUtil.Add(QueryParameters, "Filter." + (i + 1) + ".Key", filters[i].Key);
                }
            }
        }

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

        public new string RegionId
        {
            get
            {
                return regionId;
            }
            set
            {
                regionId = value;
                DictionaryUtil.Add(QueryParameters, "RegionId", value);
            }
        }

        public int? PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = value;
                DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                DictionaryUtil.Add(QueryParameters, "Type", value);
            }
        }

        public int? PageNumber
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
                DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
            }
        }

        public class Filter
        {

            private List<string> values;

            private string key;

            public List<string> Values
            {
                get
                {
                    return values;
                }
                set
                {
                    values = value;
                }
            }

            public string Key
            {
                get
                {
                    return key;
                }
                set
                {
                    key = value;
                }
            }
        }

        public override DescribeAccessPointsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeAccessPointsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }

    }

    public class DescribeAccessPointsResponse : AcsResponse
    {

        private string requestId;

        private int? pageNumber;

        private int? pageSize;

        private int? totalCount;

        private List<DescribeAccessPoints_AccessPointType> accessPointSet;

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

        public int? PageNumber
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
            }
        }

        public int? PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = value;
            }
        }

        public int? TotalCount
        {
            get
            {
                return totalCount;
            }
            set
            {
                totalCount = value;
            }
        }

        public List<DescribeAccessPoints_AccessPointType> AccessPointSet
        {
            get
            {
                return accessPointSet;
            }
            set
            {
                accessPointSet = value;
            }
        }

        public class DescribeAccessPoints_AccessPointType
        {

            private string accessPointId;

            private string status;

            private string type;

            private string attachedRegionNo;

            private string location;

            private string hostOperator;

            private string name;

            private string description;

            public string AccessPointId
            {
                get
                {
                    return accessPointId;
                }
                set
                {
                    accessPointId = value;
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

            public string Type
            {
                get
                {
                    return type;
                }
                set
                {
                    type = value;
                }
            }

            public string AttachedRegionNo
            {
                get
                {
                    return attachedRegionNo;
                }
                set
                {
                    attachedRegionNo = value;
                }
            }

            public string Location
            {
                get
                {
                    return location;
                }
                set
                {
                    location = value;
                }
            }

            public string HostOperator
            {
                get
                {
                    return hostOperator;
                }
                set
                {
                    hostOperator = value;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public string Description
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            }
        }
    }

    public class DescribeAccessPointsResponseUnmarshaller
    {
        public static DescribeAccessPointsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeAccessPointsResponse describeAccessPointsResponse = new DescribeAccessPointsResponse();

            describeAccessPointsResponse.HttpResponse = context.HttpResponse;
            describeAccessPointsResponse.RequestId = context.StringValue("DescribeAccessPoints.RequestId");
            describeAccessPointsResponse.PageNumber = context.IntegerValue("DescribeAccessPoints.PageNumber");
            describeAccessPointsResponse.PageSize = context.IntegerValue("DescribeAccessPoints.PageSize");
            describeAccessPointsResponse.TotalCount = context.IntegerValue("DescribeAccessPoints.TotalCount");

            List<DescribeAccessPointsResponse.DescribeAccessPoints_AccessPointType> describeAccessPointsResponse_accessPointSet = new List<DescribeAccessPointsResponse.DescribeAccessPoints_AccessPointType>();
            for (int i = 0; i < context.Length("DescribeAccessPoints.AccessPointSet.Length"); i++)
            {
                DescribeAccessPointsResponse.DescribeAccessPoints_AccessPointType accessPointType = new DescribeAccessPointsResponse.DescribeAccessPoints_AccessPointType();
                accessPointType.AccessPointId = context.StringValue("DescribeAccessPoints.AccessPointSet[" + i + "].AccessPointId");
                accessPointType.Status = context.StringValue("DescribeAccessPoints.AccessPointSet[" + i + "].Status");
                accessPointType.Type = context.StringValue("DescribeAccessPoints.AccessPointSet[" + i + "].Type");
                accessPointType.AttachedRegionNo = context.StringValue("DescribeAccessPoints.AccessPointSet[" + i + "].AttachedRegionNo");
                accessPointType.Location = context.StringValue("DescribeAccessPoints.AccessPointSet[" + i + "].Location");
                accessPointType.HostOperator = context.StringValue("DescribeAccessPoints.AccessPointSet[" + i + "].HostOperator");
                accessPointType.Name = context.StringValue("DescribeAccessPoints.AccessPointSet[" + i + "].Name");
                accessPointType.Description = context.StringValue("DescribeAccessPoints.AccessPointSet[" + i + "].Description");

                describeAccessPointsResponse_accessPointSet.Add(accessPointType);
            }
            describeAccessPointsResponse.AccessPointSet = describeAccessPointsResponse_accessPointSet;

            return describeAccessPointsResponse;
        }
    }
}
