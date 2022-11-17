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
    public class CreateOmsOpenAPIProjectResponseUnmarshaller
    {
        public static CreateOmsOpenAPIProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateOmsOpenAPIProjectResponse createOmsOpenAPIProjectResponse = new CreateOmsOpenAPIProjectResponse();

			createOmsOpenAPIProjectResponse.HttpResponse = _ctx.HttpResponse;
			createOmsOpenAPIProjectResponse.Success = _ctx.BooleanValue("CreateOmsOpenAPIProject.Success");
			createOmsOpenAPIProjectResponse.Code = _ctx.StringValue("CreateOmsOpenAPIProject.Code");
			createOmsOpenAPIProjectResponse.Message = _ctx.StringValue("CreateOmsOpenAPIProject.Message");
			createOmsOpenAPIProjectResponse.Advice = _ctx.StringValue("CreateOmsOpenAPIProject.Advice");
			createOmsOpenAPIProjectResponse.RequestId = _ctx.StringValue("CreateOmsOpenAPIProject.RequestId");
			createOmsOpenAPIProjectResponse.PageNumber = _ctx.IntegerValue("CreateOmsOpenAPIProject.PageNumber");
			createOmsOpenAPIProjectResponse.PageSize = _ctx.IntegerValue("CreateOmsOpenAPIProject.PageSize");
			createOmsOpenAPIProjectResponse.TotalCount = _ctx.LongValue("CreateOmsOpenAPIProject.TotalCount");
			createOmsOpenAPIProjectResponse.Cost = _ctx.StringValue("CreateOmsOpenAPIProject.Cost");
			createOmsOpenAPIProjectResponse.Data = _ctx.StringValue("CreateOmsOpenAPIProject.Data");

			CreateOmsOpenAPIProjectResponse.CreateOmsOpenAPIProject_ErrorDetail errorDetail = new CreateOmsOpenAPIProjectResponse.CreateOmsOpenAPIProject_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("CreateOmsOpenAPIProject.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("CreateOmsOpenAPIProject.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("CreateOmsOpenAPIProject.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("CreateOmsOpenAPIProject.ErrorDetail.Proposal");
			createOmsOpenAPIProjectResponse.ErrorDetail = errorDetail;
        
			return createOmsOpenAPIProjectResponse;
        }
    }
}
