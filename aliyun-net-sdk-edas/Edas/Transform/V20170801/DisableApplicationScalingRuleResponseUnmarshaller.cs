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
    public class DisableApplicationScalingRuleResponseUnmarshaller
    {
        public static DisableApplicationScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DisableApplicationScalingRuleResponse disableApplicationScalingRuleResponse = new DisableApplicationScalingRuleResponse();

			disableApplicationScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			disableApplicationScalingRuleResponse.RequestId = _ctx.StringValue("DisableApplicationScalingRule.RequestId");
			disableApplicationScalingRuleResponse.Code = _ctx.IntegerValue("DisableApplicationScalingRule.Code");
			disableApplicationScalingRuleResponse.Message = _ctx.StringValue("DisableApplicationScalingRule.Message");

			DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule appScalingRule = new DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule();
			appScalingRule.AppId = _ctx.StringValue("DisableApplicationScalingRule.AppScalingRule.AppId");
			appScalingRule.ScaleRuleName = _ctx.StringValue("DisableApplicationScalingRule.AppScalingRule.ScaleRuleName");
			appScalingRule.ScaleRuleType = _ctx.StringValue("DisableApplicationScalingRule.AppScalingRule.ScaleRuleType");
			appScalingRule.ScaleRuleEnabled = _ctx.BooleanValue("DisableApplicationScalingRule.AppScalingRule.ScaleRuleEnabled");
			appScalingRule.MinReplicas = _ctx.IntegerValue("DisableApplicationScalingRule.AppScalingRule.MinReplicas");
			appScalingRule.MaxReplicas = _ctx.IntegerValue("DisableApplicationScalingRule.AppScalingRule.MaxReplicas");
			appScalingRule.CreateTime = _ctx.LongValue("DisableApplicationScalingRule.AppScalingRule.CreateTime");
			appScalingRule.UpdateTime = _ctx.LongValue("DisableApplicationScalingRule.AppScalingRule.UpdateTime");
			appScalingRule.LastDisableTime = _ctx.LongValue("DisableApplicationScalingRule.AppScalingRule.LastDisableTime");

			DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Metric metric = new DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Metric();
			metric.MaxReplicas = _ctx.IntegerValue("DisableApplicationScalingRule.AppScalingRule.Metric.MaxReplicas");
			metric.MinReplicas = _ctx.IntegerValue("DisableApplicationScalingRule.AppScalingRule.Metric.MinReplicas");

			List<DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Metric.DisableApplicationScalingRule_Metric1> metric_metrics = new List<DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Metric.DisableApplicationScalingRule_Metric1>();
			for (int i = 0; i < _ctx.Length("DisableApplicationScalingRule.AppScalingRule.Metric.Metrics.Length"); i++) {
				DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Metric.DisableApplicationScalingRule_Metric1 metric1 = new DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Metric.DisableApplicationScalingRule_Metric1();
				metric1.MetricType = _ctx.StringValue("DisableApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricType");
				metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("DisableApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricTargetAverageUtilization");

				metric_metrics.Add(metric1);
			}
			metric.Metrics = metric_metrics;
			appScalingRule.Metric = metric;

			DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Trigger trigger = new DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Trigger();
			trigger.MaxReplicas = _ctx.IntegerValue("DisableApplicationScalingRule.AppScalingRule.Trigger.MaxReplicas");
			trigger.MinReplicas = _ctx.IntegerValue("DisableApplicationScalingRule.AppScalingRule.Trigger.MinReplicas");

			List<DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Trigger.DisableApplicationScalingRule_Trigger2> trigger_triggers = new List<DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Trigger.DisableApplicationScalingRule_Trigger2>();
			for (int i = 0; i < _ctx.Length("DisableApplicationScalingRule.AppScalingRule.Trigger.Triggers.Length"); i++) {
				DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Trigger.DisableApplicationScalingRule_Trigger2 trigger2 = new DisableApplicationScalingRuleResponse.DisableApplicationScalingRule_AppScalingRule.DisableApplicationScalingRule_Trigger.DisableApplicationScalingRule_Trigger2();
				trigger2.Type = _ctx.StringValue("DisableApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].Type");
				trigger2.Name = _ctx.StringValue("DisableApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].Name");
				trigger2.MetaData = _ctx.StringValue("DisableApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].MetaData");

				trigger_triggers.Add(trigger2);
			}
			trigger.Triggers = trigger_triggers;
			appScalingRule.Trigger = trigger;
			disableApplicationScalingRuleResponse.AppScalingRule = appScalingRule;
        
			return disableApplicationScalingRuleResponse;
        }
    }
}
