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
    public class QueryAvailableInstancesRequest : RpcAcsRequest<QueryAvailableInstancesResponse>
    {
        public QueryAvailableInstancesRequest()
            : base("BssOpenApi", "2017-12-14", "QueryAvailableInstances", "bssopenapi", "openAPI")
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

		private int? pageNum;

		private string productType;

		private int? pageSize;

		private string renewStatus;

		private long? ownerId;

		private string endTimeStart;

		private string createTimeEnd;

		private string instanceIDs;

		private string endTimeEnd;

		private string createTimeStart;

		private string region;

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

		[JsonProperty(PropertyName = "PageNum")]
		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
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

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "RenewStatus")]
		public string RenewStatus
		{
			get
			{
				return renewStatus;
			}
			set	
			{
				renewStatus = value;
				DictionaryUtil.Add(QueryParameters, "RenewStatus", value);
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

		[JsonProperty(PropertyName = "EndTimeStart")]
		public string EndTimeStart
		{
			get
			{
				return endTimeStart;
			}
			set	
			{
				endTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeStart", value);
			}
		}

		[JsonProperty(PropertyName = "CreateTimeEnd")]
		public string CreateTimeEnd
		{
			get
			{
				return createTimeEnd;
			}
			set	
			{
				createTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeEnd", value);
			}
		}

		[JsonProperty(PropertyName = "InstanceIDs")]
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

		[JsonProperty(PropertyName = "EndTimeEnd")]
		public string EndTimeEnd
		{
			get
			{
				return endTimeEnd;
			}
			set	
			{
				endTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeEnd", value);
			}
		}

		[JsonProperty(PropertyName = "CreateTimeStart")]
		public string CreateTimeStart
		{
			get
			{
				return createTimeStart;
			}
			set	
			{
				createTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeStart", value);
			}
		}

		[JsonProperty(PropertyName = "Region")]
		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryAvailableInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryAvailableInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
