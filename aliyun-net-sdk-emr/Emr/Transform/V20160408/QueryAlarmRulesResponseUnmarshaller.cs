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
    public class QueryAlarmRulesResponseUnmarshaller
    {
        public static QueryAlarmRulesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAlarmRulesResponse queryAlarmRulesResponse = new QueryAlarmRulesResponse();

			queryAlarmRulesResponse.HttpResponse = context.HttpResponse;
			queryAlarmRulesResponse.RequestId = context.StringValue("QueryAlarmRules.RequestId");

			List<QueryAlarmRulesResponse.QueryAlarmRules_Alarm> queryAlarmRulesResponse_alarmList = new List<QueryAlarmRulesResponse.QueryAlarmRules_Alarm>();
			for (int i = 0; i < context.Length("QueryAlarmRules.AlarmList.Length"); i++) {
				QueryAlarmRulesResponse.QueryAlarmRules_Alarm alarm = new QueryAlarmRulesResponse.QueryAlarmRules_Alarm();
				alarm.Name = context.StringValue("QueryAlarmRules.AlarmList["+ i +"].Name");
				alarm.MetricName = context.StringValue("QueryAlarmRules.AlarmList["+ i +"].MetricName");
				alarm.Period = context.IntegerValue("QueryAlarmRules.AlarmList["+ i +"].Period");
				alarm.Threshold = context.StringValue("QueryAlarmRules.AlarmList["+ i +"].Threshold");
				alarm.EvaluationCount = context.IntegerValue("QueryAlarmRules.AlarmList["+ i +"].EvaluationCount");
				alarm.StartTime = context.IntegerValue("QueryAlarmRules.AlarmList["+ i +"].StartTime");
				alarm.EndTime = context.IntegerValue("QueryAlarmRules.AlarmList["+ i +"].EndTime");
				alarm.SilenceTime = context.IntegerValue("QueryAlarmRules.AlarmList["+ i +"].SilenceTime");
				alarm.NotifyType = context.IntegerValue("QueryAlarmRules.AlarmList["+ i +"].NotifyType");
				alarm.Enable = context.BooleanValue("QueryAlarmRules.AlarmList["+ i +"].Enable");
				alarm.State = context.StringValue("QueryAlarmRules.AlarmList["+ i +"].State");
				alarm.ComparisonOperator = context.StringValue("QueryAlarmRules.AlarmList["+ i +"].ComparisonOperator");
				alarm.ContactGroups = context.StringValue("QueryAlarmRules.AlarmList["+ i +"].ContactGroups");

				queryAlarmRulesResponse_alarmList.Add(alarm);
			}
			queryAlarmRulesResponse.AlarmList = queryAlarmRulesResponse_alarmList;
        
			return queryAlarmRulesResponse;
        }
    }
}
