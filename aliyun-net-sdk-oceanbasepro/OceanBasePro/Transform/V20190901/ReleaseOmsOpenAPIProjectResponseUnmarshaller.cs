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
    public class ReleaseOmsOpenAPIProjectResponseUnmarshaller
    {
        public static ReleaseOmsOpenAPIProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReleaseOmsOpenAPIProjectResponse releaseOmsOpenAPIProjectResponse = new ReleaseOmsOpenAPIProjectResponse();

			releaseOmsOpenAPIProjectResponse.HttpResponse = _ctx.HttpResponse;
			releaseOmsOpenAPIProjectResponse.Success = _ctx.BooleanValue("ReleaseOmsOpenAPIProject.Success");
			releaseOmsOpenAPIProjectResponse.Code = _ctx.StringValue("ReleaseOmsOpenAPIProject.Code");
			releaseOmsOpenAPIProjectResponse.Message = _ctx.StringValue("ReleaseOmsOpenAPIProject.Message");
			releaseOmsOpenAPIProjectResponse.Advice = _ctx.StringValue("ReleaseOmsOpenAPIProject.Advice");
			releaseOmsOpenAPIProjectResponse.RequestId = _ctx.StringValue("ReleaseOmsOpenAPIProject.RequestId");
			releaseOmsOpenAPIProjectResponse.PageNumber = _ctx.IntegerValue("ReleaseOmsOpenAPIProject.PageNumber");
			releaseOmsOpenAPIProjectResponse.PageSize = _ctx.IntegerValue("ReleaseOmsOpenAPIProject.PageSize");
			releaseOmsOpenAPIProjectResponse.TotalCount = _ctx.LongValue("ReleaseOmsOpenAPIProject.TotalCount");
			releaseOmsOpenAPIProjectResponse.Cost = _ctx.StringValue("ReleaseOmsOpenAPIProject.Cost");
			releaseOmsOpenAPIProjectResponse.Data = _ctx.BooleanValue("ReleaseOmsOpenAPIProject.Data");

			ReleaseOmsOpenAPIProjectResponse.ReleaseOmsOpenAPIProject_ErrorDetail errorDetail = new ReleaseOmsOpenAPIProjectResponse.ReleaseOmsOpenAPIProject_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("ReleaseOmsOpenAPIProject.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("ReleaseOmsOpenAPIProject.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("ReleaseOmsOpenAPIProject.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("ReleaseOmsOpenAPIProject.ErrorDetail.Proposal");
			releaseOmsOpenAPIProjectResponse.ErrorDetail = errorDetail;
        
			return releaseOmsOpenAPIProjectResponse;
        }
    }
}
