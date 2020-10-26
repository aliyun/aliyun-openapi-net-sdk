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
using Aliyun.Acs.Ess.Model.V20140828;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeAlarmsResponseUnmarshaller
    {
        public static DescribeAlarmsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAlarmsResponse describeAlarmsResponse = new DescribeAlarmsResponse();

			describeAlarmsResponse.HttpResponse = context.HttpResponse;
			describeAlarmsResponse.RequestId = context.StringValue("DescribeAlarms.RequestId");
			describeAlarmsResponse.TotalCount = context.IntegerValue("DescribeAlarms.TotalCount");
			describeAlarmsResponse.PageNumber = context.IntegerValue("DescribeAlarms.PageNumber");
			describeAlarmsResponse.PageSize = context.IntegerValue("DescribeAlarms.PageSize");

			List<DescribeAlarmsResponse.DescribeAlarms_Alarm> describeAlarmsResponse_alarmList = new List<DescribeAlarmsResponse.DescribeAlarms_Alarm>();
			for (int i = 0; i < context.Length("DescribeAlarms.AlarmList.Length"); i++) {
				DescribeAlarmsResponse.DescribeAlarms_Alarm alarm = new DescribeAlarmsResponse.DescribeAlarms_Alarm();
				alarm.AlarmTaskId = context.StringValue("DescribeAlarms.AlarmList["+ i +"].AlarmTaskId");
				alarm.Name = context.StringValue("DescribeAlarms.AlarmList["+ i +"].Name");
				alarm.Description = context.StringValue("DescribeAlarms.AlarmList["+ i +"].Description");
				alarm.MetricType = context.StringValue("DescribeAlarms.AlarmList["+ i +"].MetricType");
				alarm.MetricName = context.StringValue("DescribeAlarms.AlarmList["+ i +"].MetricName");
				alarm.Period = context.IntegerValue("DescribeAlarms.AlarmList["+ i +"].Period");
				alarm.Statistics = context.StringValue("DescribeAlarms.AlarmList["+ i +"].Statistics");
				alarm.ComparisonOperator = context.StringValue("DescribeAlarms.AlarmList["+ i +"].ComparisonOperator");
				alarm.Threshold = context.FloatValue("DescribeAlarms.AlarmList["+ i +"].Threshold");
				alarm.EvaluationCount = context.IntegerValue("DescribeAlarms.AlarmList["+ i +"].EvaluationCount");
				alarm.State = context.StringValue("DescribeAlarms.AlarmList["+ i +"].State");
				alarm.ScalingGroupId = context.StringValue("DescribeAlarms.AlarmList["+ i +"].ScalingGroupId");
				alarm.Enable = context.BooleanValue("DescribeAlarms.AlarmList["+ i +"].Enable");
				alarm.Effective = context.StringValue("DescribeAlarms.AlarmList["+ i +"].Effective");

				List<string> alarm_alarmActions = new List<string>();
				for (int j = 0; j < context.Length("DescribeAlarms.AlarmList["+ i +"].AlarmActions.Length"); j++) {
					alarm_alarmActions.Add(context.StringValue("DescribeAlarms.AlarmList["+ i +"].AlarmActions["+ j +"]"));
				}
				alarm.AlarmActions = alarm_alarmActions;

				List<DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Dimension> alarm_dimensions = new List<DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Dimension>();
				for (int j = 0; j < context.Length("DescribeAlarms.AlarmList["+ i +"].Dimensions.Length"); j++) {
					DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Dimension dimension = new DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Dimension();
					dimension.DimensionKey = context.StringValue("DescribeAlarms.AlarmList["+ i +"].Dimensions["+ j +"].DimensionKey");
					dimension.DimensionValue = context.StringValue("DescribeAlarms.AlarmList["+ i +"].Dimensions["+ j +"].DimensionValue");

					alarm_dimensions.Add(dimension);
				}
				alarm.Dimensions = alarm_dimensions;

				describeAlarmsResponse_alarmList.Add(alarm);
			}
			describeAlarmsResponse.AlarmList = describeAlarmsResponse_alarmList;
        
			return describeAlarmsResponse;
        }
    }
}
