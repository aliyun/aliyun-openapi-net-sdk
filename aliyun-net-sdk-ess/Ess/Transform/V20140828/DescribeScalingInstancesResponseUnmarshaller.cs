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
using Aliyun.Acs.Ess.Model.V20140828;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeScalingInstancesResponseUnmarshaller
    {
        public static DescribeScalingInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingInstancesResponse describeScalingInstancesResponse = new DescribeScalingInstancesResponse();

			describeScalingInstancesResponse.HttpResponse = context.HttpResponse;
			describeScalingInstancesResponse.TotalCount = context.IntegerValue("DescribeScalingInstances.TotalCount");
			describeScalingInstancesResponse.PageNumber = context.IntegerValue("DescribeScalingInstances.PageNumber");
			describeScalingInstancesResponse.PageSize = context.IntegerValue("DescribeScalingInstances.PageSize");
			describeScalingInstancesResponse.RequestId = context.StringValue("DescribeScalingInstances.RequestId");

			List<DescribeScalingInstancesResponse.DescribeScalingInstances_ScalingInstance> describeScalingInstancesResponse_scalingInstances = new List<DescribeScalingInstancesResponse.DescribeScalingInstances_ScalingInstance>();
			for (int i = 0; i < context.Length("DescribeScalingInstances.ScalingInstances.Length"); i++) {
				DescribeScalingInstancesResponse.DescribeScalingInstances_ScalingInstance scalingInstance = new DescribeScalingInstancesResponse.DescribeScalingInstances_ScalingInstance();
				scalingInstance.InstanceId = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].InstanceId");
				scalingInstance.ScalingConfigurationId = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].ScalingConfigurationId");
				scalingInstance.ScalingGroupId = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].ScalingGroupId");
				scalingInstance.HealthStatus = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].HealthStatus");
				scalingInstance.LoadBalancerWeight = context.IntegerValue("DescribeScalingInstances.ScalingInstances["+ i +"].LoadBalancerWeight");
				scalingInstance.LifecycleState = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].LifecycleState");
				scalingInstance.CreationTime = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].CreationTime");
				scalingInstance.CreationType = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].CreationType");
				scalingInstance.LaunchTemplateId = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].LaunchTemplateId");
				scalingInstance.LaunchTemplateVersion = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].LaunchTemplateVersion");
				scalingInstance.WarmupState = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].WarmupState");
				scalingInstance.Entrusted = context.BooleanValue("DescribeScalingInstances.ScalingInstances["+ i +"].Entrusted");
				scalingInstance.CreatedTime = context.StringValue("DescribeScalingInstances.ScalingInstances["+ i +"].CreatedTime");

				describeScalingInstancesResponse_scalingInstances.Add(scalingInstance);
			}
			describeScalingInstancesResponse.ScalingInstances = describeScalingInstancesResponse_scalingInstances;
        
			return describeScalingInstancesResponse;
        }
    }
}
