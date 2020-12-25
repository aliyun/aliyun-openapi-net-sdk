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
        public static DescribeScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScalingRuleResponse describeScalingRuleResponse = new DescribeScalingRuleResponse();

			describeScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			describeScalingRuleResponse.RequestId = _ctx.StringValue("DescribeScalingRule.RequestId");
			describeScalingRuleResponse.Id = _ctx.StringValue("DescribeScalingRule.Id");
			describeScalingRuleResponse.GmtCreate = _ctx.StringValue("DescribeScalingRule.GmtCreate");
			describeScalingRuleResponse.GmtModified = _ctx.StringValue("DescribeScalingRule.GmtModified");
			describeScalingRuleResponse.RuleName = _ctx.StringValue("DescribeScalingRule.RuleName");
			describeScalingRuleResponse.RuleCategory = _ctx.StringValue("DescribeScalingRule.RuleCategory");
			describeScalingRuleResponse.AdjustmentType = _ctx.StringValue("DescribeScalingRule.AdjustmentType");
			describeScalingRuleResponse.AdjustmentValue = _ctx.IntegerValue("DescribeScalingRule.AdjustmentValue");
			describeScalingRuleResponse.Cooldown = _ctx.IntegerValue("DescribeScalingRule.Cooldown");
			describeScalingRuleResponse.Status = _ctx.StringValue("DescribeScalingRule.Status");
			describeScalingRuleResponse.WithGrace = _ctx.BooleanValue("DescribeScalingRule.WithGrace");
			describeScalingRuleResponse.TimeoutWithGrace = _ctx.LongValue("DescribeScalingRule.TimeoutWithGrace");

			DescribeScalingRuleResponse.DescribeScalingRule_SchedulerTrigger schedulerTrigger = new DescribeScalingRuleResponse.DescribeScalingRule_SchedulerTrigger();
			schedulerTrigger.LaunchTime = _ctx.LongValue("DescribeScalingRule.SchedulerTrigger.LaunchTime");
			schedulerTrigger.LaunchExpirationTime = _ctx.IntegerValue("DescribeScalingRule.SchedulerTrigger.LaunchExpirationTime");
			schedulerTrigger.RecurrenceType = _ctx.StringValue("DescribeScalingRule.SchedulerTrigger.RecurrenceType");
			schedulerTrigger.RecurrenceValue = _ctx.StringValue("DescribeScalingRule.SchedulerTrigger.RecurrenceValue");
			schedulerTrigger.RecurrenceEndTime = _ctx.LongValue("DescribeScalingRule.SchedulerTrigger.RecurrenceEndTime");
			describeScalingRuleResponse.SchedulerTrigger = schedulerTrigger;

			DescribeScalingRuleResponse.DescribeScalingRule_CloudWatchTrigger cloudWatchTrigger = new DescribeScalingRuleResponse.DescribeScalingRule_CloudWatchTrigger();
			cloudWatchTrigger.MetricName = _ctx.StringValue("DescribeScalingRule.CloudWatchTrigger.MetricName");
			cloudWatchTrigger.Period = _ctx.IntegerValue("DescribeScalingRule.CloudWatchTrigger.Period");
			cloudWatchTrigger.Statistics = _ctx.StringValue("DescribeScalingRule.CloudWatchTrigger.Statistics");
			cloudWatchTrigger.ComparisonOperator = _ctx.StringValue("DescribeScalingRule.CloudWatchTrigger.ComparisonOperator");
			cloudWatchTrigger.Threshold = _ctx.StringValue("DescribeScalingRule.CloudWatchTrigger.Threshold");
			cloudWatchTrigger.EvaluationCount = _ctx.StringValue("DescribeScalingRule.CloudWatchTrigger.EvaluationCount");
			cloudWatchTrigger.Unit = _ctx.StringValue("DescribeScalingRule.CloudWatchTrigger.Unit");
			cloudWatchTrigger.MetricDisplayName = _ctx.StringValue("DescribeScalingRule.CloudWatchTrigger.MetricDisplayName");
			describeScalingRuleResponse.CloudWatchTrigger = cloudWatchTrigger;
        
			return describeScalingRuleResponse;
        }
    }
}
