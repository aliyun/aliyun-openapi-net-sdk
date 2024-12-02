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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class CreateServiceIdentityRoleResponseUnmarshaller
    {
        public static CreateServiceIdentityRoleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateServiceIdentityRoleResponse createServiceIdentityRoleResponse = new CreateServiceIdentityRoleResponse();

			createServiceIdentityRoleResponse.HttpResponse = _ctx.HttpResponse;
			createServiceIdentityRoleResponse.RequestId = _ctx.StringValue("CreateServiceIdentityRole.RequestId");
			createServiceIdentityRoleResponse.RoleName = _ctx.StringValue("CreateServiceIdentityRole.RoleName");
			createServiceIdentityRoleResponse.Code = _ctx.StringValue("CreateServiceIdentityRole.Code");
        
			return createServiceIdentityRoleResponse;
        }
    }
}
