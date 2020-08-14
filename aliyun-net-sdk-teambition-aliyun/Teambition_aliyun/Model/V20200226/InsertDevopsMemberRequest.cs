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
using Aliyun.Acs.teambition_aliyun;
using Aliyun.Acs.teambition_aliyun.Transform;
using Aliyun.Acs.teambition_aliyun.Transform.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Model.V20200226
{
    public class InsertDevopsMemberRequest : RpcAcsRequest<InsertDevopsMemberResponse>
    {
        public InsertDevopsMemberRequest()
            : base("teambition-aliyun", "2020-02-26", "InsertDevopsMember")
        {
			Method = MethodType.POST;
        }

		private string phone;

		private string userPk;

		private string email;

		private string userName;

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
				DictionaryUtil.Add(BodyParameters, "Phone", value);
			}
		}

		public string UserPk
		{
			get
			{
				return userPk;
			}
			set	
			{
				userPk = value;
				DictionaryUtil.Add(BodyParameters, "UserPk", value);
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
				DictionaryUtil.Add(BodyParameters, "Email", value);
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
				DictionaryUtil.Add(BodyParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InsertDevopsMemberResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertDevopsMemberResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
