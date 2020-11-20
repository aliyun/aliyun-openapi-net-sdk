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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.RequestId");

			List<DescribeRegionsResponse.DescribeRegions_RegionInfo> describeRegionsResponse_result = new List<DescribeRegionsResponse.DescribeRegions_RegionInfo>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.Result.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_RegionInfo regionInfo = new DescribeRegionsResponse.DescribeRegions_RegionInfo();
				regionInfo.RegionId = _ctx.StringValue("DescribeRegions.Result["+ i +"].regionId");
				regionInfo.RegionEndpoint = _ctx.StringValue("DescribeRegions.Result["+ i +"].regionEndpoint");
				regionInfo.LocalName = _ctx.StringValue("DescribeRegions.Result["+ i +"].localName");
				regionInfo.ConsoleEndpoint = _ctx.StringValue("DescribeRegions.Result["+ i +"].consoleEndpoint");
				regionInfo.Status = _ctx.StringValue("DescribeRegions.Result["+ i +"].status");

				describeRegionsResponse_result.Add(regionInfo);
			}
			describeRegionsResponse.Result = describeRegionsResponse_result;
        
			return describeRegionsResponse;
        }
    }
}
