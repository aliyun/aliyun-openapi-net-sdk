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
    public class DescribeFleetsResponseUnmarshaller
    {
        public static DescribeFleetsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFleetsResponse describeFleetsResponse = new DescribeFleetsResponse();

			describeFleetsResponse.HttpResponse = context.HttpResponse;
			describeFleetsResponse.RequestId = context.StringValue("DescribeFleets.RequestId");
			describeFleetsResponse.TotalCount = context.IntegerValue("DescribeFleets.TotalCount");
			describeFleetsResponse.PageNumber = context.IntegerValue("DescribeFleets.PageNumber");
			describeFleetsResponse.PageSize = context.IntegerValue("DescribeFleets.PageSize");

			List<DescribeFleetsResponse.DescribeFleets_Fleet> describeFleetsResponse_fleets = new List<DescribeFleetsResponse.DescribeFleets_Fleet>();
			for (int i = 0; i < context.Length("DescribeFleets.Fleets.Length"); i++) {
				DescribeFleetsResponse.DescribeFleets_Fleet fleet = new DescribeFleetsResponse.DescribeFleets_Fleet();
				fleet.FleetId = context.StringValue("DescribeFleets.Fleets["+ i +"].FleetId");
				fleet.FleetName = context.StringValue("DescribeFleets.Fleets["+ i +"].FleetName");
				fleet.FleetType = context.StringValue("DescribeFleets.Fleets["+ i +"].FleetType");
				fleet.Status = context.StringValue("DescribeFleets.Fleets["+ i +"].Status");
				fleet.State = context.StringValue("DescribeFleets.Fleets["+ i +"].State");
				fleet.RegionId = context.StringValue("DescribeFleets.Fleets["+ i +"].RegionId");
				fleet.ValidFrom = context.StringValue("DescribeFleets.Fleets["+ i +"].ValidFrom");
				fleet.ValidUntil = context.StringValue("DescribeFleets.Fleets["+ i +"].ValidUntil");
				fleet.ExcessCapacityTerminationPolicy = context.StringValue("DescribeFleets.Fleets["+ i +"].ExcessCapacityTerminationPolicy");
				fleet.MaxSpotPrice = context.FloatValue("DescribeFleets.Fleets["+ i +"].MaxSpotPrice");
				fleet.LaunchTemplateId = context.StringValue("DescribeFleets.Fleets["+ i +"].LaunchTemplateId");
				fleet.LaunchTemplateVersion = context.StringValue("DescribeFleets.Fleets["+ i +"].LaunchTemplateVersion");
				fleet.TerminateInstances = context.BooleanValue("DescribeFleets.Fleets["+ i +"].TerminateInstances");
				fleet.TerminateInstancesWithExpiration = context.BooleanValue("DescribeFleets.Fleets["+ i +"].TerminateInstancesWithExpiration");
				fleet.CreationTime = context.StringValue("DescribeFleets.Fleets["+ i +"].CreationTime");

				DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_SpotOptions spotOptions = new DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_SpotOptions();
				spotOptions.AllocationStrategy = context.StringValue("DescribeFleets.Fleets["+ i +"].SpotOptions.AllocationStrategy");
				spotOptions.InstanceInterruptionBehavior = context.StringValue("DescribeFleets.Fleets["+ i +"].SpotOptions.InstanceInterruptionBehavior");
				spotOptions.InstancePoolsToUseCount = context.IntegerValue("DescribeFleets.Fleets["+ i +"].SpotOptions.InstancePoolsToUseCount");
				fleet.SpotOptions = spotOptions;

				DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_OnDemandOptions onDemandOptions = new DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_OnDemandOptions();
				onDemandOptions.AllocationStrategy = context.StringValue("DescribeFleets.Fleets["+ i +"].OnDemandOptions.AllocationStrategy");
				fleet.OnDemandOptions = onDemandOptions;

				DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_TargetCapacitySpecification targetCapacitySpecification = new DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_TargetCapacitySpecification();
				targetCapacitySpecification.TotalTargetCapacity = context.FloatValue("DescribeFleets.Fleets["+ i +"].TargetCapacitySpecification.TotalTargetCapacity");
				targetCapacitySpecification.OnDemandTargetCapacity = context.FloatValue("DescribeFleets.Fleets["+ i +"].TargetCapacitySpecification.OnDemandTargetCapacity");
				targetCapacitySpecification.SpotTargetCapacity = context.FloatValue("DescribeFleets.Fleets["+ i +"].TargetCapacitySpecification.SpotTargetCapacity");
				targetCapacitySpecification.DefaultTargetCapacityType = context.StringValue("DescribeFleets.Fleets["+ i +"].TargetCapacitySpecification.DefaultTargetCapacityType");
				targetCapacitySpecification.FillGapWithOnDemand = context.BooleanValue("DescribeFleets.Fleets["+ i +"].TargetCapacitySpecification.FillGapWithOnDemand");
				fleet.TargetCapacitySpecification = targetCapacitySpecification;

				List<DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_LaunchTemplateConfig> fleet_launchTemplateConfigs = new List<DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_LaunchTemplateConfig>();
				for (int j = 0; j < context.Length("DescribeFleets.Fleets["+ i +"].LaunchTemplateConfigs.Length"); j++) {
					DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_LaunchTemplateConfig launchTemplateConfig = new DescribeFleetsResponse.DescribeFleets_Fleet.DescribeFleets_LaunchTemplateConfig();
					launchTemplateConfig.InstanceType = context.StringValue("DescribeFleets.Fleets["+ i +"].LaunchTemplateConfigs["+ j +"].InstanceType");
					launchTemplateConfig.MaxPrice = context.FloatValue("DescribeFleets.Fleets["+ i +"].LaunchTemplateConfigs["+ j +"].MaxPrice");
					launchTemplateConfig.VSWitchId = context.StringValue("DescribeFleets.Fleets["+ i +"].LaunchTemplateConfigs["+ j +"].VSWitchId");
					launchTemplateConfig.WeightedCapacity = context.FloatValue("DescribeFleets.Fleets["+ i +"].LaunchTemplateConfigs["+ j +"].WeightedCapacity");
					launchTemplateConfig.Priority = context.FloatValue("DescribeFleets.Fleets["+ i +"].LaunchTemplateConfigs["+ j +"].Priority");

					fleet_launchTemplateConfigs.Add(launchTemplateConfig);
				}
				fleet.LaunchTemplateConfigs = fleet_launchTemplateConfigs;

				describeFleetsResponse_fleets.Add(fleet);
			}
			describeFleetsResponse.Fleets = describeFleetsResponse_fleets;
        
			return describeFleetsResponse;
        }
    }
}
