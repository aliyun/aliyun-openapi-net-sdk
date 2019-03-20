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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ListAlarmResponseUnmarshaller
    {
        public static ListAlarmResponse Unmarshall(UnmarshallerContext context)
        {
			ListAlarmResponse listAlarmResponse = new ListAlarmResponse();

			listAlarmResponse.HttpResponse = context.HttpResponse;
			listAlarmResponse.Success = context.BooleanValue("ListAlarm.Success");
			listAlarmResponse.Code = context.StringValue("ListAlarm.Code");
			listAlarmResponse.Message = context.StringValue("ListAlarm.Message");
			listAlarmResponse.NextToken = context.IntegerValue("ListAlarm.NextToken");
			listAlarmResponse.Total = context.IntegerValue("ListAlarm.Total");
			listAlarmResponse.RequestId = context.StringValue("ListAlarm.RequestId");

			List<ListAlarmResponse.ListAlarm_Alarm> listAlarmResponse_alarmList = new List<ListAlarmResponse.ListAlarm_Alarm>();
			for (int i = 0; i < context.Length("ListAlarm.AlarmList.Length"); i++) {
				ListAlarmResponse.ListAlarm_Alarm alarm = new ListAlarmResponse.ListAlarm_Alarm();
				alarm.Id = context.StringValue("ListAlarm.AlarmList["+ i +"].Id");
				alarm.Name = context.StringValue("ListAlarm.AlarmList["+ i +"].Name");
				alarm._Namespace = context.StringValue("ListAlarm.AlarmList["+ i +"].Namespace");
				alarm.MetricName = context.StringValue("ListAlarm.AlarmList["+ i +"].MetricName");
				alarm.Dimensions = context.StringValue("ListAlarm.AlarmList["+ i +"].Dimensions");
				alarm.Period = context.IntegerValue("ListAlarm.AlarmList["+ i +"].Period");
				alarm.Statistics = context.StringValue("ListAlarm.AlarmList["+ i +"].Statistics");
				alarm.ComparisonOperator = context.StringValue("ListAlarm.AlarmList["+ i +"].ComparisonOperator");
				alarm.Threshold = context.StringValue("ListAlarm.AlarmList["+ i +"].Threshold");
				alarm.EvaluationCount = context.IntegerValue("ListAlarm.AlarmList["+ i +"].EvaluationCount");
				alarm.StartTime = context.IntegerValue("ListAlarm.AlarmList["+ i +"].StartTime");
				alarm.EndTime = context.IntegerValue("ListAlarm.AlarmList["+ i +"].EndTime");
				alarm.SilenceTime = context.IntegerValue("ListAlarm.AlarmList["+ i +"].SilenceTime");
				alarm.NotifyType = context.IntegerValue("ListAlarm.AlarmList["+ i +"].NotifyType");
				alarm.Enable = context.BooleanValue("ListAlarm.AlarmList["+ i +"].Enable");
				alarm.State = context.StringValue("ListAlarm.AlarmList["+ i +"].State");
				alarm.ContactGroups = context.StringValue("ListAlarm.AlarmList["+ i +"].ContactGroups");
				alarm.Webhook = context.StringValue("ListAlarm.AlarmList["+ i +"].Webhook");

				listAlarmResponse_alarmList.Add(alarm);
			}
			listAlarmResponse.AlarmList = listAlarmResponse_alarmList;
        
			return listAlarmResponse;
        }
    }
}
