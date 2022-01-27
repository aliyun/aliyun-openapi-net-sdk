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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryRelationListResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private bool? success;

		private string message;

		private QueryRelationList_Data data;

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

				private long? relationId;

				private string accountType;

				private long? accountId;

				private string accountName;

				private string accountNickName;

				private string relationType;

				private string state;

				private string setupTime;

				private string startTime;

				private string endTime;

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
			}
		}
	}
}
