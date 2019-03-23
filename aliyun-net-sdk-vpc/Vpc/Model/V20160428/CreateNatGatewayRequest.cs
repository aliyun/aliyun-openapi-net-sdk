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
    public class CreateNatGatewayRequest : RpcAcsRequest<CreateNatGatewayResponse>
    {
        public CreateNatGatewayRequest()
            : base("Vpc", "2016-04-28", "CreateNatGateway", "vpc", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private bool? autoPay;

        private string resourceOwnerAccount;

        private string clientToken;

        private string ownerAccount;

        private string description;

        private long? ownerId;

        private string spec;

        private string duration;

        private string regionId;

        private string vpcId;

        private string name;

        private string action;

        private List<BandwidthPackage> bandwidthPackages;

        private string instanceChargeType;

        private string pricingCycle;

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

        public string Spec
        {
            get
            {
                return spec;
            }
            set
            {
                spec = value;
                DictionaryUtil.Add(QueryParameters, "Spec", value);
            }
        }

        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
                DictionaryUtil.Add(QueryParameters, "Duration", value);
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
                    DictionaryUtil.Add(QueryParameters, "BandwidthPackage." + (i + 1) + ".InternetChargeType", bandwidthPackages[i].InternetChargeType);
                    DictionaryUtil.Add(QueryParameters, "BandwidthPackage." + (i + 1) + ".ISP", bandwidthPackages[i].ISP);
                    DictionaryUtil.Add(QueryParameters, "BandwidthPackage." + (i + 1) + ".IpCount", bandwidthPackages[i].IpCount);
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

        public class BandwidthPackage
        {

            private int? bandwidth;

            private string zone;

            private string internetChargeType;

            private string iSP;

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

            public string InternetChargeType
            {
                get
                {
                    return internetChargeType;
                }
                set
                {
                    internetChargeType = value;
                }
            }

            public string ISP
            {
                get
                {
                    return iSP;
                }
                set
                {
                    iSP = value;
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