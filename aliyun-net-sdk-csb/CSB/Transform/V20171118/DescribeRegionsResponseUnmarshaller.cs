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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.Code = context.IntegerValue("DescribeRegions.Code");
			describeRegionsResponse.Message = context.StringValue("DescribeRegions.Message");
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");

			DescribeRegionsResponse.DescribeRegions_Data data = new DescribeRegionsResponse.DescribeRegions_Data();

			List<DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region> data_regionList = new List<DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region>();
			for (int i = 0; i < context.Length("DescribeRegions.Data.RegionList.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region region = new DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region();
				region.RegionId = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].RegionId");
				region.RegionName = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].RegionName");
				region.RegionUrl = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].RegionUrl");
				region.Isdefault = context.BooleanValue("DescribeRegions.Data.RegionList["+ i +"].Isdefault");

				List<DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region.DescribeRegions_PhysicalLocation> region_physicalLocations = new List<DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region.DescribeRegions_PhysicalLocation>();
				for (int j = 0; j < context.Length("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations.Length"); j++) {
					DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region.DescribeRegions_PhysicalLocation physicalLocation = new DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region.DescribeRegions_PhysicalLocation();
					physicalLocation.No = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations["+ j +"].No");
					physicalLocation.ServiceCode = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations["+ j +"].ServiceCode");
					physicalLocation.Type = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations["+ j +"].Type");
					physicalLocation.Name = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations["+ j +"].Name");
					physicalLocation.Status = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations["+ j +"].Status");

					List<DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region.DescribeRegions_PhysicalLocation.DescribeRegions_Attribute> physicalLocation_attributes = new List<DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region.DescribeRegions_PhysicalLocation.DescribeRegions_Attribute>();
					for (int k = 0; k < context.Length("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations["+ j +"].Attributes.Length"); k++) {
						DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region.DescribeRegions_PhysicalLocation.DescribeRegions_Attribute attribute = new DescribeRegionsResponse.DescribeRegions_Data.DescribeRegions_Region.DescribeRegions_PhysicalLocation.DescribeRegions_Attribute();
						attribute.Name = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations["+ j +"].Attributes["+ k +"].Name");
						attribute._Value = context.StringValue("DescribeRegions.Data.RegionList["+ i +"].PhysicalLocations["+ j +"].Attributes["+ k +"].Value");

						physicalLocation_attributes.Add(attribute);
					}
					physicalLocation.Attributes = physicalLocation_attributes;

					region_physicalLocations.Add(physicalLocation);
				}
				region.PhysicalLocations = region_physicalLocations;

				data_regionList.Add(region);
			}
			data.RegionList = data_regionList;
			describeRegionsResponse.Data = data;
        
			return describeRegionsResponse;
        }
    }
}
