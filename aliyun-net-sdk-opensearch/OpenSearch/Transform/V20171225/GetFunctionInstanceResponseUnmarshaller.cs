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
    public class GetFunctionInstanceResponseUnmarshaller
    {
        public static GetFunctionInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFunctionInstanceResponse getFunctionInstanceResponse = new GetFunctionInstanceResponse();

			getFunctionInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getFunctionInstanceResponse.Status = _ctx.StringValue("GetFunctionInstance.Status");
			getFunctionInstanceResponse.HttpCode = _ctx.LongValue("GetFunctionInstance.HttpCode");
			getFunctionInstanceResponse.RequestId = _ctx.StringValue("GetFunctionInstance.RequestId");
			getFunctionInstanceResponse.Message = _ctx.StringValue("GetFunctionInstance.Message");
			getFunctionInstanceResponse.Code = _ctx.StringValue("GetFunctionInstance.Code");
			getFunctionInstanceResponse.Latency = _ctx.LongValue("GetFunctionInstance.Latency");

			GetFunctionInstanceResponse.GetFunctionInstance_Result result = new GetFunctionInstanceResponse.GetFunctionInstance_Result();
			result.CreateTime = _ctx.LongValue("GetFunctionInstance.Result.CreateTime");
			result.Cron = _ctx.StringValue("GetFunctionInstance.Result.Cron");
			result.Description = _ctx.StringValue("GetFunctionInstance.Result.Description");
			result.ExtendInfo = _ctx.StringValue("GetFunctionInstance.Result.ExtendInfo");
			result.FunctionName = _ctx.StringValue("GetFunctionInstance.Result.FunctionName");
			result.FunctionType = _ctx.StringValue("GetFunctionInstance.Result.FunctionType");
			result.InstanceName = _ctx.StringValue("GetFunctionInstance.Result.InstanceName");
			result.ModelType = _ctx.StringValue("GetFunctionInstance.Result.ModelType");
			result.Source = _ctx.StringValue("GetFunctionInstance.Result.Source");
			result.Status = _ctx.StringValue("GetFunctionInstance.Result.Status");
			result.VersionId = _ctx.LongValue("GetFunctionInstance.Result.VersionId");

			GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_Belongs belongs = new GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_Belongs();
			belongs.Category = _ctx.StringValue("GetFunctionInstance.Result.Belongs.Category");
			belongs.Domain = _ctx.StringValue("GetFunctionInstance.Result.Belongs.Domain");
			belongs.Language = _ctx.StringValue("GetFunctionInstance.Result.Belongs.Language");
			result.Belongs = belongs;

			GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_Task task = new GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_Task();
			task.DagStatus = _ctx.StringValue("GetFunctionInstance.Result.Task.DagStatus");
			task.LastRunTime = _ctx.LongValue("GetFunctionInstance.Result.Task.LastRunTime");
			result.Task = task;

			List<GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_CreateParametersItem> result_createParameters = new List<GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_CreateParametersItem>();
			for (int i = 0; i < _ctx.Length("GetFunctionInstance.Result.CreateParameters.Length"); i++) {
				GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_CreateParametersItem createParametersItem = new GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_CreateParametersItem();
				createParametersItem.Name = _ctx.StringValue("GetFunctionInstance.Result.CreateParameters["+ i +"].Name");
				createParametersItem._Value = _ctx.StringValue("GetFunctionInstance.Result.CreateParameters["+ i +"].Value");

				result_createParameters.Add(createParametersItem);
			}
			result.CreateParameters = result_createParameters;

			List<GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_UsageParametersItem> result_usageParameters = new List<GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_UsageParametersItem>();
			for (int i = 0; i < _ctx.Length("GetFunctionInstance.Result.UsageParameters.Length"); i++) {
				GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_UsageParametersItem usageParametersItem = new GetFunctionInstanceResponse.GetFunctionInstance_Result.GetFunctionInstance_UsageParametersItem();
				usageParametersItem.Name = _ctx.StringValue("GetFunctionInstance.Result.UsageParameters["+ i +"].Name");
				usageParametersItem._Value = _ctx.StringValue("GetFunctionInstance.Result.UsageParameters["+ i +"].Value");

				result_usageParameters.Add(usageParametersItem);
			}
			result.UsageParameters = result_usageParameters;
			getFunctionInstanceResponse.Result = result;
        
			return getFunctionInstanceResponse;
        }
    }
}
