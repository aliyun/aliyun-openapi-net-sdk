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
	public class ListUnrecognizedIntentsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListUnrecognizedIntents_UnrecognizedIntents unrecognizedIntents;

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

		public ListUnrecognizedIntents_UnrecognizedIntents UnrecognizedIntents
		{
			get
			{
				return unrecognizedIntents;
			}
			set	
			{
				unrecognizedIntents = value;
			}
		}

		public class ListUnrecognizedIntents_UnrecognizedIntents
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListUnrecognizedIntents_UnrecognizedIntent> list;

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

			public List<ListUnrecognizedIntents_UnrecognizedIntent> List
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

			public class ListUnrecognizedIntents_UnrecognizedIntent
			{

				private string question;

				private string nodeId;

				private int? totalCount;

				private int? unrecognizedCount;

				private int? unrecognizedPercentage;

				public string Question
				{
					get
					{
						return question;
					}
					set	
					{
						question = value;
					}
				}

				public string NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
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

				public int? UnrecognizedCount
				{
					get
					{
						return unrecognizedCount;
					}
					set	
					{
						unrecognizedCount = value;
					}
				}

				public int? UnrecognizedPercentage
				{
					get
					{
						return unrecognizedPercentage;
					}
					set	
					{
						unrecognizedPercentage = value;
					}
				}
			}
		}
	}
}
