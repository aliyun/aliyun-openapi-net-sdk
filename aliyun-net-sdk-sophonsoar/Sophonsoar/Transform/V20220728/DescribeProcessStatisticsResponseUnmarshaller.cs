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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeProcessStatisticsResponseUnmarshaller
    {
        public static DescribeProcessStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProcessStatisticsResponse describeProcessStatisticsResponse = new DescribeProcessStatisticsResponse();

			describeProcessStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeProcessStatisticsResponse.RequestId = _ctx.StringValue("DescribeProcessStatistics.RequestId");

			DescribeProcessStatisticsResponse.DescribeProcessStatistics_Metrics metrics = new DescribeProcessStatisticsResponse.DescribeProcessStatistics_Metrics();
			metrics.TaskNum = _ctx.IntegerValue("DescribeProcessStatistics.Metrics.TaskNum");
			metrics.BanIpNum = _ctx.IntegerValue("DescribeProcessStatistics.Metrics.BanIpNum");
			metrics.BanFileNum = _ctx.IntegerValue("DescribeProcessStatistics.Metrics.BanFileNum");
			metrics.BanProcessNum = _ctx.IntegerValue("DescribeProcessStatistics.Metrics.BanProcessNum");
			describeProcessStatisticsResponse.Metrics = metrics;
        
			return describeProcessStatisticsResponse;
        }
    }
}
