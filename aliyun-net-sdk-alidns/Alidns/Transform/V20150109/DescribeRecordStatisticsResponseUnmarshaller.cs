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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeRecordStatisticsResponseUnmarshaller
    {
        public static DescribeRecordStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRecordStatisticsResponse describeRecordStatisticsResponse = new DescribeRecordStatisticsResponse();

			describeRecordStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeRecordStatisticsResponse.RequestId = _ctx.StringValue("DescribeRecordStatistics.RequestId");

			List<DescribeRecordStatisticsResponse.DescribeRecordStatistics_Statistic> describeRecordStatisticsResponse_statistics = new List<DescribeRecordStatisticsResponse.DescribeRecordStatistics_Statistic>();
			for (int i = 0; i < _ctx.Length("DescribeRecordStatistics.Statistics.Length"); i++) {
				DescribeRecordStatisticsResponse.DescribeRecordStatistics_Statistic statistic = new DescribeRecordStatisticsResponse.DescribeRecordStatistics_Statistic();
				statistic.Timestamp = _ctx.LongValue("DescribeRecordStatistics.Statistics["+ i +"].Timestamp");
				statistic.Count = _ctx.LongValue("DescribeRecordStatistics.Statistics["+ i +"].Count");

				describeRecordStatisticsResponse_statistics.Add(statistic);
			}
			describeRecordStatisticsResponse.Statistics = describeRecordStatisticsResponse_statistics;
        
			return describeRecordStatisticsResponse;
        }
    }
}
