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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class DescribePipelineManagementConfigResponseUnmarshaller
    {
        public static DescribePipelineManagementConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePipelineManagementConfigResponse describePipelineManagementConfigResponse = new DescribePipelineManagementConfigResponse();

			describePipelineManagementConfigResponse.HttpResponse = _ctx.HttpResponse;
			describePipelineManagementConfigResponse.RequestId = _ctx.StringValue("DescribePipelineManagementConfig.RequestId");

			DescribePipelineManagementConfigResponse.DescribePipelineManagementConfig_Result result = new DescribePipelineManagementConfigResponse.DescribePipelineManagementConfig_Result();
			result.PipelineManagementType = _ctx.StringValue("DescribePipelineManagementConfig.Result.pipelineManagementType");
			result.Endpoints = _ctx.StringValue("DescribePipelineManagementConfig.Result.endpoints");
			result.UserName = _ctx.StringValue("DescribePipelineManagementConfig.Result.userName");
			result.EsInstanceId = _ctx.StringValue("DescribePipelineManagementConfig.Result.esInstanceId");

			List<string> result_pipelineIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePipelineManagementConfig.Result.PipelineIds.Length"); i++) {
				result_pipelineIds.Add(_ctx.StringValue("DescribePipelineManagementConfig.Result.PipelineIds["+ i +"]"));
			}
			result.PipelineIds = result_pipelineIds;
			describePipelineManagementConfigResponse.Result = result;
        
			return describePipelineManagementConfigResponse;
        }
    }
}
