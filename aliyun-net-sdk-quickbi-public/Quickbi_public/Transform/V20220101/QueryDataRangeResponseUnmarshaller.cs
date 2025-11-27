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
    public class QueryDataRangeResponseUnmarshaller
    {
        public static QueryDataRangeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDataRangeResponse queryDataRangeResponse = new QueryDataRangeResponse();

			queryDataRangeResponse.HttpResponse = _ctx.HttpResponse;
			queryDataRangeResponse.RequestId = _ctx.StringValue("QueryDataRange.RequestId");
			queryDataRangeResponse.Success = _ctx.BooleanValue("QueryDataRange.Success");

			QueryDataRangeResponse.QueryDataRange_Result result = new QueryDataRangeResponse.QueryDataRange_Result();

			List<QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotLlmCubeModelsItem> result_apiCopilotLlmCubeModels = new List<QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotLlmCubeModelsItem>();
			for (int i = 0; i < _ctx.Length("QueryDataRange.Result.ApiCopilotLlmCubeModels.Length"); i++) {
				QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotLlmCubeModelsItem apiCopilotLlmCubeModelsItem = new QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotLlmCubeModelsItem();
				apiCopilotLlmCubeModelsItem.Alias = _ctx.StringValue("QueryDataRange.Result.ApiCopilotLlmCubeModels["+ i +"].Alias");
				apiCopilotLlmCubeModelsItem.CreateUser = _ctx.StringValue("QueryDataRange.Result.ApiCopilotLlmCubeModels["+ i +"].CreateUser");
				apiCopilotLlmCubeModelsItem.LlmCubeId = _ctx.StringValue("QueryDataRange.Result.ApiCopilotLlmCubeModels["+ i +"].LlmCubeId");

				result_apiCopilotLlmCubeModels.Add(apiCopilotLlmCubeModelsItem);
			}
			result.ApiCopilotLlmCubeModels = result_apiCopilotLlmCubeModels;

			List<QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotThemeModelsItem> result_apiCopilotThemeModels = new List<QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotThemeModelsItem>();
			for (int i = 0; i < _ctx.Length("QueryDataRange.Result.ApiCopilotThemeModels.Length"); i++) {
				QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotThemeModelsItem apiCopilotThemeModelsItem = new QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotThemeModelsItem();
				apiCopilotThemeModelsItem.CreateUser = _ctx.StringValue("QueryDataRange.Result.ApiCopilotThemeModels["+ i +"].CreateUser");
				apiCopilotThemeModelsItem.ThemeId = _ctx.StringValue("QueryDataRange.Result.ApiCopilotThemeModels["+ i +"].ThemeId");
				apiCopilotThemeModelsItem.ThemeName = _ctx.StringValue("QueryDataRange.Result.ApiCopilotThemeModels["+ i +"].ThemeName");

				List<QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotThemeModelsItem.QueryDataRange_ApiCopilotLlmCubeModelsItem2> apiCopilotThemeModelsItem_apiCopilotLlmCubeModels1 = new List<QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotThemeModelsItem.QueryDataRange_ApiCopilotLlmCubeModelsItem2>();
				for (int j = 0; j < _ctx.Length("QueryDataRange.Result.ApiCopilotThemeModels["+ i +"].ApiCopilotLlmCubeModels.Length"); j++) {
					QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotThemeModelsItem.QueryDataRange_ApiCopilotLlmCubeModelsItem2 apiCopilotLlmCubeModelsItem2 = new QueryDataRangeResponse.QueryDataRange_Result.QueryDataRange_ApiCopilotThemeModelsItem.QueryDataRange_ApiCopilotLlmCubeModelsItem2();
					apiCopilotLlmCubeModelsItem2.Alias = _ctx.StringValue("QueryDataRange.Result.ApiCopilotThemeModels["+ i +"].ApiCopilotLlmCubeModels["+ j +"].Alias");
					apiCopilotLlmCubeModelsItem2.CreateUser = _ctx.StringValue("QueryDataRange.Result.ApiCopilotThemeModels["+ i +"].ApiCopilotLlmCubeModels["+ j +"].CreateUser");
					apiCopilotLlmCubeModelsItem2.LlmCubeId = _ctx.StringValue("QueryDataRange.Result.ApiCopilotThemeModels["+ i +"].ApiCopilotLlmCubeModels["+ j +"].LlmCubeId");

					apiCopilotThemeModelsItem_apiCopilotLlmCubeModels1.Add(apiCopilotLlmCubeModelsItem2);
				}
				apiCopilotThemeModelsItem.ApiCopilotLlmCubeModels1 = apiCopilotThemeModelsItem_apiCopilotLlmCubeModels1;

				result_apiCopilotThemeModels.Add(apiCopilotThemeModelsItem);
			}
			result.ApiCopilotThemeModels = result_apiCopilotThemeModels;
			queryDataRangeResponse.Result = result;
        
			return queryDataRangeResponse;
        }
    }
}
