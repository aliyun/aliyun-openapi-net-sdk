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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListLLMConfigsResponseUnmarshaller
    {
        public static ListLLMConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLLMConfigsResponse listLLMConfigsResponse = new ListLLMConfigsResponse();

			listLLMConfigsResponse.HttpResponse = _ctx.HttpResponse;
			listLLMConfigsResponse.RequestId = _ctx.StringValue("ListLLMConfigs.RequestId");
			listLLMConfigsResponse.TotalCount = _ctx.LongValue("ListLLMConfigs.TotalCount");
			listLLMConfigsResponse.NextToken = _ctx.StringValue("ListLLMConfigs.NextToken");
			listLLMConfigsResponse.MaxResults = _ctx.IntegerValue("ListLLMConfigs.MaxResults");

			List<ListLLMConfigsResponse.ListLLMConfigs_LlmConfigsItem> listLLMConfigsResponse_lLMConfigs = new List<ListLLMConfigsResponse.ListLLMConfigs_LlmConfigsItem>();
			for (int i = 0; i < _ctx.Length("ListLLMConfigs.LLMConfigs.Length"); i++) {
				ListLLMConfigsResponse.ListLLMConfigs_LlmConfigsItem llmConfigsItem = new ListLLMConfigsResponse.ListLLMConfigs_LlmConfigsItem();
				llmConfigsItem.LLMConfigId = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].LLMConfigId");
				llmConfigsItem.Name = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].Name");
				llmConfigsItem.ApiKey = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].ApiKey");
				llmConfigsItem.Model = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].Model");
				llmConfigsItem.BaseUrl = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].BaseUrl");
				llmConfigsItem.Rps = _ctx.IntegerValue("ListLLMConfigs.LLMConfigs["+ i +"].Rps");
				llmConfigsItem.MaxTokens = _ctx.IntegerValue("ListLLMConfigs.LLMConfigs["+ i +"].MaxTokens");
				llmConfigsItem.GmtCreateTime = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].GmtCreateTime");
				llmConfigsItem.GmtModifiedTime = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].GmtModifiedTime");
				llmConfigsItem.ResourceGroupId = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].ResourceGroupId");
				llmConfigsItem.BatchSize = _ctx.IntegerValue("ListLLMConfigs.LLMConfigs["+ i +"].BatchSize");
				llmConfigsItem.WorkspaceId = _ctx.StringValue("ListLLMConfigs.LLMConfigs["+ i +"].WorkspaceId");

				listLLMConfigsResponse_lLMConfigs.Add(llmConfigsItem);
			}
			listLLMConfigsResponse.LLMConfigs = listLLMConfigsResponse_lLMConfigs;
        
			return listLLMConfigsResponse;
        }
    }
}
