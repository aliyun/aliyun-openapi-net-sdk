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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class ExportOssResultRequest : RpcAcsRequest<ExportOssResultResponse>
    {
        public ExportOssResultRequest()
            : base("Green", "2017-08-23", "ExportOssResult", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private float? minScore;

		private float? maxScore;

		private long? stockTaskId;

		private string startDate;

		private string scene;

		private string sourceIp;

		private int? pageSize;

		private string lang;

		private bool? stock;

		private int? totalCount;

		private string suggestion;

		private int? currentPage;

		private string resourceType;

		private string bucket;

		private string endDate;

		public float? MinScore
		{
			get
			{
				return minScore;
			}
			set	
			{
				minScore = value;
				DictionaryUtil.Add(QueryParameters, "MinScore", value.ToString());
			}
		}

		public float? MaxScore
		{
			get
			{
				return maxScore;
			}
			set	
			{
				maxScore = value;
				DictionaryUtil.Add(QueryParameters, "MaxScore", value.ToString());
			}
		}

		public long? StockTaskId
		{
			get
			{
				return stockTaskId;
			}
			set	
			{
				stockTaskId = value;
				DictionaryUtil.Add(QueryParameters, "StockTaskId", value.ToString());
			}
		}

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(QueryParameters, "StartDate", value);
			}
		}

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(QueryParameters, "Scene", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

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

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public bool? Stock
		{
			get
			{
				return stock;
			}
			set	
			{
				stock = value;
				DictionaryUtil.Add(QueryParameters, "Stock", value.ToString());
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
				DictionaryUtil.Add(QueryParameters, "TotalCount", value.ToString());
			}
		}

		public string Suggestion
		{
			get
			{
				return suggestion;
			}
			set	
			{
				suggestion = value;
				DictionaryUtil.Add(QueryParameters, "Suggestion", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string Bucket
		{
			get
			{
				return bucket;
			}
			set	
			{
				bucket = value;
				DictionaryUtil.Add(QueryParameters, "Bucket", value);
			}
		}

		public string EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(QueryParameters, "EndDate", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExportOssResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExportOssResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
