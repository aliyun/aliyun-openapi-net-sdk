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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeAutoProvisioningGroupsResponseUnmarshaller
    {
        public static DescribeAutoProvisioningGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAutoProvisioningGroupsResponse describeAutoProvisioningGroupsResponse = new DescribeAutoProvisioningGroupsResponse();

			describeAutoProvisioningGroupsResponse.HttpResponse = context.HttpResponse;
			describeAutoProvisioningGroupsResponse.RequestId = context.StringValue("DescribeAutoProvisioningGroups.RequestId");
			describeAutoProvisioningGroupsResponse.TotalCount = context.IntegerValue("DescribeAutoProvisioningGroups.TotalCount");
			describeAutoProvisioningGroupsResponse.PageNumber = context.IntegerValue("DescribeAutoProvisioningGroups.PageNumber");
			describeAutoProvisioningGroupsResponse.PageSize = context.IntegerValue("DescribeAutoProvisioningGroups.PageSize");

			List<DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup> describeAutoProvisioningGroupsResponse_autoProvisioningGroups = new List<DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup>();
			for (int i = 0; i < context.Length("DescribeAutoProvisioningGroups.AutoProvisioningGroups.Length"); i++) {
				DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup autoProvisioningGroup = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup();
				autoProvisioningGroup.AutoProvisioningGroupId = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].AutoProvisioningGroupId");
				autoProvisioningGroup.AutoProvisioningGroupName = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].AutoProvisioningGroupName");
				autoProvisioningGroup.AutoProvisioningGroupType = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].AutoProvisioningGroupType");
				autoProvisioningGroup.Status = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].Status");
				autoProvisioningGroup.State = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].State");
				autoProvisioningGroup.RegionId = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].RegionId");
				autoProvisioningGroup.ValidFrom = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].ValidFrom");
				autoProvisioningGroup.ValidUntil = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].ValidUntil");
				autoProvisioningGroup.ExcessCapacityTerminationPolicy = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].ExcessCapacityTerminationPolicy");
				autoProvisioningGroup.MaxSpotPrice = context.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].MaxSpotPrice");
				autoProvisioningGroup.LaunchTemplateId = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateId");
				autoProvisioningGroup.LaunchTemplateVersion = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateVersion");
				autoProvisioningGroup.TerminateInstances = context.BooleanValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TerminateInstances");
				autoProvisioningGroup.TerminateInstancesWithExpiration = context.BooleanValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TerminateInstancesWithExpiration");
				autoProvisioningGroup.CreationTime = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].CreationTime");

				DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_SpotOptions spotOptions = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_SpotOptions();
				spotOptions.AllocationStrategy = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].SpotOptions.AllocationStrategy");
				spotOptions.InstanceInterruptionBehavior = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].SpotOptions.InstanceInterruptionBehavior");
				spotOptions.InstancePoolsToUseCount = context.IntegerValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].SpotOptions.InstancePoolsToUseCount");
				autoProvisioningGroup.SpotOptions = spotOptions;

				DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_PayAsYouGoOptions payAsYouGoOptions = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_PayAsYouGoOptions();
				payAsYouGoOptions.AllocationStrategy = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].PayAsYouGoOptions.AllocationStrategy");
				autoProvisioningGroup.PayAsYouGoOptions = payAsYouGoOptions;

				DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_TargetCapacitySpecification targetCapacitySpecification = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_TargetCapacitySpecification();
				targetCapacitySpecification.TotalTargetCapacity = context.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TargetCapacitySpecification.TotalTargetCapacity");
				targetCapacitySpecification.PayAsYouGoTargetCapacity = context.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TargetCapacitySpecification.PayAsYouGoTargetCapacity");
				targetCapacitySpecification.SpotTargetCapacity = context.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TargetCapacitySpecification.SpotTargetCapacity");
				targetCapacitySpecification.DefaultTargetCapacityType = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TargetCapacitySpecification.DefaultTargetCapacityType");
				autoProvisioningGroup.TargetCapacitySpecification = targetCapacitySpecification;

				List<DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_LaunchTemplateConfig> autoProvisioningGroup_launchTemplateConfigs = new List<DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_LaunchTemplateConfig>();
				for (int j = 0; j < context.Length("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs.Length"); j++) {
					DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_LaunchTemplateConfig launchTemplateConfig = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_LaunchTemplateConfig();
					launchTemplateConfig.InstanceType = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].InstanceType");
					launchTemplateConfig.MaxPrice = context.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].MaxPrice");
					launchTemplateConfig.VSwitchId = context.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].VSwitchId");
					launchTemplateConfig.WeightedCapacity = context.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].WeightedCapacity");
					launchTemplateConfig.Priority = context.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].Priority");

					autoProvisioningGroup_launchTemplateConfigs.Add(launchTemplateConfig);
				}
				autoProvisioningGroup.LaunchTemplateConfigs = autoProvisioningGroup_launchTemplateConfigs;

				describeAutoProvisioningGroupsResponse_autoProvisioningGroups.Add(autoProvisioningGroup);
			}
			describeAutoProvisioningGroupsResponse.AutoProvisioningGroups = describeAutoProvisioningGroupsResponse_autoProvisioningGroups;
        
			return describeAutoProvisioningGroupsResponse;
        }
    }
}
