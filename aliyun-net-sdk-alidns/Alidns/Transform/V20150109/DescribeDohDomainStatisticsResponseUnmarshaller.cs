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
    public class DescribeDohDomainStatisticsResponseUnmarshaller
    {
        public static DescribeDohDomainStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDohDomainStatisticsResponse describeDohDomainStatisticsResponse = new DescribeDohDomainStatisticsResponse();

			describeDohDomainStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeDohDomainStatisticsResponse.RequestId = _ctx.StringValue("DescribeDohDomainStatistics.RequestId");

			List<DescribeDohDomainStatisticsResponse.DescribeDohDomainStatistics_Statistic> describeDohDomainStatisticsResponse_statistics = new List<DescribeDohDomainStatisticsResponse.DescribeDohDomainStatistics_Statistic>();
			for (int i = 0; i < _ctx.Length("DescribeDohDomainStatistics.Statistics.Length"); i++) {
				DescribeDohDomainStatisticsResponse.DescribeDohDomainStatistics_Statistic statistic = new DescribeDohDomainStatisticsResponse.DescribeDohDomainStatistics_Statistic();
				statistic.Timestamp = _ctx.LongValue("DescribeDohDomainStatistics.Statistics["+ i +"].Timestamp");
				statistic.V4HttpCount = _ctx.LongValue("DescribeDohDomainStatistics.Statistics["+ i +"].V4HttpCount");
				statistic.V6HttpCount = _ctx.LongValue("DescribeDohDomainStatistics.Statistics["+ i +"].V6HttpCount");
				statistic.V4HttpsCount = _ctx.LongValue("DescribeDohDomainStatistics.Statistics["+ i +"].V4HttpsCount");
				statistic.V6HttpsCount = _ctx.LongValue("DescribeDohDomainStatistics.Statistics["+ i +"].V6HttpsCount");
				statistic.TotalCount = _ctx.LongValue("DescribeDohDomainStatistics.Statistics["+ i +"].TotalCount");

				describeDohDomainStatisticsResponse_statistics.Add(statistic);
			}
			describeDohDomainStatisticsResponse.Statistics = describeDohDomainStatisticsResponse_statistics;
        
			return describeDohDomainStatisticsResponse;
        }
    }
}
