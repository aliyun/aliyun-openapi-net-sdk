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
	public class ListIntentsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ListIntents_Intents intents;

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

		public ListIntents_Intents Intents
		{
			get
			{
				return intents;
			}
			set	
			{
				intents = value;
			}
		}

		public class ListIntents_Intents
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListIntents_Intent> list;

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

			public List<ListIntents_Intent> List
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

			public class ListIntents_Intent
			{

				private long? createTime;

				private string intentDescription;

				private string intentId;

				private string intentName;

				private string keywords;

				private string scriptId;

				private long? updateTime;

				private string utterances;

				public long? CreateTime
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

				public string IntentDescription
				{
					get
					{
						return intentDescription;
					}
					set	
					{
						intentDescription = value;
					}
				}

				public string IntentId
				{
					get
					{
						return intentId;
					}
					set	
					{
						intentId = value;
					}
				}

				public string IntentName
				{
					get
					{
						return intentName;
					}
					set	
					{
						intentName = value;
					}
				}

				public string Keywords
				{
					get
					{
						return keywords;
					}
					set	
					{
						keywords = value;
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

				public string Utterances
				{
					get
					{
						return utterances;
					}
					set	
					{
						utterances = value;
					}
				}
			}
		}
	}
}
