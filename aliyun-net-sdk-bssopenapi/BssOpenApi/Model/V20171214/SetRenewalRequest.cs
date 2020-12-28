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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class SetRenewalRequest : RpcAcsRequest<SetRenewalResponse>
    {
        public SetRenewalRequest()
            : base("BssOpenApi", "2017-12-14", "SetRenewal")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productCode;

		private string subscriptionType;

		private int? renewalPeriod;

		private long? ownerId;

		private string productType;

		private string instanceIDs;

		private string renewalStatus;

		private string renewalPeriodUnit;

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

		public string SubscriptionType
		{
			get
			{
				return subscriptionType;
			}
			set	
			{
				subscriptionType = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionType", value);
			}
		}

		public int? RenewalPeriod
		{
			get
			{
				return renewalPeriod;
			}
			set	
			{
				renewalPeriod = value;
				DictionaryUtil.Add(QueryParameters, "RenewalPeriod", value.ToString());
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

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		public string InstanceIDs
		{
			get
			{
				return instanceIDs;
			}
			set	
			{
				instanceIDs = value;
				DictionaryUtil.Add(QueryParameters, "InstanceIDs", value);
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

		public string RenewalPeriodUnit
		{
			get
			{
				return renewalPeriodUnit;
			}
			set	
			{
				renewalPeriodUnit = value;
				DictionaryUtil.Add(QueryParameters, "RenewalPeriodUnit", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetRenewalResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetRenewalResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
