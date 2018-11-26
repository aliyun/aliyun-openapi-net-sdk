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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;
using System.Collections.Generic;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class RegisterUserRequest : RpcAcsRequest<RegisterUserResponse>
    {
        public RegisterUserRequest()
            : base("dms_enterprise", "2018-11-01", "RegisterUser", "dmsenterprise", "openAPI")
        {
        }

		private string roleNames;

		private long? uid;

		private string userNick;

		private long? tid;

		public string RoleNames
		{
			get
			{
				return roleNames;
			}
			set	
			{
				roleNames = value;
				DictionaryUtil.Add(QueryParameters, "RoleNames", value);
			}
		}

		public long? Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value.ToString());
			}
		}

		public string UserNick
		{
			get
			{
				return userNick;
			}
			set	
			{
				userNick = value;
				DictionaryUtil.Add(QueryParameters, "UserNick", value);
			}
		}

		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

        public override RegisterUserResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RegisterUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}