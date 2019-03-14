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
    public class ListScalingRuleResponseUnmarshaller
    {
        public static ListScalingRuleResponse Unmarshall(UnmarshallerContext context)
        {
			ListScalingRuleResponse listScalingRuleResponse = new ListScalingRuleResponse();

			listScalingRuleResponse.HttpResponse = context.HttpResponse;
			listScalingRuleResponse.RequestId = context.StringValue("ListScalingRule.RequestId");
			listScalingRuleResponse.PageNumber = context.IntegerValue("ListScalingRule.PageNumber");
			listScalingRuleResponse.PageSize = context.IntegerValue("ListScalingRule.PageSize");
			listScalingRuleResponse.Total = context.IntegerValue("ListScalingRule.Total");

			List<ListScalingRuleResponse.ListScalingRule_Rule> listScalingRuleResponse_ruleList = new List<ListScalingRuleResponse.ListScalingRule_Rule>();
			for (int i = 0; i < context.Length("ListScalingRule.RuleList.Length"); i++) {
				ListScalingRuleResponse.ListScalingRule_Rule rule = new ListScalingRuleResponse.ListScalingRule_Rule();
				rule.Id = context.StringValue("ListScalingRule.RuleList["+ i +"].Id");
				rule.GmtCreate = context.LongValue("ListScalingRule.RuleList["+ i +"].GmtCreate");
				rule.GmtModified = context.LongValue("ListScalingRule.RuleList["+ i +"].GmtModified");
				rule.RuleName = context.StringValue("ListScalingRule.RuleList["+ i +"].RuleName");
				rule.RuleCategory = context.StringValue("ListScalingRule.RuleList["+ i +"].RuleCategory");
				rule.AdjustmentType = context.StringValue("ListScalingRule.RuleList["+ i +"].AdjustmentType");
				rule.AdjustmentValue = context.IntegerValue("ListScalingRule.RuleList["+ i +"].AdjustmentValue");
				rule.Cooldown = context.IntegerValue("ListScalingRule.RuleList["+ i +"].Cooldown");
				rule.Status = context.StringValue("ListScalingRule.RuleList["+ i +"].Status");

				ListScalingRuleResponse.ListScalingRule_Rule.ListScalingRule_SchedulerTrigger schedulerTrigger = new ListScalingRuleResponse.ListScalingRule_Rule.ListScalingRule_SchedulerTrigger();
				schedulerTrigger.LaunchTime = context.LongValue("ListScalingRule.RuleList["+ i +"].SchedulerTrigger.LaunchTime");
				schedulerTrigger.LaunchExpirationTime = context.IntegerValue("ListScalingRule.RuleList["+ i +"].SchedulerTrigger.LaunchExpirationTime");
				schedulerTrigger.RecurrenceType = context.StringValue("ListScalingRule.RuleList["+ i +"].SchedulerTrigger.RecurrenceType");
				schedulerTrigger.RecurrenceValue = context.StringValue("ListScalingRule.RuleList["+ i +"].SchedulerTrigger.RecurrenceValue");
				schedulerTrigger.RecurrenceEndTime = context.LongValue("ListScalingRule.RuleList["+ i +"].SchedulerTrigger.RecurrenceEndTime");
				rule.SchedulerTrigger = schedulerTrigger;

				ListScalingRuleResponse.ListScalingRule_Rule.ListScalingRule_CloudWatchTrigger cloudWatchTrigger = new ListScalingRuleResponse.ListScalingRule_Rule.ListScalingRule_CloudWatchTrigger();
				cloudWatchTrigger.MetricName = context.StringValue("ListScalingRule.RuleList["+ i +"].CloudWatchTrigger.MetricName");
				cloudWatchTrigger.Period = context.IntegerValue("ListScalingRule.RuleList["+ i +"].CloudWatchTrigger.Period");
				cloudWatchTrigger.Statistics = context.StringValue("ListScalingRule.RuleList["+ i +"].CloudWatchTrigger.Statistics");
				cloudWatchTrigger.ComparisonOperator = context.StringValue("ListScalingRule.RuleList["+ i +"].CloudWatchTrigger.ComparisonOperator");
				cloudWatchTrigger.Threshold = context.StringValue("ListScalingRule.RuleList["+ i +"].CloudWatchTrigger.Threshold");
				cloudWatchTrigger.EvaluationCount = context.StringValue("ListScalingRule.RuleList["+ i +"].CloudWatchTrigger.EvaluationCount");
				cloudWatchTrigger.Unit = context.StringValue("ListScalingRule.RuleList["+ i +"].CloudWatchTrigger.Unit");
				cloudWatchTrigger.MetricDisplayName = context.StringValue("ListScalingRule.RuleList["+ i +"].CloudWatchTrigger.MetricDisplayName");
				rule.CloudWatchTrigger = cloudWatchTrigger;

				listScalingRuleResponse_ruleList.Add(rule);
			}
			listScalingRuleResponse.RuleList = listScalingRuleResponse_ruleList;
        
			return listScalingRuleResponse;
        }
    }
}
