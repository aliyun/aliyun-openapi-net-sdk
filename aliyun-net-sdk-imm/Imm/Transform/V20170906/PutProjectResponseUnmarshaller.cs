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
    public class PutProjectResponseUnmarshaller
    {
        public static PutProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PutProjectResponse putProjectResponse = new PutProjectResponse();

			putProjectResponse.HttpResponse = _ctx.HttpResponse;
			putProjectResponse.RequestId = _ctx.StringValue("PutProject.RequestId");
			putProjectResponse.Project = _ctx.StringValue("PutProject.Project");
			putProjectResponse.CreateTime = _ctx.StringValue("PutProject.CreateTime");
			putProjectResponse.ModifyTime = _ctx.StringValue("PutProject.ModifyTime");
			putProjectResponse.ServiceRole = _ctx.StringValue("PutProject.ServiceRole");
			putProjectResponse.CU = _ctx.IntegerValue("PutProject.CU");
			putProjectResponse.Type = _ctx.StringValue("PutProject.Type");
			putProjectResponse.Endpoint = _ctx.StringValue("PutProject.Endpoint");
			putProjectResponse.BillingType = _ctx.StringValue("PutProject.BillingType");
			putProjectResponse.RegionId = _ctx.StringValue("PutProject.RegionId");
        
			return putProjectResponse;
        }
    }
}
