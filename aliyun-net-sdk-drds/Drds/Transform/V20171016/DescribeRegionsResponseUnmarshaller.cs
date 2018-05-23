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
using Aliyun.Acs.Drds.Model.V20171016;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");
			describeRegionsResponse.Success = context.BooleanValue("DescribeRegions.Success");

			List<DescribeRegionsResponse.DescribeRegions_DrdsRegion> describeRegionsResponse_drdsRegions = new List<DescribeRegionsResponse.DescribeRegions_DrdsRegion>();
			for (int i = 0; i < context.Length("DescribeRegions.DrdsRegions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_DrdsRegion drdsRegion = new DescribeRegionsResponse.DescribeRegions_DrdsRegion();
				drdsRegion.RegionId = context.StringValue("DescribeRegions.DrdsRegions["+ i +"].RegionId");
				drdsRegion.RegionName = context.StringValue("DescribeRegions.DrdsRegions["+ i +"].RegionName");
				drdsRegion.ZoneId = context.StringValue("DescribeRegions.DrdsRegions["+ i +"].ZoneId");
				drdsRegion.ZoneName = context.StringValue("DescribeRegions.DrdsRegions["+ i +"].ZoneName");

				List<DescribeRegionsResponse.DescribeRegions_DrdsRegion.DescribeRegions_InstanceSeries> drdsRegion_instanceSeriesList = new List<DescribeRegionsResponse.DescribeRegions_DrdsRegion.DescribeRegions_InstanceSeries>();
				for (int j = 0; j < context.Length("DescribeRegions.DrdsRegions["+ i +"].InstanceSeriesList.Length"); j++) {
					DescribeRegionsResponse.DescribeRegions_DrdsRegion.DescribeRegions_InstanceSeries instanceSeries = new DescribeRegionsResponse.DescribeRegions_DrdsRegion.DescribeRegions_InstanceSeries();
					instanceSeries.SeriesId = context.StringValue("DescribeRegions.DrdsRegions["+ i +"].InstanceSeriesList["+ j +"].SeriesId");
					instanceSeries.SeriesName = context.StringValue("DescribeRegions.DrdsRegions["+ i +"].InstanceSeriesList["+ j +"].SeriesName");

					List<DescribeRegionsResponse.DescribeRegions_DrdsRegion.DescribeRegions_InstanceSeries.DescribeRegions_Spec> instanceSeries_specList = new List<DescribeRegionsResponse.DescribeRegions_DrdsRegion.DescribeRegions_InstanceSeries.DescribeRegions_Spec>();
					for (int k = 0; k < context.Length("DescribeRegions.DrdsRegions["+ i +"].InstanceSeriesList["+ j +"].SpecList.Length"); k++) {
						DescribeRegionsResponse.DescribeRegions_DrdsRegion.DescribeRegions_InstanceSeries.DescribeRegions_Spec spec = new DescribeRegionsResponse.DescribeRegions_DrdsRegion.DescribeRegions_InstanceSeries.DescribeRegions_Spec();
						spec.SpecId = context.StringValue("DescribeRegions.DrdsRegions["+ i +"].InstanceSeriesList["+ j +"].SpecList["+ k +"].SpecId");
						spec.SpecName = context.StringValue("DescribeRegions.DrdsRegions["+ i +"].InstanceSeriesList["+ j +"].SpecList["+ k +"].SpecName");

						instanceSeries_specList.Add(spec);
					}
					instanceSeries.SpecList = instanceSeries_specList;

					drdsRegion_instanceSeriesList.Add(instanceSeries);
				}
				drdsRegion.InstanceSeriesList = drdsRegion_instanceSeriesList;

				describeRegionsResponse_drdsRegions.Add(drdsRegion);
			}
			describeRegionsResponse.DrdsRegions = describeRegionsResponse_drdsRegions;
        
			return describeRegionsResponse;
        }
    }
}