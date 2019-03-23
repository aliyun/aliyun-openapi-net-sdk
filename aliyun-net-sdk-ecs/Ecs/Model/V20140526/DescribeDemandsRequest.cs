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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeDemandsRequest : RpcAcsRequest<DescribeDemandsResponse>
    {
        public DescribeDemandsRequest()
            : base("Ecs", "2014-05-26", "DescribeDemands", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private int? pageNumber;

        private string regionId;

        private int? pageSize;

        private string action;

        private string instanceType;

        private List<Tag> tags;

        private string instanceChargeType;

        private bool? dryRun;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private string instanceTypeFamily;

        private long? ownerId;

        private List<string> demandStatuss;

        private string zoneId;

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

        public string InstanceType
        {
            get
            {
                return instanceType;
            }
            set
            {
                instanceType = value;
                DictionaryUtil.Add(QueryParameters, "InstanceType", value);
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
                    DictionaryUtil.Add(QueryParameters, "Tag." + (i + 1) + ".Key", tags[i].Key);
                    DictionaryUtil.Add(QueryParameters, "Tag." + (i + 1) + ".Value", tags[i].Value);
                }
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

        public bool? DryRun
        {
            get
            {
                return dryRun;
            }
            set
            {
                dryRun = value;
                DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

        public string InstanceTypeFamily
        {
            get
            {
                return instanceTypeFamily;
            }
            set
            {
                instanceTypeFamily = value;
                DictionaryUtil.Add(QueryParameters, "InstanceTypeFamily", value);
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

        public List<string> DemandStatuss
        {
            get
            {
                return demandStatuss;
            }

            set
            {
                demandStatuss = value;
                for (int i = 0; i < demandStatuss.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "DemandStatus." + (i + 1), demandStatuss[i]);
                }
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

        public class Tag
        {

            private string key;

            private string value_;

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
        }

        public override DescribeDemandsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeDemandsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}