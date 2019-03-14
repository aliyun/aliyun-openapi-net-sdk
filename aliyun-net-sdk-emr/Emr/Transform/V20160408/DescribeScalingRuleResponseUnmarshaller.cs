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
    public class DescribeScalingRuleResponseUnmarshaller
    {
        public static DescribeScalingRuleResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingRuleResponse describeScalingRuleResponse = new DescribeScalingRuleResponse();

			describeScalingRuleResponse.HttpResponse = context.HttpResponse;
			describeScalingRuleResponse.RequestId = context.StringValue("DescribeScalingRule.RequestId");
			describeScalingRuleResponse.Id = context.StringValue("DescribeScalingRule.Id");
			describeScalingRuleResponse.GmtCreate = context.StringValue("DescribeScalingRule.GmtCreate");
			describeScalingRuleResponse.GmtModified = context.StringValue("DescribeScalingRule.GmtModified");
			describeScalingRuleResponse.RuleName = context.StringValue("DescribeScalingRule.RuleName");
			describeScalingRuleResponse.RuleCategory = context.StringValue("DescribeScalingRule.RuleCategory");
			describeScalingRuleResponse.AdjustmentType = context.StringValue("DescribeScalingRule.AdjustmentType");
			describeScalingRuleResponse.AdjustmentValue = context.IntegerValue("DescribeScalingRule.AdjustmentValue");
			describeScalingRuleResponse.Cooldown = context.IntegerValue("DescribeScalingRule.Cooldown");
			describeScalingRuleResponse.Status = context.StringValue("DescribeScalingRule.Status");

			DescribeScalingRuleResponse.DescribeScalingRule_SchedulerTrigger schedulerTrigger = new DescribeScalingRuleResponse.DescribeScalingRule_SchedulerTrigger();
			schedulerTrigger.LaunchTime = context.LongValue("DescribeScalingRule.SchedulerTrigger.LaunchTime");
			schedulerTrigger.LaunchExpirationTime = context.IntegerValue("DescribeScalingRule.SchedulerTrigger.LaunchExpirationTime");
			schedulerTrigger.RecurrenceType = context.StringValue("DescribeScalingRule.SchedulerTrigger.RecurrenceType");
			schedulerTrigger.RecurrenceValue = context.StringValue("DescribeScalingRule.SchedulerTrigger.RecurrenceValue");
			schedulerTrigger.RecurrenceEndTime = context.LongValue("DescribeScalingRule.SchedulerTrigger.RecurrenceEndTime");
			describeScalingRuleResponse.SchedulerTrigger = schedulerTrigger;

			DescribeScalingRuleResponse.DescribeScalingRule_CloudWatchTrigger cloudWatchTrigger = new DescribeScalingRuleResponse.DescribeScalingRule_CloudWatchTrigger();
			cloudWatchTrigger.MetricName = context.StringValue("DescribeScalingRule.CloudWatchTrigger.MetricName");
			cloudWatchTrigger.Period = context.IntegerValue("DescribeScalingRule.CloudWatchTrigger.Period");
			cloudWatchTrigger.Statistics = context.StringValue("DescribeScalingRule.CloudWatchTrigger.Statistics");
			cloudWatchTrigger.ComparisonOperator = context.StringValue("DescribeScalingRule.CloudWatchTrigger.ComparisonOperator");
			cloudWatchTrigger.Threshold = context.StringValue("DescribeScalingRule.CloudWatchTrigger.Threshold");
			cloudWatchTrigger.EvaluationCount = context.StringValue("DescribeScalingRule.CloudWatchTrigger.EvaluationCount");
			cloudWatchTrigger.Unit = context.StringValue("DescribeScalingRule.CloudWatchTrigger.Unit");
			cloudWatchTrigger.MetricDisplayName = context.StringValue("DescribeScalingRule.CloudWatchTrigger.MetricDisplayName");
			describeScalingRuleResponse.CloudWatchTrigger = cloudWatchTrigger;
        
			return describeScalingRuleResponse;
        }
    }
}
