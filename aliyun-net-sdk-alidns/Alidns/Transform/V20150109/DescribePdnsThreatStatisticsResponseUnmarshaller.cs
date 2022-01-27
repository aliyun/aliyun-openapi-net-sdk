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
    public class DescribePdnsThreatStatisticsResponseUnmarshaller
    {
        public static DescribePdnsThreatStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsThreatStatisticsResponse describePdnsThreatStatisticsResponse = new DescribePdnsThreatStatisticsResponse();

			describePdnsThreatStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsThreatStatisticsResponse.TotalCount = _ctx.LongValue("DescribePdnsThreatStatistics.TotalCount");
			describePdnsThreatStatisticsResponse.RequestId = _ctx.StringValue("DescribePdnsThreatStatistics.RequestId");
			describePdnsThreatStatisticsResponse.PageSize = _ctx.LongValue("DescribePdnsThreatStatistics.PageSize");
			describePdnsThreatStatisticsResponse.PageNumber = _ctx.LongValue("DescribePdnsThreatStatistics.PageNumber");

			List<DescribePdnsThreatStatisticsResponse.DescribePdnsThreatStatistics_StatisticItem> describePdnsThreatStatisticsResponse_data = new List<DescribePdnsThreatStatisticsResponse.DescribePdnsThreatStatistics_StatisticItem>();
			for (int i = 0; i < _ctx.Length("DescribePdnsThreatStatistics.Data.Length"); i++) {
				DescribePdnsThreatStatisticsResponse.DescribePdnsThreatStatistics_StatisticItem statisticItem = new DescribePdnsThreatStatisticsResponse.DescribePdnsThreatStatistics_StatisticItem();
				statisticItem.SubDomain = _ctx.StringValue("DescribePdnsThreatStatistics.Data["+ i +"].SubDomain");
				statisticItem.UdpTotalCount = _ctx.LongValue("DescribePdnsThreatStatistics.Data["+ i +"].UdpTotalCount");
				statisticItem.TotalCount = _ctx.LongValue("DescribePdnsThreatStatistics.Data["+ i +"].TotalCount");
				statisticItem.SourceIp = _ctx.StringValue("DescribePdnsThreatStatistics.Data["+ i +"].SourceIp");
				statisticItem.ThreatLevel = _ctx.StringValue("DescribePdnsThreatStatistics.Data["+ i +"].ThreatLevel");
				statisticItem.DomainName = _ctx.StringValue("DescribePdnsThreatStatistics.Data["+ i +"].DomainName");
				statisticItem.ThreatType = _ctx.StringValue("DescribePdnsThreatStatistics.Data["+ i +"].ThreatType");
				statisticItem.MaxThreatLevel = _ctx.StringValue("DescribePdnsThreatStatistics.Data["+ i +"].MaxThreatLevel");
				statisticItem.LatestThreatTime = _ctx.LongValue("DescribePdnsThreatStatistics.Data["+ i +"].LatestThreatTime");
				statisticItem.DohTotalCount = _ctx.LongValue("DescribePdnsThreatStatistics.Data["+ i +"].DohTotalCount");
				statisticItem.DomainCount = _ctx.LongValue("DescribePdnsThreatStatistics.Data["+ i +"].DomainCount");

				describePdnsThreatStatisticsResponse_data.Add(statisticItem);
			}
			describePdnsThreatStatisticsResponse.Data = describePdnsThreatStatisticsResponse_data;
        
			return describePdnsThreatStatisticsResponse;
        }
    }
}
