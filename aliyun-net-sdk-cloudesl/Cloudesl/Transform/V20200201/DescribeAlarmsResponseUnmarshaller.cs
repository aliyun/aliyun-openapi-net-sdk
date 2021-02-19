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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeAlarmsResponseUnmarshaller
    {
        public static DescribeAlarmsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlarmsResponse describeAlarmsResponse = new DescribeAlarmsResponse();

			describeAlarmsResponse.HttpResponse = _ctx.HttpResponse;
			describeAlarmsResponse.ErrorMessage = _ctx.StringValue("DescribeAlarms.ErrorMessage");
			describeAlarmsResponse.ErrorCode = _ctx.StringValue("DescribeAlarms.ErrorCode");
			describeAlarmsResponse.PageSize = _ctx.IntegerValue("DescribeAlarms.PageSize");
			describeAlarmsResponse.Message = _ctx.StringValue("DescribeAlarms.Message");
			describeAlarmsResponse.TotalCount = _ctx.IntegerValue("DescribeAlarms.TotalCount");
			describeAlarmsResponse.PageNumber = _ctx.IntegerValue("DescribeAlarms.PageNumber");
			describeAlarmsResponse.DynamicCode = _ctx.StringValue("DescribeAlarms.DynamicCode");
			describeAlarmsResponse.Code = _ctx.StringValue("DescribeAlarms.Code");
			describeAlarmsResponse.DynamicMessage = _ctx.StringValue("DescribeAlarms.DynamicMessage");
			describeAlarmsResponse.RequestId = _ctx.StringValue("DescribeAlarms.RequestId");
			describeAlarmsResponse.Success = _ctx.BooleanValue("DescribeAlarms.Success");

			List<DescribeAlarmsResponse.DescribeAlarms_AlarmInfo> describeAlarmsResponse_alarms = new List<DescribeAlarmsResponse.DescribeAlarms_AlarmInfo>();
			for (int i = 0; i < _ctx.Length("DescribeAlarms.Alarms.Length"); i++) {
				DescribeAlarmsResponse.DescribeAlarms_AlarmInfo alarmInfo = new DescribeAlarmsResponse.DescribeAlarms_AlarmInfo();
				alarmInfo.Remark = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].Remark");
				alarmInfo.StoreId = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].StoreId");
				alarmInfo.DeviceBarCode = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].DeviceBarCode");
				alarmInfo.DealUserId = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].DealUserId");
				alarmInfo.DeviceType = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].DeviceType");
				alarmInfo.ItemTitle = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].ItemTitle");
				alarmInfo.AlarmTime = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].AlarmTime");
				alarmInfo.ErrorType = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].ErrorType");
				alarmInfo.DeviceMac = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].DeviceMac");
				alarmInfo.AlarmId = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].AlarmId");
				alarmInfo.RetryGmtCreate = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].RetryGmtCreate");
				alarmInfo.RetryGmtModified = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].RetryGmtModified");
				alarmInfo.ItemBarCode = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].ItemBarCode");
				alarmInfo.RetryTimes = _ctx.LongValue("DescribeAlarms.Alarms["+ i +"].RetryTimes");
				alarmInfo.DealTime = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].DealTime");
				alarmInfo.AlarmType = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].AlarmType");
				alarmInfo.AlarmStatus = _ctx.StringValue("DescribeAlarms.Alarms["+ i +"].AlarmStatus");

				describeAlarmsResponse_alarms.Add(alarmInfo);
			}
			describeAlarmsResponse.Alarms = describeAlarmsResponse_alarms;
        
			return describeAlarmsResponse;
        }
    }
}
