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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetGrayAppsResponseUnmarshaller
    {
        public static GetGrayAppsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetGrayAppsResponse getGrayAppsResponse = new GetGrayAppsResponse();

			getGrayAppsResponse.HttpResponse = _ctx.HttpResponse;
			getGrayAppsResponse.RequestId = _ctx.StringValue("GetGrayApps.RequestId");
			getGrayAppsResponse.Code = _ctx.IntegerValue("GetGrayApps.Code");
			getGrayAppsResponse.Message = _ctx.StringValue("GetGrayApps.Message");

			GetGrayAppsResponse.GetGrayApps_Data data = new GetGrayAppsResponse.GetGrayApps_Data();

			GetGrayAppsResponse.GetGrayApps_Data.GetGrayApps_Result result = new GetGrayAppsResponse.GetGrayApps_Data.GetGrayApps_Result();
			result.AppId = _ctx.StringValue("GetGrayApps.Data.Result.AppId");
			result.ApplicationType = _ctx.StringValue("GetGrayApps.Data.Result.ApplicationType");
			result.Appname = _ctx.StringValue("GetGrayApps.Data.Result.Appname");
			result.DefaultGroupId = _ctx.StringValue("GetGrayApps.Data.Result.DefaultGroupId");
			result.PackageVersion = _ctx.StringValue("GetGrayApps.Data.Result.PackageVersion");
			result.RegionId = _ctx.StringValue("GetGrayApps.Data.Result.RegionId");
			result.DevelopType = _ctx.StringValue("GetGrayApps.Data.Result.DevelopType");
			data.Result = result;
			getGrayAppsResponse.Data = data;
        
			return getGrayAppsResponse;
        }
    }
}
