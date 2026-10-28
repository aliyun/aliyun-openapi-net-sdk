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
using Aliyun.Acs.quotas.Transform;
using Aliyun.Acs.quotas.Transform.V20200510;

namespace Aliyun.Acs.quotas.Model.V20200510
{
    public class ListQuotaUtilizationReportRequest : RpcAcsRequest<ListQuotaUtilizationReportResponse>
    {
        public ListQuotaUtilizationReportRequest()
            : base("quotas", "2020-05-10", "ListQuotaUtilizationReport", "Quotas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productCode;

		private string keyWords;

		private string nextToken;

		private string quotaCategory;

		private List<string> utilizationStatusess = new List<string>(){ };

		private string quotaRegionId;

		private int? maxResults;

		private bool? adjustable;

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

		public string KeyWords
		{
			get
			{
				return keyWords;
			}
			set	
			{
				keyWords = value;
				DictionaryUtil.Add(BodyParameters, "KeyWords", value);
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
				DictionaryUtil.Add(BodyParameters, "NextToken", value);
			}
		}

		public string QuotaCategory
		{
			get
			{
				return quotaCategory;
			}
			set	
			{
				quotaCategory = value;
				DictionaryUtil.Add(BodyParameters, "QuotaCategory", value);
			}
		}

		public List<string> UtilizationStatusess
		{
			get
			{
				return utilizationStatusess;
			}

			set
			{
				utilizationStatusess = value;
			}
		}

		public string QuotaRegionId
		{
			get
			{
				return quotaRegionId;
			}
			set	
			{
				quotaRegionId = value;
				DictionaryUtil.Add(BodyParameters, "QuotaRegionId", value);
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
				DictionaryUtil.Add(BodyParameters, "MaxResults", value.ToString());
			}
		}

		public bool? Adjustable
		{
			get
			{
				return adjustable;
			}
			set	
			{
				adjustable = value;
				DictionaryUtil.Add(BodyParameters, "Adjustable", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListQuotaUtilizationReportResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListQuotaUtilizationReportResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
