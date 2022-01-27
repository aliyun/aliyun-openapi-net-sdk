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
    public class CreateApplicationScalingRuleResponseUnmarshaller
    {
        public static CreateApplicationScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateApplicationScalingRuleResponse createApplicationScalingRuleResponse = new CreateApplicationScalingRuleResponse();

			createApplicationScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			createApplicationScalingRuleResponse.RequestId = _ctx.StringValue("CreateApplicationScalingRule.RequestId");
			createApplicationScalingRuleResponse.Code = _ctx.IntegerValue("CreateApplicationScalingRule.Code");
			createApplicationScalingRuleResponse.Message = _ctx.StringValue("CreateApplicationScalingRule.Message");

			CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule appScalingRule = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule();
			appScalingRule.AppId = _ctx.StringValue("CreateApplicationScalingRule.AppScalingRule.AppId");
			appScalingRule.ScaleRuleName = _ctx.StringValue("CreateApplicationScalingRule.AppScalingRule.ScaleRuleName");
			appScalingRule.ScaleRuleType = _ctx.StringValue("CreateApplicationScalingRule.AppScalingRule.ScaleRuleType");
			appScalingRule.ScaleRuleEnabled = _ctx.BooleanValue("CreateApplicationScalingRule.AppScalingRule.ScaleRuleEnabled");
			appScalingRule.MinReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.AppScalingRule.MinReplicas");
			appScalingRule.MaxReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.AppScalingRule.MaxReplicas");
			appScalingRule.CreateTime = _ctx.LongValue("CreateApplicationScalingRule.AppScalingRule.CreateTime");
			appScalingRule.UpdateTime = _ctx.LongValue("CreateApplicationScalingRule.AppScalingRule.UpdateTime");
			appScalingRule.LastDisableTime = _ctx.LongValue("CreateApplicationScalingRule.AppScalingRule.LastDisableTime");

			CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Metric metric = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Metric();
			metric.MaxReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.AppScalingRule.Metric.MaxReplicas");
			metric.MinReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.AppScalingRule.Metric.MinReplicas");

			List<CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Metric.CreateApplicationScalingRule_Metric1> metric_metrics = new List<CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Metric.CreateApplicationScalingRule_Metric1>();
			for (int i = 0; i < _ctx.Length("CreateApplicationScalingRule.AppScalingRule.Metric.Metrics.Length"); i++) {
				CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Metric.CreateApplicationScalingRule_Metric1 metric1 = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Metric.CreateApplicationScalingRule_Metric1();
				metric1.MetricType = _ctx.StringValue("CreateApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricType");
				metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("CreateApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricTargetAverageUtilization");

				metric_metrics.Add(metric1);
			}
			metric.Metrics = metric_metrics;
			appScalingRule.Metric = metric;

			CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Trigger trigger = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Trigger();
			trigger.MaxReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.AppScalingRule.Trigger.MaxReplicas");
			trigger.MinReplicas = _ctx.IntegerValue("CreateApplicationScalingRule.AppScalingRule.Trigger.MinReplicas");

			List<CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Trigger.CreateApplicationScalingRule_Trigger2> trigger_triggers = new List<CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Trigger.CreateApplicationScalingRule_Trigger2>();
			for (int i = 0; i < _ctx.Length("CreateApplicationScalingRule.AppScalingRule.Trigger.Triggers.Length"); i++) {
				CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Trigger.CreateApplicationScalingRule_Trigger2 trigger2 = new CreateApplicationScalingRuleResponse.CreateApplicationScalingRule_AppScalingRule.CreateApplicationScalingRule_Trigger.CreateApplicationScalingRule_Trigger2();
				trigger2.Type = _ctx.StringValue("CreateApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].Type");
				trigger2.Name = _ctx.StringValue("CreateApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].Name");
				trigger2.MetaData = _ctx.StringValue("CreateApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].MetaData");

				trigger_triggers.Add(trigger2);
			}
			trigger.Triggers = trigger_triggers;
			appScalingRule.Trigger = trigger;
			createApplicationScalingRuleResponse.AppScalingRule = appScalingRule;
        
			return createApplicationScalingRuleResponse;
        }
    }
}
