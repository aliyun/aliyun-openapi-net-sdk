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
    public class CreateCommonBandwidthPackageRequest : RpcAcsRequest<CreateCommonBandwidthPackageResponse>
    {
        public CreateCommonBandwidthPackageRequest()
            : base("Vpc", "2016-04-28", "CreateCommonBandwidthPackage", "vpc", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private string resourceOwnerAccount;

        private string clientToken;

        private int? bandwidth;

        private string ownerAccount;

        private string iSP;

        private string description;

        private long? ownerId;

        private string resourceGroupId;

        private string regionId;

        private string zone;

        private string internetChargeType;

        private string name;

        private string action;

        private int? ratio;

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

        public int? Bandwidth
        {
            get
            {
                return bandwidth;
            }
            set
            {
                bandwidth = value;
                DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
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

        public string ISP
        {
            get
            {
                return iSP;
            }
            set
            {
                iSP = value;
                DictionaryUtil.Add(QueryParameters, "ISP", value);
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

        public string Zone
        {
            get
            {
                return zone;
            }
            set
            {
                zone = value;
                DictionaryUtil.Add(QueryParameters, "Zone", value);
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
                DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
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

        public int? Ratio
        {
            get
            {
                return ratio;
            }
            set
            {
                ratio = value;
                DictionaryUtil.Add(QueryParameters, "Ratio", value.ToString());
            }
        }

        public override CreateCommonBandwidthPackageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateCommonBandwidthPackageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}