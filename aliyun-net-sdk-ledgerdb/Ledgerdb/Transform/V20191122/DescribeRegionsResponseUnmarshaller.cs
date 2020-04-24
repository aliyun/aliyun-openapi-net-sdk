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
using Aliyun.Acs.ledgerdb.Model.V20191122;

namespace Aliyun.Acs.ledgerdb.Transform.V20191122
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.ErrorCode = context.IntegerValue("DescribeRegions.ErrorCode");
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");
			describeRegionsResponse.Success = context.BooleanValue("DescribeRegions.Success");

			List<DescribeRegionsResponse.DescribeRegions_Result> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_Result>();
			for (int i = 0; i < context.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_Result result = new DescribeRegionsResponse.DescribeRegions_Result();
				result.LocalName = context.StringValue("DescribeRegions.Regions["+ i +"].LocalName");
				result.RegionEndpoint = context.StringValue("DescribeRegions.Regions["+ i +"].RegionEndpoint");
				result.RegionId = context.StringValue("DescribeRegions.Regions["+ i +"].RegionId");

				describeRegionsResponse_regions.Add(result);
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}
