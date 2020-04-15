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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeNetworkOptimizationSagsResponseUnmarshaller
    {
        public static DescribeNetworkOptimizationSagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkOptimizationSagsResponse describeNetworkOptimizationSagsResponse = new DescribeNetworkOptimizationSagsResponse();

			describeNetworkOptimizationSagsResponse.HttpResponse = context.HttpResponse;
			describeNetworkOptimizationSagsResponse.RequestId = context.StringValue("DescribeNetworkOptimizationSags.RequestId");
			describeNetworkOptimizationSagsResponse.TotalCount = context.IntegerValue("DescribeNetworkOptimizationSags.TotalCount");
			describeNetworkOptimizationSagsResponse.PageNumber = context.IntegerValue("DescribeNetworkOptimizationSags.PageNumber");
			describeNetworkOptimizationSagsResponse.PageSize = context.IntegerValue("DescribeNetworkOptimizationSags.PageSize");

			List<DescribeNetworkOptimizationSagsResponse.DescribeNetworkOptimizationSags_SmartAccessGateway> describeNetworkOptimizationSagsResponse_smartAccessGateways = new List<DescribeNetworkOptimizationSagsResponse.DescribeNetworkOptimizationSags_SmartAccessGateway>();
			for (int i = 0; i < context.Length("DescribeNetworkOptimizationSags.SmartAccessGateways.Length"); i++) {
				DescribeNetworkOptimizationSagsResponse.DescribeNetworkOptimizationSags_SmartAccessGateway smartAccessGateway = new DescribeNetworkOptimizationSagsResponse.DescribeNetworkOptimizationSags_SmartAccessGateway();
				smartAccessGateway.InstanceId = context.StringValue("DescribeNetworkOptimizationSags.SmartAccessGateways["+ i +"].InstanceId");
				smartAccessGateway.Name = context.StringValue("DescribeNetworkOptimizationSags.SmartAccessGateways["+ i +"].Name");
				smartAccessGateway.State = context.StringValue("DescribeNetworkOptimizationSags.SmartAccessGateways["+ i +"].State");
				smartAccessGateway.CreateTime = context.LongValue("DescribeNetworkOptimizationSags.SmartAccessGateways["+ i +"].CreateTime");
				smartAccessGateway.EndTime = context.LongValue("DescribeNetworkOptimizationSags.SmartAccessGateways["+ i +"].EndTime");
				smartAccessGateway.MaxBandwidth = context.StringValue("DescribeNetworkOptimizationSags.SmartAccessGateways["+ i +"].MaxBandwidth");

				describeNetworkOptimizationSagsResponse_smartAccessGateways.Add(smartAccessGateway);
			}
			describeNetworkOptimizationSagsResponse.SmartAccessGateways = describeNetworkOptimizationSagsResponse_smartAccessGateways;
        
			return describeNetworkOptimizationSagsResponse;
        }
    }
}
