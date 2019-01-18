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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class GetConversationDetailByContactIdResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private GetConversationDetailByContactId_DataList dataList;

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

		public GetConversationDetailByContactId_DataList DataList
		{
			get
			{
				return dataList;
			}
			set	
			{
				dataList = value;
			}
		}

		public class GetConversationDetailByContactId_DataList
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<GetConversationDetailByContactId_QualityCheckPhrase> list;

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

			public List<GetConversationDetailByContactId_QualityCheckPhrase> List
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

			public class GetConversationDetailByContactId_QualityCheckPhrase
			{

				private string identity;

				private string role;

				private string words;

				private long? begin;

				private long? end;

				public string Identity
				{
					get
					{
						return identity;
					}
					set	
					{
						identity = value;
					}
				}

				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				public string Words
				{
					get
					{
						return words;
					}
					set	
					{
						words = value;
					}
				}

				public long? Begin
				{
					get
					{
						return begin;
					}
					set	
					{
						begin = value;
					}
				}

				public long? End
				{
					get
					{
						return end;
					}
					set	
					{
						end = value;
					}
				}
			}
		}
	}
}