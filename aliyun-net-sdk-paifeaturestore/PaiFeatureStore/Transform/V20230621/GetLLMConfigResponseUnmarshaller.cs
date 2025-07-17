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
    public class GetLLMConfigResponseUnmarshaller
    {
        public static GetLLMConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLLMConfigResponse getLLMConfigResponse = new GetLLMConfigResponse();

			getLLMConfigResponse.HttpResponse = _ctx.HttpResponse;
			getLLMConfigResponse.RequestId = _ctx.StringValue("GetLLMConfig.RequestId");
			getLLMConfigResponse.LLMConfigId = _ctx.StringValue("GetLLMConfig.LLMConfigId");
			getLLMConfigResponse.Name = _ctx.StringValue("GetLLMConfig.Name");
			getLLMConfigResponse.ApiKey = _ctx.StringValue("GetLLMConfig.ApiKey");
			getLLMConfigResponse.Model = _ctx.StringValue("GetLLMConfig.Model");
			getLLMConfigResponse.BaseUrl = _ctx.StringValue("GetLLMConfig.BaseUrl");
			getLLMConfigResponse.Rps = _ctx.IntegerValue("GetLLMConfig.Rps");
			getLLMConfigResponse.MaxTokens = _ctx.IntegerValue("GetLLMConfig.MaxTokens");
			getLLMConfigResponse.GmtCreateTime = _ctx.StringValue("GetLLMConfig.GmtCreateTime");
			getLLMConfigResponse.GmtModifiedTime = _ctx.StringValue("GetLLMConfig.GmtModifiedTime");
			getLLMConfigResponse.BatchSize = _ctx.IntegerValue("GetLLMConfig.BatchSize");
			getLLMConfigResponse.WorkspaceId = _ctx.StringValue("GetLLMConfig.WorkspaceId");
        
			return getLLMConfigResponse;
        }
    }
}
