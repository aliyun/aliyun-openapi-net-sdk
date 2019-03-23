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
    public class CreateNatGatewayRequest : RpcAcsRequest<CreateNatGatewayResponse>
    {
        public CreateNatGatewayRequest()
            : base("Ecs", "2014-05-26", "CreateNatGateway", "ecs", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private string regionId;

        private string clientToken;

        private string ownerAccount;

        private string vpcId;

        private string name;

        private string action;

        private string description;

        private long? ownerId;

        private List<BandwidthPackage> bandwidthPackages;

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

        public List<BandwidthPackage> BandwidthPackages
        {
            get
            {
                return bandwidthPackages;
            }

            set
            {
                bandwidthPackages = value;
                for (int i = 0; i < bandwidthPackages.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "BandwidthPackage." + (i + 1) + ".Bandwidth", bandwidthPackages[i].Bandwidth);
                    DictionaryUtil.Add(QueryParameters, "BandwidthPackage." + (i + 1) + ".Zone", bandwidthPackages[i].Zone);
                    DictionaryUtil.Add(QueryParameters, "BandwidthPackage." + (i + 1) + ".IpCount", bandwidthPackages[i].IpCount);
                }
            }
        }

        public class BandwidthPackage
        {

            private int? bandwidth;

            private string zone;

            private int? ipCount;

            public int? Bandwidth
            {
                get
                {
                    return bandwidth;
                }
                set
                {
                    bandwidth = value;
                }
            }

            public string Zone
            {
                get
                {
                    return zone;
                }
                set
                {
                    zone = value;
                }
            }

            public int? IpCount
            {
                get
                {
                    return ipCount;
                }
                set
                {
                    ipCount = value;
                }
            }
        }

        public override CreateNatGatewayResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateNatGatewayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}