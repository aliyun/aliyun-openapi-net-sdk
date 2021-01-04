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
    public class DescribeDohSubDomainStatisticsResponseUnmarshaller
    {
        public static DescribeDohSubDomainStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDohSubDomainStatisticsResponse describeDohSubDomainStatisticsResponse = new DescribeDohSubDomainStatisticsResponse();

			describeDohSubDomainStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeDohSubDomainStatisticsResponse.RequestId = _ctx.StringValue("DescribeDohSubDomainStatistics.RequestId");

			List<DescribeDohSubDomainStatisticsResponse.DescribeDohSubDomainStatistics_Statistic> describeDohSubDomainStatisticsResponse_statistics = new List<DescribeDohSubDomainStatisticsResponse.DescribeDohSubDomainStatistics_Statistic>();
			for (int i = 0; i < _ctx.Length("DescribeDohSubDomainStatistics.Statistics.Length"); i++) {
				DescribeDohSubDomainStatisticsResponse.DescribeDohSubDomainStatistics_Statistic statistic = new DescribeDohSubDomainStatisticsResponse.DescribeDohSubDomainStatistics_Statistic();
				statistic.Timestamp = _ctx.LongValue("DescribeDohSubDomainStatistics.Statistics["+ i +"].Timestamp");
				statistic.V4HttpCount = _ctx.LongValue("DescribeDohSubDomainStatistics.Statistics["+ i +"].V4HttpCount");
				statistic.V4HttpsCount = _ctx.LongValue("DescribeDohSubDomainStatistics.Statistics["+ i +"].V4HttpsCount");
				statistic.V6HttpCount = _ctx.LongValue("DescribeDohSubDomainStatistics.Statistics["+ i +"].V6HttpCount");
				statistic.V6HttpsCount = _ctx.LongValue("DescribeDohSubDomainStatistics.Statistics["+ i +"].V6HttpsCount");
				statistic.TotalCount = _ctx.LongValue("DescribeDohSubDomainStatistics.Statistics["+ i +"].TotalCount");

				describeDohSubDomainStatisticsResponse_statistics.Add(statistic);
			}
			describeDohSubDomainStatisticsResponse.Statistics = describeDohSubDomainStatisticsResponse_statistics;
        
			return describeDohSubDomainStatisticsResponse;
        }
    }
}
