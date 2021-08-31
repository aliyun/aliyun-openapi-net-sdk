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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class EnableApplicationScalingRuleResponseUnmarshaller
    {
        public static EnableApplicationScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EnableApplicationScalingRuleResponse enableApplicationScalingRuleResponse = new EnableApplicationScalingRuleResponse();

			enableApplicationScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			enableApplicationScalingRuleResponse.RequestId = _ctx.StringValue("EnableApplicationScalingRule.RequestId");
			enableApplicationScalingRuleResponse.Code = _ctx.IntegerValue("EnableApplicationScalingRule.Code");
			enableApplicationScalingRuleResponse.Message = _ctx.StringValue("EnableApplicationScalingRule.Message");

			EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule appScalingRule = new EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule();
			appScalingRule.AppId = _ctx.StringValue("EnableApplicationScalingRule.AppScalingRule.AppId");
			appScalingRule.ScaleRuleName = _ctx.StringValue("EnableApplicationScalingRule.AppScalingRule.ScaleRuleName");
			appScalingRule.ScaleRuleType = _ctx.StringValue("EnableApplicationScalingRule.AppScalingRule.ScaleRuleType");
			appScalingRule.ScaleRuleEnabled = _ctx.BooleanValue("EnableApplicationScalingRule.AppScalingRule.ScaleRuleEnabled");
			appScalingRule.MinReplicas = _ctx.IntegerValue("EnableApplicationScalingRule.AppScalingRule.MinReplicas");
			appScalingRule.MaxReplicas = _ctx.IntegerValue("EnableApplicationScalingRule.AppScalingRule.MaxReplicas");
			appScalingRule.CreateTime = _ctx.LongValue("EnableApplicationScalingRule.AppScalingRule.CreateTime");
			appScalingRule.UpdateTime = _ctx.LongValue("EnableApplicationScalingRule.AppScalingRule.UpdateTime");
			appScalingRule.LastDisableTime = _ctx.LongValue("EnableApplicationScalingRule.AppScalingRule.LastDisableTime");

			EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Metric metric = new EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Metric();
			metric.MaxReplicas = _ctx.IntegerValue("EnableApplicationScalingRule.AppScalingRule.Metric.MaxReplicas");
			metric.MinReplicas = _ctx.IntegerValue("EnableApplicationScalingRule.AppScalingRule.Metric.MinReplicas");

			List<EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Metric.EnableApplicationScalingRule_Metric1> metric_metrics = new List<EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Metric.EnableApplicationScalingRule_Metric1>();
			for (int i = 0; i < _ctx.Length("EnableApplicationScalingRule.AppScalingRule.Metric.Metrics.Length"); i++) {
				EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Metric.EnableApplicationScalingRule_Metric1 metric1 = new EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Metric.EnableApplicationScalingRule_Metric1();
				metric1.MetricType = _ctx.StringValue("EnableApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricType");
				metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("EnableApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricTargetAverageUtilization");

				metric_metrics.Add(metric1);
			}
			metric.Metrics = metric_metrics;
			appScalingRule.Metric = metric;

			EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Trigger trigger = new EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Trigger();
			trigger.MaxReplicas = _ctx.IntegerValue("EnableApplicationScalingRule.AppScalingRule.Trigger.MaxReplicas");
			trigger.MinReplicas = _ctx.IntegerValue("EnableApplicationScalingRule.AppScalingRule.Trigger.MinReplicas");

			List<EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Trigger.EnableApplicationScalingRule_Trigger2> trigger_triggers = new List<EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Trigger.EnableApplicationScalingRule_Trigger2>();
			for (int i = 0; i < _ctx.Length("EnableApplicationScalingRule.AppScalingRule.Trigger.Triggers.Length"); i++) {
				EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Trigger.EnableApplicationScalingRule_Trigger2 trigger2 = new EnableApplicationScalingRuleResponse.EnableApplicationScalingRule_AppScalingRule.EnableApplicationScalingRule_Trigger.EnableApplicationScalingRule_Trigger2();
				trigger2.Type = _ctx.StringValue("EnableApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].Type");
				trigger2.Name = _ctx.StringValue("EnableApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].Name");
				trigger2.MetaData = _ctx.StringValue("EnableApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].MetaData");

				trigger_triggers.Add(trigger2);
			}
			trigger.Triggers = trigger_triggers;
			appScalingRule.Trigger = trigger;
			enableApplicationScalingRuleResponse.AppScalingRule = appScalingRule;
        
			return enableApplicationScalingRuleResponse;
        }
    }
}
