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

namespace Aliyun.Acs.Httpdns.Model.V20160201
{
	public class GetAccountInfoResponse : AcsResponse
	{

		private string requestId;

		private GetAccountInfo_AccountInfo accountInfo;

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

		public GetAccountInfo_AccountInfo AccountInfo
		{
			get
			{
				return accountInfo;
			}
			set	
			{
				accountInfo = value;
			}
		}

		public class GetAccountInfo_AccountInfo
		{

			private string accountId;

			private int? monthFreeCount;

			private int? monthHttpsResolveCount;

			private int? monthResolveCount;

			private int? packageCount;

			private int? userStatus;

			private string signSecret;

			private bool? unsignedEnabled;

			private long? signedCount;

			private long? unsignedCount;

			public string AccountId
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

			public int? MonthFreeCount
			{
				get
				{
					return monthFreeCount;
				}
				set	
				{
					monthFreeCount = value;
				}
			}

			public int? MonthHttpsResolveCount
			{
				get
				{
					return monthHttpsResolveCount;
				}
				set	
				{
					monthHttpsResolveCount = value;
				}
			}

			public int? MonthResolveCount
			{
				get
				{
					return monthResolveCount;
				}
				set	
				{
					monthResolveCount = value;
				}
			}

			public int? PackageCount
			{
				get
				{
					return packageCount;
				}
				set	
				{
					packageCount = value;
				}
			}

			public int? UserStatus
			{
				get
				{
					return userStatus;
				}
				set	
				{
					userStatus = value;
				}
			}

			public string SignSecret
			{
				get
				{
					return signSecret;
				}
				set	
				{
					signSecret = value;
				}
			}

			public bool? UnsignedEnabled
			{
				get
				{
					return unsignedEnabled;
				}
				set	
				{
					unsignedEnabled = value;
				}
			}

			public long? SignedCount
			{
				get
				{
					return signedCount;
				}
				set	
				{
					signedCount = value;
				}
			}

			public long? UnsignedCount
			{
				get
				{
					return unsignedCount;
				}
				set	
				{
					unsignedCount = value;
				}
			}
		}
	}
}