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
    public class ModifyDedicatedHostAutoRenewAttributeRequest : RpcAcsRequest<ModifyDedicatedHostAutoRenewAttributeResponse>
    {
        public ModifyDedicatedHostAutoRenewAttributeRequest()
            : base("Ecs", "2014-05-26", "ModifyDedicatedHostAutoRenewAttribute", "ecs", "openAPI")
        {
        }

        private int? duration;

        private string dedicatedHostIds;

        private long? resourceOwnerId;

        private string periodUnit;

        private bool? autoRenew;

        private string resourceOwnerAccount;

        private string regionId;

        private string ownerAccount;

        private string renewalStatus;

        private string action;

        private long? ownerId;

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

        public string DedicatedHostIds
        {
            get
            {
                return dedicatedHostIds;
            }
            set
            {
                dedicatedHostIds = value;
                DictionaryUtil.Add(QueryParameters, "DedicatedHostIds", value);
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

        public string RenewalStatus
        {
            get
            {
                return renewalStatus;
            }
            set
            {
                renewalStatus = value;
                DictionaryUtil.Add(QueryParameters, "RenewalStatus", value);
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

        public override ModifyDedicatedHostAutoRenewAttributeResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyDedicatedHostAutoRenewAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}