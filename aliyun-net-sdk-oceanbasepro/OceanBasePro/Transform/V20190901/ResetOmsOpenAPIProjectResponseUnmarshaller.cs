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
    public class ResetOmsOpenAPIProjectResponseUnmarshaller
    {
        public static ResetOmsOpenAPIProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ResetOmsOpenAPIProjectResponse resetOmsOpenAPIProjectResponse = new ResetOmsOpenAPIProjectResponse();

			resetOmsOpenAPIProjectResponse.HttpResponse = _ctx.HttpResponse;
			resetOmsOpenAPIProjectResponse.Success = _ctx.BooleanValue("ResetOmsOpenAPIProject.Success");
			resetOmsOpenAPIProjectResponse.Code = _ctx.StringValue("ResetOmsOpenAPIProject.Code");
			resetOmsOpenAPIProjectResponse.Message = _ctx.StringValue("ResetOmsOpenAPIProject.Message");
			resetOmsOpenAPIProjectResponse.Advice = _ctx.StringValue("ResetOmsOpenAPIProject.Advice");
			resetOmsOpenAPIProjectResponse.RequestId = _ctx.StringValue("ResetOmsOpenAPIProject.RequestId");
			resetOmsOpenAPIProjectResponse.PageNumber = _ctx.IntegerValue("ResetOmsOpenAPIProject.PageNumber");
			resetOmsOpenAPIProjectResponse.PageSize = _ctx.IntegerValue("ResetOmsOpenAPIProject.PageSize");
			resetOmsOpenAPIProjectResponse.TotalCount = _ctx.LongValue("ResetOmsOpenAPIProject.TotalCount");
			resetOmsOpenAPIProjectResponse.Cost = _ctx.StringValue("ResetOmsOpenAPIProject.Cost");
			resetOmsOpenAPIProjectResponse.Data = _ctx.BooleanValue("ResetOmsOpenAPIProject.Data");

			ResetOmsOpenAPIProjectResponse.ResetOmsOpenAPIProject_ErrorDetail errorDetail = new ResetOmsOpenAPIProjectResponse.ResetOmsOpenAPIProject_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("ResetOmsOpenAPIProject.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("ResetOmsOpenAPIProject.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("ResetOmsOpenAPIProject.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("ResetOmsOpenAPIProject.ErrorDetail.Proposal");
			resetOmsOpenAPIProjectResponse.ErrorDetail = errorDetail;
        
			return resetOmsOpenAPIProjectResponse;
        }
    }
}
