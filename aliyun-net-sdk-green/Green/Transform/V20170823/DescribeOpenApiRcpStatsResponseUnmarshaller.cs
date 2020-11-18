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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeOpenApiRcpStatsResponseUnmarshaller
    {
        public static DescribeOpenApiRcpStatsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOpenApiRcpStatsResponse describeOpenApiRcpStatsResponse = new DescribeOpenApiRcpStatsResponse();

			describeOpenApiRcpStatsResponse.HttpResponse = _ctx.HttpResponse;
			describeOpenApiRcpStatsResponse.RequestId = _ctx.StringValue("DescribeOpenApiRcpStats.RequestId");
			describeOpenApiRcpStatsResponse.TotalCount = _ctx.IntegerValue("DescribeOpenApiRcpStats.TotalCount");

			List<DescribeOpenApiRcpStatsResponse.DescribeOpenApiRcpStats_Stat> describeOpenApiRcpStatsResponse_statList = new List<DescribeOpenApiRcpStatsResponse.DescribeOpenApiRcpStats_Stat>();
			for (int i = 0; i < _ctx.Length("DescribeOpenApiRcpStats.StatList.Length"); i++) {
				DescribeOpenApiRcpStatsResponse.DescribeOpenApiRcpStats_Stat stat = new DescribeOpenApiRcpStatsResponse.DescribeOpenApiRcpStats_Stat();
				stat.Date = _ctx.StringValue("DescribeOpenApiRcpStats.StatList["+ i +"].Date");
				stat.ResourceType = _ctx.StringValue("DescribeOpenApiRcpStats.StatList["+ i +"].ResourceType");
				stat.TotalCount = _ctx.IntegerValue("DescribeOpenApiRcpStats.StatList["+ i +"].TotalCount");
				stat.PassCount = _ctx.IntegerValue("DescribeOpenApiRcpStats.StatList["+ i +"].PassCount");
				stat.ReviewCount = _ctx.IntegerValue("DescribeOpenApiRcpStats.StatList["+ i +"].ReviewCount");
				stat.BlockCount = _ctx.IntegerValue("DescribeOpenApiRcpStats.StatList["+ i +"].BlockCount");
				stat.TotalDuration = _ctx.IntegerValue("DescribeOpenApiRcpStats.StatList["+ i +"].TotalDuration");

				describeOpenApiRcpStatsResponse_statList.Add(stat);
			}
			describeOpenApiRcpStatsResponse.StatList = describeOpenApiRcpStatsResponse_statList;
        
			return describeOpenApiRcpStatsResponse;
        }
    }
}
