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
    public class DescribeAlarmsResponseUnmarshaller
    {
        public static DescribeAlarmsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAlarmsResponse describeAlarmsResponse = new DescribeAlarmsResponse();

			describeAlarmsResponse.HttpResponse = context.HttpResponse;
			describeAlarmsResponse.RequestId = context.StringValue("DescribeAlarms.RequestId");
			describeAlarmsResponse.TraceId = context.StringValue("DescribeAlarms.TraceId");
			describeAlarmsResponse.Success = context.BooleanValue("DescribeAlarms.Success");
			describeAlarmsResponse.Code = context.IntegerValue("DescribeAlarms.Code");
			describeAlarmsResponse.Message = context.StringValue("DescribeAlarms.Message");
			describeAlarmsResponse.Total = context.StringValue("DescribeAlarms.Total");

			List<DescribeAlarmsResponse.DescribeAlarms_Alarm> describeAlarmsResponse_datapoints = new List<DescribeAlarmsResponse.DescribeAlarms_Alarm>();
			for (int i = 0; i < context.Length("DescribeAlarms.Datapoints.Length"); i++) {
				DescribeAlarmsResponse.DescribeAlarms_Alarm alarm = new DescribeAlarmsResponse.DescribeAlarms_Alarm();
				alarm.Uuid = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Uuid");
				alarm.Name = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Name");
				alarm._Namespace = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Namespace");
				alarm.MetricName = context.StringValue("DescribeAlarms.Datapoints["+ i +"].MetricName");
				alarm.Period = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Period");
				alarm.EvaluationCount = context.StringValue("DescribeAlarms.Datapoints["+ i +"].EvaluationCount");
				alarm.EffectiveInterval = context.StringValue("DescribeAlarms.Datapoints["+ i +"].EffectiveInterval");
				alarm.NoEffectiveInterval = context.StringValue("DescribeAlarms.Datapoints["+ i +"].NoEffectiveInterval");
				alarm.SilenceTime = context.StringValue("DescribeAlarms.Datapoints["+ i +"].SilenceTime");
				alarm.Enable = context.BooleanValue("DescribeAlarms.Datapoints["+ i +"].Enable");
				alarm.State = context.StringValue("DescribeAlarms.Datapoints["+ i +"].State");
				alarm.ContactGroups = context.StringValue("DescribeAlarms.Datapoints["+ i +"].ContactGroups");
				alarm.Webhook = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Webhook");
				alarm.Subject = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Subject");
				alarm.RuleName = context.StringValue("DescribeAlarms.Datapoints["+ i +"].RuleName");
				alarm.Resources = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Resources");
				alarm.Level = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Level");
				alarm.GroupId = context.StringValue("DescribeAlarms.Datapoints["+ i +"].GroupId");
				alarm.GroupName = context.StringValue("DescribeAlarms.Datapoints["+ i +"].GroupName");
				alarm.Dimensions = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Dimensions");
				alarm.Statistics = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Statistics");
				alarm.ComparisonOperator = context.StringValue("DescribeAlarms.Datapoints["+ i +"].ComparisonOperator");
				alarm.Threshold = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Threshold");
				alarm.DisplayName = context.StringValue("DescribeAlarms.Datapoints["+ i +"].DisplayName");

				DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Escalations escalations = new DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Escalations();

				DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Escalations.DescribeAlarms_Info info = new DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Escalations.DescribeAlarms_Info();
				info.ComparisonOperator = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Info.ComparisonOperator");
				info.Statistics = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Info.Statistics");
				info.Threshold = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Info.Threshold");
				info.Times = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Info.Times");
				escalations.Info = info;

				DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Escalations.DescribeAlarms_Warn warn = new DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Escalations.DescribeAlarms_Warn();
				warn.ComparisonOperator = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Warn.ComparisonOperator");
				warn.Statistics = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Warn.Statistics");
				warn.Threshold = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Warn.Threshold");
				warn.Times = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Warn.Times");
				escalations.Warn = warn;

				DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Escalations.DescribeAlarms_Critical critical = new DescribeAlarmsResponse.DescribeAlarms_Alarm.DescribeAlarms_Escalations.DescribeAlarms_Critical();
				critical.ComparisonOperator = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Critical.ComparisonOperator");
				critical.Statistics = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Critical.Statistics");
				critical.Threshold = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Critical.Threshold");
				critical.Times = context.StringValue("DescribeAlarms.Datapoints["+ i +"].Escalations.Critical.Times");
				escalations.Critical = critical;
				alarm.Escalations = escalations;

				describeAlarmsResponse_datapoints.Add(alarm);
			}
			describeAlarmsResponse.Datapoints = describeAlarmsResponse_datapoints;
        
			return describeAlarmsResponse;
        }
    }
}
