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

namespace Aliyun.Acs.Sms.Model.V20160927
{
	public class QuerySmsFailByPageResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<stat> data;

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

		public List<stat> Data
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

		public class stat{

			private string receiverNum;

			private string smsCode;

			private int? smsStatus;

			private string resultCode;

			public string ReceiverNum
			{
				get
				{
					return receiverNum;
				}
				set	
				{
					receiverNum = value;
				}
			}

			public string SmsCode
			{
				get
				{
					return smsCode;
				}
				set	
				{
					smsCode = value;
				}
			}

			public int? SmsStatus
			{
				get
				{
					return smsStatus;
				}
				set	
				{
					smsStatus = value;
				}
			}

			public string ResultCode
			{
				get
				{
					return resultCode;
				}
				set	
				{
					resultCode = value;
				}
			}
		}
	}
}