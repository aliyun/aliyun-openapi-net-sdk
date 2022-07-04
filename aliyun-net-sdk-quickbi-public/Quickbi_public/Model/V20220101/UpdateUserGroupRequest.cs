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
    public class UpdateUserGroupRequest : RpcAcsRequest<UpdateUserGroupResponse>
    {
        public UpdateUserGroupRequest()
            : base("quickbi-public", "2022-01-01", "UpdateUserGroup", "quick", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string userGroupId;

		private string userGroupName;

		private string userGroupDescription;

		public string UserGroupId
		{
			get
			{
				return userGroupId;
			}
			set	
			{
				userGroupId = value;
				DictionaryUtil.Add(QueryParameters, "UserGroupId", value);
			}
		}

		public string UserGroupName
		{
			get
			{
				return userGroupName;
			}
			set	
			{
				userGroupName = value;
				DictionaryUtil.Add(QueryParameters, "UserGroupName", value);
			}
		}

		public string UserGroupDescription
		{
			get
			{
				return userGroupDescription;
			}
			set	
			{
				userGroupDescription = value;
				DictionaryUtil.Add(QueryParameters, "UserGroupDescription", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateUserGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateUserGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
