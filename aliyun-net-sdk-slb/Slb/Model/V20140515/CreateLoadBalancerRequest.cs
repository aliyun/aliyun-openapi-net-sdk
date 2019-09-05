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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class CreateLoadBalancerRequest : RpcAcsRequest<CreateLoadBalancerResponse>
    {
        public CreateLoadBalancerRequest()
            : base("Slb", "2014-05-15", "CreateLoadBalancer", "slb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string addressIPVersion;

		private string masterZoneId;

		private int? duration;

		private string resourceGroupId;

		private string loadBalancerName;

		private string addressType;

		private string slaveZoneId;

		private string deleteProtection;

		private string loadBalancerSpec;

		private bool? autoPay;

		private string address;

		private string resourceOwnerAccount;

		private int? bandwidth;

		private string ownerAccount;

		private long? ownerId;

		private string vSwitchId;

		private string internetChargeType;

		private string vpcId;

		private string payType;

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

		public string AddressIPVersion
		{
			get
			{
				return addressIPVersion;
			}
			set	
			{
				addressIPVersion = value;
				DictionaryUtil.Add(QueryParameters, "AddressIPVersion", value);
			}
		}

		public string MasterZoneId
		{
			get
			{
				return masterZoneId;
			}
			set	
			{
				masterZoneId = value;
				DictionaryUtil.Add(QueryParameters, "MasterZoneId", value);
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

		public string LoadBalancerName
		{
			get
			{
				return loadBalancerName;
			}
			set	
			{
				loadBalancerName = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerName", value);
			}
		}

		public string AddressType
		{
			get
			{
				return addressType;
			}
			set	
			{
				addressType = value;
				DictionaryUtil.Add(QueryParameters, "AddressType", value);
			}
		}

		public string SlaveZoneId
		{
			get
			{
				return slaveZoneId;
			}
			set	
			{
				slaveZoneId = value;
				DictionaryUtil.Add(QueryParameters, "SlaveZoneId", value);
			}
		}

		public string DeleteProtection
		{
			get
			{
				return deleteProtection;
			}
			set	
			{
				deleteProtection = value;
				DictionaryUtil.Add(QueryParameters, "DeleteProtection", value);
			}
		}

		public string LoadBalancerSpec
		{
			get
			{
				return loadBalancerSpec;
			}
			set	
			{
				loadBalancerSpec = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerSpec", value);
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

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
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

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
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

        public override CreateLoadBalancerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLoadBalancerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
