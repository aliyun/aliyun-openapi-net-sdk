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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class CreateUserResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private CreateUser_Data data;

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

		public CreateUser_Data Data
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

		public class CreateUser_Data
		{

			private int? userId;

			private string isvSubId;

			private string userName;

			private int? userGroupId;

			private string idNumber;

			private string faceImageUrl;

			private string address;

			private string age;

			private string gender;

			private string plateNo;

			private string phoneNo;

			private string attachment;

			private string bizId;

			public int? UserId
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

			public string IsvSubId
			{
				get
				{
					return isvSubId;
				}
				set	
				{
					isvSubId = value;
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

			public int? UserGroupId
			{
				get
				{
					return userGroupId;
				}
				set	
				{
					userGroupId = value;
				}
			}

			public string IdNumber
			{
				get
				{
					return idNumber;
				}
				set	
				{
					idNumber = value;
				}
			}

			public string FaceImageUrl
			{
				get
				{
					return faceImageUrl;
				}
				set	
				{
					faceImageUrl = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string Age
			{
				get
				{
					return age;
				}
				set	
				{
					age = value;
				}
			}

			public string Gender
			{
				get
				{
					return gender;
				}
				set	
				{
					gender = value;
				}
			}

			public string PlateNo
			{
				get
				{
					return plateNo;
				}
				set	
				{
					plateNo = value;
				}
			}

			public string PhoneNo
			{
				get
				{
					return phoneNo;
				}
				set	
				{
					phoneNo = value;
				}
			}

			public string Attachment
			{
				get
				{
					return attachment;
				}
				set	
				{
					attachment = value;
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
		}
	}
}
