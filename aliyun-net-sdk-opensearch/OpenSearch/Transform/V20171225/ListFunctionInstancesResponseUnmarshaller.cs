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
    public class ListFunctionInstancesResponseUnmarshaller
    {
        public static ListFunctionInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFunctionInstancesResponse listFunctionInstancesResponse = new ListFunctionInstancesResponse();

			listFunctionInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listFunctionInstancesResponse.Status = _ctx.StringValue("ListFunctionInstances.Status");
			listFunctionInstancesResponse.HttpCode = _ctx.LongValue("ListFunctionInstances.HttpCode");
			listFunctionInstancesResponse.TotalCount = _ctx.LongValue("ListFunctionInstances.TotalCount");
			listFunctionInstancesResponse.RequestId = _ctx.StringValue("ListFunctionInstances.RequestId");
			listFunctionInstancesResponse.Message = _ctx.StringValue("ListFunctionInstances.Message");
			listFunctionInstancesResponse.Code = _ctx.StringValue("ListFunctionInstances.Code");
			listFunctionInstancesResponse.Latency = _ctx.LongValue("ListFunctionInstances.Latency");

			List<ListFunctionInstancesResponse.ListFunctionInstances_ResultItem> listFunctionInstancesResponse_result = new List<ListFunctionInstancesResponse.ListFunctionInstances_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListFunctionInstances.Result.Length"); i++) {
				ListFunctionInstancesResponse.ListFunctionInstances_ResultItem resultItem = new ListFunctionInstancesResponse.ListFunctionInstances_ResultItem();
				resultItem.CreateTime = _ctx.LongValue("ListFunctionInstances.Result["+ i +"].CreateTime");
				resultItem.Cron = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].Cron");
				resultItem.Description = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].Description");
				resultItem.ExtendInfo = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].ExtendInfo");
				resultItem.FunctionName = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].FunctionName");
				resultItem.FunctionType = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].FunctionType");
				resultItem.InstanceName = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].InstanceName");
				resultItem.ModelType = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].ModelType");
				resultItem.Source = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].Source");
				resultItem.Status = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].Status");
				resultItem.VersionId = _ctx.LongValue("ListFunctionInstances.Result["+ i +"].VersionId");

				ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_Belongs belongs = new ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_Belongs();
				belongs.Category = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].Belongs.Category");
				belongs.Domain = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].Belongs.Domain");
				belongs.Language = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].Belongs.Language");
				resultItem.Belongs = belongs;

				List<ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_CreateParametersItem> resultItem_createParameters = new List<ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_CreateParametersItem>();
				for (int j = 0; j < _ctx.Length("ListFunctionInstances.Result["+ i +"].CreateParameters.Length"); j++) {
					ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_CreateParametersItem createParametersItem = new ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_CreateParametersItem();
					createParametersItem.Name = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].CreateParameters["+ j +"].Name");
					createParametersItem._Value = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].CreateParameters["+ j +"].Value");

					resultItem_createParameters.Add(createParametersItem);
				}
				resultItem.CreateParameters = resultItem_createParameters;

				List<ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_UsageParametersItem> resultItem_usageParameters = new List<ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_UsageParametersItem>();
				for (int j = 0; j < _ctx.Length("ListFunctionInstances.Result["+ i +"].UsageParameters.Length"); j++) {
					ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_UsageParametersItem usageParametersItem = new ListFunctionInstancesResponse.ListFunctionInstances_ResultItem.ListFunctionInstances_UsageParametersItem();
					usageParametersItem.Name = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].UsageParameters["+ j +"].Name");
					usageParametersItem._Value = _ctx.StringValue("ListFunctionInstances.Result["+ i +"].UsageParameters["+ j +"].Value");

					resultItem_usageParameters.Add(usageParametersItem);
				}
				resultItem.UsageParameters = resultItem_usageParameters;

				listFunctionInstancesResponse_result.Add(resultItem);
			}
			listFunctionInstancesResponse.Result = listFunctionInstancesResponse_result;
        
			return listFunctionInstancesResponse;
        }
    }
}
