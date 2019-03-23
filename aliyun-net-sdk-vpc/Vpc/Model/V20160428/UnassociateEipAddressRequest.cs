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
    public class UnassociateEipAddressRequest : RpcAcsRequest<UnassociateEipAddressResponse>
    {
        public UnassociateEipAddressRequest()
            : base("Vpc", "2016-04-28", "UnassociateEipAddress", "vpc", "openAPI")
        {
        }

        private string privateIpAddress;

        private long? resourceOwnerId;

        private string instanceId;

        private string resourceOwnerAccount;

        private string regionId;

        private string ownerAccount;

        private string action;

        private string instanceType;

        private bool? force;

        private string allocationId;

        private long? ownerId;

        public string PrivateIpAddress
        {
            get
            {
                return privateIpAddress;
            }
            set
            {
                privateIpAddress = value;
                DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
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

        public bool? Force
        {
            get
            {
                return force;
            }
            set
            {
                force = value;
                DictionaryUtil.Add(QueryParameters, "Force", value.ToString());
            }
        }

        public string AllocationId
        {
            get
            {
                return allocationId;
            }
            set
            {
                allocationId = value;
                DictionaryUtil.Add(QueryParameters, "AllocationId", value);
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

        public override UnassociateEipAddressResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UnassociateEipAddressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}