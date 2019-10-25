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

namespace Aliyun.Acs.aliyuncvc.Model.V20190919
{
	public class QueryUserInfoResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private string requestId;

		private QueryUserInfo_UserInfo userInfo;

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public QueryUserInfo_UserInfo UserInfo
		{
			get
			{
				return userInfo;
			}
			set	
			{
				userInfo = value;
			}
		}

		public class QueryUserInfo_UserInfo
		{

			private int? curNum;

			private int? memberConcurrentMax;

			private int? maxNum;

			public int? CurNum
			{
				get
				{
					return curNum;
				}
				set	
				{
					curNum = value;
				}
			}

			public int? MemberConcurrentMax
			{
				get
				{
					return memberConcurrentMax;
				}
				set	
				{
					memberConcurrentMax = value;
				}
			}

			public int? MaxNum
			{
				get
				{
					return maxNum;
				}
				set	
				{
					maxNum = value;
				}
			}
		}
	}
}
