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
using Aliyun.Acs.OceanBasePro.Transform;
using Aliyun.Acs.OceanBasePro.Transform.V20190901;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
    public class DescribeSlowSQLListRequest : RpcAcsRequest<DescribeSlowSQLListResponse>
    {
        public DescribeSlowSQLListRequest()
            : base("OceanBasePro", "2019-09-01", "DescribeSlowSQLList", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string startTime;

		private int? pageNumber;

		private string searchRule;

		private string tenantId;

		private int? pageSize;

		private string searchParameter;

		private string sortOrder;

		private string searchValue;

		private string sQLId;

		private string filterCondition;

		private string endTime;

		private string nodeIp;

		private string dbName;

		private string searchKeyWord;

		private string sortColumn;

		[JsonProperty(PropertyName = "StartTime")]
		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value);
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SearchRule")]
		public string SearchRule
		{
			get
			{
				return searchRule;
			}
			set	
			{
				searchRule = value;
				DictionaryUtil.Add(BodyParameters, "SearchRule", value);
			}
		}

		[JsonProperty(PropertyName = "TenantId")]
		public string TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(BodyParameters, "TenantId", value);
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
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SearchParameter")]
		public string SearchParameter
		{
			get
			{
				return searchParameter;
			}
			set	
			{
				searchParameter = value;
				DictionaryUtil.Add(BodyParameters, "SearchParameter", value);
			}
		}

		[JsonProperty(PropertyName = "SortOrder")]
		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(BodyParameters, "SortOrder", value);
			}
		}

		[JsonProperty(PropertyName = "SearchValue")]
		public string SearchValue
		{
			get
			{
				return searchValue;
			}
			set	
			{
				searchValue = value;
				DictionaryUtil.Add(BodyParameters, "SearchValue", value);
			}
		}

		[JsonProperty(PropertyName = "SQLId")]
		public string SQLId
		{
			get
			{
				return sQLId;
			}
			set	
			{
				sQLId = value;
				DictionaryUtil.Add(BodyParameters, "SQLId", value);
			}
		}

		[JsonProperty(PropertyName = "FilterCondition")]
		public string FilterCondition
		{
			get
			{
				return filterCondition;
			}
			set	
			{
				filterCondition = value;
				DictionaryUtil.Add(BodyParameters, "FilterCondition", value);
			}
		}

		[JsonProperty(PropertyName = "EndTime")]
		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
			}
		}

		[JsonProperty(PropertyName = "NodeIp")]
		public string NodeIp
		{
			get
			{
				return nodeIp;
			}
			set	
			{
				nodeIp = value;
				DictionaryUtil.Add(BodyParameters, "NodeIp", value);
			}
		}

		[JsonProperty(PropertyName = "DbName")]
		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
				DictionaryUtil.Add(BodyParameters, "DbName", value);
			}
		}

		[JsonProperty(PropertyName = "SearchKeyWord")]
		public string SearchKeyWord
		{
			get
			{
				return searchKeyWord;
			}
			set	
			{
				searchKeyWord = value;
				DictionaryUtil.Add(BodyParameters, "SearchKeyWord", value);
			}
		}

		[JsonProperty(PropertyName = "SortColumn")]
		public string SortColumn
		{
			get
			{
				return sortColumn;
			}
			set	
			{
				sortColumn = value;
				DictionaryUtil.Add(BodyParameters, "SortColumn", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSlowSQLListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSlowSQLListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
