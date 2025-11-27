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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.eds_user.Transform;
using Aliyun.Acs.eds_user.Transform.V20210308;

namespace Aliyun.Acs.eds_user.Model.V20210308
{
    public class CreateUsersRequest : RpcAcsRequest<CreateUsersResponse>
    {
        public CreateUsersRequest()
            : base("eds-user", "2021-03-08", "CreateUsers", "eds-user", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eds_user.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string autoLockTime;

		private bool? isLocalAdmin;

		private List<string> userss = new List<string>(){ };

		private string password;

		private string passwordExpireDays;

		public string AutoLockTime
		{
			get
			{
				return autoLockTime;
			}
			set	
			{
				autoLockTime = value;
				DictionaryUtil.Add(QueryParameters, "AutoLockTime", value);
			}
		}

		public bool? IsLocalAdmin
		{
			get
			{
				return isLocalAdmin;
			}
			set	
			{
				isLocalAdmin = value;
				DictionaryUtil.Add(QueryParameters, "IsLocalAdmin", value.ToString());
			}
		}

		public List<string> Userss
		{
			get
			{
				return userss;
			}

			set
			{
				userss = value;
				if(userss != null)
				{
					for (int depth1 = 0; depth1 < userss.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Users." + (depth1 + 1), userss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Users." + (depth1 + 1), userss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Users." + (depth1 + 1), userss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Users." + (depth1 + 1), userss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Users." + (depth1 + 1), userss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Users." + (depth1 + 1), userss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Users." + (depth1 + 1), userss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Users." + (depth1 + 1), userss[depth1]);
					}
				}
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
				DictionaryUtil.Add(BodyParameters, "Password", value);
			}
		}

		public string PasswordExpireDays
		{
			get
			{
				return passwordExpireDays;
			}
			set	
			{
				passwordExpireDays = value;
				DictionaryUtil.Add(QueryParameters, "PasswordExpireDays", value);
			}
		}

		public class Users
		{

			private string password;

			private string realNickName;

			private string phone;

			private string ownerType;

			private string endUserId;

			private string remark;

			private string email;

			private string orgId;

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

			public string RealNickName
			{
				get
				{
					return realNickName;
				}
				set	
				{
					realNickName = value;
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

			public string OwnerType
			{
				get
				{
					return ownerType;
				}
				set	
				{
					ownerType = value;
				}
			}

			public string EndUserId
			{
				get
				{
					return endUserId;
				}
				set	
				{
					endUserId = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
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

			public string OrgId
			{
				get
				{
					return orgId;
				}
				set	
				{
					orgId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateUsersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateUsersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
