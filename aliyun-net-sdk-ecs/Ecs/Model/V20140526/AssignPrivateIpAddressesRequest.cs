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
    public class AssignPrivateIpAddressesRequest : RpcAcsRequest<AssignPrivateIpAddressesResponse>
    {
        public AssignPrivateIpAddressesRequest()
            : base("Ecs", "2014-05-26", "AssignPrivateIpAddresses", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private int? secondaryPrivateIpAddressCount;

        private string regionId;

        private string action;

        private string resourceOwnerAccount;

        private string ownerAccount;

        private long? ownerId;

        private List<string> privateIpAddresss;

        private string networkInterfaceId;

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

        public int? SecondaryPrivateIpAddressCount
        {
            get
            {
                return secondaryPrivateIpAddressCount;
            }
            set
            {
                secondaryPrivateIpAddressCount = value;
                DictionaryUtil.Add(QueryParameters, "SecondaryPrivateIpAddressCount", value.ToString());
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

        public List<string> PrivateIpAddresss
        {
            get
            {
                return privateIpAddresss;
            }

            set
            {
                privateIpAddresss = value;
                for (int i = 0; i < privateIpAddresss.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "PrivateIpAddress." + (i + 1), privateIpAddresss[i]);
                }
            }
        }

        public string NetworkInterfaceId
        {
            get
            {
                return networkInterfaceId;
            }
            set
            {
                networkInterfaceId = value;
                DictionaryUtil.Add(QueryParameters, "NetworkInterfaceId", value);
            }
        }

        public override AssignPrivateIpAddressesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AssignPrivateIpAddressesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}