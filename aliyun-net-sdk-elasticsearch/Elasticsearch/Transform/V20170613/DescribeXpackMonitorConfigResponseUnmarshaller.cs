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
    public class DescribeXpackMonitorConfigResponseUnmarshaller
    {
        public static DescribeXpackMonitorConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeXpackMonitorConfigResponse describeXpackMonitorConfigResponse = new DescribeXpackMonitorConfigResponse();

			describeXpackMonitorConfigResponse.HttpResponse = context.HttpResponse;
			describeXpackMonitorConfigResponse.RequestId = context.StringValue("DescribeXpackMonitorConfig.RequestId");

			DescribeXpackMonitorConfigResponse.DescribeXpackMonitorConfig_Result result = new DescribeXpackMonitorConfigResponse.DescribeXpackMonitorConfig_Result();
			result.EsInstanceId = context.StringValue("DescribeXpackMonitorConfig.Result.esInstanceId");
			result.UserName = context.StringValue("DescribeXpackMonitorConfig.Result.userName");
			result.Enable = context.BooleanValue("DescribeXpackMonitorConfig.Result.enable");

			List<string> result_endpoints = new List<string>();
			for (int i = 0; i < context.Length("DescribeXpackMonitorConfig.Result.Endpoints.Length"); i++) {
				result_endpoints.Add(context.StringValue("DescribeXpackMonitorConfig.Result.Endpoints["+ i +"]"));
			}
			result.Endpoints = result_endpoints;

			List<string> result_pipelineIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeXpackMonitorConfig.Result.PipelineIds.Length"); i++) {
				result_pipelineIds.Add(context.StringValue("DescribeXpackMonitorConfig.Result.PipelineIds["+ i +"]"));
			}
			result.PipelineIds = result_pipelineIds;
			describeXpackMonitorConfigResponse.Result = result;
        
			return describeXpackMonitorConfigResponse;
        }
    }
}
