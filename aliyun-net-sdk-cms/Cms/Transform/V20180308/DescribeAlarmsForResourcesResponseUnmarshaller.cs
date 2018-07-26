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
    public class DescribeAlarmsForResourcesResponseUnmarshaller
    {
        public static DescribeAlarmsForResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAlarmsForResourcesResponse describeAlarmsForResourcesResponse = new DescribeAlarmsForResourcesResponse();

			describeAlarmsForResourcesResponse.HttpResponse = context.HttpResponse;
			describeAlarmsForResourcesResponse.RequestId = context.StringValue("DescribeAlarmsForResources.RequestId");
			describeAlarmsForResourcesResponse.TraceId = context.StringValue("DescribeAlarmsForResources.TraceId");
			describeAlarmsForResourcesResponse.Success = context.BooleanValue("DescribeAlarmsForResources.Success");
			describeAlarmsForResourcesResponse.Code = context.IntegerValue("DescribeAlarmsForResources.Code");
			describeAlarmsForResourcesResponse.Message = context.StringValue("DescribeAlarmsForResources.Message");
			describeAlarmsForResourcesResponse.Total = context.StringValue("DescribeAlarmsForResources.Total");
			describeAlarmsForResourcesResponse.Dimensions = context.StringValue("DescribeAlarmsForResources.Dimensions");

			List<DescribeAlarmsForResourcesResponse.DescribeAlarmsForResources_Alarm> describeAlarmsForResourcesResponse_datapoints = new List<DescribeAlarmsForResourcesResponse.DescribeAlarmsForResources_Alarm>();
			for (int i = 0; i < context.Length("DescribeAlarmsForResources.Datapoints.Length"); i++) {
				DescribeAlarmsForResourcesResponse.DescribeAlarmsForResources_Alarm alarm = new DescribeAlarmsForResourcesResponse.DescribeAlarmsForResources_Alarm();
				alarm.Uuid = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Uuid");
				alarm.Name = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Name");
				alarm._Namespace = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Namespace");
				alarm.MetricName = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].MetricName");
				alarm.Period = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Period");
				alarm.EvaluationCount = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].EvaluationCount");
				alarm.EffectiveInterval = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].EffectiveInterval");
				alarm.NoEffectiveInterval = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].NoEffectiveInterval");
				alarm.SilenceTime = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].SilenceTime");
				alarm.Enable = context.BooleanValue("DescribeAlarmsForResources.Datapoints["+ i +"].Enable");
				alarm.State = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].State");
				alarm.ContactGroups = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].ContactGroups");
				alarm.Webhook = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Webhook");
				alarm.Subject = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Subject");
				alarm.DisplayName = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].DisplayName");
				alarm.Resources = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Resources");
				alarm.Level = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Level");
				alarm.GroupId = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].GroupId");
				alarm.GroupName = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].GroupName");
				alarm.Statistics = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Statistics");
				alarm.ComparisonOperator = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].ComparisonOperator");
				alarm.Threshold = context.StringValue("DescribeAlarmsForResources.Datapoints["+ i +"].Threshold");

				describeAlarmsForResourcesResponse_datapoints.Add(alarm);
			}
			describeAlarmsForResourcesResponse.Datapoints = describeAlarmsForResourcesResponse_datapoints;
        
			return describeAlarmsForResourcesResponse;
        }
    }
}