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
    public class DescribeSavingsPlansUsageDetailRequest : RpcAcsRequest<DescribeSavingsPlansUsageDetailResponse>
    {
        public DescribeSavingsPlansUsageDetailRequest()
            : base("BssOpenApi", "2017-12-14", "DescribeSavingsPlansUsageDetail", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string periodType;

		private long? billOwnerId;

		private string startPeriod;

		private string endPeriod;

		private string token;

		private int? maxResults;

		[JsonProperty(PropertyName = "PeriodType")]
		public string PeriodType
		{
			get
			{
				return periodType;
			}
			set	
			{
				periodType = value;
				DictionaryUtil.Add(QueryParameters, "PeriodType", value);
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

		[JsonProperty(PropertyName = "StartPeriod")]
		public string StartPeriod
		{
			get
			{
				return startPeriod;
			}
			set	
			{
				startPeriod = value;
				DictionaryUtil.Add(QueryParameters, "StartPeriod", value);
			}
		}

		[JsonProperty(PropertyName = "EndPeriod")]
		public string EndPeriod
		{
			get
			{
				return endPeriod;
			}
			set	
			{
				endPeriod = value;
				DictionaryUtil.Add(QueryParameters, "EndPeriod", value);
			}
		}

		[JsonProperty(PropertyName = "Token")]
		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
				DictionaryUtil.Add(QueryParameters, "Token", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSavingsPlansUsageDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSavingsPlansUsageDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
