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
    public class DescribeDohDomainStatisticsSummaryResponseUnmarshaller
    {
        public static DescribeDohDomainStatisticsSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDohDomainStatisticsSummaryResponse describeDohDomainStatisticsSummaryResponse = new DescribeDohDomainStatisticsSummaryResponse();

			describeDohDomainStatisticsSummaryResponse.HttpResponse = context.HttpResponse;
			describeDohDomainStatisticsSummaryResponse.RequestId = context.StringValue("DescribeDohDomainStatisticsSummary.RequestId");
			describeDohDomainStatisticsSummaryResponse.TotalItems = context.IntegerValue("DescribeDohDomainStatisticsSummary.TotalItems");
			describeDohDomainStatisticsSummaryResponse.TotalPages = context.IntegerValue("DescribeDohDomainStatisticsSummary.TotalPages");
			describeDohDomainStatisticsSummaryResponse.PageSize = context.IntegerValue("DescribeDohDomainStatisticsSummary.PageSize");
			describeDohDomainStatisticsSummaryResponse.PageNumber = context.IntegerValue("DescribeDohDomainStatisticsSummary.PageNumber");

			List<DescribeDohDomainStatisticsSummaryResponse.DescribeDohDomainStatisticsSummary_Statistic> describeDohDomainStatisticsSummaryResponse_statistics = new List<DescribeDohDomainStatisticsSummaryResponse.DescribeDohDomainStatisticsSummary_Statistic>();
			for (int i = 0; i < context.Length("DescribeDohDomainStatisticsSummary.Statistics.Length"); i++) {
				DescribeDohDomainStatisticsSummaryResponse.DescribeDohDomainStatisticsSummary_Statistic statistic = new DescribeDohDomainStatisticsSummaryResponse.DescribeDohDomainStatisticsSummary_Statistic();
				statistic.DomainName = context.StringValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].DomainName");
				statistic.V4HttpCount = context.LongValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].V4HttpCount");
				statistic.V6HttpCount = context.LongValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].V6HttpCount");
				statistic.V4HttpsCount = context.LongValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].V4HttpsCount");
				statistic.V6HttpsCount = context.LongValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].V6HttpsCount");
				statistic.TotalCount = context.LongValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].TotalCount");
				statistic.IpCount = context.LongValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].IpCount");
				statistic.HttpCount = context.LongValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].HttpCount");
				statistic.HttpsCount = context.LongValue("DescribeDohDomainStatisticsSummary.Statistics["+ i +"].HttpsCount");

				describeDohDomainStatisticsSummaryResponse_statistics.Add(statistic);
			}
			describeDohDomainStatisticsSummaryResponse.Statistics = describeDohDomainStatisticsSummaryResponse_statistics;
        
			return describeDohDomainStatisticsSummaryResponse;
        }
    }
}
