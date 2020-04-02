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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class GetUserInfoResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private GetUserInfo_LoginResult loginResult;

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

		public GetUserInfo_LoginResult LoginResult
		{
			get
			{
				return loginResult;
			}
			set	
			{
				loginResult = value;
			}
		}

		public class GetUserInfo_LoginResult
		{

			private long? lmUserId;

			private string bizId;

			private string bizUid;

			private string bizUserName;

			private string returnUrl;

			private string extInfo;

			private List<string> subBizId;

			public long? LmUserId
			{
				get
				{
					return lmUserId;
				}
				set	
				{
					lmUserId = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string BizUid
			{
				get
				{
					return bizUid;
				}
				set	
				{
					bizUid = value;
				}
			}

			public string BizUserName
			{
				get
				{
					return bizUserName;
				}
				set	
				{
					bizUserName = value;
				}
			}

			public string ReturnUrl
			{
				get
				{
					return returnUrl;
				}
				set	
				{
					returnUrl = value;
				}
			}

			public string ExtInfo
			{
				get
				{
					return extInfo;
				}
				set	
				{
					extInfo = value;
				}
			}

			public List<string> SubBizId
			{
				get
				{
					return subBizId;
				}
				set	
				{
					subBizId = value;
				}
			}
		}
	}
}
