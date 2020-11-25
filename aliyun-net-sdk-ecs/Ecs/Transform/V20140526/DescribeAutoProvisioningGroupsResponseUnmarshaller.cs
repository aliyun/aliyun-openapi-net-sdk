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
        public static DescribeAutoProvisioningGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoProvisioningGroupsResponse describeAutoProvisioningGroupsResponse = new DescribeAutoProvisioningGroupsResponse();

			describeAutoProvisioningGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoProvisioningGroupsResponse.RequestId = _ctx.StringValue("DescribeAutoProvisioningGroups.RequestId");
			describeAutoProvisioningGroupsResponse.TotalCount = _ctx.IntegerValue("DescribeAutoProvisioningGroups.TotalCount");
			describeAutoProvisioningGroupsResponse.PageNumber = _ctx.IntegerValue("DescribeAutoProvisioningGroups.PageNumber");
			describeAutoProvisioningGroupsResponse.PageSize = _ctx.IntegerValue("DescribeAutoProvisioningGroups.PageSize");

			List<DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup> describeAutoProvisioningGroupsResponse_autoProvisioningGroups = new List<DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup>();
			for (int i = 0; i < _ctx.Length("DescribeAutoProvisioningGroups.AutoProvisioningGroups.Length"); i++) {
				DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup autoProvisioningGroup = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup();
				autoProvisioningGroup.AutoProvisioningGroupId = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].AutoProvisioningGroupId");
				autoProvisioningGroup.AutoProvisioningGroupName = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].AutoProvisioningGroupName");
				autoProvisioningGroup.AutoProvisioningGroupType = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].AutoProvisioningGroupType");
				autoProvisioningGroup.Status = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].Status");
				autoProvisioningGroup.State = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].State");
				autoProvisioningGroup.RegionId = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].RegionId");
				autoProvisioningGroup.ValidFrom = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].ValidFrom");
				autoProvisioningGroup.ValidUntil = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].ValidUntil");
				autoProvisioningGroup.ExcessCapacityTerminationPolicy = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].ExcessCapacityTerminationPolicy");
				autoProvisioningGroup.MaxSpotPrice = _ctx.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].MaxSpotPrice");
				autoProvisioningGroup.LaunchTemplateId = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateId");
				autoProvisioningGroup.LaunchTemplateVersion = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateVersion");
				autoProvisioningGroup.TerminateInstances = _ctx.BooleanValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TerminateInstances");
				autoProvisioningGroup.TerminateInstancesWithExpiration = _ctx.BooleanValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TerminateInstancesWithExpiration");
				autoProvisioningGroup.CreationTime = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].CreationTime");

				DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_SpotOptions spotOptions = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_SpotOptions();
				spotOptions.AllocationStrategy = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].SpotOptions.AllocationStrategy");
				spotOptions.InstanceInterruptionBehavior = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].SpotOptions.InstanceInterruptionBehavior");
				spotOptions.InstancePoolsToUseCount = _ctx.IntegerValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].SpotOptions.InstancePoolsToUseCount");
				autoProvisioningGroup.SpotOptions = spotOptions;

				DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_PayAsYouGoOptions payAsYouGoOptions = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_PayAsYouGoOptions();
				payAsYouGoOptions.AllocationStrategy = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].PayAsYouGoOptions.AllocationStrategy");
				autoProvisioningGroup.PayAsYouGoOptions = payAsYouGoOptions;

				DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_TargetCapacitySpecification targetCapacitySpecification = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_TargetCapacitySpecification();
				targetCapacitySpecification.TotalTargetCapacity = _ctx.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TargetCapacitySpecification.TotalTargetCapacity");
				targetCapacitySpecification.PayAsYouGoTargetCapacity = _ctx.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TargetCapacitySpecification.PayAsYouGoTargetCapacity");
				targetCapacitySpecification.SpotTargetCapacity = _ctx.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TargetCapacitySpecification.SpotTargetCapacity");
				targetCapacitySpecification.DefaultTargetCapacityType = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].TargetCapacitySpecification.DefaultTargetCapacityType");
				autoProvisioningGroup.TargetCapacitySpecification = targetCapacitySpecification;

				List<DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_LaunchTemplateConfig> autoProvisioningGroup_launchTemplateConfigs = new List<DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_LaunchTemplateConfig>();
				for (int j = 0; j < _ctx.Length("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs.Length"); j++) {
					DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_LaunchTemplateConfig launchTemplateConfig = new DescribeAutoProvisioningGroupsResponse.DescribeAutoProvisioningGroups_AutoProvisioningGroup.DescribeAutoProvisioningGroups_LaunchTemplateConfig();
					launchTemplateConfig.InstanceType = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].InstanceType");
					launchTemplateConfig.MaxPrice = _ctx.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].MaxPrice");
					launchTemplateConfig.VSwitchId = _ctx.StringValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].VSwitchId");
					launchTemplateConfig.WeightedCapacity = _ctx.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].WeightedCapacity");
					launchTemplateConfig.Priority = _ctx.FloatValue("DescribeAutoProvisioningGroups.AutoProvisioningGroups["+ i +"].LaunchTemplateConfigs["+ j +"].Priority");

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
