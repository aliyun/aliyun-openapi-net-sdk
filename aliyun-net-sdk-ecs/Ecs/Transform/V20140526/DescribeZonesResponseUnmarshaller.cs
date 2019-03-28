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
    public class DescribeZonesResponseUnmarshaller
    {
        public static DescribeZonesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeZonesResponse describeZonesResponse = new DescribeZonesResponse();

			describeZonesResponse.HttpResponse = context.HttpResponse;
			describeZonesResponse.RequestId = context.StringValue("DescribeZones.RequestId");

			List<DescribeZonesResponse.DescribeZones_Zone> describeZonesResponse_zones = new List<DescribeZonesResponse.DescribeZones_Zone>();
			for (int i = 0; i < context.Length("DescribeZones.Zones.Length"); i++) {
				DescribeZonesResponse.DescribeZones_Zone zone = new DescribeZonesResponse.DescribeZones_Zone();
				zone.ZoneId = context.StringValue("DescribeZones.Zones["+ i +"].ZoneId");
				zone.LocalName = context.StringValue("DescribeZones.Zones["+ i +"].LocalName");

				List<string> zone_availableResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].AvailableResourceCreation.Length"); j++) {
					zone_availableResourceCreation.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableResourceCreation["+ j +"]"));
				}
				zone.AvailableResourceCreation = zone_availableResourceCreation;

				List<string> zone_availableDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].AvailableDiskCategories.Length"); j++) {
					zone_availableDiskCategories.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableDiskCategories["+ j +"]"));
				}
				zone.AvailableDiskCategories = zone_availableDiskCategories;

				List<string> zone_availableInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].AvailableInstanceTypes.Length"); j++) {
					zone_availableInstanceTypes.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableInstanceTypes["+ j +"]"));
				}
				zone.AvailableInstanceTypes = zone_availableInstanceTypes;

				List<string> zone_availableVolumeCategories = new List<string>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].AvailableVolumeCategories.Length"); j++) {
					zone_availableVolumeCategories.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableVolumeCategories["+ j +"]"));
				}
				zone.AvailableVolumeCategories = zone_availableVolumeCategories;

				List<string> zone_availableDedicatedHostTypes = new List<string>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].AvailableDedicatedHostTypes.Length"); j++) {
					zone_availableDedicatedHostTypes.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableDedicatedHostTypes["+ j +"]"));
				}
				zone.AvailableDedicatedHostTypes = zone_availableDedicatedHostTypes;

				List<string> zone_dedicatedHostGenerations = new List<string>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].DedicatedHostGenerations.Length"); j++) {
					zone_dedicatedHostGenerations.Add(context.StringValue("DescribeZones.Zones["+ i +"].DedicatedHostGenerations["+ j +"]"));
				}
				zone.DedicatedHostGenerations = zone_dedicatedHostGenerations;

				List<DescribeZonesResponse.DescribeZones_Zone.DescribeZones_ResourcesInfo> zone_availableResources = new List<DescribeZonesResponse.DescribeZones_Zone.DescribeZones_ResourcesInfo>();
				for (int j = 0; j < context.Length("DescribeZones.Zones["+ i +"].AvailableResources.Length"); j++) {
					DescribeZonesResponse.DescribeZones_Zone.DescribeZones_ResourcesInfo resourcesInfo = new DescribeZonesResponse.DescribeZones_Zone.DescribeZones_ResourcesInfo();
					resourcesInfo.IoOptimized = context.BooleanValue("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].IoOptimized");

					List<string> resourcesInfo_systemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].SystemDiskCategories.Length"); k++) {
						resourcesInfo_systemDiskCategories.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].SystemDiskCategories["+ k +"]"));
					}
					resourcesInfo.SystemDiskCategories = resourcesInfo_systemDiskCategories;

					List<string> resourcesInfo_dataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].DataDiskCategories.Length"); k++) {
						resourcesInfo_dataDiskCategories.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].DataDiskCategories["+ k +"]"));
					}
					resourcesInfo.DataDiskCategories = resourcesInfo_dataDiskCategories;

					List<string> resourcesInfo_networkTypes = new List<string>();
					for (int k = 0; k < context.Length("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].NetworkTypes.Length"); k++) {
						resourcesInfo_networkTypes.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].NetworkTypes["+ k +"]"));
					}
					resourcesInfo.NetworkTypes = resourcesInfo_networkTypes;

					List<string> resourcesInfo_instanceTypes = new List<string>();
					for (int k = 0; k < context.Length("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].InstanceTypes.Length"); k++) {
						resourcesInfo_instanceTypes.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].InstanceTypes["+ k +"]"));
					}
					resourcesInfo.InstanceTypes = resourcesInfo_instanceTypes;

					List<string> resourcesInfo_instanceTypeFamilies = new List<string>();
					for (int k = 0; k < context.Length("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].InstanceTypeFamilies.Length"); k++) {
						resourcesInfo_instanceTypeFamilies.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].InstanceTypeFamilies["+ k +"]"));
					}
					resourcesInfo.InstanceTypeFamilies = resourcesInfo_instanceTypeFamilies;

					List<string> resourcesInfo_instanceGenerations = new List<string>();
					for (int k = 0; k < context.Length("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].InstanceGenerations.Length"); k++) {
						resourcesInfo_instanceGenerations.Add(context.StringValue("DescribeZones.Zones["+ i +"].AvailableResources["+ j +"].InstanceGenerations["+ k +"]"));
					}
					resourcesInfo.InstanceGenerations = resourcesInfo_instanceGenerations;

					zone_availableResources.Add(resourcesInfo);
				}
				zone.AvailableResources = zone_availableResources;

				describeZonesResponse_zones.Add(zone);
			}
			describeZonesResponse.Zones = describeZonesResponse_zones;
        
			return describeZonesResponse;
        }
    }
}
