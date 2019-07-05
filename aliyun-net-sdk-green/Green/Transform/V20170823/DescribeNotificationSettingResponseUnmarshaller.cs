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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeNotificationSettingResponseUnmarshaller
    {
        public static DescribeNotificationSettingResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNotificationSettingResponse describeNotificationSettingResponse = new DescribeNotificationSettingResponse();

			describeNotificationSettingResponse.HttpResponse = context.HttpResponse;
			describeNotificationSettingResponse.RequestId = context.StringValue("DescribeNotificationSetting.RequestId");
			describeNotificationSettingResponse.Email = context.StringValue("DescribeNotificationSetting.Email");
			describeNotificationSettingResponse.Phone = context.StringValue("DescribeNotificationSetting.Phone");
			describeNotificationSettingResponse.ScheduleMessageTime = context.IntegerValue("DescribeNotificationSetting.ScheduleMessageTime");
			describeNotificationSettingResponse.ScheduleMessageTimeZone = context.IntegerValue("DescribeNotificationSetting.ScheduleMessageTimeZone");

			List<string> describeNotificationSettingResponse_realtimeMessageList = new List<string>();
			for (int i = 0; i < context.Length("DescribeNotificationSetting.RealtimeMessageList.Length"); i++) {
				describeNotificationSettingResponse_realtimeMessageList.Add(context.StringValue("DescribeNotificationSetting.RealtimeMessageList["+ i +"]"));
			}
			describeNotificationSettingResponse.RealtimeMessageList = describeNotificationSettingResponse_realtimeMessageList;

			List<string> describeNotificationSettingResponse_reminderModeList = new List<string>();
			for (int i = 0; i < context.Length("DescribeNotificationSetting.ReminderModeList.Length"); i++) {
				describeNotificationSettingResponse_reminderModeList.Add(context.StringValue("DescribeNotificationSetting.ReminderModeList["+ i +"]"));
			}
			describeNotificationSettingResponse.ReminderModeList = describeNotificationSettingResponse_reminderModeList;
        
			return describeNotificationSettingResponse;
        }
    }
}
