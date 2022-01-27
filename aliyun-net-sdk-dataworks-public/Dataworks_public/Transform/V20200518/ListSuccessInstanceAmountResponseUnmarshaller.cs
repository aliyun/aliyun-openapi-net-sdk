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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListSuccessInstanceAmountResponseUnmarshaller
    {
        public static ListSuccessInstanceAmountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSuccessInstanceAmountResponse listSuccessInstanceAmountResponse = new ListSuccessInstanceAmountResponse();

			listSuccessInstanceAmountResponse.HttpResponse = _ctx.HttpResponse;
			listSuccessInstanceAmountResponse.RequestId = _ctx.StringValue("ListSuccessInstanceAmount.RequestId");

			ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend instanceStatusTrend = new ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend();

			List<ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_TodayTrendItem> instanceStatusTrend_todayTrend = new List<ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_TodayTrendItem>();
			for (int i = 0; i < _ctx.Length("ListSuccessInstanceAmount.InstanceStatusTrend.TodayTrend.Length"); i++) {
				ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_TodayTrendItem todayTrendItem = new ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_TodayTrendItem();
				todayTrendItem.Count = _ctx.IntegerValue("ListSuccessInstanceAmount.InstanceStatusTrend.TodayTrend["+ i +"].Count");
				todayTrendItem.TimePoint = _ctx.StringValue("ListSuccessInstanceAmount.InstanceStatusTrend.TodayTrend["+ i +"].TimePoint");

				instanceStatusTrend_todayTrend.Add(todayTrendItem);
			}
			instanceStatusTrend.TodayTrend = instanceStatusTrend_todayTrend;

			List<ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_YesterdayTrendItem> instanceStatusTrend_yesterdayTrend = new List<ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_YesterdayTrendItem>();
			for (int i = 0; i < _ctx.Length("ListSuccessInstanceAmount.InstanceStatusTrend.YesterdayTrend.Length"); i++) {
				ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_YesterdayTrendItem yesterdayTrendItem = new ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_YesterdayTrendItem();
				yesterdayTrendItem.Count = _ctx.IntegerValue("ListSuccessInstanceAmount.InstanceStatusTrend.YesterdayTrend["+ i +"].Count");
				yesterdayTrendItem.TimePoint = _ctx.StringValue("ListSuccessInstanceAmount.InstanceStatusTrend.YesterdayTrend["+ i +"].TimePoint");

				instanceStatusTrend_yesterdayTrend.Add(yesterdayTrendItem);
			}
			instanceStatusTrend.YesterdayTrend = instanceStatusTrend_yesterdayTrend;

			List<ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_AvgTrendItem> instanceStatusTrend_avgTrend = new List<ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_AvgTrendItem>();
			for (int i = 0; i < _ctx.Length("ListSuccessInstanceAmount.InstanceStatusTrend.AvgTrend.Length"); i++) {
				ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_AvgTrendItem avgTrendItem = new ListSuccessInstanceAmountResponse.ListSuccessInstanceAmount_InstanceStatusTrend.ListSuccessInstanceAmount_AvgTrendItem();
				avgTrendItem.Count = _ctx.IntegerValue("ListSuccessInstanceAmount.InstanceStatusTrend.AvgTrend["+ i +"].Count");
				avgTrendItem.TimePoint = _ctx.StringValue("ListSuccessInstanceAmount.InstanceStatusTrend.AvgTrend["+ i +"].TimePoint");

				instanceStatusTrend_avgTrend.Add(avgTrendItem);
			}
			instanceStatusTrend.AvgTrend = instanceStatusTrend_avgTrend;
			listSuccessInstanceAmountResponse.InstanceStatusTrend = instanceStatusTrend;
        
			return listSuccessInstanceAmountResponse;
        }
    }
}
