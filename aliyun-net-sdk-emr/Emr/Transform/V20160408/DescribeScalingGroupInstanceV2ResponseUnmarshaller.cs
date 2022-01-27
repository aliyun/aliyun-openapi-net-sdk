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
    public class DescribeScalingGroupInstanceV2ResponseUnmarshaller
    {
        public static DescribeScalingGroupInstanceV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScalingGroupInstanceV2Response describeScalingGroupInstanceV2Response = new DescribeScalingGroupInstanceV2Response();

			describeScalingGroupInstanceV2Response.HttpResponse = _ctx.HttpResponse;
			describeScalingGroupInstanceV2Response.RequestId = _ctx.StringValue("DescribeScalingGroupInstanceV2.RequestId");
			describeScalingGroupInstanceV2Response.HostGroupId = _ctx.StringValue("DescribeScalingGroupInstanceV2.HostGroupId");
			describeScalingGroupInstanceV2Response.ScalingGroupId = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingGroupId");
			describeScalingGroupInstanceV2Response.MinSize = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.MinSize");
			describeScalingGroupInstanceV2Response.MaxSize = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.MaxSize");
			describeScalingGroupInstanceV2Response.DefaultCooldown = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.DefaultCooldown");
			describeScalingGroupInstanceV2Response.ActiveRuleCategory = _ctx.StringValue("DescribeScalingGroupInstanceV2.ActiveRuleCategory");
			describeScalingGroupInstanceV2Response.WithGrace = _ctx.BooleanValue("DescribeScalingGroupInstanceV2.WithGrace");
			describeScalingGroupInstanceV2Response.TimeoutWithGrace = _ctx.LongValue("DescribeScalingGroupInstanceV2.TimeoutWithGrace");
			describeScalingGroupInstanceV2Response.MultiAvailablePolicy = _ctx.StringValue("DescribeScalingGroupInstanceV2.MultiAvailablePolicy");
			describeScalingGroupInstanceV2Response.MultiAvailablePolicyParam = _ctx.StringValue("DescribeScalingGroupInstanceV2.MultiAvailablePolicyParam");

			DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingConfig scalingConfig = new DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingConfig();
			scalingConfig.SpotStrategy = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingConfig.SpotStrategy");
			scalingConfig.PayType = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingConfig.PayType");
			scalingConfig.DataDiskCategory = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingConfig.DataDiskCategory");
			scalingConfig.DataDiskSize = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.ScalingConfig.DataDiskSize");
			scalingConfig.DataDiskCount = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.ScalingConfig.DataDiskCount");
			scalingConfig.SysDiskCategory = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingConfig.SysDiskCategory");
			scalingConfig.SysDiskSize = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.ScalingConfig.SysDiskSize");

			List<string> scalingConfig_instanceTypeList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeScalingGroupInstanceV2.ScalingConfig.InstanceTypeList.Length"); i++) {
				scalingConfig_instanceTypeList.Add(_ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingConfig.InstanceTypeList["+ i +"]"));
			}
			scalingConfig.InstanceTypeList = scalingConfig_instanceTypeList;

			List<DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingConfig.DescribeScalingGroupInstanceV2_SpotPriceLimit> scalingConfig_spotPriceLimits = new List<DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingConfig.DescribeScalingGroupInstanceV2_SpotPriceLimit>();
			for (int i = 0; i < _ctx.Length("DescribeScalingGroupInstanceV2.ScalingConfig.SpotPriceLimits.Length"); i++) {
				DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingConfig.DescribeScalingGroupInstanceV2_SpotPriceLimit spotPriceLimit = new DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingConfig.DescribeScalingGroupInstanceV2_SpotPriceLimit();
				spotPriceLimit.InstanceType = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingConfig.SpotPriceLimits["+ i +"].InstanceType");
				spotPriceLimit.PriceLimit = _ctx.FloatValue("DescribeScalingGroupInstanceV2.ScalingConfig.SpotPriceLimits["+ i +"].PriceLimit");

				scalingConfig_spotPriceLimits.Add(spotPriceLimit);
			}
			scalingConfig.SpotPriceLimits = scalingConfig_spotPriceLimits;
			describeScalingGroupInstanceV2Response.ScalingConfig = scalingConfig;

			List<DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingRule> describeScalingGroupInstanceV2Response_scalingRuleList = new List<DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingRule>();
			for (int i = 0; i < _ctx.Length("DescribeScalingGroupInstanceV2.ScalingRuleList.Length"); i++) {
				DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingRule scalingRule = new DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingRule();
				scalingRule.RuleCategory = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].RuleCategory");
				scalingRule.EssScalingRuleId = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].EssScalingRuleId");
				scalingRule.ScalingGroupId = _ctx.LongValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].ScalingGroupId");
				scalingRule.RuleName = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].RuleName");
				scalingRule.AdjustmentType = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].AdjustmentType");
				scalingRule.AdjustmentValue = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].AdjustmentValue");
				scalingRule.Cooldown = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].Cooldown");
				scalingRule.Status = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].Status");
				scalingRule.LaunchTime = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].LaunchTime");
				scalingRule.LaunchExpirationTime = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].LaunchExpirationTime");
				scalingRule.RecurrenceType = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].RecurrenceType");
				scalingRule.RecurrenceValue = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].RecurrenceValue");
				scalingRule.RecurrenceEndTime = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].RecurrenceEndTime");
				scalingRule.WithGrace = _ctx.BooleanValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].WithGrace");
				scalingRule.TimeoutWithGrace = _ctx.LongValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].TimeoutWithGrace");

				DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingRule.DescribeScalingGroupInstanceV2_SchedulerTrigger schedulerTrigger = new DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingRule.DescribeScalingGroupInstanceV2_SchedulerTrigger();
				schedulerTrigger.LaunchTime = _ctx.LongValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].SchedulerTrigger.LaunchTime");
				schedulerTrigger.LaunchExpirationTime = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].SchedulerTrigger.LaunchExpirationTime");
				schedulerTrigger.RecurrenceType = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].SchedulerTrigger.RecurrenceType");
				schedulerTrigger.RecurrenceValue = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].SchedulerTrigger.RecurrenceValue");
				schedulerTrigger.RecurrenceEndTime = _ctx.LongValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].SchedulerTrigger.RecurrenceEndTime");
				scalingRule.SchedulerTrigger = schedulerTrigger;

				DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingRule.DescribeScalingGroupInstanceV2_CloudWatchTrigger cloudWatchTrigger = new DescribeScalingGroupInstanceV2Response.DescribeScalingGroupInstanceV2_ScalingRule.DescribeScalingGroupInstanceV2_CloudWatchTrigger();
				cloudWatchTrigger.MetricName = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].CloudWatchTrigger.MetricName");
				cloudWatchTrigger.Period = _ctx.IntegerValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].CloudWatchTrigger.Period");
				cloudWatchTrigger.Statistics = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].CloudWatchTrigger.Statistics");
				cloudWatchTrigger.ComparisonOperator = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].CloudWatchTrigger.ComparisonOperator");
				cloudWatchTrigger.Threshold = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].CloudWatchTrigger.Threshold");
				cloudWatchTrigger.EvaluationCount = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].CloudWatchTrigger.EvaluationCount");
				cloudWatchTrigger.Unit = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].CloudWatchTrigger.Unit");
				cloudWatchTrigger.MetricDisplayName = _ctx.StringValue("DescribeScalingGroupInstanceV2.ScalingRuleList["+ i +"].CloudWatchTrigger.MetricDisplayName");
				scalingRule.CloudWatchTrigger = cloudWatchTrigger;

				describeScalingGroupInstanceV2Response_scalingRuleList.Add(scalingRule);
			}
			describeScalingGroupInstanceV2Response.ScalingRuleList = describeScalingGroupInstanceV2Response_scalingRuleList;
        
			return describeScalingGroupInstanceV2Response;
        }
    }
}
