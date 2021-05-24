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
    public class ModifyUserRequest : RpcAcsRequest<ModifyUserResponse>
    {
        public ModifyUserRequest()
            : base("CCC", "2020-07-01", "ModifyUser", "CCC", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string roleId;

		private string mobile;

		private string workMode;

		private string userId;

		private string instanceId;

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

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
