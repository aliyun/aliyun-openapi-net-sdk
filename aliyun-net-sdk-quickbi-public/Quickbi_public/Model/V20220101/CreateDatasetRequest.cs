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
    public class CreateDatasetRequest : RpcAcsRequest<CreateDatasetResponse>
    {
        public CreateDatasetRequest()
            : base("quickbi-public", "2022-01-01", "CreateDataset", "2.2.0", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string dsId;

		private string userId;

		private string tableName;

		private string targetDirectoryId;

		private string userDefineCubeName;

		private string workspaceId;

		public string DsId
		{
			get
			{
				return dsId;
			}
			set	
			{
				dsId = value;
				DictionaryUtil.Add(QueryParameters, "DsId", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string TableName
		{
			get
			{
				return tableName;
			}
			set	
			{
				tableName = value;
				DictionaryUtil.Add(QueryParameters, "TableName", value);
			}
		}

		public string TargetDirectoryId
		{
			get
			{
				return targetDirectoryId;
			}
			set	
			{
				targetDirectoryId = value;
				DictionaryUtil.Add(QueryParameters, "TargetDirectoryId", value);
			}
		}

		public string UserDefineCubeName
		{
			get
			{
				return userDefineCubeName;
			}
			set	
			{
				userDefineCubeName = value;
				DictionaryUtil.Add(QueryParameters, "UserDefineCubeName", value);
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

        public override CreateDatasetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDatasetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
