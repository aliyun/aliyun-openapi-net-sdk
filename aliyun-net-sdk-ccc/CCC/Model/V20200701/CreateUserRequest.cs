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
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20200701;

namespace Aliyun.Acs.CCC.Model.V20200701
{
    public class CreateUserRequest : RpcAcsRequest<CreateUserResponse>
    {
        public CreateUserRequest()
            : base("CCC", "2020-07-01", "CreateUser", "CCC", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string loginName;

		private string roleId;

		private string mobile;

		private string workMode;

		private string instanceId;

		private string displayName;

		private bool? resetPassword;

		private string skillLevelList;

		private string email;

		public string LoginName
		{
			get
			{
				return loginName;
			}
			set	
			{
				loginName = value;
				DictionaryUtil.Add(QueryParameters, "LoginName", value);
			}
		}

		public string RoleId
		{
			get
			{
				return roleId;
			}
			set	
			{
				roleId = value;
				DictionaryUtil.Add(QueryParameters, "RoleId", value);
			}
		}

		public string Mobile
		{
			get
			{
				return mobile;
			}
			set	
			{
				mobile = value;
				DictionaryUtil.Add(QueryParameters, "Mobile", value);
			}
		}

		public string WorkMode
		{
			get
			{
				return workMode;
			}
			set	
			{
				workMode = value;
				DictionaryUtil.Add(QueryParameters, "WorkMode", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string DisplayName
		{
			get
			{
				return displayName;
			}
			set	
			{
				displayName = value;
				DictionaryUtil.Add(QueryParameters, "DisplayName", value);
			}
		}

		public bool? ResetPassword
		{
			get
			{
				return resetPassword;
			}
			set	
			{
				resetPassword = value;
				DictionaryUtil.Add(QueryParameters, "ResetPassword", value.ToString());
			}
		}

		public string SkillLevelList
		{
			get
			{
				return skillLevelList;
			}
			set	
			{
				skillLevelList = value;
				DictionaryUtil.Add(QueryParameters, "SkillLevelList", value);
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
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
