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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetProjectDetailResponseUnmarshaller
    {
        public static GetProjectDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProjectDetailResponse getProjectDetailResponse = new GetProjectDetailResponse();

			getProjectDetailResponse.HttpResponse = _ctx.HttpResponse;
			getProjectDetailResponse.HttpStatusCode = _ctx.IntegerValue("GetProjectDetail.HttpStatusCode");
			getProjectDetailResponse.RequestId = _ctx.StringValue("GetProjectDetail.RequestId");
			getProjectDetailResponse.Success = _ctx.BooleanValue("GetProjectDetail.Success");

			GetProjectDetailResponse.GetProjectDetail_Data data = new GetProjectDetailResponse.GetProjectDetail_Data();
			data.Status = _ctx.IntegerValue("GetProjectDetail.Data.Status");
			data.ResidentArea = _ctx.StringValue("GetProjectDetail.Data.ResidentArea");
			data.ProjectId = _ctx.IntegerValue("GetProjectDetail.Data.ProjectId");
			data.ProjectIdentifier = _ctx.StringValue("GetProjectDetail.Data.ProjectIdentifier");
			data.ProjectName = _ctx.StringValue("GetProjectDetail.Data.ProjectName");
			data.IsAllowDownload = _ctx.IntegerValue("GetProjectDetail.Data.IsAllowDownload");
			data.ProjectMode = _ctx.IntegerValue("GetProjectDetail.Data.ProjectMode");
			data.ProjectDescription = _ctx.StringValue("GetProjectDetail.Data.ProjectDescription");
			data.GmtModified = _ctx.StringValue("GetProjectDetail.Data.GmtModified");
			data.ProjectOwnerBaseId = _ctx.StringValue("GetProjectDetail.Data.ProjectOwnerBaseId");
			data.DevelopmentType = _ctx.IntegerValue("GetProjectDetail.Data.DevelopmentType");
			data.DefaultDiResourceGroupIdentifier = _ctx.StringValue("GetProjectDetail.Data.DefaultDiResourceGroupIdentifier");
			data.GmtCreate = _ctx.StringValue("GetProjectDetail.Data.GmtCreate");
			data.SchedulerMaxRetryTimes = _ctx.IntegerValue("GetProjectDetail.Data.SchedulerMaxRetryTimes");
			data.ProtectedMode = _ctx.IntegerValue("GetProjectDetail.Data.ProtectedMode");
			data.TenantId = _ctx.LongValue("GetProjectDetail.Data.TenantId");
			data.SchedulerRetryInterval = _ctx.IntegerValue("GetProjectDetail.Data.SchedulerRetryInterval");

			List<string> data_envTypes = new List<string>();
			for (int i = 0; i < _ctx.Length("GetProjectDetail.Data.EnvTypes.Length"); i++) {
				data_envTypes.Add(_ctx.StringValue("GetProjectDetail.Data.EnvTypes["+ i +"]"));
			}
			data.EnvTypes = data_envTypes;
			getProjectDetailResponse.Data = data;
        
			return getProjectDetailResponse;
        }
    }
}
