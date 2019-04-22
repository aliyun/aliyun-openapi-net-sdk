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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class ListEmailVerificationResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? totalPageNum;

		private int? pageSize;

		private bool? prePage;

		private bool? nextPage;

		private List<ListEmailVerification_EmailVerification> data;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
			}
		}

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
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

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		public List<ListEmailVerification_EmailVerification> Data
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

		public class ListEmailVerification_EmailVerification
		{

			private string gmtCreate;

			private string gmtModified;

			private string email;

			private string userId;

			private string emailVerificationNo;

			private string tokenSendTime;

			private int? verificationStatus;

			private string verificationTime;

			private string sendIp;

			private string confirmIp;

			public string GmtCreate
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

			public string GmtModified
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

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string EmailVerificationNo
			{
				get
				{
					return emailVerificationNo;
				}
				set	
				{
					emailVerificationNo = value;
				}
			}

			public string TokenSendTime
			{
				get
				{
					return tokenSendTime;
				}
				set	
				{
					tokenSendTime = value;
				}
			}

			public int? VerificationStatus
			{
				get
				{
					return verificationStatus;
				}
				set	
				{
					verificationStatus = value;
				}
			}

			public string VerificationTime
			{
				get
				{
					return verificationTime;
				}
				set	
				{
					verificationTime = value;
				}
			}

			public string SendIp
			{
				get
				{
					return sendIp;
				}
				set	
				{
					sendIp = value;
				}
			}

			public string ConfirmIp
			{
				get
				{
					return confirmIp;
				}
				set	
				{
					confirmIp = value;
				}
			}
		}
	}
}
