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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeDeploymentDetailResponseUnmarshaller
    {
        public static DescribeDeploymentDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeploymentDetailResponse describeDeploymentDetailResponse = new DescribeDeploymentDetailResponse();

			describeDeploymentDetailResponse.HttpResponse = context.HttpResponse;
			describeDeploymentDetailResponse.RequestId = context.StringValue("DescribeDeploymentDetail.RequestId");

			List<DescribeDeploymentDetailResponse.DescribeDeploymentDetail_Deployment> describeDeploymentDetailResponse_deploymentDetail = new List<DescribeDeploymentDetailResponse.DescribeDeploymentDetail_Deployment>();
			for (int i = 0; i < context.Length("DescribeDeploymentDetail.DeploymentDetail.Length"); i++) {
				DescribeDeploymentDetailResponse.DescribeDeploymentDetail_Deployment deployment = new DescribeDeploymentDetailResponse.DescribeDeploymentDetail_Deployment();
				deployment.CloudProduct = context.StringValue("DescribeDeploymentDetail.DeploymentDetail["+ i +"].CloudProduct");
				deployment.Domain = context.StringValue("DescribeDeploymentDetail.DeploymentDetail["+ i +"].Domain");
				deployment.Region = context.StringValue("DescribeDeploymentDetail.DeploymentDetail["+ i +"].Region");
				deployment.DeployTime = context.LongValue("DescribeDeploymentDetail.DeploymentDetail["+ i +"].DeployTime");
				deployment.Id = context.LongValue("DescribeDeploymentDetail.DeploymentDetail["+ i +"].Id");

				describeDeploymentDetailResponse_deploymentDetail.Add(deployment);
			}
			describeDeploymentDetailResponse.DeploymentDetail = describeDeploymentDetailResponse_deploymentDetail;
        
			return describeDeploymentDetailResponse;
        }
    }
}
