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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class QueryWorksByWorkspaceRequest : RpcAcsRequest<QueryWorksByWorkspaceResponse>
    {
        public QueryWorksByWorkspaceRequest()
            : base("quickbi-public", "2022-01-01", "QueryWorksByWorkspace", "2.2.0", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string worksType;

		private int? thirdPartAuthFlag;

		private int? pageNum;

		private int? pageSize;

		private string workspaceId;

		private int? status;

		public string WorksType
		{
			get
			{
				return worksType;
			}
			set	
			{
				worksType = value;
				DictionaryUtil.Add(QueryParameters, "WorksType", value);
			}
		}

		public int? ThirdPartAuthFlag
		{
			get
			{
				return thirdPartAuthFlag;
			}
			set	
			{
				thirdPartAuthFlag = value;
				DictionaryUtil.Add(QueryParameters, "ThirdPartAuthFlag", value.ToString());
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
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

		public string WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
				DictionaryUtil.Add(QueryParameters, "WorkspaceId", value);
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryWorksByWorkspaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryWorksByWorkspaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
