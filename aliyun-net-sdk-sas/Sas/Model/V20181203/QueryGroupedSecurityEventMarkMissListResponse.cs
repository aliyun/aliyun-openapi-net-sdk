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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class QueryGroupedSecurityEventMarkMissListResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private string requestId;

		private int? httpStatusCode;

		private long? timeCost;

		private List<QueryGroupedSecurityEventMarkMissList_ListItem> list;

		private QueryGroupedSecurityEventMarkMissList_PageInfo pageInfo;

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

		public long? TimeCost
		{
			get
			{
				return timeCost;
			}
			set	
			{
				timeCost = value;
			}
		}

		public List<QueryGroupedSecurityEventMarkMissList_ListItem> List
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

		public QueryGroupedSecurityEventMarkMissList_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class QueryGroupedSecurityEventMarkMissList_ListItem
		{

			private long? gmtCreate;

			private long? gmtModified;

			private long? aliUid;

			private string eventType;

			private string eventTypeOriginal;

			private string eventName;

			private string eventNameOriginal;

			private string uuids;

			private string field;

			private string filedAliasName;

			private string fieldValue;

			private string operate;

			public long? GmtCreate
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

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string EventType
			{
				get
				{
					return eventType;
				}
				set	
				{
					eventType = value;
				}
			}

			public string EventTypeOriginal
			{
				get
				{
					return eventTypeOriginal;
				}
				set	
				{
					eventTypeOriginal = value;
				}
			}

			public string EventName
			{
				get
				{
					return eventName;
				}
				set	
				{
					eventName = value;
				}
			}

			public string EventNameOriginal
			{
				get
				{
					return eventNameOriginal;
				}
				set	
				{
					eventNameOriginal = value;
				}
			}

			public string Uuids
			{
				get
				{
					return uuids;
				}
				set	
				{
					uuids = value;
				}
			}

			public string Field
			{
				get
				{
					return field;
				}
				set	
				{
					field = value;
				}
			}

			public string FiledAliasName
			{
				get
				{
					return filedAliasName;
				}
				set	
				{
					filedAliasName = value;
				}
			}

			public string FieldValue
			{
				get
				{
					return fieldValue;
				}
				set	
				{
					fieldValue = value;
				}
			}

			public string Operate
			{
				get
				{
					return operate;
				}
				set	
				{
					operate = value;
				}
			}
		}

		public class QueryGroupedSecurityEventMarkMissList_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
