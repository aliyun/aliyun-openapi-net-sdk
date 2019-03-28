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
    public class DescribeAvailableResourceResponseUnmarshaller
    {
        public static DescribeAvailableResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAvailableResourceResponse describeAvailableResourceResponse = new DescribeAvailableResourceResponse();

			describeAvailableResourceResponse.HttpResponse = context.HttpResponse;
			describeAvailableResourceResponse.RequestId = context.StringValue("DescribeAvailableResource.RequestId");

			List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone> describeAvailableResourceResponse_availableZones = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone>();
			for (int i = 0; i < context.Length("DescribeAvailableResource.AvailableZones.Length"); i++) {
				DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone availableZone = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone();
				availableZone.RegionId = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneId = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].ZoneId");
				availableZone.Status = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].Status");
				availableZone.StatusCategory = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].StatusCategory");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_AvailableResource> availableZone_availableResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_AvailableResource>();
				for (int j = 0; j < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_AvailableResource availableResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_AvailableResource();
					availableResource.Type = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources["+ j +"].Type");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_SupportedResource> availableResource_supportedResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_SupportedResource>();
					for (int k = 0; k < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_SupportedResource supportedResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_AvailableResource.DescribeAvailableResource_SupportedResource();
						supportedResource._Value = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Value");
						supportedResource.Status = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Status");
						supportedResource.StatusCategory = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].StatusCategory");
						supportedResource.Min = context.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Min");
						supportedResource.Max = context.IntegerValue("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Max");
						supportedResource.Unit = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].AvailableResources["+ j +"].SupportedResources["+ k +"].Unit");

						availableResource_supportedResources.Add(supportedResource);
					}
					availableResource.SupportedResources = availableResource_supportedResources;

					availableZone_availableResources.Add(availableResource);
				}
				availableZone.AvailableResources = availableZone_availableResources;

				describeAvailableResourceResponse_availableZones.Add(availableZone);
			}
			describeAvailableResourceResponse.AvailableZones = describeAvailableResourceResponse_availableZones;
        
			return describeAvailableResourceResponse;
        }
    }
}
