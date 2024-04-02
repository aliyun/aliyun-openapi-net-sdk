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
    public class GetAuditItemListRequest : RpcAcsRequest<GetAuditItemListResponse>
    {
        public GetAuditItemListRequest()
            : base("Green", "2017-08-23", "GetAuditItemList", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
        }

		private string type;

		private string startDate;

		private string rcpRiskType;

		private long? pageSize;

		private string taskId;

		private string customRiskType;

		private string rcpResult;

		private long? currentPage;

		private string bizType;

		private string endDate;

		private string dataId;

		private string customResult;

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

		public string RcpRiskType
		{
			get
			{
				return rcpRiskType;
			}
			set	
			{
				rcpRiskType = value;
				DictionaryUtil.Add(QueryParameters, "RcpRiskType", value);
			}
		}

		public long? PageSize
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

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

		public string CustomRiskType
		{
			get
			{
				return customRiskType;
			}
			set	
			{
				customRiskType = value;
				DictionaryUtil.Add(QueryParameters, "CustomRiskType", value);
			}
		}

		public string RcpResult
		{
			get
			{
				return rcpResult;
			}
			set	
			{
				rcpResult = value;
				DictionaryUtil.Add(QueryParameters, "RcpResult", value);
			}
		}

		public long? CurrentPage
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

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
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

		public string DataId
		{
			get
			{
				return dataId;
			}
			set	
			{
				dataId = value;
				DictionaryUtil.Add(QueryParameters, "DataId", value);
			}
		}

		public string CustomResult
		{
			get
			{
				return customResult;
			}
			set	
			{
				customResult = value;
				DictionaryUtil.Add(QueryParameters, "CustomResult", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetAuditItemListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAuditItemListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
