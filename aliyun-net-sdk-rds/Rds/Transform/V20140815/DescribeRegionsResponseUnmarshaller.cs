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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.RequestId");

			List<DescribeRegionsResponse.DescribeRegions_RDSRegion> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_RDSRegion>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_RDSRegion rDSRegion = new DescribeRegionsResponse.DescribeRegions_RDSRegion();
				rDSRegion.ZoneId = _ctx.StringValue("DescribeRegions.Regions["+ i +"].ZoneId");
				rDSRegion.RegionEndpoint = _ctx.StringValue("DescribeRegions.Regions["+ i +"].RegionEndpoint");
				rDSRegion.LocalName = _ctx.StringValue("DescribeRegions.Regions["+ i +"].LocalName");
				rDSRegion.RegionId = _ctx.StringValue("DescribeRegions.Regions["+ i +"].RegionId");
				rDSRegion.ZoneName = _ctx.StringValue("DescribeRegions.Regions["+ i +"].ZoneName");

				describeRegionsResponse_regions.Add(rDSRegion);
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}
