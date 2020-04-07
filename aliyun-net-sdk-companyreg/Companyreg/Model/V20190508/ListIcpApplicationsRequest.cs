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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20190508;

namespace Aliyun.Acs.companyreg.Model.V20190508
{
    public class ListIcpApplicationsRequest : RpcAcsRequest<ListIcpApplicationsResponse>
    {
        public ListIcpApplicationsRequest()
            : base("companyreg", "2019-05-08", "ListIcpApplications", "companyreg", "openAPI")
        {
        }

		private string intentionBizId;

		private int? type;

		private int? applicationStatus;

		private int? pageNumber;

		private string companyName;

		private int? pageSize;

		private string sortOrder;

		private string sortField;

		public string IntentionBizId
		{
			get
			{
				return intentionBizId;
			}
			set	
			{
				intentionBizId = value;
				DictionaryUtil.Add(QueryParameters, "IntentionBizId", value);
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public int? ApplicationStatus
		{
			get
			{
				return applicationStatus;
			}
			set	
			{
				applicationStatus = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationStatus", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string CompanyName
		{
			get
			{
				return companyName;
			}
			set	
			{
				companyName = value;
				DictionaryUtil.Add(QueryParameters, "CompanyName", value);
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

		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(QueryParameters, "SortOrder", value);
			}
		}

		public string SortField
		{
			get
			{
				return sortField;
			}
			set	
			{
				sortField = value;
				DictionaryUtil.Add(QueryParameters, "SortField", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListIcpApplicationsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListIcpApplicationsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
