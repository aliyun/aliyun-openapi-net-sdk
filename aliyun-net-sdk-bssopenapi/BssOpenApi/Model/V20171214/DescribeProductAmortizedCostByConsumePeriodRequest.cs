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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class DescribeProductAmortizedCostByConsumePeriodRequest : RpcAcsRequest<DescribeProductAmortizedCostByConsumePeriodResponse>
    {
        public DescribeProductAmortizedCostByConsumePeriodRequest()
            : base("BssOpenApi", "2017-12-14", "DescribeProductAmortizedCostByConsumePeriod", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productDetail;

		private string productCode;

		private List<string> billOwnerIdLists = new List<string>(){ };

		private string subscriptionType;

		private string billingCycle;

		private string costUnitCode;

		private List<string> amortizationPeriodFilters = new List<string>(){ };

		private string nextToken;

		private List<string> billUserIdLists = new List<string>(){ };

		private int? maxResults;

		[JsonProperty(PropertyName = "ProductDetail")]
		public string ProductDetail
		{
			get
			{
				return productDetail;
			}
			set	
			{
				productDetail = value;
				DictionaryUtil.Add(BodyParameters, "ProductDetail", value);
			}
		}

		[JsonProperty(PropertyName = "ProductCode")]
		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(BodyParameters, "ProductCode", value);
			}
		}

		[JsonProperty(PropertyName = "BillOwnerIdList")]
		public List<string> BillOwnerIdLists
		{
			get
			{
				return billOwnerIdLists;
			}

			set
			{
				billOwnerIdLists = value;
			}
		}

		[JsonProperty(PropertyName = "SubscriptionType")]
		public string SubscriptionType
		{
			get
			{
				return subscriptionType;
			}
			set	
			{
				subscriptionType = value;
				DictionaryUtil.Add(BodyParameters, "SubscriptionType", value);
			}
		}

		[JsonProperty(PropertyName = "BillingCycle")]
		public string BillingCycle
		{
			get
			{
				return billingCycle;
			}
			set	
			{
				billingCycle = value;
				DictionaryUtil.Add(BodyParameters, "BillingCycle", value);
			}
		}

		[JsonProperty(PropertyName = "CostUnitCode")]
		public string CostUnitCode
		{
			get
			{
				return costUnitCode;
			}
			set	
			{
				costUnitCode = value;
				DictionaryUtil.Add(BodyParameters, "CostUnitCode", value);
			}
		}

		[JsonProperty(PropertyName = "AmortizationPeriodFilter")]
		public List<string> AmortizationPeriodFilters
		{
			get
			{
				return amortizationPeriodFilters;
			}

			set
			{
				amortizationPeriodFilters = value;
			}
		}

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(BodyParameters, "NextToken", value);
			}
		}

		[JsonProperty(PropertyName = "BillUserIdList")]
		public List<string> BillUserIdLists
		{
			get
			{
				return billUserIdLists;
			}

			set
			{
				billUserIdLists = value;
			}
		}

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(BodyParameters, "MaxResults", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeProductAmortizedCostByConsumePeriodResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeProductAmortizedCostByConsumePeriodResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
