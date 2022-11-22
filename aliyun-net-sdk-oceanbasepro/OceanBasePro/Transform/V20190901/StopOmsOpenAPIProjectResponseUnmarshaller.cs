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
    public class StopOmsOpenAPIProjectResponseUnmarshaller
    {
        public static StopOmsOpenAPIProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StopOmsOpenAPIProjectResponse stopOmsOpenAPIProjectResponse = new StopOmsOpenAPIProjectResponse();

			stopOmsOpenAPIProjectResponse.HttpResponse = _ctx.HttpResponse;
			stopOmsOpenAPIProjectResponse.Success = _ctx.BooleanValue("StopOmsOpenAPIProject.Success");
			stopOmsOpenAPIProjectResponse.Code = _ctx.StringValue("StopOmsOpenAPIProject.Code");
			stopOmsOpenAPIProjectResponse.Message = _ctx.StringValue("StopOmsOpenAPIProject.Message");
			stopOmsOpenAPIProjectResponse.Advice = _ctx.StringValue("StopOmsOpenAPIProject.Advice");
			stopOmsOpenAPIProjectResponse.RequestId = _ctx.StringValue("StopOmsOpenAPIProject.RequestId");
			stopOmsOpenAPIProjectResponse.PageNumber = _ctx.IntegerValue("StopOmsOpenAPIProject.PageNumber");
			stopOmsOpenAPIProjectResponse.PageSize = _ctx.IntegerValue("StopOmsOpenAPIProject.PageSize");
			stopOmsOpenAPIProjectResponse.TotalCount = _ctx.LongValue("StopOmsOpenAPIProject.TotalCount");
			stopOmsOpenAPIProjectResponse.Cost = _ctx.StringValue("StopOmsOpenAPIProject.Cost");
			stopOmsOpenAPIProjectResponse.Data = _ctx.BooleanValue("StopOmsOpenAPIProject.Data");

			StopOmsOpenAPIProjectResponse.StopOmsOpenAPIProject_ErrorDetail errorDetail = new StopOmsOpenAPIProjectResponse.StopOmsOpenAPIProject_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("StopOmsOpenAPIProject.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("StopOmsOpenAPIProject.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("StopOmsOpenAPIProject.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("StopOmsOpenAPIProject.ErrorDetail.Proposal");
			stopOmsOpenAPIProjectResponse.ErrorDetail = errorDetail;
        
			return stopOmsOpenAPIProjectResponse;
        }
    }
}
