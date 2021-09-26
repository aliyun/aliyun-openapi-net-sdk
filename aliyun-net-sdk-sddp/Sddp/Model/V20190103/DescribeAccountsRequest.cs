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
using Aliyun.Acs.Sddp;
using Aliyun.Acs.Sddp.Transform;
using Aliyun.Acs.Sddp.Transform.V20190103;

namespace Aliyun.Acs.Sddp.Model.V20190103
{
    public class DescribeAccountsRequest : RpcAcsRequest<DescribeAccountsResponse>
    {
        public DescribeAccountsRequest()
            : base("Sddp", "2019-01-03", "DescribeAccounts")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productCode;

		private string packageId;

		private int? pageSize;

		private string tableId;

		private string lang;

		private string key;

		private int? queryType;

		private string loginName;

		private int? featureType;

		private string columnId;

		private int? currentPage;

		private string instanceId;

		private long? departId;

		private int? operationId;

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

		public string PackageId
		{
			get
			{
				return packageId;
			}
			set	
			{
				packageId = value;
				DictionaryUtil.Add(QueryParameters, "PackageId", value);
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

		public string TableId
		{
			get
			{
				return tableId;
			}
			set	
			{
				tableId = value;
				DictionaryUtil.Add(QueryParameters, "TableId", value);
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

		public string Key
		{
			get
			{
				return key;
			}
			set	
			{
				key = value;
				DictionaryUtil.Add(QueryParameters, "Key", value);
			}
		}

		public int? QueryType
		{
			get
			{
				return queryType;
			}
			set	
			{
				queryType = value;
				DictionaryUtil.Add(QueryParameters, "QueryType", value.ToString());
			}
		}

		public string LoginName
		{
			get
			{
				return loginName;
			}
			set	
			{
				loginName = value;
				DictionaryUtil.Add(QueryParameters, "LoginName", value);
			}
		}

		public int? FeatureType
		{
			get
			{
				return featureType;
			}
			set	
			{
				featureType = value;
				DictionaryUtil.Add(QueryParameters, "FeatureType", value.ToString());
			}
		}

		public string ColumnId
		{
			get
			{
				return columnId;
			}
			set	
			{
				columnId = value;
				DictionaryUtil.Add(QueryParameters, "ColumnId", value);
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

		public long? DepartId
		{
			get
			{
				return departId;
			}
			set	
			{
				departId = value;
				DictionaryUtil.Add(QueryParameters, "DepartId", value.ToString());
			}
		}

		public int? OperationId
		{
			get
			{
				return operationId;
			}
			set	
			{
				operationId = value;
				DictionaryUtil.Add(QueryParameters, "OperationId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeAccountsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAccountsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
