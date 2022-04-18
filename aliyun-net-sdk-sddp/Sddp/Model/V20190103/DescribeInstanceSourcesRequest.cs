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
using Aliyun.Acs.Sddp.Transform;
using Aliyun.Acs.Sddp.Transform.V20190103;

namespace Aliyun.Acs.Sddp.Model.V20190103
{
    public class DescribeInstanceSourcesRequest : RpcAcsRequest<DescribeInstanceSourcesResponse>
    {
        public DescribeInstanceSourcesRequest()
            : base("Sddp", "2019-01-03", "DescribeInstanceSources", "sddp", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productCode;

		private long? productId;

		private string searchKey;

		private string searchType;

		private int? pageSize;

		private string lang;

		private string serviceRegionId;

		private string engineType;

		private int? auditStatus;

		private int? authStatus;

		private int? currentPage;

		private string instanceId;

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

		public long? ProductId
		{
			get
			{
				return productId;
			}
			set	
			{
				productId = value;
				DictionaryUtil.Add(QueryParameters, "ProductId", value.ToString());
			}
		}

		public string SearchKey
		{
			get
			{
				return searchKey;
			}
			set	
			{
				searchKey = value;
				DictionaryUtil.Add(QueryParameters, "SearchKey", value);
			}
		}

		public string SearchType
		{
			get
			{
				return searchType;
			}
			set	
			{
				searchType = value;
				DictionaryUtil.Add(QueryParameters, "SearchType", value);
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

		public string ServiceRegionId
		{
			get
			{
				return serviceRegionId;
			}
			set	
			{
				serviceRegionId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceRegionId", value);
			}
		}

		public string EngineType
		{
			get
			{
				return engineType;
			}
			set	
			{
				engineType = value;
				DictionaryUtil.Add(QueryParameters, "EngineType", value);
			}
		}

		public int? AuditStatus
		{
			get
			{
				return auditStatus;
			}
			set	
			{
				auditStatus = value;
				DictionaryUtil.Add(QueryParameters, "AuditStatus", value.ToString());
			}
		}

		public int? AuthStatus
		{
			get
			{
				return authStatus;
			}
			set	
			{
				authStatus = value;
				DictionaryUtil.Add(QueryParameters, "AuthStatus", value.ToString());
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeInstanceSourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstanceSourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
