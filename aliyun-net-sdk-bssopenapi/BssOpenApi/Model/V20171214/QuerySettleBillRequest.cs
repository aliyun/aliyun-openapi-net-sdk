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
    public class QuerySettleBillRequest : RpcAcsRequest<QuerySettleBillResponse>
    {
        public QuerySettleBillRequest()
            : base("BssOpenApi", "2017-12-14", "QuerySettleBill")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productCode;

		private bool? isHideZeroCharge;

		private bool? isDisplayLocalCurrency;

		private string subscriptionType;

		private string billingCycle;

		private string type;

		private long? ownerId;

		private long? billOwnerId;

		private string productType;

		private string recordID;

		private string nextToken;

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

		public bool? IsHideZeroCharge
		{
			get
			{
				return isHideZeroCharge;
			}
			set	
			{
				isHideZeroCharge = value;
				DictionaryUtil.Add(QueryParameters, "IsHideZeroCharge", value.ToString());
			}
		}

		public bool? IsDisplayLocalCurrency
		{
			get
			{
				return isDisplayLocalCurrency;
			}
			set	
			{
				isDisplayLocalCurrency = value;
				DictionaryUtil.Add(QueryParameters, "IsDisplayLocalCurrency", value.ToString());
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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
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

		public string RecordID
		{
			get
			{
				return recordID;
			}
			set	
			{
				recordID = value;
				DictionaryUtil.Add(QueryParameters, "RecordID", value);
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

        public override QuerySettleBillResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QuerySettleBillResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
