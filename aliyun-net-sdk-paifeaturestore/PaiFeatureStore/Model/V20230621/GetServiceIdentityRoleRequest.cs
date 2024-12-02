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
using Aliyun.Acs.PaiFeatureStore;
using Aliyun.Acs.PaiFeatureStore.Transform;
using Aliyun.Acs.PaiFeatureStore.Transform.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
    public class GetServiceIdentityRoleRequest : RoaAcsRequest<GetServiceIdentityRoleResponse>
    {
        public GetServiceIdentityRoleRequest()
            : base("PaiFeatureStore", "2023-06-21", "GetServiceIdentityRole")
        {
			UriPattern = "/api/v1/serviceidentityroles/[RoleName]";
			Method = MethodType.GET;
        }

		private string roleName;

		public string RoleName
		{
			get
			{
				return roleName;
			}
			set	
			{
				roleName = value;
				DictionaryUtil.Add(PathParameters, "RoleName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetServiceIdentityRoleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetServiceIdentityRoleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
