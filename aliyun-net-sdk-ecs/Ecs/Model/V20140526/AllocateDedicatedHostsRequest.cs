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
    public class AllocateDedicatedHostsRequest : RpcAcsRequest<AllocateDedicatedHostsResponse>
    {
        public AllocateDedicatedHostsRequest()
            : base("Ecs", "2014-05-26", "AllocateDedicatedHosts", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string clientToken;

        private string description;

        private string resourceGroupId;

        private string regionId;

        private string actionOnMaintenance;

        private string action;

        private List<Tag> tags;

        private string dedicatedHostType;

        private int? autoRenewPeriod;

        private int? period;

        private int? quantity;

        private string dedicatedHostName;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private string autoReleaseTime;

        private long? ownerId;

        private string periodUnit;

        private bool? autoRenew;

        private int? networkAttributesSlbUdpTimeout;

        private string zoneId;

        private string chargeType;

        private int? networkAttributesUdpTimeout;

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

        public string ClientToken
        {
            get
            {
                return clientToken;
            }
            set
            {
                clientToken = value;
                DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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
                DictionaryUtil.Add(QueryParameters, "Description", value);
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

        public string ActionOnMaintenance
        {
            get
            {
                return actionOnMaintenance;
            }
            set
            {
                actionOnMaintenance = value;
                DictionaryUtil.Add(QueryParameters, "ActionOnMaintenance", value);
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

        public string DedicatedHostType
        {
            get
            {
                return dedicatedHostType;
            }
            set
            {
                dedicatedHostType = value;
                DictionaryUtil.Add(QueryParameters, "DedicatedHostType", value);
            }
        }

        public int? AutoRenewPeriod
        {
            get
            {
                return autoRenewPeriod;
            }
            set
            {
                autoRenewPeriod = value;
                DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
            }
        }

        public int? Period
        {
            get
            {
                return period;
            }
            set
            {
                period = value;
                DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
            }
        }

        public int? Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                DictionaryUtil.Add(QueryParameters, "Quantity", value.ToString());
            }
        }

        public string DedicatedHostName
        {
            get
            {
                return dedicatedHostName;
            }
            set
            {
                dedicatedHostName = value;
                DictionaryUtil.Add(QueryParameters, "DedicatedHostName", value);
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

        public string AutoReleaseTime
        {
            get
            {
                return autoReleaseTime;
            }
            set
            {
                autoReleaseTime = value;
                DictionaryUtil.Add(QueryParameters, "AutoReleaseTime", value);
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

        public string PeriodUnit
        {
            get
            {
                return periodUnit;
            }
            set
            {
                periodUnit = value;
                DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
            }
        }

        public bool? AutoRenew
        {
            get
            {
                return autoRenew;
            }
            set
            {
                autoRenew = value;
                DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
            }
        }

        public int? NetworkAttributesSlbUdpTimeout
        {
            get
            {
                return networkAttributesSlbUdpTimeout;
            }
            set
            {
                networkAttributesSlbUdpTimeout = value;
                DictionaryUtil.Add(QueryParameters, "NetworkAttributes.SlbUdpTimeout", value.ToString());
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

        public string ChargeType
        {
            get
            {
                return chargeType;
            }
            set
            {
                chargeType = value;
                DictionaryUtil.Add(QueryParameters, "ChargeType", value);
            }
        }

        public int? NetworkAttributesUdpTimeout
        {
            get
            {
                return networkAttributesUdpTimeout;
            }
            set
            {
                networkAttributesUdpTimeout = value;
                DictionaryUtil.Add(QueryParameters, "NetworkAttributes.UdpTimeout", value.ToString());
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

        public override AllocateDedicatedHostsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AllocateDedicatedHostsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}