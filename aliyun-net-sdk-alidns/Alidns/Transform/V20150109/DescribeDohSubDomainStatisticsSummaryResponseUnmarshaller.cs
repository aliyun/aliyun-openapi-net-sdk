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
    public class DescribeDohSubDomainStatisticsSummaryResponseUnmarshaller
    {
        public static DescribeDohSubDomainStatisticsSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDohSubDomainStatisticsSummaryResponse describeDohSubDomainStatisticsSummaryResponse = new DescribeDohSubDomainStatisticsSummaryResponse();

			describeDohSubDomainStatisticsSummaryResponse.HttpResponse = context.HttpResponse;
			describeDohSubDomainStatisticsSummaryResponse.RequestId = context.StringValue("DescribeDohSubDomainStatisticsSummary.RequestId");
			describeDohSubDomainStatisticsSummaryResponse.TotalItems = context.IntegerValue("DescribeDohSubDomainStatisticsSummary.TotalItems");
			describeDohSubDomainStatisticsSummaryResponse.TotalPages = context.IntegerValue("DescribeDohSubDomainStatisticsSummary.TotalPages");
			describeDohSubDomainStatisticsSummaryResponse.PageSize = context.IntegerValue("DescribeDohSubDomainStatisticsSummary.PageSize");
			describeDohSubDomainStatisticsSummaryResponse.PageNumber = context.IntegerValue("DescribeDohSubDomainStatisticsSummary.PageNumber");

			List<DescribeDohSubDomainStatisticsSummaryResponse.DescribeDohSubDomainStatisticsSummary_Statistic> describeDohSubDomainStatisticsSummaryResponse_statistics = new List<DescribeDohSubDomainStatisticsSummaryResponse.DescribeDohSubDomainStatisticsSummary_Statistic>();
			for (int i = 0; i < context.Length("DescribeDohSubDomainStatisticsSummary.Statistics.Length"); i++) {
				DescribeDohSubDomainStatisticsSummaryResponse.DescribeDohSubDomainStatisticsSummary_Statistic statistic = new DescribeDohSubDomainStatisticsSummaryResponse.DescribeDohSubDomainStatisticsSummary_Statistic();
				statistic.SubDomain = context.StringValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].SubDomain");
				statistic.V4HttpCount = context.LongValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].V4HttpCount");
				statistic.V6HttpCount = context.LongValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].V6HttpCount");
				statistic.V4HttpsCount = context.LongValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].V4HttpsCount");
				statistic.V6HttpsCount = context.LongValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].V6HttpsCount");
				statistic.TotalCount = context.LongValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].TotalCount");
				statistic.IpCount = context.LongValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].IpCount");
				statistic.HttpCount = context.LongValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].HttpCount");
				statistic.HttpsCount = context.LongValue("DescribeDohSubDomainStatisticsSummary.Statistics["+ i +"].HttpsCount");

				describeDohSubDomainStatisticsSummaryResponse_statistics.Add(statistic);
			}
			describeDohSubDomainStatisticsSummaryResponse.Statistics = describeDohSubDomainStatisticsSummaryResponse_statistics;
        
			return describeDohSubDomainStatisticsSummaryResponse;
        }
    }
}
