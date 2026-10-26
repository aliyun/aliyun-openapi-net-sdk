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
    public class QueryAiproEmbedConfigResponseUnmarshaller
    {
        public static QueryAiproEmbedConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAiproEmbedConfigResponse queryAiproEmbedConfigResponse = new QueryAiproEmbedConfigResponse();

			queryAiproEmbedConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryAiproEmbedConfigResponse.RequestId = _ctx.StringValue("QueryAiproEmbedConfig.RequestId");
			queryAiproEmbedConfigResponse.Success = _ctx.BooleanValue("QueryAiproEmbedConfig.Success");

			List<QueryAiproEmbedConfigResponse.QueryAiproEmbedConfig_Data> queryAiproEmbedConfigResponse_result = new List<QueryAiproEmbedConfigResponse.QueryAiproEmbedConfig_Data>();
			for (int i = 0; i < _ctx.Length("QueryAiproEmbedConfig.Result.Length"); i++) {
				QueryAiproEmbedConfigResponse.QueryAiproEmbedConfig_Data data = new QueryAiproEmbedConfigResponse.QueryAiproEmbedConfig_Data();
				data.Status = _ctx.IntegerValue("QueryAiproEmbedConfig.Result["+ i +"].Status");
				data.ChatHistoryStatus = _ctx.IntegerValue("QueryAiproEmbedConfig.Result["+ i +"].ChatHistoryStatus");
				data.NextToken = _ctx.StringValue("QueryAiproEmbedConfig.Result["+ i +"].NextToken");
				data.Config = _ctx.StringValue("QueryAiproEmbedConfig.Result["+ i +"].Config");
				data.MemoryEnabled = _ctx.IntegerValue("QueryAiproEmbedConfig.Result["+ i +"].MemoryEnabled");
				data.MaxResults = _ctx.IntegerValue("QueryAiproEmbedConfig.Result["+ i +"].MaxResults");
				data.UploadEnabled = _ctx.IntegerValue("QueryAiproEmbedConfig.Result["+ i +"].UploadEnabled");
				data.AgentName = _ctx.StringValue("QueryAiproEmbedConfig.Result["+ i +"].AgentName");
				data.ShowName = _ctx.StringValue("QueryAiproEmbedConfig.Result["+ i +"].ShowName");
				data.AiProId = _ctx.StringValue("QueryAiproEmbedConfig.Result["+ i +"].AiProId");

				queryAiproEmbedConfigResponse_result.Add(data);
			}
			queryAiproEmbedConfigResponse.Result = queryAiproEmbedConfigResponse_result;
        
			return queryAiproEmbedConfigResponse;
        }
    }
}
