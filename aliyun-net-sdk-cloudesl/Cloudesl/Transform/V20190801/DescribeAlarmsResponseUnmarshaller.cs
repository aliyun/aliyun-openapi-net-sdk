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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class DescribeAlarmsResponseUnmarshaller
    {
        public static DescribeAlarmsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAlarmsResponse describeAlarmsResponse = new DescribeAlarmsResponse();

			describeAlarmsResponse.HttpResponse = context.HttpResponse;
			describeAlarmsResponse.ErrorMessage = context.StringValue("DescribeAlarms.ErrorMessage");
			describeAlarmsResponse.ErrorCode = context.StringValue("DescribeAlarms.ErrorCode");
			describeAlarmsResponse.PageSize = context.IntegerValue("DescribeAlarms.PageSize");
			describeAlarmsResponse.Message = context.StringValue("DescribeAlarms.Message");
			describeAlarmsResponse.TotalCount = context.IntegerValue("DescribeAlarms.TotalCount");
			describeAlarmsResponse.PageNumber = context.IntegerValue("DescribeAlarms.PageNumber");
			describeAlarmsResponse.DynamicCode = context.StringValue("DescribeAlarms.DynamicCode");
			describeAlarmsResponse.Code = context.StringValue("DescribeAlarms.Code");
			describeAlarmsResponse.DynamicMessage = context.StringValue("DescribeAlarms.DynamicMessage");
			describeAlarmsResponse.RequestId = context.StringValue("DescribeAlarms.RequestId");
			describeAlarmsResponse.Success = context.BooleanValue("DescribeAlarms.Success");

			List<DescribeAlarmsResponse.DescribeAlarms_AlarmInfo> describeAlarmsResponse_alarms = new List<DescribeAlarmsResponse.DescribeAlarms_AlarmInfo>();
			for (int i = 0; i < context.Length("DescribeAlarms.Alarms.Length"); i++) {
				DescribeAlarmsResponse.DescribeAlarms_AlarmInfo alarmInfo = new DescribeAlarmsResponse.DescribeAlarms_AlarmInfo();
				alarmInfo.StoreId = context.StringValue("DescribeAlarms.Alarms["+ i +"].StoreId");
				alarmInfo.DeviceBarCode = context.StringValue("DescribeAlarms.Alarms["+ i +"].DeviceBarCode");
				alarmInfo.DealUserId = context.LongValue("DescribeAlarms.Alarms["+ i +"].DealUserId");
				alarmInfo.DeviceType = context.StringValue("DescribeAlarms.Alarms["+ i +"].DeviceType");
				alarmInfo.ItemTitle = context.StringValue("DescribeAlarms.Alarms["+ i +"].ItemTitle");
				alarmInfo.AlarmTime = context.StringValue("DescribeAlarms.Alarms["+ i +"].AlarmTime");
				alarmInfo.ErrorType = context.StringValue("DescribeAlarms.Alarms["+ i +"].ErrorType");
				alarmInfo.DeviceMac = context.StringValue("DescribeAlarms.Alarms["+ i +"].DeviceMac");
				alarmInfo.AlarmId = context.StringValue("DescribeAlarms.Alarms["+ i +"].AlarmId");
				alarmInfo.Model = context.StringValue("DescribeAlarms.Alarms["+ i +"].Model");
				alarmInfo.ItemBarCode = context.StringValue("DescribeAlarms.Alarms["+ i +"].ItemBarCode");
				alarmInfo.DealTime = context.StringValue("DescribeAlarms.Alarms["+ i +"].DealTime");
				alarmInfo.AlarmType = context.StringValue("DescribeAlarms.Alarms["+ i +"].AlarmType");
				alarmInfo.CompanyId = context.StringValue("DescribeAlarms.Alarms["+ i +"].CompanyId");
				alarmInfo.AlarmStatus = context.StringValue("DescribeAlarms.Alarms["+ i +"].AlarmStatus");
				alarmInfo.Vendor = context.StringValue("DescribeAlarms.Alarms["+ i +"].Vendor");

				describeAlarmsResponse_alarms.Add(alarmInfo);
			}
			describeAlarmsResponse.Alarms = describeAlarmsResponse_alarms;
        
			return describeAlarmsResponse;
        }
    }
}
