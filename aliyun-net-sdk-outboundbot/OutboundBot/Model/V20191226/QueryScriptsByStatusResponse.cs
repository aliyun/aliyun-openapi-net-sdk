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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class QueryScriptsByStatusResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private QueryScriptsByStatus_Scripts scripts;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public QueryScriptsByStatus_Scripts Scripts
		{
			get
			{
				return scripts;
			}
			set	
			{
				scripts = value;
			}
		}

		public class QueryScriptsByStatus_Scripts
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<QueryScriptsByStatus_Script> list;

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
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
				}
			}

			public List<QueryScriptsByStatus_Script> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryScriptsByStatus_Script
			{

				private string scriptId;

				private string scriptName;

				private string scriptDescription;

				private string industry;

				private string scene;

				private string status;

				private string debugStatus;

				private string debugVersion;

				private string appliedVersion;

				private long? updateTime;

				private bool? isDrafted;

				private bool? isDebugDrafted;

				public string ScriptId
				{
					get
					{
						return scriptId;
					}
					set	
					{
						scriptId = value;
					}
				}

				public string ScriptName
				{
					get
					{
						return scriptName;
					}
					set	
					{
						scriptName = value;
					}
				}

				public string ScriptDescription
				{
					get
					{
						return scriptDescription;
					}
					set	
					{
						scriptDescription = value;
					}
				}

				public string Industry
				{
					get
					{
						return industry;
					}
					set	
					{
						industry = value;
					}
				}

				public string Scene
				{
					get
					{
						return scene;
					}
					set	
					{
						scene = value;
					}
				}

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

				public string DebugStatus
				{
					get
					{
						return debugStatus;
					}
					set	
					{
						debugStatus = value;
					}
				}

				public string DebugVersion
				{
					get
					{
						return debugVersion;
					}
					set	
					{
						debugVersion = value;
					}
				}

				public string AppliedVersion
				{
					get
					{
						return appliedVersion;
					}
					set	
					{
						appliedVersion = value;
					}
				}

				public long? UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public bool? IsDrafted
				{
					get
					{
						return isDrafted;
					}
					set	
					{
						isDrafted = value;
					}
				}

				public bool? IsDebugDrafted
				{
					get
					{
						return isDebugDrafted;
					}
					set	
					{
						isDebugDrafted = value;
					}
				}
			}
		}
	}
}
