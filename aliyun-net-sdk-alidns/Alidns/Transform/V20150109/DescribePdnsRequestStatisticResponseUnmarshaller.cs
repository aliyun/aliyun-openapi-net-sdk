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
    public class DescribePdnsRequestStatisticResponseUnmarshaller
    {
        public static DescribePdnsRequestStatisticResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsRequestStatisticResponse describePdnsRequestStatisticResponse = new DescribePdnsRequestStatisticResponse();

			describePdnsRequestStatisticResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsRequestStatisticResponse.RequestId = _ctx.StringValue("DescribePdnsRequestStatistic.RequestId");

			List<DescribePdnsRequestStatisticResponse.DescribePdnsRequestStatistic_StatisticItem> describePdnsRequestStatisticResponse_data = new List<DescribePdnsRequestStatisticResponse.DescribePdnsRequestStatistic_StatisticItem>();
			for (int i = 0; i < _ctx.Length("DescribePdnsRequestStatistic.Data.Length"); i++) {
				DescribePdnsRequestStatisticResponse.DescribePdnsRequestStatistic_StatisticItem statisticItem = new DescribePdnsRequestStatisticResponse.DescribePdnsRequestStatistic_StatisticItem();
				statisticItem.UdpTotalCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].UdpTotalCount");
				statisticItem.IpCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].IpCount");
				statisticItem.TotalCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].TotalCount");
				statisticItem.V4HttpCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].V4HttpCount");
				statisticItem.V6HttpCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].V6HttpCount");
				statisticItem.V4Count = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].V4Count");
				statisticItem.HttpsCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].HttpsCount");
				statisticItem.HttpCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].HttpCount");
				statisticItem.V4HttpsCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].V4HttpsCount");
				statisticItem.Timestamp = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].Timestamp");
				statisticItem.V6HttpsCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].V6HttpsCount");
				statisticItem.DohTotalCount = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].DohTotalCount");
				statisticItem.V6Count = _ctx.LongValue("DescribePdnsRequestStatistic.Data["+ i +"].V6Count");

				describePdnsRequestStatisticResponse_data.Add(statisticItem);
			}
			describePdnsRequestStatisticResponse.Data = describePdnsRequestStatisticResponse_data;
        
			return describePdnsRequestStatisticResponse;
        }
    }
}
