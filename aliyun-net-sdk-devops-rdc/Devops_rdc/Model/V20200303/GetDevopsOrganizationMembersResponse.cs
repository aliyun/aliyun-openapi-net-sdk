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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetDevopsOrganizationMembersResponse : AcsResponse
	{

		private string errorMsg;

		private string requestId;

		private bool? successful;

		private string errorCode;

		private List<GetDevopsOrganizationMembers_Member> _object;

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public bool? Successful
		{
			get
			{
				return successful;
			}
			set	
			{
				successful = value;
			}
		}

		public string ErrorCode
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

		public List<GetDevopsOrganizationMembers_Member> _Object
		{
			get
			{
				return _object;
			}
			set	
			{
				_object = value;
			}
		}

		public class GetDevopsOrganizationMembers_Member
		{

			private string email;

			private string avatarUrl;

			private string userId;

			private string memberId;

			private int? role;

			private string name;

			private string phone;

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

			public string AvatarUrl
			{
				get
				{
					return avatarUrl;
				}
				set	
				{
					avatarUrl = value;
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

			public string MemberId
			{
				get
				{
					return memberId;
				}
				set	
				{
					memberId = value;
				}
			}

			public int? Role
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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Phone
			{
				get
				{
					return phone;
				}
				set	
				{
					phone = value;
				}
			}
		}
	}
}
