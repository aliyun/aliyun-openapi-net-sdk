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
    public class GetSolutionProjectResponseUnmarshaller
    {
        public static GetSolutionProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSolutionProjectResponse getSolutionProjectResponse = new GetSolutionProjectResponse();

			getSolutionProjectResponse.HttpResponse = _ctx.HttpResponse;
			getSolutionProjectResponse.RequestId = _ctx.StringValue("GetSolutionProject.RequestId");
			getSolutionProjectResponse.Success = _ctx.BooleanValue("GetSolutionProject.Success");
			getSolutionProjectResponse.Code = _ctx.StringValue("GetSolutionProject.Code");
			getSolutionProjectResponse.ErrorMessage = _ctx.StringValue("GetSolutionProject.ErrorMessage");

			GetSolutionProjectResponse.GetSolutionProject_Data data = new GetSolutionProjectResponse.GetSolutionProject_Data();
			data.GmtCreate = _ctx.LongValue("GetSolutionProject.Data.GmtCreate");
			data.GmtModified = _ctx.LongValue("GetSolutionProject.Data.GmtModified");
			data.Code = _ctx.StringValue("GetSolutionProject.Data.Code");
			data.Type = _ctx.StringValue("GetSolutionProject.Data.Type");
			data.TenantId = _ctx.StringValue("GetSolutionProject.Data.TenantId");
			data.Name = _ctx.StringValue("GetSolutionProject.Data.Name");
			data.Description = _ctx.StringValue("GetSolutionProject.Data.Description");
			data.Status = _ctx.StringValue("GetSolutionProject.Data.Status");

			GetSolutionProjectResponse.GetSolutionProject_Data.GetSolutionProject_ExtMap extMap = new GetSolutionProjectResponse.GetSolutionProject_Data.GetSolutionProject_ExtMap();
			extMap.ProductKey = _ctx.StringValue("GetSolutionProject.Data.ExtMap.ProductKey");
			extMap.DeviceNumLimit = _ctx.LongValue("GetSolutionProject.Data.ExtMap.DeviceNumLimit");
			data.ExtMap = extMap;
			getSolutionProjectResponse.Data = data;
        
			return getSolutionProjectResponse;
        }
    }
}
