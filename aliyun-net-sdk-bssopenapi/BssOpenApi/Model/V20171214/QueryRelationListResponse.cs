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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryRelationListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryRelationList_Data data;

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Data")]
		public QueryRelationList_Data Data
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

		public class QueryRelationList_Data
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QueryRelationList_FinancialRelationInfoListItem> financialRelationInfoList;

			[JsonProperty(PropertyName = "PageNum")]
			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			[JsonProperty(PropertyName = "PageSize")]
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

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "FinancialRelationInfoList")]
			public List<QueryRelationList_FinancialRelationInfoListItem> FinancialRelationInfoList
			{
				get
				{
					return financialRelationInfoList;
				}
				set	
				{
					financialRelationInfoList = value;
				}
			}

			public class QueryRelationList_FinancialRelationInfoListItem
			{

				private string endTime;

				private string relationType;

				private string accountNickName;

				private string startTime;

				private string state;

				private long? accountId;

				private string setupTime;

				private string accountType;

				private string accountName;

				private long? relationId;

				[JsonProperty(PropertyName = "EndTime")]
				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				[JsonProperty(PropertyName = "RelationType")]
				public string RelationType
				{
					get
					{
						return relationType;
					}
					set	
					{
						relationType = value;
					}
				}

				[JsonProperty(PropertyName = "AccountNickName")]
				public string AccountNickName
				{
					get
					{
						return accountNickName;
					}
					set	
					{
						accountNickName = value;
					}
				}

				[JsonProperty(PropertyName = "StartTime")]
				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				[JsonProperty(PropertyName = "State")]
				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				[JsonProperty(PropertyName = "AccountId")]
				public long? AccountId
				{
					get
					{
						return accountId;
					}
					set	
					{
						accountId = value;
					}
				}

				[JsonProperty(PropertyName = "SetupTime")]
				public string SetupTime
				{
					get
					{
						return setupTime;
					}
					set	
					{
						setupTime = value;
					}
				}

				[JsonProperty(PropertyName = "AccountType")]
				public string AccountType
				{
					get
					{
						return accountType;
					}
					set	
					{
						accountType = value;
					}
				}

				[JsonProperty(PropertyName = "AccountName")]
				public string AccountName
				{
					get
					{
						return accountName;
					}
					set	
					{
						accountName = value;
					}
				}

				[JsonProperty(PropertyName = "RelationId")]
				public long? RelationId
				{
					get
					{
						return relationId;
					}
					set	
					{
						relationId = value;
					}
				}
			}
		}
	}
}
