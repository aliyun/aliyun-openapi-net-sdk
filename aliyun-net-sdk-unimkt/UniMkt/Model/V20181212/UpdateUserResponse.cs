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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class UpdateUserResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private string requestId;

		private UpdateUser_Model model;

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

		public UpdateUser_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class UpdateUser_Model
		{

			private string sspUserId;

			private long? gmtCreateTime;

			private long? gmtModifiedTime;

			private string isDeleteTag;

			private string userName;

			private string yunUid;

			private string yunPersonsId;

			private string mobilePhone;

			private string email;

			private string status;

			private string tenantId;

			private string tenantUserId;

			private string roleCode;

			public string SspUserId
			{
				get
				{
					return sspUserId;
				}
				set	
				{
					sspUserId = value;
				}
			}

			public long? GmtCreateTime
			{
				get
				{
					return gmtCreateTime;
				}
				set	
				{
					gmtCreateTime = value;
				}
			}

			public long? GmtModifiedTime
			{
				get
				{
					return gmtModifiedTime;
				}
				set	
				{
					gmtModifiedTime = value;
				}
			}

			public string IsDeleteTag
			{
				get
				{
					return isDeleteTag;
				}
				set	
				{
					isDeleteTag = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string YunUid
			{
				get
				{
					return yunUid;
				}
				set	
				{
					yunUid = value;
				}
			}

			public string YunPersonsId
			{
				get
				{
					return yunPersonsId;
				}
				set	
				{
					yunPersonsId = value;
				}
			}

			public string MobilePhone
			{
				get
				{
					return mobilePhone;
				}
				set	
				{
					mobilePhone = value;
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

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string TenantUserId
			{
				get
				{
					return tenantUserId;
				}
				set	
				{
					tenantUserId = value;
				}
			}

			public string RoleCode
			{
				get
				{
					return roleCode;
				}
				set	
				{
					roleCode = value;
				}
			}
		}
	}
}
