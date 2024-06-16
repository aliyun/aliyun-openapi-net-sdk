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
    public class DescribeOasTopSQLListRequest : RpcAcsRequest<DescribeOasTopSQLListResponse>
    {
        public DescribeOasTopSQLListRequest()
            : base("OceanBasePro", "2019-09-01", "DescribeOasTopSQLList", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string startTime;

		private string searchRule;

		private bool? mergeDynamicSql;

		private bool? dynamicSql;

		private long? sqlTextLength;

		private string tenantId;

		private string searchValue;

		private string sqlId;

		private string filterCondition;

		private string searchParam;

		private string endTime;

		private string nodeIp;

		private string instanceId;

		private string dbName;

		private string searchKeyWord;

		private string acceptLanguage;

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

		[JsonProperty(PropertyName = "MergeDynamicSql")]
		public bool? MergeDynamicSql
		{
			get
			{
				return mergeDynamicSql;
			}
			set	
			{
				mergeDynamicSql = value;
				DictionaryUtil.Add(BodyParameters, "MergeDynamicSql", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DynamicSql")]
		public bool? DynamicSql
		{
			get
			{
				return dynamicSql;
			}
			set	
			{
				dynamicSql = value;
				DictionaryUtil.Add(BodyParameters, "DynamicSql", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SqlTextLength")]
		public long? SqlTextLength
		{
			get
			{
				return sqlTextLength;
			}
			set	
			{
				sqlTextLength = value;
				DictionaryUtil.Add(BodyParameters, "SqlTextLength", value.ToString());
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

		[JsonProperty(PropertyName = "SqlId")]
		public string SqlId
		{
			get
			{
				return sqlId;
			}
			set	
			{
				sqlId = value;
				DictionaryUtil.Add(BodyParameters, "SqlId", value);
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

		[JsonProperty(PropertyName = "SearchParam")]
		public string SearchParam
		{
			get
			{
				return searchParam;
			}
			set	
			{
				searchParam = value;
				DictionaryUtil.Add(BodyParameters, "SearchParam", value);
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

		[JsonProperty(PropertyName = "InstanceId")]
		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
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

		[JsonProperty(PropertyName = "AcceptLanguage")]
		public string AcceptLanguage
		{
			get
			{
				return acceptLanguage;
			}
			set	
			{
				acceptLanguage = value;
				DictionaryUtil.Add(BodyParameters, "AcceptLanguage", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeOasTopSQLListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeOasTopSQLListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
