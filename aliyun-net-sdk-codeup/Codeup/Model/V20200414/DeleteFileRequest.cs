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
using Aliyun.Acs.codeup;
using Aliyun.Acs.codeup.Transform;
using Aliyun.Acs.codeup.Transform.V20200414;

namespace Aliyun.Acs.codeup.Model.V20200414
{
    public class DeleteFileRequest : RoaAcsRequest<DeleteFileResponse>
    {
        public DeleteFileRequest()
            : base("codeup", "2020-04-14", "DeleteFile")
        {
			UriPattern = "/api/v3/projects/[ProjectId]/repository/files";
			Method = MethodType.DELETE;
        }

		private string organizationId;

		private string subUserId;

		private string filePath;

		private string accessToken;

		private string commitMessage;

		private long? projectId;

		private string branchName;

		public string OrganizationId
		{
			get
			{
				return organizationId;
			}
			set	
			{
				organizationId = value;
				DictionaryUtil.Add(QueryParameters, "OrganizationId", value);
			}
		}

		public string SubUserId
		{
			get
			{
				return subUserId;
			}
			set	
			{
				subUserId = value;
				DictionaryUtil.Add(QueryParameters, "SubUserId", value);
			}
		}

		public string FilePath
		{
			get
			{
				return filePath;
			}
			set	
			{
				filePath = value;
				DictionaryUtil.Add(QueryParameters, "FilePath", value);
			}
		}

		public string AccessToken
		{
			get
			{
				return accessToken;
			}
			set	
			{
				accessToken = value;
				DictionaryUtil.Add(QueryParameters, "AccessToken", value);
			}
		}

		public string CommitMessage
		{
			get
			{
				return commitMessage;
			}
			set	
			{
				commitMessage = value;
				DictionaryUtil.Add(QueryParameters, "CommitMessage", value);
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(PathParameters, "ProjectId", value.ToString());
			}
		}

		public string BranchName
		{
			get
			{
				return branchName;
			}
			set	
			{
				branchName = value;
				DictionaryUtil.Add(QueryParameters, "BranchName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
