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
    public class CreateWorkspaceRequest : RpcAcsRequest<CreateWorkspaceResponse>
    {
        public CreateWorkspaceRequest()
            : base("quickbi-public", "2022-01-01", "CreateWorkspace", "2.2.0", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? allowViewAll;

		private string workspaceName;

		private string workspaceDescription;

		private bool? onlyAdminCreateDatasource;

		private bool? allowShare;

		private bool? defaultShareToAll;

		private bool? allowPublish;

		private bool? useComment;

		public bool? AllowViewAll
		{
			get
			{
				return allowViewAll;
			}
			set	
			{
				allowViewAll = value;
				DictionaryUtil.Add(QueryParameters, "AllowViewAll", value.ToString());
			}
		}

		public string WorkspaceName
		{
			get
			{
				return workspaceName;
			}
			set	
			{
				workspaceName = value;
				DictionaryUtil.Add(QueryParameters, "WorkspaceName", value);
			}
		}

		public string WorkspaceDescription
		{
			get
			{
				return workspaceDescription;
			}
			set	
			{
				workspaceDescription = value;
				DictionaryUtil.Add(QueryParameters, "WorkspaceDescription", value);
			}
		}

		public bool? OnlyAdminCreateDatasource
		{
			get
			{
				return onlyAdminCreateDatasource;
			}
			set	
			{
				onlyAdminCreateDatasource = value;
				DictionaryUtil.Add(QueryParameters, "OnlyAdminCreateDatasource", value.ToString());
			}
		}

		public bool? AllowShare
		{
			get
			{
				return allowShare;
			}
			set	
			{
				allowShare = value;
				DictionaryUtil.Add(QueryParameters, "AllowShare", value.ToString());
			}
		}

		public bool? DefaultShareToAll
		{
			get
			{
				return defaultShareToAll;
			}
			set	
			{
				defaultShareToAll = value;
				DictionaryUtil.Add(QueryParameters, "DefaultShareToAll", value.ToString());
			}
		}

		public bool? AllowPublish
		{
			get
			{
				return allowPublish;
			}
			set	
			{
				allowPublish = value;
				DictionaryUtil.Add(QueryParameters, "AllowPublish", value.ToString());
			}
		}

		public bool? UseComment
		{
			get
			{
				return useComment;
			}
			set	
			{
				useComment = value;
				DictionaryUtil.Add(QueryParameters, "UseComment", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateWorkspaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateWorkspaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
