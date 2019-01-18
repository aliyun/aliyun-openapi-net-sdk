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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cms.Model.V20180308;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ListAlarmHistoryResponseUnmarshaller
    {
        public static ListAlarmHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			ListAlarmHistoryResponse listAlarmHistoryResponse = new ListAlarmHistoryResponse();

			listAlarmHistoryResponse.HttpResponse = context.HttpResponse;
			listAlarmHistoryResponse.Success = context.BooleanValue("ListAlarmHistory.Success");
			listAlarmHistoryResponse.Code = context.StringValue("ListAlarmHistory.Code");
			listAlarmHistoryResponse.Message = context.StringValue("ListAlarmHistory.Message");
			listAlarmHistoryResponse.Cursor = context.StringValue("ListAlarmHistory.Cursor");
			listAlarmHistoryResponse.RequestId = context.StringValue("ListAlarmHistory.RequestId");

			List<ListAlarmHistoryResponse.ListAlarmHistory_AlarmHistory> listAlarmHistoryResponse_alarmHistoryList = new List<ListAlarmHistoryResponse.ListAlarmHistory_AlarmHistory>();
			for (int i = 0; i < context.Length("ListAlarmHistory.AlarmHistoryList.Length"); i++) {
				ListAlarmHistoryResponse.ListAlarmHistory_AlarmHistory alarmHistory = new ListAlarmHistoryResponse.ListAlarmHistory_AlarmHistory();
				alarmHistory.Id = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].Id");
				alarmHistory.Name = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].Name");
				alarmHistory._Namespace = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].Namespace");
				alarmHistory.MetricName = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].MetricName");
				alarmHistory.Dimension = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].Dimension");
				alarmHistory.EvaluationCount = context.IntegerValue("ListAlarmHistory.AlarmHistoryList["+ i +"].EvaluationCount");
				alarmHistory._Value = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].Value");
				alarmHistory.AlarmTime = context.LongValue("ListAlarmHistory.AlarmHistoryList["+ i +"].AlarmTime");
				alarmHistory.LastTime = context.LongValue("ListAlarmHistory.AlarmHistoryList["+ i +"].LastTime");
				alarmHistory.State = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].State");
				alarmHistory.Status = context.IntegerValue("ListAlarmHistory.AlarmHistoryList["+ i +"].Status");
				alarmHistory.ContactGroups = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].ContactGroups");
				alarmHistory.InstanceName = context.StringValue("ListAlarmHistory.AlarmHistoryList["+ i +"].InstanceName");

				listAlarmHistoryResponse_alarmHistoryList.Add(alarmHistory);
			}
			listAlarmHistoryResponse.AlarmHistoryList = listAlarmHistoryResponse_alarmHistoryList;
        
			return listAlarmHistoryResponse;
        }
    }
}