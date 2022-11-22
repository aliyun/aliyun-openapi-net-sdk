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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class StartOmsOpenAPIProjectResponseUnmarshaller
    {
        public static StartOmsOpenAPIProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartOmsOpenAPIProjectResponse startOmsOpenAPIProjectResponse = new StartOmsOpenAPIProjectResponse();

			startOmsOpenAPIProjectResponse.HttpResponse = _ctx.HttpResponse;
			startOmsOpenAPIProjectResponse.Success = _ctx.BooleanValue("StartOmsOpenAPIProject.Success");
			startOmsOpenAPIProjectResponse.Code = _ctx.StringValue("StartOmsOpenAPIProject.Code");
			startOmsOpenAPIProjectResponse.Message = _ctx.StringValue("StartOmsOpenAPIProject.Message");
			startOmsOpenAPIProjectResponse.Advice = _ctx.StringValue("StartOmsOpenAPIProject.Advice");
			startOmsOpenAPIProjectResponse.RequestId = _ctx.StringValue("StartOmsOpenAPIProject.RequestId");
			startOmsOpenAPIProjectResponse.PageNumber = _ctx.IntegerValue("StartOmsOpenAPIProject.PageNumber");
			startOmsOpenAPIProjectResponse.PageSize = _ctx.IntegerValue("StartOmsOpenAPIProject.PageSize");
			startOmsOpenAPIProjectResponse.TotalCount = _ctx.LongValue("StartOmsOpenAPIProject.TotalCount");
			startOmsOpenAPIProjectResponse.Cost = _ctx.StringValue("StartOmsOpenAPIProject.Cost");
			startOmsOpenAPIProjectResponse.Data = _ctx.BooleanValue("StartOmsOpenAPIProject.Data");

			StartOmsOpenAPIProjectResponse.StartOmsOpenAPIProject_ErrorDetail errorDetail = new StartOmsOpenAPIProjectResponse.StartOmsOpenAPIProject_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("StartOmsOpenAPIProject.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("StartOmsOpenAPIProject.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("StartOmsOpenAPIProject.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("StartOmsOpenAPIProject.ErrorDetail.Proposal");
			startOmsOpenAPIProjectResponse.ErrorDetail = errorDetail;
        
			return startOmsOpenAPIProjectResponse;
        }
    }
}
