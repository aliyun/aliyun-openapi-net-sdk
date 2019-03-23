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
    public class DescribeIpv6EgressOnlyRulesRequest : RpcAcsRequest<DescribeIpv6EgressOnlyRulesResponse>
    {
        public DescribeIpv6EgressOnlyRulesRequest()
            : base("Vpc", "2016-04-28", "DescribeIpv6EgressOnlyRules", "vpc", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private int? pageNumber;

        private string ipv6EgressOnlyRuleId;

        private string regionId;

        private int? pageSize;

        private string instanceType;

        private string action;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private long? ownerId;

        private string instanceId;

        private string ipv6GatewayId;

        private string name;

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

        public string Ipv6EgressOnlyRuleId
        {
            get
            {
                return ipv6EgressOnlyRuleId;
            }
            set
            {
                ipv6EgressOnlyRuleId = value;
                DictionaryUtil.Add(QueryParameters, "Ipv6EgressOnlyRuleId", value);
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

        public string InstanceId
        {
            get
            {
                return instanceId;
            }
            set
            {
                instanceId = value;
                DictionaryUtil.Add(QueryParameters, "InstanceId", value);
            }
        }

        public string Ipv6GatewayId
        {
            get
            {
                return ipv6GatewayId;
            }
            set
            {
                ipv6GatewayId = value;
                DictionaryUtil.Add(QueryParameters, "Ipv6GatewayId", value);
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
                DictionaryUtil.Add(QueryParameters, "Name", value);
            }
        }

        public override DescribeIpv6EgressOnlyRulesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeIpv6EgressOnlyRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}