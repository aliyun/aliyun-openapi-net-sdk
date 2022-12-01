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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class GetFunctionVersionResponseUnmarshaller
    {
        public static GetFunctionVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFunctionVersionResponse getFunctionVersionResponse = new GetFunctionVersionResponse();

			getFunctionVersionResponse.HttpResponse = _ctx.HttpResponse;
			getFunctionVersionResponse.Status = _ctx.StringValue("GetFunctionVersion.Status");
			getFunctionVersionResponse.HttpCode = _ctx.LongValue("GetFunctionVersion.HttpCode");
			getFunctionVersionResponse.RequestId = _ctx.StringValue("GetFunctionVersion.RequestId");
			getFunctionVersionResponse.Message = _ctx.StringValue("GetFunctionVersion.Message");
			getFunctionVersionResponse.Code = _ctx.StringValue("GetFunctionVersion.Code");
			getFunctionVersionResponse.Latency = _ctx.LongValue("GetFunctionVersion.Latency");

			GetFunctionVersionResponse.GetFunctionVersion_Result result = new GetFunctionVersionResponse.GetFunctionVersion_Result();
			result.FunctionName = _ctx.StringValue("GetFunctionVersion.Result.FunctionName");
			result.FunctionType = _ctx.StringValue("GetFunctionVersion.Result.FunctionType");
			result.ModelType = _ctx.StringValue("GetFunctionVersion.Result.ModelType");
			result.VersionId = _ctx.LongValue("GetFunctionVersion.Result.VersionId");
			result.VersionName = _ctx.StringValue("GetFunctionVersion.Result.VersionName");

			GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig versionConfig = new GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig();

			List<GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_CreateParametersItem> versionConfig_createParameters = new List<GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_CreateParametersItem>();
			for (int i = 0; i < _ctx.Length("GetFunctionVersion.Result.VersionConfig.CreateParameters.Length"); i++) {
				GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_CreateParametersItem createParametersItem = new GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_CreateParametersItem();
				createParametersItem.Name = _ctx.StringValue("GetFunctionVersion.Result.VersionConfig.CreateParameters["+ i +"].Name");
				createParametersItem.Required = _ctx.StringValue("GetFunctionVersion.Result.VersionConfig.CreateParameters["+ i +"].Required");

				versionConfig_createParameters.Add(createParametersItem);
			}
			versionConfig.CreateParameters = versionConfig_createParameters;

			List<GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_DependsItem> versionConfig_depends = new List<GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_DependsItem>();
			for (int i = 0; i < _ctx.Length("GetFunctionVersion.Result.VersionConfig.Depends.Length"); i++) {
				GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_DependsItem dependsItem = new GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_DependsItem();
				dependsItem.Condition = _ctx.StringValue("GetFunctionVersion.Result.VersionConfig.Depends["+ i +"].Condition");
				dependsItem.Dependency = _ctx.StringValue("GetFunctionVersion.Result.VersionConfig.Depends["+ i +"].Dependency");
				dependsItem.Description = _ctx.StringValue("GetFunctionVersion.Result.VersionConfig.Depends["+ i +"].Description");

				versionConfig_depends.Add(dependsItem);
			}
			versionConfig.Depends = versionConfig_depends;

			List<GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_UsageParametersItem> versionConfig_usageParameters = new List<GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_UsageParametersItem>();
			for (int i = 0; i < _ctx.Length("GetFunctionVersion.Result.VersionConfig.UsageParameters.Length"); i++) {
				GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_UsageParametersItem usageParametersItem = new GetFunctionVersionResponse.GetFunctionVersion_Result.GetFunctionVersion_VersionConfig.GetFunctionVersion_UsageParametersItem();
				usageParametersItem.Name = _ctx.StringValue("GetFunctionVersion.Result.VersionConfig.UsageParameters["+ i +"].Name");
				usageParametersItem.Required = _ctx.StringValue("GetFunctionVersion.Result.VersionConfig.UsageParameters["+ i +"].Required");

				versionConfig_usageParameters.Add(usageParametersItem);
			}
			versionConfig.UsageParameters = versionConfig_usageParameters;
			result.VersionConfig = versionConfig;
			getFunctionVersionResponse.Result = result;
        
			return getFunctionVersionResponse;
        }
    }
}
