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
    public class DeleteOmsOpenAPIProjectResponseUnmarshaller
    {
        public static DeleteOmsOpenAPIProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteOmsOpenAPIProjectResponse deleteOmsOpenAPIProjectResponse = new DeleteOmsOpenAPIProjectResponse();

			deleteOmsOpenAPIProjectResponse.HttpResponse = _ctx.HttpResponse;
			deleteOmsOpenAPIProjectResponse.Success = _ctx.BooleanValue("DeleteOmsOpenAPIProject.Success");
			deleteOmsOpenAPIProjectResponse.Code = _ctx.StringValue("DeleteOmsOpenAPIProject.Code");
			deleteOmsOpenAPIProjectResponse.Message = _ctx.StringValue("DeleteOmsOpenAPIProject.Message");
			deleteOmsOpenAPIProjectResponse.Advice = _ctx.StringValue("DeleteOmsOpenAPIProject.Advice");
			deleteOmsOpenAPIProjectResponse.RequestId = _ctx.StringValue("DeleteOmsOpenAPIProject.RequestId");
			deleteOmsOpenAPIProjectResponse.PageNumber = _ctx.IntegerValue("DeleteOmsOpenAPIProject.PageNumber");
			deleteOmsOpenAPIProjectResponse.PageSize = _ctx.IntegerValue("DeleteOmsOpenAPIProject.PageSize");
			deleteOmsOpenAPIProjectResponse.TotalCount = _ctx.LongValue("DeleteOmsOpenAPIProject.TotalCount");
			deleteOmsOpenAPIProjectResponse.Cost = _ctx.StringValue("DeleteOmsOpenAPIProject.Cost");
			deleteOmsOpenAPIProjectResponse.Data = _ctx.BooleanValue("DeleteOmsOpenAPIProject.Data");

			DeleteOmsOpenAPIProjectResponse.DeleteOmsOpenAPIProject_ErrorDetail errorDetail = new DeleteOmsOpenAPIProjectResponse.DeleteOmsOpenAPIProject_ErrorDetail();
			errorDetail.Code = _ctx.StringValue("DeleteOmsOpenAPIProject.ErrorDetail.Code");
			errorDetail.Level = _ctx.StringValue("DeleteOmsOpenAPIProject.ErrorDetail.Level");
			errorDetail.Message = _ctx.StringValue("DeleteOmsOpenAPIProject.ErrorDetail.Message");
			errorDetail.Proposal = _ctx.StringValue("DeleteOmsOpenAPIProject.ErrorDetail.Proposal");
			deleteOmsOpenAPIProjectResponse.ErrorDetail = errorDetail;
        
			return deleteOmsOpenAPIProjectResponse;
        }
    }
}
