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
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class ModifyLoadBalancerPayTypeRequest : RpcAcsRequest<ModifyLoadBalancerPayTypeResponse>
    {
        public ModifyLoadBalancerPayTypeRequest()
            : base("Slb", "2014-05-15", "ModifyLoadBalancerPayType", "slb", "openAPI")
        {
        }

        private string access_key_id;

        private long? resourceOwnerId;

        private bool? autoPay;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private long? ownerId;

        private string tags;

        private int? duration;

        private string loadBalancerId;

        private string regionId;

        private string action;

        private string payType;

        private string pricingCycle;

        public string Access_key_id
        {
            get
            {
                return access_key_id;
            }
            set
            {
                access_key_id = value;
                DictionaryUtil.Add(QueryParameters, "access_key_id", value);
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

        public bool? AutoPay
        {
            get
            {
                return autoPay;
            }
            set
            {
                autoPay = value;
                DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
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

        public string Tags
        {
            get
            {
                return tags;
            }
            set
            {
                tags = value;
                DictionaryUtil.Add(QueryParameters, "Tags", value);
            }
        }

        public int? Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
                DictionaryUtil.Add(QueryParameters, "Duration", value.ToString());
            }
        }

        public string LoadBalancerId
        {
            get
            {
                return loadBalancerId;
            }
            set
            {
                loadBalancerId = value;
                DictionaryUtil.Add(QueryParameters, "LoadBalancerId", value);
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

        public string PayType
        {
            get
            {
                return payType;
            }
            set
            {
                payType = value;
                DictionaryUtil.Add(QueryParameters, "PayType", value);
            }
        }

        public string PricingCycle
        {
            get
            {
                return pricingCycle;
            }
            set
            {
                pricingCycle = value;
                DictionaryUtil.Add(QueryParameters, "PricingCycle", value);
            }
        }

        public override ModifyLoadBalancerPayTypeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyLoadBalancerPayTypeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}