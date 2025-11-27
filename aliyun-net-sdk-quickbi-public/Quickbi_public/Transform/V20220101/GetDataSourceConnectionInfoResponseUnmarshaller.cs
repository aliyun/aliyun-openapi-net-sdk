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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class GetDataSourceConnectionInfoResponseUnmarshaller
    {
        public static GetDataSourceConnectionInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataSourceConnectionInfoResponse getDataSourceConnectionInfoResponse = new GetDataSourceConnectionInfoResponse();

			getDataSourceConnectionInfoResponse.HttpResponse = _ctx.HttpResponse;
			getDataSourceConnectionInfoResponse.RequestId = _ctx.StringValue("GetDataSourceConnectionInfo.RequestId");
			getDataSourceConnectionInfoResponse.Success = _ctx.BooleanValue("GetDataSourceConnectionInfo.Success");

			GetDataSourceConnectionInfoResponse.GetDataSourceConnectionInfo_Result result = new GetDataSourceConnectionInfoResponse.GetDataSourceConnectionInfo_Result();
			result.Address = _ctx.StringValue("GetDataSourceConnectionInfo.Result.Address");
			result.AuthLevel = _ctx.StringValue("GetDataSourceConnectionInfo.Result.AuthLevel");
			result.CreatorId = _ctx.StringValue("GetDataSourceConnectionInfo.Result.CreatorId");
			result.DsId = _ctx.StringValue("GetDataSourceConnectionInfo.Result.DsId");
			result.DsType = _ctx.StringValue("GetDataSourceConnectionInfo.Result.DsType");
			result.DsVersion = _ctx.StringValue("GetDataSourceConnectionInfo.Result.DsVersion");
			result.Instance = _ctx.StringValue("GetDataSourceConnectionInfo.Result.Instance");
			result.InstanceId = _ctx.StringValue("GetDataSourceConnectionInfo.Result.InstanceId");
			result.ModifyUser = _ctx.StringValue("GetDataSourceConnectionInfo.Result.ModifyUser");
			result.NoSasl = _ctx.BooleanValue("GetDataSourceConnectionInfo.Result.NoSasl");
			result.ParentDsType = _ctx.StringValue("GetDataSourceConnectionInfo.Result.ParentDsType");
			result.Port = _ctx.StringValue("GetDataSourceConnectionInfo.Result.Port");
			result.Project = _ctx.StringValue("GetDataSourceConnectionInfo.Result.Project");
			result.Schema = _ctx.StringValue("GetDataSourceConnectionInfo.Result.Schema");
			result.ShowName = _ctx.StringValue("GetDataSourceConnectionInfo.Result.ShowName");
			result.WorkspaceId = _ctx.StringValue("GetDataSourceConnectionInfo.Result.WorkspaceId");
			getDataSourceConnectionInfoResponse.Result = result;
        
			return getDataSourceConnectionInfoResponse;
        }
    }
}
