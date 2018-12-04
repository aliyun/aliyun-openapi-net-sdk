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
    public class DescribeEcosphereSpecsResponseUnmarshaller
    {
        public static DescribeEcosphereSpecsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEcosphereSpecsResponse describeEcosphereSpecsResponse = new DescribeEcosphereSpecsResponse();

			describeEcosphereSpecsResponse.HttpResponse = context.HttpResponse;
			describeEcosphereSpecsResponse.RequestId = context.StringValue("DescribeEcosphereSpecs.RequestId");
			describeEcosphereSpecsResponse.Success = context.BooleanValue("DescribeEcosphereSpecs.Success");
			describeEcosphereSpecsResponse.ErrorCode = context.IntegerValue("DescribeEcosphereSpecs.ErrorCode");

			List<DescribeEcosphereSpecsResponse.DescribeEcosphereSpecs_ClusterSpec> describeEcosphereSpecsResponse_result = new List<DescribeEcosphereSpecsResponse.DescribeEcosphereSpecs_ClusterSpec>();
			for (int i = 0; i < context.Length("DescribeEcosphereSpecs.Result.Length"); i++) {
				DescribeEcosphereSpecsResponse.DescribeEcosphereSpecs_ClusterSpec clusterSpec = new DescribeEcosphereSpecsResponse.DescribeEcosphereSpecs_ClusterSpec();
				clusterSpec.Name = context.StringValue("DescribeEcosphereSpecs.Result["+ i +"].Name");
				clusterSpec.Title = context.StringValue("DescribeEcosphereSpecs.Result["+ i +"].Title");
				clusterSpec.NumOfNodes = context.IntegerValue("DescribeEcosphereSpecs.Result["+ i +"].NumOfNodes");
				clusterSpec.MasterDescription = context.StringValue("DescribeEcosphereSpecs.Result["+ i +"].MasterDescription");
				clusterSpec.WorkerDescription = context.StringValue("DescribeEcosphereSpecs.Result["+ i +"].WorkerDescription");
				clusterSpec.Enable = context.BooleanValue("DescribeEcosphereSpecs.Result["+ i +"].Enable");

				describeEcosphereSpecsResponse_result.Add(clusterSpec);
			}
			describeEcosphereSpecsResponse.Result = describeEcosphereSpecsResponse_result;
        
			return describeEcosphereSpecsResponse;
        }
    }
}