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
using Aliyun.Acs.Dds;
using Aliyun.Acs.Dds.Transform;
using Aliyun.Acs.Dds.Transform.V20151201;

namespace Aliyun.Acs.Dds.Model.V20151201
{
    public class DescribePriceRequest : RpcAcsRequest<DescribePriceResponse>
    {
        public DescribePriceRequest()
            : base("Dds", "2015-12-01", "DescribePrice")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string productCode;

		private string couponNo;

		private string resourceGroupId;

		private string securityToken;

		private string businessInfo;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string orderParamOut;

		private string commodityCode;

		private long? ownerId;

		private string dBInstances;

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

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
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

		public string CommodityCode
		{
			get
			{
				return commodityCode;
			}
			set	
			{
				commodityCode = value;
				DictionaryUtil.Add(QueryParameters, "CommodityCode", value);
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

		public string DBInstances
		{
			get
			{
				return dBInstances;
			}
			set	
			{
				dBInstances = value;
				DictionaryUtil.Add(QueryParameters, "DBInstances", value);
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
