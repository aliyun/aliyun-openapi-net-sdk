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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class CreateUserRequest : RpcAcsRequest<CreateUserResponse>
    {
        public CreateUserRequest()
            : base("Emr", "2016-04-08", "CreateUser", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string userType;

		private string description;

		private List<UserAccountParamList> userAccountParamLists = new List<UserAccountParamList>(){ };

		private List<long?> groupIdLists = new List<long?>(){ };

		private List<long?> roleIdLists = new List<long?>(){ };

		private string aliyunUserId;

		private string userName;

		private string status;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string UserType
		{
			get
			{
				return userType;
			}
			set	
			{
				userType = value;
				DictionaryUtil.Add(QueryParameters, "UserType", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public List<UserAccountParamList> UserAccountParamLists
		{
			get
			{
				return userAccountParamLists;
			}

			set
			{
				userAccountParamLists = value;
				for (int i = 0; i < userAccountParamLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserAccountParamList." + (i + 1) + ".AccountType", userAccountParamLists[i].AccountType);
					DictionaryUtil.Add(QueryParameters,"UserAccountParamList." + (i + 1) + ".AuthType", userAccountParamLists[i].AuthType);
					DictionaryUtil.Add(QueryParameters,"UserAccountParamList." + (i + 1) + ".AccountPassword", userAccountParamLists[i].AccountPassword);
				}
			}
		}

		public List<long?> GroupIdLists
		{
			get
			{
				return groupIdLists;
			}

			set
			{
				groupIdLists = value;
				for (int i = 0; i < groupIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"GroupIdList." + (i + 1) , groupIdLists[i]);
				}
			}
		}

		public List<long?> RoleIdLists
		{
			get
			{
				return roleIdLists;
			}

			set
			{
				roleIdLists = value;
				for (int i = 0; i < roleIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RoleIdList." + (i + 1) , roleIdLists[i]);
				}
			}
		}

		public string AliyunUserId
		{
			get
			{
				return aliyunUserId;
			}
			set	
			{
				aliyunUserId = value;
				DictionaryUtil.Add(QueryParameters, "AliyunUserId", value);
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
				DictionaryUtil.Add(QueryParameters, "UserName", value);
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
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public class UserAccountParamList
		{

			private string accountType;

			private string authType;

			private string accountPassword;

			public string AccountType
			{
				get
				{
					return accountType;
				}
				set	
				{
					accountType = value;
				}
			}

			public string AuthType
			{
				get
				{
					return authType;
				}
				set	
				{
					authType = value;
				}
			}

			public string AccountPassword
			{
				get
				{
					return accountPassword;
				}
				set	
				{
					accountPassword = value;
				}
			}
		}

        public override CreateUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
