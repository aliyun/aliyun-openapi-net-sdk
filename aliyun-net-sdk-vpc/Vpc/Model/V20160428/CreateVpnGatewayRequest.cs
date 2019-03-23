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
    public class CreateVpnGatewayRequest : RpcAcsRequest<CreateVpnGatewayResponse>
    {
        public CreateVpnGatewayRequest()
            : base("Vpc", "2016-04-28", "CreateVpnGateway", "vpc", "openAPI")
        {
        }

        private long? resourceOwnerId;

        private int? period;

        private bool? autoPay;

        private string resourceOwnerAccount;

        private int? bandwidth;

        private bool? enableIpsec;

        private string ownerAccount;

        private long? ownerId;

        private bool? enableSsl;

        private int? sslConnections;

        private string regionId;

        private string vpcId;

        private string name;

        private string action;

        private string instanceChargeType;

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

        public bool? EnableIpsec
        {
            get
            {
                return enableIpsec;
            }
            set
            {
                enableIpsec = value;
                DictionaryUtil.Add(QueryParameters, "EnableIpsec", value.ToString());
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

        public bool? EnableSsl
        {
            get
            {
                return enableSsl;
            }
            set
            {
                enableSsl = value;
                DictionaryUtil.Add(QueryParameters, "EnableSsl", value.ToString());
            }
        }

        public int? SslConnections
        {
            get
            {
                return sslConnections;
            }
            set
            {
                sslConnections = value;
                DictionaryUtil.Add(QueryParameters, "SslConnections", value.ToString());
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

        public override CreateVpnGatewayResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateVpnGatewayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}