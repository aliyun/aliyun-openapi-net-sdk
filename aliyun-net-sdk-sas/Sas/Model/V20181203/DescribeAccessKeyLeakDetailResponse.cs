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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeAccessKeyLeakDetailResponse : AcsResponse
	{

		private string type;

		private string githubUserPicUrl;

		private string githubUser;

		private string githubRepoName;

		private string githubFileType;

		private string remark;

		private string githubFileUpdateTime;

		private string whitelistStatus;

		private string githubFileName;

		private string source;

		private string gmtModified;

		private string asset;

		private string dealTime;

		private string requestId;

		private string accesskeyId;

		private string githubFileUrl;

		private string dealType;

		private string code;

		private string gmtCreate;

		private string githubRepoUrl;

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public string GithubUserPicUrl
		{
			get
			{
				return githubUserPicUrl;
			}
			set	
			{
				githubUserPicUrl = value;
			}
		}

		public string GithubUser
		{
			get
			{
				return githubUser;
			}
			set	
			{
				githubUser = value;
			}
		}

		public string GithubRepoName
		{
			get
			{
				return githubRepoName;
			}
			set	
			{
				githubRepoName = value;
			}
		}

		public string GithubFileType
		{
			get
			{
				return githubFileType;
			}
			set	
			{
				githubFileType = value;
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
			}
		}

		public string GithubFileUpdateTime
		{
			get
			{
				return githubFileUpdateTime;
			}
			set	
			{
				githubFileUpdateTime = value;
			}
		}

		public string WhitelistStatus
		{
			get
			{
				return whitelistStatus;
			}
			set	
			{
				whitelistStatus = value;
			}
		}

		public string GithubFileName
		{
			get
			{
				return githubFileName;
			}
			set	
			{
				githubFileName = value;
			}
		}

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
			}
		}

		public string GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
			}
		}

		public string Asset
		{
			get
			{
				return asset;
			}
			set	
			{
				asset = value;
			}
		}

		public string DealTime
		{
			get
			{
				return dealTime;
			}
			set	
			{
				dealTime = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string AccesskeyId
		{
			get
			{
				return accesskeyId;
			}
			set	
			{
				accesskeyId = value;
			}
		}

		public string GithubFileUrl
		{
			get
			{
				return githubFileUrl;
			}
			set	
			{
				githubFileUrl = value;
			}
		}

		public string DealType
		{
			get
			{
				return dealType;
			}
			set	
			{
				dealType = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
			}
		}

		public string GithubRepoUrl
		{
			get
			{
				return githubRepoUrl;
			}
			set	
			{
				githubRepoUrl = value;
			}
		}
	}
}
