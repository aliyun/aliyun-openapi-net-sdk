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
    public class DescribeScalingRulesResponseUnmarshaller
    {
        public static DescribeScalingRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingRulesResponse describeScalingRulesResponse = new DescribeScalingRulesResponse();

			describeScalingRulesResponse.HttpResponse = context.HttpResponse;
			describeScalingRulesResponse.TotalCount = context.IntegerValue("DescribeScalingRules.TotalCount");
			describeScalingRulesResponse.PageNumber = context.IntegerValue("DescribeScalingRules.PageNumber");
			describeScalingRulesResponse.PageSize = context.IntegerValue("DescribeScalingRules.PageSize");
			describeScalingRulesResponse.RequestId = context.StringValue("DescribeScalingRules.RequestId");

			List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule> describeScalingRulesResponse_scalingRules = new List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule>();
			for (int i = 0; i < context.Length("DescribeScalingRules.ScalingRules.Length"); i++) {
				DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule scalingRule = new DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule();
				scalingRule.ScalingRuleId = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingRuleId");
				scalingRule.ScalingGroupId = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingGroupId");
				scalingRule.ScalingRuleName = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingRuleName");
				scalingRule.Cooldown = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].Cooldown");
				scalingRule.MinAdjustmentMagnitude = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].MinAdjustmentMagnitude");
				scalingRule.AdjustmentType = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].AdjustmentType");
				scalingRule.AdjustmentValue = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].AdjustmentValue");
				scalingRule.MinSize = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].MinSize");
				scalingRule.MaxSize = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].MaxSize");
				scalingRule.ScalingRuleAri = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingRuleAri");
				scalingRule.ScalingRuleType = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingRuleType");
				scalingRule.EstimatedInstanceWarmup = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].EstimatedInstanceWarmup");
				scalingRule.MetricName = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].MetricName");
				scalingRule.TargetValue = context.FloatValue("DescribeScalingRules.ScalingRules["+ i +"].TargetValue");
				scalingRule.DisableScaleIn = context.BooleanValue("DescribeScalingRules.ScalingRules["+ i +"].DisableScaleIn");
				scalingRule.ScaleInEvaluationCount = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].ScaleInEvaluationCount");
				scalingRule.ScaleOutEvaluationCount = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].ScaleOutEvaluationCount");
				scalingRule.PredictiveScalingMode = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].PredictiveScalingMode");
				scalingRule.PredictiveValueBehavior = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].PredictiveValueBehavior");
				scalingRule.PredictiveValueBuffer = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].PredictiveValueBuffer");
				scalingRule.PredictiveTaskBufferTime = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].PredictiveTaskBufferTime");
				scalingRule.InitialMaxSize = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].InitialMaxSize");

				List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_Alarm> scalingRule_alarms = new List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_Alarm>();
				for (int j = 0; j < context.Length("DescribeScalingRules.ScalingRules["+ i +"].Alarms.Length"); j++) {
					DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_Alarm alarm = new DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_Alarm();
					alarm.AlarmTaskName = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].AlarmTaskName");
					alarm.AlarmTaskId = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].AlarmTaskId");
					alarm.ComparisonOperator = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].ComparisonOperator");
					alarm.Statistics = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].Statistics");
					alarm.MetricName = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].MetricName");
					alarm.Threshold = context.FloatValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].Threshold");
					alarm.EvaluationCount = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].EvaluationCount");

					List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_Alarm.DescribeScalingRules_Dimension> alarm_dimensions = new List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_Alarm.DescribeScalingRules_Dimension>();
					for (int k = 0; k < context.Length("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].Dimensions.Length"); k++) {
						DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_Alarm.DescribeScalingRules_Dimension dimension = new DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_Alarm.DescribeScalingRules_Dimension();
						dimension.DimensionKey = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].Dimensions["+ k +"].DimensionKey");
						dimension.DimensionValue = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].Alarms["+ j +"].Dimensions["+ k +"].DimensionValue");

						alarm_dimensions.Add(dimension);
					}
					alarm.Dimensions = alarm_dimensions;

					scalingRule_alarms.Add(alarm);
				}
				scalingRule.Alarms = scalingRule_alarms;

				List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_StepAdjustment> scalingRule_stepAdjustments = new List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_StepAdjustment>();
				for (int j = 0; j < context.Length("DescribeScalingRules.ScalingRules["+ i +"].StepAdjustments.Length"); j++) {
					DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_StepAdjustment stepAdjustment = new DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule.DescribeScalingRules_StepAdjustment();
					stepAdjustment.MetricIntervalLowerBound = context.FloatValue("DescribeScalingRules.ScalingRules["+ i +"].StepAdjustments["+ j +"].MetricIntervalLowerBound");
					stepAdjustment.MetricIntervalUpperBound = context.FloatValue("DescribeScalingRules.ScalingRules["+ i +"].StepAdjustments["+ j +"].MetricIntervalUpperBound");
					stepAdjustment.ScalingAdjustment = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].StepAdjustments["+ j +"].ScalingAdjustment");

					scalingRule_stepAdjustments.Add(stepAdjustment);
				}
				scalingRule.StepAdjustments = scalingRule_stepAdjustments;

				describeScalingRulesResponse_scalingRules.Add(scalingRule);
			}
			describeScalingRulesResponse.ScalingRules = describeScalingRulesResponse_scalingRules;
        
			return describeScalingRulesResponse;
        }
    }
}
