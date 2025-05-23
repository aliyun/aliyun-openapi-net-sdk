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

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
	public class ListJobScriptHistoryResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private ListJobScriptHistory_Data data;

		public int? Code
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public ListJobScriptHistory_Data Data
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

		public class ListJobScriptHistory_Data
		{

			private List<ListJobScriptHistory_JobScriptHistoryInfo> jobScriptHistoryInfos;

			public List<ListJobScriptHistory_JobScriptHistoryInfo> JobScriptHistoryInfos
			{
				get
				{
					return jobScriptHistoryInfos;
				}
				set	
				{
					jobScriptHistoryInfos = value;
				}
			}

			public class ListJobScriptHistory_JobScriptHistoryInfo
			{

				private string versionesDescription;

				private string creator;

				private string createTime;

				private string scriptContent;

				public string VersionesDescription
				{
					get
					{
						return versionesDescription;
					}
					set	
					{
						versionesDescription = value;
					}
				}

				public string Creator
				{
					get
					{
						return creator;
					}
					set	
					{
						creator = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public string ScriptContent
				{
					get
					{
						return scriptContent;
					}
					set	
					{
						scriptContent = value;
					}
				}
			}
		}
	}
}
