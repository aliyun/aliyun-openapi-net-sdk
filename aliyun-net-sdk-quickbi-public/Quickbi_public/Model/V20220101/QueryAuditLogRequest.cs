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
    public class QueryAuditLogRequest : RpcAcsRequest<QueryAuditLogResponse>
    {
        public QueryAuditLogRequest()
            : base("quickbi-public", "2022-01-01", "QueryAuditLog", "2.2.0", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string startDate;

		private string logType;

		private string resourceType;

		private string operatorTypes;

		private string endDate;

		private string operatorId;

		private string workspaceId;

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

		public string LogType
		{
			get
			{
				return logType;
			}
			set	
			{
				logType = value;
				DictionaryUtil.Add(QueryParameters, "LogType", value);
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

		public string OperatorTypes
		{
			get
			{
				return operatorTypes;
			}
			set	
			{
				operatorTypes = value;
				DictionaryUtil.Add(QueryParameters, "OperatorTypes", value);
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

		public string OperatorId
		{
			get
			{
				return operatorId;
			}
			set	
			{
				operatorId = value;
				DictionaryUtil.Add(QueryParameters, "OperatorId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryAuditLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryAuditLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
