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
				scalingGroup.PendingWaitCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].PendingWaitCapacity");
				scalingGroup.RemovingWaitCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].RemovingWaitCapacity");
				scalingGroup.PendingCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].PendingCapacity");
				scalingGroup.RemovingCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].RemovingCapacity");
				scalingGroup.ScalingGroupName = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].ScalingGroupName");
				scalingGroup.ActiveCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].ActiveCapacity");
				scalingGroup.StandbyCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].StandbyCapacity");
				scalingGroup.ProtectedCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].ProtectedCapacity");
				scalingGroup.ActiveScalingConfigurationId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].ActiveScalingConfigurationId");
				scalingGroup.LaunchTemplateId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].LaunchTemplateId");
				scalingGroup.LaunchTemplateVersion = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].LaunchTemplateVersion");
				scalingGroup.ScalingGroupId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].ScalingGroupId");
				scalingGroup.RegionId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].RegionId");
				scalingGroup.TotalCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].TotalCapacity");
				scalingGroup.MinSize = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].MinSize");
				scalingGroup.LifecycleState = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].LifecycleState");
				scalingGroup.CreationTime = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].CreationTime");
				scalingGroup.ModificationTime = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].ModificationTime");
				scalingGroup.VpcId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].VpcId");
				scalingGroup.VSwitchId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].VSwitchId");
				scalingGroup.MultiAZPolicy = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].MultiAZPolicy");
				scalingGroup.HealthCheckType = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].HealthCheckType");
				scalingGroup.ScalingPolicy = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].ScalingPolicy");
				scalingGroup.StoppedCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].StoppedCapacity");
				scalingGroup.OnDemandBaseCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].OnDemandBaseCapacity");
				scalingGroup.OnDemandPercentageAboveBaseCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].OnDemandPercentageAboveBaseCapacity");
				scalingGroup.SpotInstanceRemedy = context.BooleanValue("DescribeScalingGroups.ScalingGroups["+ i +"].SpotInstanceRemedy");
				scalingGroup.CompensateWithOnDemand = context.BooleanValue("DescribeScalingGroups.ScalingGroups["+ i +"].CompensateWithOnDemand");
				scalingGroup.SpotInstancePools = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].SpotInstancePools");
				scalingGroup.DesiredCapacity = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].DesiredCapacity");
				scalingGroup.GroupDeletionProtection = context.BooleanValue("DescribeScalingGroups.ScalingGroups["+ i +"].GroupDeletionProtection");
				scalingGroup.ScaleOutAmountCheck = context.BooleanValue("DescribeScalingGroups.ScalingGroups["+ i +"].ScaleOutAmountCheck");

				List<string> scalingGroup_vSwitchIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeScalingGroups.ScalingGroups["+ i +"].VSwitchIds.Length"); j++) {
					scalingGroup_vSwitchIds.Add(context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].VSwitchIds["+ j +"]"));
				}
				scalingGroup.VSwitchIds = scalingGroup_vSwitchIds;

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

				List<string> scalingGroup_suspendedProcesses = new List<string>();
				for (int j = 0; j < context.Length("DescribeScalingGroups.ScalingGroups["+ i +"].SuspendedProcesses.Length"); j++) {
					scalingGroup_suspendedProcesses.Add(context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].SuspendedProcesses["+ j +"]"));
				}
				scalingGroup.SuspendedProcesses = scalingGroup_suspendedProcesses;

				List<DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup.DescribeScalingGroups_VServerGroup> scalingGroup_vServerGroups = new List<DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup.DescribeScalingGroups_VServerGroup>();
				for (int j = 0; j < context.Length("DescribeScalingGroups.ScalingGroups["+ i +"].VServerGroups.Length"); j++) {
					DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup.DescribeScalingGroups_VServerGroup vServerGroup = new DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup.DescribeScalingGroups_VServerGroup();
					vServerGroup.LoadBalancerId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].VServerGroups["+ j +"].LoadBalancerId");

					List<DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup.DescribeScalingGroups_VServerGroup.DescribeScalingGroups_VServerGroupAttribute> vServerGroup_vServerGroupAttributes = new List<DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup.DescribeScalingGroups_VServerGroup.DescribeScalingGroups_VServerGroupAttribute>();
					for (int k = 0; k < context.Length("DescribeScalingGroups.ScalingGroups["+ i +"].VServerGroups["+ j +"].VServerGroupAttributes.Length"); k++) {
						DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup.DescribeScalingGroups_VServerGroup.DescribeScalingGroups_VServerGroupAttribute vServerGroupAttribute = new DescribeScalingGroupsResponse.DescribeScalingGroups_ScalingGroup.DescribeScalingGroups_VServerGroup.DescribeScalingGroups_VServerGroupAttribute();
						vServerGroupAttribute.VServerGroupId = context.StringValue("DescribeScalingGroups.ScalingGroups["+ i +"].VServerGroups["+ j +"].VServerGroupAttributes["+ k +"].VServerGroupId");
						vServerGroupAttribute.Port = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].VServerGroups["+ j +"].VServerGroupAttributes["+ k +"].Port");
						vServerGroupAttribute.Weight = context.IntegerValue("DescribeScalingGroups.ScalingGroups["+ i +"].VServerGroups["+ j +"].VServerGroupAttributes["+ k +"].Weight");

						vServerGroup_vServerGroupAttributes.Add(vServerGroupAttribute);
					}
					vServerGroup.VServerGroupAttributes = vServerGroup_vServerGroupAttributes;

					scalingGroup_vServerGroups.Add(vServerGroup);
				}
				scalingGroup.VServerGroups = scalingGroup_vServerGroups;

				describeScalingGroupsResponse_scalingGroups.Add(scalingGroup);
			}
			describeScalingGroupsResponse.ScalingGroups = describeScalingGroupsResponse_scalingGroups;
        
			return describeScalingGroupsResponse;
        }
    }
}
