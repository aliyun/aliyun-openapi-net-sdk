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

namespace Aliyun.Acs.Ims.Model.V20190815
{
	public class CreateLoginProfileResponse : AcsResponse
	{

		private string requestId;

		private CreateLoginProfile_LoginProfile loginProfile;

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

		public CreateLoginProfile_LoginProfile LoginProfile
		{
			get
			{
				return loginProfile;
			}
			set	
			{
				loginProfile = value;
			}
		}

		public class CreateLoginProfile_LoginProfile
		{

			private string userPrincipalName;

			private string status;

			private string password;

			private string updateDate;

			private bool? passwordResetRequired;

			private bool? mFABindRequired;

			private string createDate;

			public string UserPrincipalName
			{
				get
				{
					return userPrincipalName;
				}
				set	
				{
					userPrincipalName = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public bool? PasswordResetRequired
			{
				get
				{
					return passwordResetRequired;
				}
				set	
				{
					passwordResetRequired = value;
				}
			}

			public bool? MFABindRequired
			{
				get
				{
					return mFABindRequired;
				}
				set	
				{
					mFABindRequired = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}
		}
	}
}
