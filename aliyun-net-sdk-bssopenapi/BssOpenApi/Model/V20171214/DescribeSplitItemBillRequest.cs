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
    public class DescribeSplitItemBillRequest : RpcAcsRequest<DescribeSplitItemBillResponse>
    {
        public DescribeSplitItemBillRequest()
            : base("BssOpenApi", "2017-12-14", "DescribeSplitItemBill", "bssopenapi", "openAPI")
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

		private long? billOwnerId;

		private string productType;

		private string nextToken;

		private string splitItemID;

		private string billingCycle;

		private long? ownerId;

		private List<TagFilter> tagFilters = new List<TagFilter>(){ };

		private string billingDate;

		private string instanceID;

		private string granularity;

		private int? maxResults;

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
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
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
				DictionaryUtil.Add(QueryParameters, "SubscriptionType", value);
			}
		}

		[JsonProperty(PropertyName = "BillOwnerId")]
		public long? BillOwnerId
		{
			get
			{
				return billOwnerId;
			}
			set	
			{
				billOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "BillOwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ProductType")]
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
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		[JsonProperty(PropertyName = "SplitItemID")]
		public string SplitItemID
		{
			get
			{
				return splitItemID;
			}
			set	
			{
				splitItemID = value;
				DictionaryUtil.Add(QueryParameters, "SplitItemID", value);
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
				DictionaryUtil.Add(QueryParameters, "BillingCycle", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "TagFilter")]
		public List<TagFilter> TagFilters
		{
			get
			{
				return tagFilters;
			}

			set
			{
				tagFilters = value;
				if(tagFilters != null)
				{
					for (int depth1 = 0; depth1 < tagFilters.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TagFilter." + (depth1 + 1), tagFilters[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "BillingDate")]
		public string BillingDate
		{
			get
			{
				return billingDate;
			}
			set	
			{
				billingDate = value;
				DictionaryUtil.Add(QueryParameters, "BillingDate", value);
			}
		}

		[JsonProperty(PropertyName = "InstanceID")]
		public string InstanceID
		{
			get
			{
				return instanceID;
			}
			set	
			{
				instanceID = value;
				DictionaryUtil.Add(QueryParameters, "InstanceID", value);
			}
		}

		[JsonProperty(PropertyName = "Granularity")]
		public string Granularity
		{
			get
			{
				return granularity;
			}
			set	
			{
				granularity = value;
				DictionaryUtil.Add(QueryParameters, "Granularity", value);
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
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public class TagFilter
		{

			private List<string> tagValuess = new List<string>(){ };

			private string tagKey;

			[JsonProperty(PropertyName = "TagValues")]
			public List<string> TagValuess
			{
				get
				{
					return tagValuess;
				}
				set	
				{
					tagValuess = value;
				}
			}

			[JsonProperty(PropertyName = "TagKey")]
			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSplitItemBillResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSplitItemBillResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
