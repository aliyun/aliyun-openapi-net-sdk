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
using Aliyun.Acs.devops_rdc;
using Aliyun.Acs.devops_rdc.Transform;
using Aliyun.Acs.devops_rdc.Transform.V20200303;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
    public class CreateDevopsOrganizationRequest : RpcAcsRequest<CreateDevopsOrganizationResponse>
    {
        public CreateDevopsOrganizationRequest()
            : base("devops-rdc", "2020-03-03", "CreateDevopsOrganization")
        {
			Method = MethodType.POST;
        }

		private string orgName;

		private string source;

		private string realPk;

		private int? desiredMemberCount;

		public string OrgName
		{
			get
			{
				return orgName;
			}
			set	
			{
				orgName = value;
				DictionaryUtil.Add(BodyParameters, "OrgName", value);
			}
		}

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
				DictionaryUtil.Add(BodyParameters, "Source", value);
			}
		}

		public string RealPk
		{
			get
			{
				return realPk;
			}
			set	
			{
				realPk = value;
				DictionaryUtil.Add(BodyParameters, "RealPk", value);
			}
		}

		public int? DesiredMemberCount
		{
			get
			{
				return desiredMemberCount;
			}
			set	
			{
				desiredMemberCount = value;
				DictionaryUtil.Add(BodyParameters, "DesiredMemberCount", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDevopsOrganizationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDevopsOrganizationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
