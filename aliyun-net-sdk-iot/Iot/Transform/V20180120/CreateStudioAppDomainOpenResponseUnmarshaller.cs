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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class CreateStudioAppDomainOpenResponseUnmarshaller
    {
        public static CreateStudioAppDomainOpenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateStudioAppDomainOpenResponse createStudioAppDomainOpenResponse = new CreateStudioAppDomainOpenResponse();

			createStudioAppDomainOpenResponse.HttpResponse = _ctx.HttpResponse;
			createStudioAppDomainOpenResponse.RequestId = _ctx.StringValue("CreateStudioAppDomainOpen.RequestId");
			createStudioAppDomainOpenResponse.Success = _ctx.BooleanValue("CreateStudioAppDomainOpen.Success");
			createStudioAppDomainOpenResponse.Code = _ctx.StringValue("CreateStudioAppDomainOpen.Code");
			createStudioAppDomainOpenResponse.ErrorMessage = _ctx.StringValue("CreateStudioAppDomainOpen.ErrorMessage");

			CreateStudioAppDomainOpenResponse.CreateStudioAppDomainOpen_Data data = new CreateStudioAppDomainOpenResponse.CreateStudioAppDomainOpen_Data();
			data.TenantId = _ctx.StringValue("CreateStudioAppDomainOpen.Data.TenantId");
			data.AppId = _ctx.StringValue("CreateStudioAppDomainOpen.Data.AppId");
			data.ProjectId = _ctx.StringValue("CreateStudioAppDomainOpen.Data.ProjectId");
			data.Host = _ctx.StringValue("CreateStudioAppDomainOpen.Data.Host");
			data.Id = _ctx.IntegerValue("CreateStudioAppDomainOpen.Data.Id");
			data.IsBeian = _ctx.StringValue("CreateStudioAppDomainOpen.Data.IsBeian");
			data.Protocol = _ctx.StringValue("CreateStudioAppDomainOpen.Data.Protocol");
			createStudioAppDomainOpenResponse.Data = data;
        
			return createStudioAppDomainOpenResponse;
        }
    }
}
