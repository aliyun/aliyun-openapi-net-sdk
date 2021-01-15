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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.requestId");

			List<DescribeRegionsResponse.DescribeRegions_ResultItem> describeRegionsResponse_result = new List<DescribeRegionsResponse.DescribeRegions_ResultItem>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.Result.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_ResultItem resultItem = new DescribeRegionsResponse.DescribeRegions_ResultItem();
				resultItem.RegionId = _ctx.StringValue("DescribeRegions.Result["+ i +"].regionId");
				resultItem.LocalName = _ctx.StringValue("DescribeRegions.Result["+ i +"].localName");
				resultItem.Endpoint = _ctx.StringValue("DescribeRegions.Result["+ i +"].endpoint");
				resultItem.ConsoleUrl = _ctx.StringValue("DescribeRegions.Result["+ i +"].consoleUrl");

				describeRegionsResponse_result.Add(resultItem);
			}
			describeRegionsResponse.Result = describeRegionsResponse_result;
        
			return describeRegionsResponse;
        }
    }
}
