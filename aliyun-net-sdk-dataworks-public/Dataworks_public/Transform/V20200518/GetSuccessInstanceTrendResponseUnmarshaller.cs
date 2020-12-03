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
    public class GetSuccessInstanceTrendResponseUnmarshaller
    {
        public static GetSuccessInstanceTrendResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSuccessInstanceTrendResponse getSuccessInstanceTrendResponse = new GetSuccessInstanceTrendResponse();

			getSuccessInstanceTrendResponse.HttpResponse = _ctx.HttpResponse;
			getSuccessInstanceTrendResponse.RequestId = _ctx.StringValue("GetSuccessInstanceTrend.RequestId");

			GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend instanceStatusTrend = new GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend();

			List<GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_TodayTrendItem> instanceStatusTrend_todayTrend = new List<GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_TodayTrendItem>();
			for (int i = 0; i < _ctx.Length("GetSuccessInstanceTrend.InstanceStatusTrend.TodayTrend.Length"); i++) {
				GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_TodayTrendItem todayTrendItem = new GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_TodayTrendItem();
				todayTrendItem.Count = _ctx.IntegerValue("GetSuccessInstanceTrend.InstanceStatusTrend.TodayTrend["+ i +"].Count");
				todayTrendItem.TimePoint = _ctx.StringValue("GetSuccessInstanceTrend.InstanceStatusTrend.TodayTrend["+ i +"].TimePoint");

				instanceStatusTrend_todayTrend.Add(todayTrendItem);
			}
			instanceStatusTrend.TodayTrend = instanceStatusTrend_todayTrend;

			List<GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_YesterdayTrendItem> instanceStatusTrend_yesterdayTrend = new List<GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_YesterdayTrendItem>();
			for (int i = 0; i < _ctx.Length("GetSuccessInstanceTrend.InstanceStatusTrend.YesterdayTrend.Length"); i++) {
				GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_YesterdayTrendItem yesterdayTrendItem = new GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_YesterdayTrendItem();
				yesterdayTrendItem.Count = _ctx.IntegerValue("GetSuccessInstanceTrend.InstanceStatusTrend.YesterdayTrend["+ i +"].Count");
				yesterdayTrendItem.TimePoint = _ctx.StringValue("GetSuccessInstanceTrend.InstanceStatusTrend.YesterdayTrend["+ i +"].TimePoint");

				instanceStatusTrend_yesterdayTrend.Add(yesterdayTrendItem);
			}
			instanceStatusTrend.YesterdayTrend = instanceStatusTrend_yesterdayTrend;

			List<GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_AvgTrendItem> instanceStatusTrend_avgTrend = new List<GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_AvgTrendItem>();
			for (int i = 0; i < _ctx.Length("GetSuccessInstanceTrend.InstanceStatusTrend.AvgTrend.Length"); i++) {
				GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_AvgTrendItem avgTrendItem = new GetSuccessInstanceTrendResponse.GetSuccessInstanceTrend_InstanceStatusTrend.GetSuccessInstanceTrend_AvgTrendItem();
				avgTrendItem.Count = _ctx.IntegerValue("GetSuccessInstanceTrend.InstanceStatusTrend.AvgTrend["+ i +"].Count");
				avgTrendItem.TimePoint = _ctx.StringValue("GetSuccessInstanceTrend.InstanceStatusTrend.AvgTrend["+ i +"].TimePoint");

				instanceStatusTrend_avgTrend.Add(avgTrendItem);
			}
			instanceStatusTrend.AvgTrend = instanceStatusTrend_avgTrend;
			getSuccessInstanceTrendResponse.InstanceStatusTrend = instanceStatusTrend;
        
			return getSuccessInstanceTrendResponse;
        }
    }
}
