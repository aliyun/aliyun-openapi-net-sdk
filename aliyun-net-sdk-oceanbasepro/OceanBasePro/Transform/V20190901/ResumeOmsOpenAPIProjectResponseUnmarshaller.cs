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
    public class ResumeOmsOpenAPIProjectResponseUnmarshaller
    {
        public static ResumeOmsOpenAPIProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ResumeOmsOpenAPIProjectResponse resumeOmsOpenAPIProjectResponse = new ResumeOmsOpenAPIProjectResponse();

			resumeOmsOpenAPIProjectResponse.HttpResponse = _ctx.HttpResponse;
			resumeOmsOpenAPIProjectResponse.Success = _ctx.BooleanValue("ResumeOmsOpenAPIProject.Success");
			resumeOmsOpenAPIProjectResponse.Code = _ctx.StringValue("ResumeOmsOpenAPIProject.Code");
			resumeOmsOpenAPIProjectResponse.Message = _ctx.StringValue("ResumeOmsOpenAPIProject.Message");
			resumeOmsOpenAPIProjectResponse.Advice = _ctx.StringValue("ResumeOmsOpenAPIProject.Advice");
			resumeOmsOpenAPIProjectResponse.RequestId = _ctx.StringValue("ResumeOmsOpenAPIProject.RequestId");
			resumeOmsOpenAPIProjectResponse.PageNumber = _ctx.IntegerValue("ResumeOmsOpenAPIProject.PageNumber");
			resumeOmsOpenAPIProjectResponse.PageSize = _ctx.IntegerValue("ResumeOmsOpenAPIProject.PageSize");
			resumeOmsOpenAPIProjectResponse.TotalCount = _ctx.LongValue("ResumeOmsOpenAPIProject.TotalCount");
			resumeOmsOpenAPIProjectResponse.Cost = _ctx.StringValue("ResumeOmsOpenAPIProject.Cost");
			resumeOmsOpenAPIProjectResponse.Data = _ctx.BooleanValue("ResumeOmsOpenAPIProject.Data");

			ResumeOmsOpenAPIProjectResponse.ResumeOmsOpenAPIProject_ErrorDetail errorDetail = new ResumeOmsOpenAPIProjectResponse.ResumeOmsOpenAPIProject_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("ResumeOmsOpenAPIProject.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("ResumeOmsOpenAPIProject.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("ResumeOmsOpenAPIProject.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("ResumeOmsOpenAPIProject.ErrorDetail.Proposal");
			resumeOmsOpenAPIProjectResponse.ErrorDetail = errorDetail;
        
			return resumeOmsOpenAPIProjectResponse;
        }
    }
}
