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
using Aliyun.Acs.Ess.Model.V20140828;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeScalingGroupsResponseUnmarshaller
    {
        public static DescribeScalingGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingGroupsResponse describeScalingGroupsResponse = new DescribeScalingGroupsResponse();

			describeScalingGroupsResponse.HttpResponse = context.HttpResponse;
			describeScalingGroupsResponse.TotalCount = context.IntegerValue("DescribeScalingGroups.TotalCount");
			describeScalingGroupsResponse.PageNumber = context.IntegerValue("DescribeScalingGroups.PageNumber");
			describeScalingGroupsResponse.PageSize = context.IntegerValue("DescribeScalingGroups.PageSize");
			describeScalingGroupsResponse.RequestId = context.StringValue("DescribeScalingGroups.RequestId");

			List<DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup> describeScalingGroupsResponse_scalingGroups = new List<DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup>();
			for (int i = 0; i < context.Length("DescribeScalingGroups.ScalingGroups.Length"); i++) {
				DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup scalingGroup = new DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup();
				scalingGroup.DefaultCooldown = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].DefaultCooldown");
				scalingGroup.MaxSize = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].MaxSize");
				scalingGroup.PendingCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].PendingCapacity");
				scalingGroup.RemovingCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].RemovingCapacity");
				scalingGroup.ScalingGroupName = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].ScalingGroupName");
				scalingGroup.ActiveCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].ActiveCapacity");
				scalingGroup.ActiveScalingConfigurationId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].ActiveScalingConfigurationId");
				scalingGroup.ScalingGroupId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].ScalingGroupId");
				scalingGroup.RegionId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].RegionId");
				scalingGroup.TotalCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].TotalCapacity");
				scalingGroup.MinSize = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].MinSize");
				scalingGroup.LifecycleState = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].LifecycleState");
				scalingGroup.CreationTime = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].CreationTime");
				scalingGroup.VpcId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].VpcId");
				scalingGroup.VSwitchId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].VSwitchId");

				List<string> scalingGroup_removalPolicies = new List<string>();
				for (int j = 0; j < context.Length("DescribeScalingGroups.ScalingGroups["+ i +"].RemovalPolicies.Length"); j++) {
					scalingGroup_removalPolicies.Add(context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].RemovalPolicies["+ j +"]"));
				}
				scalingGroup.RemovalPolicies = scalingGroup_removalPolicies;

				List<string> scalingGroup_dBInstanceIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeScalingGroups.ScalingGroups["+ i +"].DBInstanceIds.Length"); j++) {
					scalingGroup_dBInstanceIds.Add(context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].DBInstanceIds["+ j +"]"));
				}
				scalingGroup.DBInstanceIds = scalingGroup_dBInstanceIds;

				List<string> scalingGroup_loadBalancerIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeScalingGroups.ScalingGroups["+ i +"].LoadBalancerIds.Length"); j++) {
					scalingGroup_loadBalancerIds.Add(context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].LoadBalancerIds["+ j +"]"));
				}
				scalingGroup.LoadBalancerIds = scalingGroup_loadBalancerIds;

				describeScalingGroupsResponse_scalingGroups.Add(scalingGroup);
			}
			describeScalingGroupsResponse.ScalingGroups = describeScalingGroupsResponse_scalingGroups;
        
			return describeScalingGroupsResponse;
        }
    }
}