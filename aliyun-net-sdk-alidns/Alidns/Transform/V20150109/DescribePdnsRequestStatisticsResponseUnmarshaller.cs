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
    public class DescribePdnsRequestStatisticsResponseUnmarshaller
    {
        public static DescribePdnsRequestStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsRequestStatisticsResponse describePdnsRequestStatisticsResponse = new DescribePdnsRequestStatisticsResponse();

			describePdnsRequestStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsRequestStatisticsResponse.TotalCount = _ctx.LongValue("DescribePdnsRequestStatistics.TotalCount");
			describePdnsRequestStatisticsResponse.RequestId = _ctx.StringValue("DescribePdnsRequestStatistics.RequestId");
			describePdnsRequestStatisticsResponse.PageSize = _ctx.LongValue("DescribePdnsRequestStatistics.PageSize");
			describePdnsRequestStatisticsResponse.PageNumber = _ctx.LongValue("DescribePdnsRequestStatistics.PageNumber");

			List<DescribePdnsRequestStatisticsResponse.DescribePdnsRequestStatistics_StatisticItem> describePdnsRequestStatisticsResponse_data = new List<DescribePdnsRequestStatisticsResponse.DescribePdnsRequestStatistics_StatisticItem>();
			for (int i = 0; i < _ctx.Length("DescribePdnsRequestStatistics.Data.Length"); i++) {
				DescribePdnsRequestStatisticsResponse.DescribePdnsRequestStatistics_StatisticItem statisticItem = new DescribePdnsRequestStatisticsResponse.DescribePdnsRequestStatistics_StatisticItem();
				statisticItem.UdpTotalCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].UdpTotalCount");
				statisticItem.IpCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].IpCount");
				statisticItem.DomainName = _ctx.StringValue("DescribePdnsRequestStatistics.Data["+ i +"].DomainName");
				statisticItem.V6HttpCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].V6HttpCount");
				statisticItem.V4Count = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].V4Count");
				statisticItem.HttpsCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].HttpsCount");
				statisticItem.V4HttpsCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].V4HttpsCount");
				statisticItem.V6Count = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].V6Count");
				statisticItem.SubDomain = _ctx.StringValue("DescribePdnsRequestStatistics.Data["+ i +"].SubDomain");
				statisticItem.TotalCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].TotalCount");
				statisticItem.V4HttpCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].V4HttpCount");
				statisticItem.ThreatCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].ThreatCount");
				statisticItem.MaxThreatLevel = _ctx.StringValue("DescribePdnsRequestStatistics.Data["+ i +"].MaxThreatLevel");
				statisticItem.HttpCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].HttpCount");
				statisticItem.V6HttpsCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].V6HttpsCount");
				statisticItem.DohTotalCount = _ctx.LongValue("DescribePdnsRequestStatistics.Data["+ i +"].DohTotalCount");

				List<DescribePdnsRequestStatisticsResponse.DescribePdnsRequestStatistics_StatisticItem.DescribePdnsRequestStatistics_ThreatItem> statisticItem_threatInfo = new List<DescribePdnsRequestStatisticsResponse.DescribePdnsRequestStatistics_StatisticItem.DescribePdnsRequestStatistics_ThreatItem>();
				for (int j = 0; j < _ctx.Length("DescribePdnsRequestStatistics.Data["+ i +"].ThreatInfo.Length"); j++) {
					DescribePdnsRequestStatisticsResponse.DescribePdnsRequestStatistics_StatisticItem.DescribePdnsRequestStatistics_ThreatItem threatItem = new DescribePdnsRequestStatisticsResponse.DescribePdnsRequestStatistics_StatisticItem.DescribePdnsRequestStatistics_ThreatItem();
					threatItem.ThreatLevel = _ctx.StringValue("DescribePdnsRequestStatistics.Data["+ i +"].ThreatInfo["+ j +"].ThreatLevel");
					threatItem.ThreatType = _ctx.StringValue("DescribePdnsRequestStatistics.Data["+ i +"].ThreatInfo["+ j +"].ThreatType");

					statisticItem_threatInfo.Add(threatItem);
				}
				statisticItem.ThreatInfo = statisticItem_threatInfo;

				describePdnsRequestStatisticsResponse_data.Add(statisticItem);
			}
			describePdnsRequestStatisticsResponse.Data = describePdnsRequestStatisticsResponse_data;
        
			return describePdnsRequestStatisticsResponse;
        }
    }
}
