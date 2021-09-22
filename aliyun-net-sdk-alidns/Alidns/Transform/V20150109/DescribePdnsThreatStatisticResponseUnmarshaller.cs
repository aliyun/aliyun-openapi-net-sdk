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
    public class DescribePdnsThreatStatisticResponseUnmarshaller
    {
        public static DescribePdnsThreatStatisticResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsThreatStatisticResponse describePdnsThreatStatisticResponse = new DescribePdnsThreatStatisticResponse();

			describePdnsThreatStatisticResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsThreatStatisticResponse.RequestId = _ctx.StringValue("DescribePdnsThreatStatistic.RequestId");

			List<DescribePdnsThreatStatisticResponse.DescribePdnsThreatStatistic_StatisticItem> describePdnsThreatStatisticResponse_data = new List<DescribePdnsThreatStatisticResponse.DescribePdnsThreatStatistic_StatisticItem>();
			for (int i = 0; i < _ctx.Length("DescribePdnsThreatStatistic.Data.Length"); i++) {
				DescribePdnsThreatStatisticResponse.DescribePdnsThreatStatistic_StatisticItem statisticItem = new DescribePdnsThreatStatisticResponse.DescribePdnsThreatStatistic_StatisticItem();
				statisticItem.UdpTotalCount = _ctx.LongValue("DescribePdnsThreatStatistic.Data["+ i +"].UdpTotalCount");
				statisticItem.TotalCount = _ctx.LongValue("DescribePdnsThreatStatistic.Data["+ i +"].TotalCount");
				statisticItem.ThreatLevel = _ctx.StringValue("DescribePdnsThreatStatistic.Data["+ i +"].ThreatLevel");
				statisticItem.ThreatType = _ctx.StringValue("DescribePdnsThreatStatistic.Data["+ i +"].ThreatType");
				statisticItem.Timestamp = _ctx.LongValue("DescribePdnsThreatStatistic.Data["+ i +"].Timestamp");
				statisticItem.DohTotalCount = _ctx.LongValue("DescribePdnsThreatStatistic.Data["+ i +"].DohTotalCount");

				describePdnsThreatStatisticResponse_data.Add(statisticItem);
			}
			describePdnsThreatStatisticResponse.Data = describePdnsThreatStatisticResponse_data;
        
			return describePdnsThreatStatisticResponse;
        }
    }
}
