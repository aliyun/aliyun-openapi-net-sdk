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
    public class DescribeDomainStatisticsSummaryResponseUnmarshaller
    {
        public static DescribeDomainStatisticsSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainStatisticsSummaryResponse describeDomainStatisticsSummaryResponse = new DescribeDomainStatisticsSummaryResponse();

			describeDomainStatisticsSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainStatisticsSummaryResponse.RequestId = _ctx.StringValue("DescribeDomainStatisticsSummary.RequestId");
			describeDomainStatisticsSummaryResponse.TotalItems = _ctx.IntegerValue("DescribeDomainStatisticsSummary.TotalItems");
			describeDomainStatisticsSummaryResponse.TotalPages = _ctx.IntegerValue("DescribeDomainStatisticsSummary.TotalPages");
			describeDomainStatisticsSummaryResponse.PageSize = _ctx.IntegerValue("DescribeDomainStatisticsSummary.PageSize");
			describeDomainStatisticsSummaryResponse.PageNumber = _ctx.IntegerValue("DescribeDomainStatisticsSummary.PageNumber");

			List<DescribeDomainStatisticsSummaryResponse.DescribeDomainStatisticsSummary_Statistic> describeDomainStatisticsSummaryResponse_statistics = new List<DescribeDomainStatisticsSummaryResponse.DescribeDomainStatisticsSummary_Statistic>();
			for (int i = 0; i < _ctx.Length("DescribeDomainStatisticsSummary.Statistics.Length"); i++) {
				DescribeDomainStatisticsSummaryResponse.DescribeDomainStatisticsSummary_Statistic statistic = new DescribeDomainStatisticsSummaryResponse.DescribeDomainStatisticsSummary_Statistic();
				statistic.DomainName = _ctx.StringValue("DescribeDomainStatisticsSummary.Statistics["+ i +"].DomainName");
				statistic.Count = _ctx.LongValue("DescribeDomainStatisticsSummary.Statistics["+ i +"].Count");
				statistic.DomainType = _ctx.StringValue("DescribeDomainStatisticsSummary.Statistics["+ i +"].DomainType");

				describeDomainStatisticsSummaryResponse_statistics.Add(statistic);
			}
			describeDomainStatisticsSummaryResponse.Statistics = describeDomainStatisticsSummaryResponse_statistics;
        
			return describeDomainStatisticsSummaryResponse;
        }
    }
}
