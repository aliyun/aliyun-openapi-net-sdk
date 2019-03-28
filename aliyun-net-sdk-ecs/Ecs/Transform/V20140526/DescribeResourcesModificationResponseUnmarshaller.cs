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
    public class DescribeResourcesModificationResponseUnmarshaller
    {
        public static DescribeResourcesModificationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResourcesModificationResponse describeResourcesModificationResponse = new DescribeResourcesModificationResponse();

			describeResourcesModificationResponse.HttpResponse = context.HttpResponse;
			describeResourcesModificationResponse.RequestId = context.StringValue("DescribeResourcesModification.RequestId");

			List<DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone> describeResourcesModificationResponse_availableZones = new List<DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone>();
			for (int i = 0; i < context.Length("DescribeResourcesModification.AvailableZones.Length"); i++) {
				DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone availableZone = new DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone();
				availableZone.RegionId = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneId = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].ZoneId");
				availableZone.Status = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].Status");
				availableZone.StatusCategory = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].StatusCategory");

				List<DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone.DescribeResourcesModification_AvailableResource> availableZone_availableResources = new List<DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone.DescribeResourcesModification_AvailableResource>();
				for (int j = 0; j < context.Length("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources.Length"); j++) {
					DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone.DescribeResourcesModification_AvailableResource availableResource = new DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone.DescribeResourcesModification_AvailableResource();
					availableResource.Type = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources["+ j +"].Type");

					List<DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone.DescribeResourcesModification_AvailableResource.DescribeResourcesModification_SupportedResource> availableResource_supportedResources = new List<DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone.DescribeResourcesModification_AvailableResource.DescribeResourcesModification_SupportedResource>();
					for (int k = 0; k < context.Length("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources.Length"); k++) {
						DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone.DescribeResourcesModification_AvailableResource.DescribeResourcesModification_SupportedResource supportedResource = new DescribeResourcesModificationResponse.DescribeResourcesModification_AvailableZone.DescribeResourcesModification_AvailableResource.DescribeResourcesModification_SupportedResource();
						supportedResource._Value = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Value");
						supportedResource.Status = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Status");
						supportedResource.StatusCategory = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].StatusCategory");
						supportedResource.Min = context.IntegerValue("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Min");
						supportedResource.Max = context.IntegerValue("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Max");
						supportedResource.Unit = context.StringValue("DescribeResourcesModification.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Unit");

						availableResource_supportedResources.Add(supportedResource);
					}
					availableResource.SupportedResources = availableResource_supportedResources;

					availableZone_availableResources.Add(availableResource);
				}
				availableZone.AvailableResources = availableZone_availableResources;

				describeResourcesModificationResponse_availableZones.Add(availableZone);
			}
			describeResourcesModificationResponse.AvailableZones = describeResourcesModificationResponse_availableZones;
        
			return describeResourcesModificationResponse;
        }
    }
}
