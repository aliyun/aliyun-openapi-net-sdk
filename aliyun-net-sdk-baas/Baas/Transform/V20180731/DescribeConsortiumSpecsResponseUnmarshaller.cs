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
    public class DescribeConsortiumSpecsResponseUnmarshaller
    {
        public static DescribeConsortiumSpecsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumSpecsResponse describeConsortiumSpecsResponse = new DescribeConsortiumSpecsResponse();

			describeConsortiumSpecsResponse.HttpResponse = context.HttpResponse;
			describeConsortiumSpecsResponse.RequestId = context.StringValue("DescribeConsortiumSpecs.RequestId");
			describeConsortiumSpecsResponse.Success = context.BooleanValue("DescribeConsortiumSpecs.Success");
			describeConsortiumSpecsResponse.ErrorCode = context.IntegerValue("DescribeConsortiumSpecs.ErrorCode");

			List<DescribeConsortiumSpecsResponse.DescribeConsortiumSpecs_ClusterSpec> describeConsortiumSpecsResponse_result = new List<DescribeConsortiumSpecsResponse.DescribeConsortiumSpecs_ClusterSpec>();
			for (int i = 0; i < context.Length("DescribeConsortiumSpecs.Result.Length"); i++) {
				DescribeConsortiumSpecsResponse.DescribeConsortiumSpecs_ClusterSpec clusterSpec = new DescribeConsortiumSpecsResponse.DescribeConsortiumSpecs_ClusterSpec();
				clusterSpec.Name = context.StringValue("DescribeConsortiumSpecs.Result["+ i +"].Name");
				clusterSpec.Title = context.StringValue("DescribeConsortiumSpecs.Result["+ i +"].Title");
				clusterSpec.NumOfNodes = context.IntegerValue("DescribeConsortiumSpecs.Result["+ i +"].NumOfNodes");
				clusterSpec.MasterDescription = context.StringValue("DescribeConsortiumSpecs.Result["+ i +"].MasterDescription");
				clusterSpec.WorkerDescription = context.StringValue("DescribeConsortiumSpecs.Result["+ i +"].WorkerDescription");
				clusterSpec.Enable = context.BooleanValue("DescribeConsortiumSpecs.Result["+ i +"].Enable");

				describeConsortiumSpecsResponse_result.Add(clusterSpec);
			}
			describeConsortiumSpecsResponse.Result = describeConsortiumSpecsResponse_result;
        
			return describeConsortiumSpecsResponse;
        }
    }
}