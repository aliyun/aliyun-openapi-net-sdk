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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");
			describeRegionsResponse.Success = context.BooleanValue("DescribeRegions.Success");
			describeRegionsResponse.Code = context.StringValue("DescribeRegions.Code");
			describeRegionsResponse.Message = context.StringValue("DescribeRegions.Message");

			List<DescribeRegionsResponse.DescribeRegions_Region> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_Region>();
			for (int i = 0; i < context.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_Region region = new DescribeRegionsResponse.DescribeRegions_Region();
				region.RegionId = context.StringValue("DescribeRegions.Regions["+ i +"].RegionId");

				describeRegionsResponse_regions.Add(region);
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}
