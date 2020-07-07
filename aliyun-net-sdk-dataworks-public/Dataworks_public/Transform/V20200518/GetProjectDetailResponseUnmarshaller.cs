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
        public static GetProjectDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectDetailResponse getProjectDetailResponse = new GetProjectDetailResponse();

			getProjectDetailResponse.HttpResponse = context.HttpResponse;
			getProjectDetailResponse.HttpStatusCode = context.IntegerValue("GetProjectDetail.HttpStatusCode");
			getProjectDetailResponse.Success = context.BooleanValue("GetProjectDetail.Success");
			getProjectDetailResponse.RequestId = context.StringValue("GetProjectDetail.RequestId");

			GetProjectDetailResponse.GetProjectDetail_Data data = new GetProjectDetailResponse.GetProjectDetail_Data();
			data.GmtModified = context.StringValue("GetProjectDetail.Data.GmtModified");
			data.DefaultDiResourceGroupIdentifier = context.StringValue("GetProjectDetail.Data.DefaultDiResourceGroupIdentifier");
			data.IsAllowDownload = context.IntegerValue("GetProjectDetail.Data.IsAllowDownload");
			data.SchedulerRetryInterval = context.IntegerValue("GetProjectDetail.Data.SchedulerRetryInterval");
			data.ResidentArea = context.StringValue("GetProjectDetail.Data.ResidentArea");
			data.ProjectOwnerBaseId = context.StringValue("GetProjectDetail.Data.ProjectOwnerBaseId");
			data.ProjectMode = context.IntegerValue("GetProjectDetail.Data.ProjectMode");
			data.GmtCreate = context.StringValue("GetProjectDetail.Data.GmtCreate");
			data.ProtectedMode = context.IntegerValue("GetProjectDetail.Data.ProtectedMode");
			data.TenantId = context.LongValue("GetProjectDetail.Data.TenantId");
			data.ProjectDescription = context.StringValue("GetProjectDetail.Data.ProjectDescription");
			data.SchedulerMaxRetryTimes = context.IntegerValue("GetProjectDetail.Data.SchedulerMaxRetryTimes");
			data.ProjectName = context.StringValue("GetProjectDetail.Data.ProjectName");
			data.ProjectIdentifier = context.StringValue("GetProjectDetail.Data.ProjectIdentifier");
			data.ProjectId = context.IntegerValue("GetProjectDetail.Data.ProjectId");
			data.Status = context.IntegerValue("GetProjectDetail.Data.Status");
			data.DevelopmentType = context.IntegerValue("GetProjectDetail.Data.DevelopmentType");

			List<string> data_envTypes = new List<string>();
			for (int i = 0; i < context.Length("GetProjectDetail.Data.EnvTypes.Length"); i++) {
				data_envTypes.Add(context.StringValue("GetProjectDetail.Data.EnvTypes["+ i +"]"));
			}
			data.EnvTypes = data_envTypes;
			getProjectDetailResponse.Data = data;
        
			return getProjectDetailResponse;
        }
    }
}
