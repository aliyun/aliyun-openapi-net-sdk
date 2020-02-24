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
	public class ListScriptPublishHistoriesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListScriptPublishHistories_ScriptPublishHistories scriptPublishHistories;

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

		public ListScriptPublishHistories_ScriptPublishHistories ScriptPublishHistories
		{
			get
			{
				return scriptPublishHistories;
			}
			set	
			{
				scriptPublishHistories = value;
			}
		}

		public class ListScriptPublishHistories_ScriptPublishHistories
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListScriptPublishHistories_PublishHistory> list;

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

			public List<ListScriptPublishHistories_PublishHistory> List
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

			public class ListScriptPublishHistories_PublishHistory
			{

				private string instanceId;

				private string scriptId;

				private string scriptVersion;

				private string description;

				private long? publishTime;

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

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

				public string ScriptVersion
				{
					get
					{
						return scriptVersion;
					}
					set	
					{
						scriptVersion = value;
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

				public long? PublishTime
				{
					get
					{
						return publishTime;
					}
					set	
					{
						publishTime = value;
					}
				}
			}
		}
	}
}
