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
    public class DescribeRegionInfosResponseUnmarshaller
    {
        public static DescribeRegionInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionInfosResponse describeRegionInfosResponse = new DescribeRegionInfosResponse();

			describeRegionInfosResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionInfosResponse.RequestId = _ctx.StringValue("DescribeRegionInfos.RequestId");

			List<DescribeRegionInfosResponse.DescribeRegionInfos_RDSRegion> describeRegionInfosResponse_regions = new List<DescribeRegionInfosResponse.DescribeRegionInfos_RDSRegion>();
			for (int i = 0; i < _ctx.Length("DescribeRegionInfos.Regions.Length"); i++) {
				DescribeRegionInfosResponse.DescribeRegionInfos_RDSRegion rDSRegion = new DescribeRegionInfosResponse.DescribeRegionInfos_RDSRegion();
				rDSRegion.RegionId = _ctx.StringValue("DescribeRegionInfos.Regions["+ i +"].RegionId");

				describeRegionInfosResponse_regions.Add(rDSRegion);
			}
			describeRegionInfosResponse.Regions = describeRegionInfosResponse_regions;
        
			return describeRegionInfosResponse;
        }
    }
}
