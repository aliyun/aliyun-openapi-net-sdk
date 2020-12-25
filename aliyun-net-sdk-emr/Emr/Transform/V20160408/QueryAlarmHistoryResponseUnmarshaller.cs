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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class QueryAlarmHistoryResponseUnmarshaller
    {
        public static QueryAlarmHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAlarmHistoryResponse queryAlarmHistoryResponse = new QueryAlarmHistoryResponse();

			queryAlarmHistoryResponse.HttpResponse = _ctx.HttpResponse;
			queryAlarmHistoryResponse.RequestId = _ctx.StringValue("QueryAlarmHistory.RequestId");
			queryAlarmHistoryResponse.Total = _ctx.StringValue("QueryAlarmHistory.Total");
			queryAlarmHistoryResponse.Cursor = _ctx.StringValue("QueryAlarmHistory.Cursor");

			List<QueryAlarmHistoryResponse.QueryAlarmHistory_EmrAlarmHistory> queryAlarmHistoryResponse_alarmHistoryList = new List<QueryAlarmHistoryResponse.QueryAlarmHistory_EmrAlarmHistory>();
			for (int i = 0; i < _ctx.Length("QueryAlarmHistory.AlarmHistoryList.Length"); i++) {
				QueryAlarmHistoryResponse.QueryAlarmHistory_EmrAlarmHistory emrAlarmHistory = new QueryAlarmHistoryResponse.QueryAlarmHistory_EmrAlarmHistory();
				emrAlarmHistory.ClusterId = _ctx.StringValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].ClusterId");
				emrAlarmHistory.Role = _ctx.StringValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].Role");
				emrAlarmHistory.InstanceId = _ctx.StringValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].InstanceId");
				emrAlarmHistory.Name = _ctx.StringValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].Name");
				emrAlarmHistory.MetricName = _ctx.StringValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].MetricName");
				emrAlarmHistory.AlarmTime = _ctx.LongValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].AlarmTime");
				emrAlarmHistory.LastTime = _ctx.LongValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].LastTime");
				emrAlarmHistory.State = _ctx.StringValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].State");
				emrAlarmHistory.Status = _ctx.IntegerValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].Status");
				emrAlarmHistory.ContactGroups = _ctx.StringValue("QueryAlarmHistory.AlarmHistoryList["+ i +"].ContactGroups");

				queryAlarmHistoryResponse_alarmHistoryList.Add(emrAlarmHistory);
			}
			queryAlarmHistoryResponse.AlarmHistoryList = queryAlarmHistoryResponse_alarmHistoryList;
        
			return queryAlarmHistoryResponse;
        }
    }
}
