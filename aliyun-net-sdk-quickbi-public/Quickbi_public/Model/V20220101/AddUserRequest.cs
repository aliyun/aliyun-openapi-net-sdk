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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class AddUserRequest : RpcAcsRequest<AddUserResponse>
    {
        public AddUserRequest()
            : base("quickbi-public", "2022-01-01", "AddUser", "quick", "openAPI")
        {
			Method = MethodType.POST;
        }

		private bool? adminUser;

		private int? userType;

		private string accountName;

		private string nickName;

		private bool? authAdminUser;

		public bool? AdminUser
		{
			get
			{
				return adminUser;
			}
			set	
			{
				adminUser = value;
				DictionaryUtil.Add(QueryParameters, "AdminUser", value.ToString());
			}
		}

		public int? UserType
		{
			get
			{
				return userType;
			}
			set	
			{
				userType = value;
				DictionaryUtil.Add(QueryParameters, "UserType", value.ToString());
			}
		}

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public string NickName
		{
			get
			{
				return nickName;
			}
			set	
			{
				nickName = value;
				DictionaryUtil.Add(QueryParameters, "NickName", value);
			}
		}

		public bool? AuthAdminUser
		{
			get
			{
				return authAdminUser;
			}
			set	
			{
				authAdminUser = value;
				DictionaryUtil.Add(QueryParameters, "AuthAdminUser", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
