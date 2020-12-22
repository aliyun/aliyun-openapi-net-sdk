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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetProjectResponseUnmarshaller
    {
        public static GetProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProjectResponse getProjectResponse = new GetProjectResponse();

			getProjectResponse.HttpResponse = _ctx.HttpResponse;
			getProjectResponse.RequestId = _ctx.StringValue("GetProject.RequestId");
			getProjectResponse.Project = _ctx.StringValue("GetProject.Project");
			getProjectResponse.ServiceRole = _ctx.StringValue("GetProject.ServiceRole");
			getProjectResponse.Endpoint = _ctx.StringValue("GetProject.Endpoint");
			getProjectResponse.CreateTime = _ctx.StringValue("GetProject.CreateTime");
			getProjectResponse.ModifyTime = _ctx.StringValue("GetProject.ModifyTime");
			getProjectResponse.Type = _ctx.StringValue("GetProject.Type");
			getProjectResponse.CU = _ctx.IntegerValue("GetProject.CU");
			getProjectResponse.BillingType = _ctx.StringValue("GetProject.BillingType");
			getProjectResponse.RegionId = _ctx.StringValue("GetProject.RegionId");
        
			return getProjectResponse;
        }
    }
}
