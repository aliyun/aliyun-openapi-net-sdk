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
    public class GetFunctionCurrentVersionResponseUnmarshaller
    {
        public static GetFunctionCurrentVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFunctionCurrentVersionResponse getFunctionCurrentVersionResponse = new GetFunctionCurrentVersionResponse();

			getFunctionCurrentVersionResponse.HttpResponse = _ctx.HttpResponse;
			getFunctionCurrentVersionResponse.Status = _ctx.StringValue("GetFunctionCurrentVersion.Status");
			getFunctionCurrentVersionResponse.HttpCode = _ctx.LongValue("GetFunctionCurrentVersion.HttpCode");
			getFunctionCurrentVersionResponse.RequestId = _ctx.StringValue("GetFunctionCurrentVersion.RequestId");
			getFunctionCurrentVersionResponse.Message = _ctx.StringValue("GetFunctionCurrentVersion.Message");
			getFunctionCurrentVersionResponse.Code = _ctx.StringValue("GetFunctionCurrentVersion.Code");
			getFunctionCurrentVersionResponse.Latency = _ctx.LongValue("GetFunctionCurrentVersion.Latency");

			GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result result = new GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result();
			result.FunctionName = _ctx.StringValue("GetFunctionCurrentVersion.Result.FunctionName");
			result.FunctionType = _ctx.StringValue("GetFunctionCurrentVersion.Result.FunctionType");
			result.ModelType = _ctx.StringValue("GetFunctionCurrentVersion.Result.ModelType");
			result.VersionId = _ctx.LongValue("GetFunctionCurrentVersion.Result.VersionId");
			result.VersionName = _ctx.StringValue("GetFunctionCurrentVersion.Result.VersionName");

			GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig versionConfig = new GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig();

			List<GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_CreateParametersItem> versionConfig_createParameters = new List<GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_CreateParametersItem>();
			for (int i = 0; i < _ctx.Length("GetFunctionCurrentVersion.Result.VersionConfig.CreateParameters.Length"); i++) {
				GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_CreateParametersItem createParametersItem = new GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_CreateParametersItem();
				createParametersItem.Name = _ctx.StringValue("GetFunctionCurrentVersion.Result.VersionConfig.CreateParameters["+ i +"].Name");
				createParametersItem.Required = _ctx.StringValue("GetFunctionCurrentVersion.Result.VersionConfig.CreateParameters["+ i +"].Required");

				versionConfig_createParameters.Add(createParametersItem);
			}
			versionConfig.CreateParameters = versionConfig_createParameters;

			List<GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_DependsItem> versionConfig_depends = new List<GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_DependsItem>();
			for (int i = 0; i < _ctx.Length("GetFunctionCurrentVersion.Result.VersionConfig.Depends.Length"); i++) {
				GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_DependsItem dependsItem = new GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_DependsItem();
				dependsItem.Condition = _ctx.StringValue("GetFunctionCurrentVersion.Result.VersionConfig.Depends["+ i +"].Condition");
				dependsItem.Dependency = _ctx.StringValue("GetFunctionCurrentVersion.Result.VersionConfig.Depends["+ i +"].Dependency");
				dependsItem.Description = _ctx.StringValue("GetFunctionCurrentVersion.Result.VersionConfig.Depends["+ i +"].Description");

				versionConfig_depends.Add(dependsItem);
			}
			versionConfig.Depends = versionConfig_depends;

			List<GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_UsageParametersItem> versionConfig_usageParameters = new List<GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_UsageParametersItem>();
			for (int i = 0; i < _ctx.Length("GetFunctionCurrentVersion.Result.VersionConfig.UsageParameters.Length"); i++) {
				GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_UsageParametersItem usageParametersItem = new GetFunctionCurrentVersionResponse.GetFunctionCurrentVersion_Result.GetFunctionCurrentVersion_VersionConfig.GetFunctionCurrentVersion_UsageParametersItem();
				usageParametersItem.Name = _ctx.StringValue("GetFunctionCurrentVersion.Result.VersionConfig.UsageParameters["+ i +"].Name");
				usageParametersItem.Required = _ctx.StringValue("GetFunctionCurrentVersion.Result.VersionConfig.UsageParameters["+ i +"].Required");

				versionConfig_usageParameters.Add(usageParametersItem);
			}
			versionConfig.UsageParameters = versionConfig_usageParameters;
			result.VersionConfig = versionConfig;
			getFunctionCurrentVersionResponse.Result = result;
        
			return getFunctionCurrentVersionResponse;
        }
    }
}
