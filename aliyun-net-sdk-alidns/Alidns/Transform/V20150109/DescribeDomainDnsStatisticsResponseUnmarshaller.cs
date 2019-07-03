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
    public class DescribeDomainDnsStatisticsResponseUnmarshaller
    {
        public static DescribeDomainDnsStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainDnsStatisticsResponse describeDomainDnsStatisticsResponse = new DescribeDomainDnsStatisticsResponse();

			describeDomainDnsStatisticsResponse.HttpResponse = context.HttpResponse;
			describeDomainDnsStatisticsResponse.RequestId = context.StringValue("DescribeDomainDnsStatistics.RequestId");

			List<DescribeDomainDnsStatisticsResponse.DescribeDomainDnsStatistics_Statistic> describeDomainDnsStatisticsResponse_statistics = new List<DescribeDomainDnsStatisticsResponse.DescribeDomainDnsStatistics_Statistic>();
			for (int i = 0; i < context.Length("DescribeDomainDnsStatistics.Statistics.Length"); i++) {
				DescribeDomainDnsStatisticsResponse.DescribeDomainDnsStatistics_Statistic statistic = new DescribeDomainDnsStatisticsResponse.DescribeDomainDnsStatistics_Statistic();
				statistic.Timestamp = context.LongValue("DescribeDomainDnsStatistics.Statistics["+ i +"].Timestamp");
				statistic.Count = context.LongValue("DescribeDomainDnsStatistics.Statistics["+ i +"].Count");

				describeDomainDnsStatisticsResponse_statistics.Add(statistic);
			}
			describeDomainDnsStatisticsResponse.Statistics = describeDomainDnsStatisticsResponse_statistics;
        
			return describeDomainDnsStatisticsResponse;
        }
    }
}
