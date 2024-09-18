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
    public class QueryCopilotEmbedConfigResponseUnmarshaller
    {
        public static QueryCopilotEmbedConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCopilotEmbedConfigResponse queryCopilotEmbedConfigResponse = new QueryCopilotEmbedConfigResponse();

			queryCopilotEmbedConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryCopilotEmbedConfigResponse.RequestId = _ctx.StringValue("QueryCopilotEmbedConfig.RequestId");
			queryCopilotEmbedConfigResponse.Success = _ctx.BooleanValue("QueryCopilotEmbedConfig.Success");

			List<QueryCopilotEmbedConfigResponse.QueryCopilotEmbedConfig_ResultItem> queryCopilotEmbedConfigResponse_result = new List<QueryCopilotEmbedConfigResponse.QueryCopilotEmbedConfig_ResultItem>();
			for (int i = 0; i < _ctx.Length("QueryCopilotEmbedConfig.Result.Length"); i++) {
				QueryCopilotEmbedConfigResponse.QueryCopilotEmbedConfig_ResultItem resultItem = new QueryCopilotEmbedConfigResponse.QueryCopilotEmbedConfig_ResultItem();
				resultItem.AgentName = _ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].AgentName");
				resultItem.CopilotId = _ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].CopilotId");
				resultItem.CreateUser = _ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].CreateUser");
				resultItem.CreateUserName = _ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].CreateUserName");
				resultItem.ModifyUser = _ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].ModifyUser");
				resultItem.ModuleName = _ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].ModuleName");
				resultItem.ShowName = _ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].ShowName");

				QueryCopilotEmbedConfigResponse.QueryCopilotEmbedConfig_ResultItem.QueryCopilotEmbedConfig_DataRange dataRange = new QueryCopilotEmbedConfigResponse.QueryCopilotEmbedConfig_ResultItem.QueryCopilotEmbedConfig_DataRange();
				dataRange.AllCube = _ctx.BooleanValue("QueryCopilotEmbedConfig.Result["+ i +"].DataRange.AllCube");
				dataRange.AllTheme = _ctx.BooleanValue("QueryCopilotEmbedConfig.Result["+ i +"].DataRange.AllTheme");

				List<string> dataRange_llmCubes = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryCopilotEmbedConfig.Result["+ i +"].DataRange.LlmCubes.Length"); j++) {
					dataRange_llmCubes.Add(_ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].DataRange.LlmCubes["+ j +"]"));
				}
				dataRange.LlmCubes = dataRange_llmCubes;

				List<string> dataRange_themes = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryCopilotEmbedConfig.Result["+ i +"].DataRange.Themes.Length"); j++) {
					dataRange_themes.Add(_ctx.StringValue("QueryCopilotEmbedConfig.Result["+ i +"].DataRange.Themes["+ j +"]"));
				}
				dataRange.Themes = dataRange_themes;
				resultItem.DataRange = dataRange;

				queryCopilotEmbedConfigResponse_result.Add(resultItem);
			}
			queryCopilotEmbedConfigResponse.Result = queryCopilotEmbedConfigResponse_result;
        
			return queryCopilotEmbedConfigResponse;
        }
    }
}
