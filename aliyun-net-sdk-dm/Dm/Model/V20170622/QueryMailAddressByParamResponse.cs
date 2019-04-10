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

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class QueryMailAddressByParamResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<QueryMailAddressByParam_MailAddress> data;

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

		public List<QueryMailAddressByParam_MailAddress> Data
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

		public class QueryMailAddressByParam_MailAddress
		{

			private string mailAddressId;

			private string accountName;

			private string replyAddress;

			private string sendtype;

			private string accountStatus;

			private string replyStatus;

			private string createTime;

			private string dailyCount;

			private string monthCount;

			private string dailyReqCount;

			private string monthReqCount;

			private string createTime1;

			private string domainStatus;

			public string MailAddressId
			{
				get
				{
					return mailAddressId;
				}
				set	
				{
					mailAddressId = value;
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

			public string ReplyAddress
			{
				get
				{
					return replyAddress;
				}
				set	
				{
					replyAddress = value;
				}
			}

			public string Sendtype
			{
				get
				{
					return sendtype;
				}
				set	
				{
					sendtype = value;
				}
			}

			public string AccountStatus
			{
				get
				{
					return accountStatus;
				}
				set	
				{
					accountStatus = value;
				}
			}

			public string ReplyStatus
			{
				get
				{
					return replyStatus;
				}
				set	
				{
					replyStatus = value;
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

			public string DailyCount
			{
				get
				{
					return dailyCount;
				}
				set	
				{
					dailyCount = value;
				}
			}

			public string MonthCount
			{
				get
				{
					return monthCount;
				}
				set	
				{
					monthCount = value;
				}
			}

			public string DailyReqCount
			{
				get
				{
					return dailyReqCount;
				}
				set	
				{
					dailyReqCount = value;
				}
			}

			public string MonthReqCount
			{
				get
				{
					return monthReqCount;
				}
				set	
				{
					monthReqCount = value;
				}
			}

			public string CreateTime1
			{
				get
				{
					return createTime1;
				}
				set	
				{
					createTime1 = value;
				}
			}

			public string DomainStatus
			{
				get
				{
					return domainStatus;
				}
				set	
				{
					domainStatus = value;
				}
			}
		}
	}
}
