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
    public class CreateServiceConnectionRequest : RpcAcsRequest<CreateServiceConnectionResponse>
    {
        public CreateServiceConnectionRequest()
            : base("devops-rdc", "2020-03-03", "CreateServiceConnection")
        {
			Method = MethodType.POST;
        }

		private string serviceConnectionType;

		private string userPk;

		private string orgId;

		public string ServiceConnectionType
		{
			get
			{
				return serviceConnectionType;
			}
			set	
			{
				serviceConnectionType = value;
				DictionaryUtil.Add(BodyParameters, "ServiceConnectionType", value);
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

        public override CreateServiceConnectionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateServiceConnectionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
