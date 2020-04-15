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
    public class DescribeNetworkOptimizationsResponseUnmarshaller
    {
        public static DescribeNetworkOptimizationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkOptimizationsResponse describeNetworkOptimizationsResponse = new DescribeNetworkOptimizationsResponse();

			describeNetworkOptimizationsResponse.HttpResponse = context.HttpResponse;
			describeNetworkOptimizationsResponse.RequestId = context.StringValue("DescribeNetworkOptimizations.RequestId");
			describeNetworkOptimizationsResponse.TotalCount = context.IntegerValue("DescribeNetworkOptimizations.TotalCount");
			describeNetworkOptimizationsResponse.PageNumber = context.IntegerValue("DescribeNetworkOptimizations.PageNumber");
			describeNetworkOptimizationsResponse.PageSize = context.IntegerValue("DescribeNetworkOptimizations.PageSize");

			List<DescribeNetworkOptimizationsResponse.DescribeNetworkOptimizations_NetworkOptimization> describeNetworkOptimizationsResponse_networkOptimizations = new List<DescribeNetworkOptimizationsResponse.DescribeNetworkOptimizations_NetworkOptimization>();
			for (int i = 0; i < context.Length("DescribeNetworkOptimizations.NetworkOptimizations.Length"); i++) {
				DescribeNetworkOptimizationsResponse.DescribeNetworkOptimizations_NetworkOptimization networkOptimization = new DescribeNetworkOptimizationsResponse.DescribeNetworkOptimizations_NetworkOptimization();
				networkOptimization.InstanceId = context.StringValue("DescribeNetworkOptimizations.NetworkOptimizations["+ i +"].InstanceId");
				networkOptimization.Name = context.StringValue("DescribeNetworkOptimizations.NetworkOptimizations["+ i +"].Name");
				networkOptimization.State = context.StringValue("DescribeNetworkOptimizations.NetworkOptimizations["+ i +"].State");
				networkOptimization.CreateTime = context.LongValue("DescribeNetworkOptimizations.NetworkOptimizations["+ i +"].CreateTime");
				networkOptimization.SagCount = context.IntegerValue("DescribeNetworkOptimizations.NetworkOptimizations["+ i +"].SagCount");
				networkOptimization.CcnId = context.StringValue("DescribeNetworkOptimizations.NetworkOptimizations["+ i +"].CcnId");

				describeNetworkOptimizationsResponse_networkOptimizations.Add(networkOptimization);
			}
			describeNetworkOptimizationsResponse.NetworkOptimizations = describeNetworkOptimizationsResponse_networkOptimizations;
        
			return describeNetworkOptimizationsResponse;
        }
    }
}
