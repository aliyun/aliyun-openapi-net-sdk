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
    public class AddProjectMembersRequest : RpcAcsRequest<AddProjectMembersResponse>
    {
        public AddProjectMembersRequest()
            : base("teambition-aliyun", "2020-02-26", "AddProjectMembers")
        {
			Method = MethodType.POST;
        }

		private string members;

		private string projectId;

		private string orgId;

		public string Members
		{
			get
			{
				return members;
			}
			set	
			{
				members = value;
				DictionaryUtil.Add(BodyParameters, "Members", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value);
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
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddProjectMembersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddProjectMembersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
