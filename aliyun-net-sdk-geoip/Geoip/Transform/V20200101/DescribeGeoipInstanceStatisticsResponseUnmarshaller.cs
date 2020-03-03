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
using Aliyun.Acs.geoip.Model.V20200101;

namespace Aliyun.Acs.geoip.Transform.V20200101
{
    public class DescribeGeoipInstanceStatisticsResponseUnmarshaller
    {
        public static DescribeGeoipInstanceStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGeoipInstanceStatisticsResponse describeGeoipInstanceStatisticsResponse = new DescribeGeoipInstanceStatisticsResponse();

			describeGeoipInstanceStatisticsResponse.HttpResponse = context.HttpResponse;
			describeGeoipInstanceStatisticsResponse.RequestId = context.StringValue("DescribeGeoipInstanceStatistics.RequestId");

			List<DescribeGeoipInstanceStatisticsResponse.DescribeGeoipInstanceStatistics_Statistic> describeGeoipInstanceStatisticsResponse_statistics = new List<DescribeGeoipInstanceStatisticsResponse.DescribeGeoipInstanceStatistics_Statistic>();
			for (int i = 0; i < context.Length("DescribeGeoipInstanceStatistics.Statistics.Length"); i++) {
				DescribeGeoipInstanceStatisticsResponse.DescribeGeoipInstanceStatistics_Statistic statistic = new DescribeGeoipInstanceStatisticsResponse.DescribeGeoipInstanceStatistics_Statistic();
				statistic.Timestamp = context.LongValue("DescribeGeoipInstanceStatistics.Statistics["+ i +"].Timestamp");
				statistic.Count = context.LongValue("DescribeGeoipInstanceStatistics.Statistics["+ i +"].Count");

				describeGeoipInstanceStatisticsResponse_statistics.Add(statistic);
			}
			describeGeoipInstanceStatisticsResponse.Statistics = describeGeoipInstanceStatisticsResponse_statistics;
        
			return describeGeoipInstanceStatisticsResponse;
        }
    }
}
