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
    public class DescribeSplitItemBillRequest : RpcAcsRequest<DescribeSplitItemBillResponse>
    {
        public DescribeSplitItemBillRequest()
            : base("BssOpenApi", "2017-12-14", "DescribeSplitItemBill")
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

		public List<TagFilter> TagFilters
		{
			get
			{
				return tagFilters;
			}

			set
			{
				tagFilters = value;
				for (int i = 0; i < tagFilters.Count; i++)
				{
					for (int j = 0; j < tagFilters[i].TagValuess.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"TagFilter." + (i + 1) + ".TagValues." +(j + 1), tagFilters[i].TagValuess[j]);
					}
					DictionaryUtil.Add(QueryParameters,"TagFilter." + (i + 1) + ".TagKey", tagFilters[i].TagKey);
				}
			}
		}

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
