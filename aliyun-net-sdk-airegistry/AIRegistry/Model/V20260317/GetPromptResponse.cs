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

namespace Aliyun.Acs.AIRegistry.Model.V20260317
{
	public class GetPromptResponse : AcsResponse
	{

		private string requestId;

		private GetPrompt_Data data;

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

		public GetPrompt_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetPrompt_Data
		{

			private string editingVersion;

			private string description;

			private int? schemaVersion;

			private string latestVersion;

			private string promptKey;

			private long? gmtModified;

			private string labels;

			private string reviewingVersion;

			private int? onlineCnt;

			private List<GetPrompt_VersionDetail> versionDetails;

			private List<string> versions;

			private List<string> bizTags;

			public string EditingVersion
			{
				get
				{
					return editingVersion;
				}
				set	
				{
					editingVersion = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public int? SchemaVersion
			{
				get
				{
					return schemaVersion;
				}
				set	
				{
					schemaVersion = value;
				}
			}

			public string LatestVersion
			{
				get
				{
					return latestVersion;
				}
				set	
				{
					latestVersion = value;
				}
			}

			public string PromptKey
			{
				get
				{
					return promptKey;
				}
				set	
				{
					promptKey = value;
				}
			}

			public long? GmtModified
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

			public string Labels
			{
				get
				{
					return labels;
				}
				set	
				{
					labels = value;
				}
			}

			public string ReviewingVersion
			{
				get
				{
					return reviewingVersion;
				}
				set	
				{
					reviewingVersion = value;
				}
			}

			public int? OnlineCnt
			{
				get
				{
					return onlineCnt;
				}
				set	
				{
					onlineCnt = value;
				}
			}

			public List<GetPrompt_VersionDetail> VersionDetails
			{
				get
				{
					return versionDetails;
				}
				set	
				{
					versionDetails = value;
				}
			}

			public List<string> Versions
			{
				get
				{
					return versions;
				}
				set	
				{
					versions = value;
				}
			}

			public List<string> BizTags
			{
				get
				{
					return bizTags;
				}
				set	
				{
					bizTags = value;
				}
			}

			public class GetPrompt_VersionDetail
			{

				private string status;

				private string version;

				private string srcUser;

				private string promptKey;

				private long? gmtModified;

				private string commitMsg;

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string SrcUser
				{
					get
					{
						return srcUser;
					}
					set	
					{
						srcUser = value;
					}
				}

				public string PromptKey
				{
					get
					{
						return promptKey;
					}
					set	
					{
						promptKey = value;
					}
				}

				public long? GmtModified
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

				public string CommitMsg
				{
					get
					{
						return commitMsg;
					}
					set	
					{
						commitMsg = value;
					}
				}
			}
		}
	}
}
