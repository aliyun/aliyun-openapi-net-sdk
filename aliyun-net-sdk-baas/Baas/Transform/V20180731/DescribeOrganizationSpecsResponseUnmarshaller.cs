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
    public class DescribeOrganizationSpecsResponseUnmarshaller
    {
        public static DescribeOrganizationSpecsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationSpecsResponse describeOrganizationSpecsResponse = new DescribeOrganizationSpecsResponse();

			describeOrganizationSpecsResponse.HttpResponse = context.HttpResponse;
			describeOrganizationSpecsResponse.RequestId = context.StringValue("DescribeOrganizationSpecs.RequestId");
			describeOrganizationSpecsResponse.Success = context.BooleanValue("DescribeOrganizationSpecs.Success");
			describeOrganizationSpecsResponse.ErrorCode = context.IntegerValue("DescribeOrganizationSpecs.ErrorCode");

			List<DescribeOrganizationSpecsResponse.DescribeOrganizationSpecs_ClusterSpec> describeOrganizationSpecsResponse_result = new List<DescribeOrganizationSpecsResponse.DescribeOrganizationSpecs_ClusterSpec>();
			for (int i = 0; i < context.Length("DescribeOrganizationSpecs.Result.Length"); i++) {
				DescribeOrganizationSpecsResponse.DescribeOrganizationSpecs_ClusterSpec clusterSpec = new DescribeOrganizationSpecsResponse.DescribeOrganizationSpecs_ClusterSpec();
				clusterSpec.Name = context.StringValue("DescribeOrganizationSpecs.Result["+ i +"].Name");
				clusterSpec.Title = context.StringValue("DescribeOrganizationSpecs.Result["+ i +"].Title");
				clusterSpec.NumOfNodes = context.IntegerValue("DescribeOrganizationSpecs.Result["+ i +"].NumOfNodes");
				clusterSpec.MasterDescription = context.StringValue("DescribeOrganizationSpecs.Result["+ i +"].MasterDescription");
				clusterSpec.WorkerDescription = context.StringValue("DescribeOrganizationSpecs.Result["+ i +"].WorkerDescription");
				clusterSpec.Enable = context.BooleanValue("DescribeOrganizationSpecs.Result["+ i +"].Enable");

				describeOrganizationSpecsResponse_result.Add(clusterSpec);
			}
			describeOrganizationSpecsResponse.Result = describeOrganizationSpecsResponse_result;
        
			return describeOrganizationSpecsResponse;
        }
    }
}