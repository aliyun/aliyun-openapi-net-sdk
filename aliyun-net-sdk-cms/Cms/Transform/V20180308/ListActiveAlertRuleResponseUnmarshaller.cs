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
    public class ListActiveAlertRuleResponseUnmarshaller
    {
        public static ListActiveAlertRuleResponse Unmarshall(UnmarshallerContext context)
        {
			ListActiveAlertRuleResponse listActiveAlertRuleResponse = new ListActiveAlertRuleResponse();

			listActiveAlertRuleResponse.HttpResponse = context.HttpResponse;
			listActiveAlertRuleResponse.Success = context.BooleanValue("ListActiveAlertRule.Success");
			listActiveAlertRuleResponse.Code = context.StringValue("ListActiveAlertRule.Code");
			listActiveAlertRuleResponse.Message = context.StringValue("ListActiveAlertRule.Message");
			listActiveAlertRuleResponse.RequestId = context.StringValue("ListActiveAlertRule.RequestId");

			List<ListActiveAlertRuleResponse.ListActiveAlertRule_Alarm> listActiveAlertRuleResponse_datapoints = new List<ListActiveAlertRuleResponse.ListActiveAlertRule_Alarm>();
			for (int i = 0; i < context.Length("ListActiveAlertRule.Datapoints.Length"); i++) {
				ListActiveAlertRuleResponse.ListActiveAlertRule_Alarm alarm = new ListActiveAlertRuleResponse.ListActiveAlertRule_Alarm();
				alarm.Uuid = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].Uuid");
				alarm.Name = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].Name");
				alarm._Namespace = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].Namespace");
				alarm.MetricName = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].MetricName");
				alarm.Period = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].Period");
				alarm.Statistics = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].Statistics");
				alarm.ComparisonOperator = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].ComparisonOperator");
				alarm.Threshold = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].Threshold");
				alarm.EvaluationCount = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].EvaluationCount");
				alarm.StartTime = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].StartTime");
				alarm.EndTime = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].EndTime");
				alarm.SilenceTime = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].SilenceTime");
				alarm.NotifyType = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].NotifyType");
				alarm.Enable = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].Enable");
				alarm.State = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].State");
				alarm.ContactGroups = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].ContactGroups");
				alarm.Webhook = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].Webhook");
				alarm.RuleName = context.StringValue("ListActiveAlertRule.Datapoints["+ i +"].RuleName");

				listActiveAlertRuleResponse_datapoints.Add(alarm);
			}
			listActiveAlertRuleResponse.Datapoints = listActiveAlertRuleResponse_datapoints;
        
			return listActiveAlertRuleResponse;
        }
    }
}
