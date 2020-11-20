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
using Aliyun.Acs.R_kvstore.Transform;
using Aliyun.Acs.R_kvstore.Transform.V20150101;

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
    public class DescribePriceRequest : RpcAcsRequest<DescribePriceResponse>
    {
        public DescribePriceRequest()
            : base("R-kvstore", "2015-01-01", "DescribePrice", "redisa", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.R_kvstore.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.R_kvstore.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string nodeType;

		private string instances;

		private string couponNo;

		private string instanceClass;

		private long? capacity;

		private string securityToken;

		private string businessInfo;

		private long? period;

		private long? quantity;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string orderParamOut;

		private long? ownerId;

		private string instanceId;

		private string zoneId;

		private string chargeType;

		private bool? forceUpgrade;

		private string orderType;

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

		public string NodeType
		{
			get
			{
				return nodeType;
			}
			set	
			{
				nodeType = value;
				DictionaryUtil.Add(QueryParameters, "NodeType", value);
			}
		}

		public string Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
				DictionaryUtil.Add(QueryParameters, "Instances", value);
			}
		}

		public string CouponNo
		{
			get
			{
				return couponNo;
			}
			set	
			{
				couponNo = value;
				DictionaryUtil.Add(QueryParameters, "CouponNo", value);
			}
		}

		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
				DictionaryUtil.Add(QueryParameters, "InstanceClass", value);
			}
		}

		public long? Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
				DictionaryUtil.Add(QueryParameters, "Capacity", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string BusinessInfo
		{
			get
			{
				return businessInfo;
			}
			set	
			{
				businessInfo = value;
				DictionaryUtil.Add(QueryParameters, "BusinessInfo", value);
			}
		}

		public long? Period
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

		public long? Quantity
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

		public string OrderParamOut
		{
			get
			{
				return orderParamOut;
			}
			set	
			{
				orderParamOut = value;
				DictionaryUtil.Add(QueryParameters, "OrderParamOut", value);
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

		public bool? ForceUpgrade
		{
			get
			{
				return forceUpgrade;
			}
			set	
			{
				forceUpgrade = value;
				DictionaryUtil.Add(QueryParameters, "ForceUpgrade", value.ToString());
			}
		}

		public string OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value);
			}
		}

        public override DescribePriceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
