/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DescribeVSwitchesRequest : RpcAcsRequest<DescribeVSwitchesResponse>
    {
        public DescribeVSwitchesRequest()
            : base("Vpc", "2016-04-28", "DescribeVSwitches", "vpc", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private long? ownerId;

        private int? pageNumber;

        private string vSwitchId;

        private string resourceGroupId;

        private string regionId;

        private string vpcId;

        private string vSwitchName;

        private int? pageSize;

        private string action;

        private string zoneId;

        private List<Tag> tags;

        private bool? isDefault;

        private string routeTableId;

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

        public string VSwitchId
        {
            get
            {
                return vSwitchId;
            }
            set
            {
                vSwitchId = value;
                DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
            }
        }

        public string ResourceGroupId
        {
            get
            {
                return resourceGroupId;
            }
            set
            {
                resourceGroupId = value;
                DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
            }
        }

        public string RegionId
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

        public string VpcId
        {
            get
            {
                return vpcId;
            }
            set
            {
                vpcId = value;
                DictionaryUtil.Add(QueryParameters, "VpcId", value);
            }
        }

        public string VSwitchName
        {
            get
            {
                return vSwitchName;
            }
            set
            {
                vSwitchName = value;
                DictionaryUtil.Add(QueryParameters, "VSwitchName", value);
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

        public string ZoneId
        {
            get
            {
                return zoneId;
            }
            set
            {
                zoneId = value;
                DictionaryUtil.Add(QueryParameters, "ZoneId", value);
            }
        }

        public List<Tag> Tags
        {
            get
            {
                return tags;
            }

            set
            {
                tags = value;
                for (int i = 0; i < tags.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "Tag." + (i + 1) + ".Value", tags[i].Value);
                    DictionaryUtil.Add(QueryParameters, "Tag." + (i + 1) + ".Key", tags[i].Key);
                }
            }
        }

        public bool? IsDefault
        {
            get
            {
                return isDefault;
            }
            set
            {
                isDefault = value;
                DictionaryUtil.Add(QueryParameters, "IsDefault", value.ToString());
            }
        }

        public string RouteTableId
        {
            get
            {
                return routeTableId;
            }
            set
            {
                routeTableId = value;
                DictionaryUtil.Add(QueryParameters, "RouteTableId", value);
            }
        }

        public class Tag
        {

            private string value_;

            private string key;

            public string Value
            {
                get
                {
                    return value_;
                }
                set
                {
                    value_ = value;
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

        public override DescribeVSwitchesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeVSwitchesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}