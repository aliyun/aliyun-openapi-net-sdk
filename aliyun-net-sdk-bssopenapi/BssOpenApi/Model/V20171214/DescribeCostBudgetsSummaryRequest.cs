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
    public class DescribeCostBudgetsSummaryRequest : RpcAcsRequest<DescribeCostBudgetsSummaryResponse>
    {
        public DescribeCostBudgetsSummaryRequest()
            : base("BssOpenApi", "2017-12-14", "DescribeCostBudgetsSummary", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string budgetStatus;

		private string budgetType;

		private string nextToken;

		private int? maxResults;

		private string budgetName;

		[JsonProperty(PropertyName = "BudgetStatus")]
		public string BudgetStatus
		{
			get
			{
				return budgetStatus;
			}
			set	
			{
				budgetStatus = value;
				DictionaryUtil.Add(QueryParameters, "BudgetStatus", value);
			}
		}

		[JsonProperty(PropertyName = "BudgetType")]
		public string BudgetType
		{
			get
			{
				return budgetType;
			}
			set	
			{
				budgetType = value;
				DictionaryUtil.Add(QueryParameters, "BudgetType", value);
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

		[JsonProperty(PropertyName = "BudgetName")]
		public string BudgetName
		{
			get
			{
				return budgetName;
			}
			set	
			{
				budgetName = value;
				DictionaryUtil.Add(QueryParameters, "BudgetName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeCostBudgetsSummaryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeCostBudgetsSummaryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
