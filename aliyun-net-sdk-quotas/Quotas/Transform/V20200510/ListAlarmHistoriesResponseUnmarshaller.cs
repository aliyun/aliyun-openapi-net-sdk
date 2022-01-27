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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class ListAlarmHistoriesResponseUnmarshaller
    {
        public static ListAlarmHistoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAlarmHistoriesResponse listAlarmHistoriesResponse = new ListAlarmHistoriesResponse();

			listAlarmHistoriesResponse.HttpResponse = _ctx.HttpResponse;
			listAlarmHistoriesResponse.RequestId = _ctx.StringValue("ListAlarmHistories.RequestId");
			listAlarmHistoriesResponse.NextToken = _ctx.StringValue("ListAlarmHistories.NextToken");
			listAlarmHistoriesResponse.MaxResults = _ctx.IntegerValue("ListAlarmHistories.MaxResults");
			listAlarmHistoriesResponse.TotalCount = _ctx.IntegerValue("ListAlarmHistories.TotalCount");

			List<ListAlarmHistoriesResponse.ListAlarmHistories_AlarmHistory> listAlarmHistoriesResponse_alarmHistories = new List<ListAlarmHistoriesResponse.ListAlarmHistories_AlarmHistory>();
			for (int i = 0; i < _ctx.Length("ListAlarmHistories.AlarmHistories.Length"); i++) {
				ListAlarmHistoriesResponse.ListAlarmHistories_AlarmHistory alarmHistory = new ListAlarmHistoriesResponse.ListAlarmHistories_AlarmHistory();
				alarmHistory.AlarmName = _ctx.StringValue("ListAlarmHistories.AlarmHistories["+ i +"].AlarmName");
				alarmHistory.QuotaUsage = _ctx.FloatValue("ListAlarmHistories.AlarmHistories["+ i +"].QuotaUsage");
				alarmHistory.ProductCode = _ctx.StringValue("ListAlarmHistories.AlarmHistories["+ i +"].ProductCode");
				alarmHistory.CreateTime = _ctx.StringValue("ListAlarmHistories.AlarmHistories["+ i +"].CreateTime");
				alarmHistory.NotifyTarget = _ctx.StringValue("ListAlarmHistories.AlarmHistories["+ i +"].NotifyTarget");
				alarmHistory.Threshold = _ctx.FloatValue("ListAlarmHistories.AlarmHistories["+ i +"].Threshold");
				alarmHistory.ThresholdPercent = _ctx.FloatValue("ListAlarmHistories.AlarmHistories["+ i +"].ThresholdPercent");
				alarmHistory.QuotaActionCode = _ctx.StringValue("ListAlarmHistories.AlarmHistories["+ i +"].QuotaActionCode");

				List<string> alarmHistory_notifyChannels = new List<string>();
				for (int j = 0; j < _ctx.Length("ListAlarmHistories.AlarmHistories["+ i +"].NotifyChannels.Length"); j++) {
					alarmHistory_notifyChannels.Add(_ctx.StringValue("ListAlarmHistories.AlarmHistories["+ i +"].NotifyChannels["+ j +"]"));
				}
				alarmHistory.NotifyChannels = alarmHistory_notifyChannels;

				listAlarmHistoriesResponse_alarmHistories.Add(alarmHistory);
			}
			listAlarmHistoriesResponse.AlarmHistories = listAlarmHistoriesResponse_alarmHistories;
        
			return listAlarmHistoriesResponse;
        }
    }
}
