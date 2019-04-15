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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeStatisticsResponseUnmarshaller
    {
        public static DescribeStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStatisticsResponse describeStatisticsResponse = new DescribeStatisticsResponse();

			describeStatisticsResponse.HttpResponse = context.HttpResponse;
			describeStatisticsResponse.RequestId = context.StringValue("DescribeStatistics.RequestId");

			DescribeStatisticsResponse.DescribeStatistics_Statistics statistics = new DescribeStatisticsResponse.DescribeStatistics_Statistics();
			statistics.VulAsapSum = context.IntegerValue("DescribeStatistics.Statistics.VulAsapSum");
			statistics.VulNntfSum = context.IntegerValue("DescribeStatistics.Statistics.VulNntfSum");
			statistics.HealthTotal = context.IntegerValue("DescribeStatistics.Statistics.HealthTotal");
			statistics.SuspiciousmediumTotal = context.IntegerValue("DescribeStatistics.Statistics.SuspiciousmediumTotal");
			statistics.Health = context.IntegerValue("DescribeStatistics.Statistics.Health");
			statistics.HealthdealedTotal = context.IntegerValue("DescribeStatistics.Statistics.HealthdealedTotal");
			statistics.Trojan = context.IntegerValue("DescribeStatistics.Statistics.Trojan");
			statistics.VulLaterSum = context.IntegerValue("DescribeStatistics.Statistics.VulLaterSum");
			statistics.Suspicious = context.IntegerValue("DescribeStatistics.Statistics.Suspicious");
			statistics.Vul = context.IntegerValue("DescribeStatistics.Statistics.Vul");
			statistics.HealthhighTotal = context.IntegerValue("DescribeStatistics.Statistics.HealthhighTotal");
			statistics.HealthlowTotal = context.IntegerValue("DescribeStatistics.Statistics.HealthlowTotal");
			statistics.HealthseriousTotal = context.IntegerValue("DescribeStatistics.Statistics.HealthseriousTotal");
			statistics.VulDealedTotal = context.IntegerValue("DescribeStatistics.Statistics.VulDealedTotal");
			statistics.Patch = context.IntegerValue("DescribeStatistics.Statistics.Patch");
			statistics.SuspicioushighTotal = context.IntegerValue("DescribeStatistics.Statistics.SuspicioushighTotal");
			statistics.SuspiciouslowTotal = context.IntegerValue("DescribeStatistics.Statistics.SuspiciouslowTotal");
			statistics.SuspiciousTotal = context.IntegerValue("DescribeStatistics.Statistics.SuspiciousTotal");
			statistics.VulTotal = context.IntegerValue("DescribeStatistics.Statistics.VulTotal");
			statistics.SuspiciousseriousTotal = context.IntegerValue("DescribeStatistics.Statistics.SuspiciousseriousTotal");
			statistics.HealthmediumTotal = context.IntegerValue("DescribeStatistics.Statistics.HealthmediumTotal");
			statistics.Online = context.BooleanValue("DescribeStatistics.Statistics.Online");
			statistics.SuspiciousdealedTotal = context.IntegerValue("DescribeStatistics.Statistics.SuspiciousdealedTotal");
			statistics.Account = context.IntegerValue("DescribeStatistics.Statistics.Account");
			describeStatisticsResponse.Statistics = statistics;
        
			return describeStatisticsResponse;
        }
    }
}
