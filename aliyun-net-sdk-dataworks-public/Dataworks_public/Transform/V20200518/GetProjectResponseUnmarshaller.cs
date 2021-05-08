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
    public class GetProjectResponseUnmarshaller
    {
        public static GetProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetProjectResponse getProjectResponse = new GetProjectResponse();

			getProjectResponse.HttpResponse = _ctx.HttpResponse;
			getProjectResponse.HttpStatusCode = _ctx.IntegerValue("GetProject.HttpStatusCode");
			getProjectResponse.Success = _ctx.BooleanValue("GetProject.Success");
			getProjectResponse.RequestId = _ctx.StringValue("GetProject.RequestId");

			GetProjectResponse.GetProject_Data data = new GetProjectResponse.GetProject_Data();
			data.GmtModified = _ctx.StringValue("GetProject.Data.GmtModified");
			data.MaxFlowNode = _ctx.IntegerValue("GetProject.Data.MaxFlowNode");
			data.DefaultDiResourceGroupIdentifier = _ctx.StringValue("GetProject.Data.DefaultDiResourceGroupIdentifier");
			data.Destination = _ctx.IntegerValue("GetProject.Data.Destination");
			data.IsAllowDownload = _ctx.IntegerValue("GetProject.Data.IsAllowDownload");
			data.ProdStorageQuota = _ctx.StringValue("GetProject.Data.ProdStorageQuota");
			data.SchedulerRetryInterval = _ctx.IntegerValue("GetProject.Data.SchedulerRetryInterval");
			data.ResidentArea = _ctx.StringValue("GetProject.Data.ResidentArea");
			data.TablePrivacyMode = _ctx.IntegerValue("GetProject.Data.TablePrivacyMode");
			data.ProjectOwnerBaseId = _ctx.StringValue("GetProject.Data.ProjectOwnerBaseId");
			data.UseProxyOdpsAccount = _ctx.BooleanValue("GetProject.Data.UseProxyOdpsAccount");
			data.DisableDevelopment = _ctx.BooleanValue("GetProject.Data.DisableDevelopment");
			data.ProjectMode = _ctx.IntegerValue("GetProject.Data.ProjectMode");
			data.GmtCreate = _ctx.StringValue("GetProject.Data.GmtCreate");
			data.DevStorageQuota = _ctx.StringValue("GetProject.Data.DevStorageQuota");
			data.IsDefault = _ctx.IntegerValue("GetProject.Data.IsDefault");
			data.ProtectedMode = _ctx.IntegerValue("GetProject.Data.ProtectedMode");
			data.BaseProject = _ctx.BooleanValue("GetProject.Data.BaseProject");
			data.TenantId = _ctx.LongValue("GetProject.Data.TenantId");
			data.ProjectDescription = _ctx.StringValue("GetProject.Data.ProjectDescription");
			data.Appkey = _ctx.StringValue("GetProject.Data.Appkey");
			data.SchedulerMaxRetryTimes = _ctx.IntegerValue("GetProject.Data.SchedulerMaxRetryTimes");
			data.ProjectName = _ctx.StringValue("GetProject.Data.ProjectName");
			data.ProjectIdentifier = _ctx.StringValue("GetProject.Data.ProjectIdentifier");
			data.ProjectId = _ctx.IntegerValue("GetProject.Data.ProjectId");
			data.Status = _ctx.IntegerValue("GetProject.Data.Status");
			data.DevelopmentType = _ctx.IntegerValue("GetProject.Data.DevelopmentType");

			List<string> data_envTypes = new List<string>();
			for (int i = 0; i < _ctx.Length("GetProject.Data.EnvTypes.Length"); i++) {
				data_envTypes.Add(_ctx.StringValue("GetProject.Data.EnvTypes["+ i +"]"));
			}
			data.EnvTypes = data_envTypes;
			getProjectResponse.Data = data;
        
			return getProjectResponse;
        }
    }
}
