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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeConsortiumConfigResponseUnmarshaller
    {
        public static DescribeConsortiumConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumConfigResponse describeConsortiumConfigResponse = new DescribeConsortiumConfigResponse();

			describeConsortiumConfigResponse.HttpResponse = context.HttpResponse;
			describeConsortiumConfigResponse.RequestId = context.StringValue("DescribeConsortiumConfig.RequestId");
			describeConsortiumConfigResponse.Success = context.BooleanValue("DescribeConsortiumConfig.Success");
			describeConsortiumConfigResponse.ErrorCode = context.IntegerValue("DescribeConsortiumConfig.ErrorCode");

			DescribeConsortiumConfigResponse.DescribeConsortiumConfig_Result result = new DescribeConsortiumConfigResponse.DescribeConsortiumConfig_Result();

			List<string> result_channelPolicy = new List<string>();
			for (int i = 0; i < context.Length("DescribeConsortiumConfig.Result.ChannelPolicy.Length"); i++) {
				result_channelPolicy.Add(context.StringValue("DescribeConsortiumConfig.Result.ChannelPolicy["+ i +"]"));
			}
			result.ChannelPolicy = result_channelPolicy;

			List<string> result_ordererType = new List<string>();
			for (int i = 0; i < context.Length("DescribeConsortiumConfig.Result.OrdererType.Length"); i++) {
				result_ordererType.Add(context.StringValue("DescribeConsortiumConfig.Result.OrdererType["+ i +"]"));
			}
			result.OrdererType = result_ordererType;
			describeConsortiumConfigResponse.Result = result;
        
			return describeConsortiumConfigResponse;
        }
    }
}