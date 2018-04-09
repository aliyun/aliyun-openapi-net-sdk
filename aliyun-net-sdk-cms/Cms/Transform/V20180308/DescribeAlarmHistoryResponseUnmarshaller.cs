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
    public class DescribeAlarmHistoryResponseUnmarshaller
    {
        public static DescribeAlarmHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAlarmHistoryResponse describeAlarmHistoryResponse = new DescribeAlarmHistoryResponse();

			describeAlarmHistoryResponse.HttpResponse = context.HttpResponse;
			describeAlarmHistoryResponse.Success = context.BooleanValue("DescribeAlarmHistory.Success");
			describeAlarmHistoryResponse.Code = context.StringValue("DescribeAlarmHistory.Code");
			describeAlarmHistoryResponse.Message = context.StringValue("DescribeAlarmHistory.Message");
			describeAlarmHistoryResponse.Total = context.StringValue("DescribeAlarmHistory.Total");
			describeAlarmHistoryResponse.RequestId = context.StringValue("DescribeAlarmHistory.RequestId");

			List<DescribeAlarmHistoryResponse.DescribeAlarmHistory_AlarmHistory> describeAlarmHistoryResponse_alarmHistoryList = new List<DescribeAlarmHistoryResponse.DescribeAlarmHistory_AlarmHistory>();
			for (int i = 0; i < context.Length("DescribeAlarmHistory.AlarmHistoryList.Length"); i++) {
				DescribeAlarmHistoryResponse.DescribeAlarmHistory_AlarmHistory alarmHistory = new DescribeAlarmHistoryResponse.DescribeAlarmHistory_AlarmHistory();
				alarmHistory.Id = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Id");
				alarmHistory.AlertName = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].AlertName");
				alarmHistory.GroupId = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].GroupId");
				alarmHistory._Namespace = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Namespace");
				alarmHistory.MetricName = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].MetricName");
				alarmHistory.Dimensions = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Dimensions");
				alarmHistory.Expression = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Expression");
				alarmHistory.EvaluationCount = context.IntegerValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].EvaluationCount");
				alarmHistory._Value = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Value");
				alarmHistory.AlertTime = context.LongValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].AlertTime");
				alarmHistory.LastTime = context.LongValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].LastTime");
				alarmHistory.Level = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Level");
				alarmHistory.PreLevel = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].PreLevel");
				alarmHistory.RuleName = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].RuleName");
				alarmHistory.State = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].State");
				alarmHistory.Status = context.IntegerValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Status");
				alarmHistory.UserId = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].UserId");
				alarmHistory.Webhooks = context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Webhooks");

				List<string> alarmHistory_contactGroups = new List<string>();
				for (int j = 0; j < context.Length("DescribeAlarmHistory.AlarmHistoryList["+ i +"].ContactGroups.Length"); j++) {
					alarmHistory_contactGroups.Add(context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].ContactGroups["+ j +"]"));
				}
				alarmHistory.ContactGroups = alarmHistory_contactGroups;

				List<string> alarmHistory_contacts = new List<string>();
				for (int j = 0; j < context.Length("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Contacts.Length"); j++) {
					alarmHistory_contacts.Add(context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].Contacts["+ j +"]"));
				}
				alarmHistory.Contacts = alarmHistory_contacts;

				List<string> alarmHistory_contactALIIMs = new List<string>();
				for (int j = 0; j < context.Length("DescribeAlarmHistory.AlarmHistoryList["+ i +"].ContactALIIMs.Length"); j++) {
					alarmHistory_contactALIIMs.Add(context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].ContactALIIMs["+ j +"]"));
				}
				alarmHistory.ContactALIIMs = alarmHistory_contactALIIMs;

				List<string> alarmHistory_contactSmses = new List<string>();
				for (int j = 0; j < context.Length("DescribeAlarmHistory.AlarmHistoryList["+ i +"].ContactSmses.Length"); j++) {
					alarmHistory_contactSmses.Add(context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].ContactSmses["+ j +"]"));
				}
				alarmHistory.ContactSmses = alarmHistory_contactSmses;

				List<string> alarmHistory_contactMails = new List<string>();
				for (int j = 0; j < context.Length("DescribeAlarmHistory.AlarmHistoryList["+ i +"].ContactMails.Length"); j++) {
					alarmHistory_contactMails.Add(context.StringValue("DescribeAlarmHistory.AlarmHistoryList["+ i +"].ContactMails["+ j +"]"));
				}
				alarmHistory.ContactMails = alarmHistory_contactMails;

				describeAlarmHistoryResponse_alarmHistoryList.Add(alarmHistory);
			}
			describeAlarmHistoryResponse.AlarmHistoryList = describeAlarmHistoryResponse_alarmHistoryList;
        
			return describeAlarmHistoryResponse;
        }
    }
}