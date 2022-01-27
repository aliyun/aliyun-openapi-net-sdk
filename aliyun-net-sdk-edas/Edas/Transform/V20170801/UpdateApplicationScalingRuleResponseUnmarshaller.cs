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
    public class UpdateApplicationScalingRuleResponseUnmarshaller
    {
        public static UpdateApplicationScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateApplicationScalingRuleResponse updateApplicationScalingRuleResponse = new UpdateApplicationScalingRuleResponse();

			updateApplicationScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			updateApplicationScalingRuleResponse.RequestId = _ctx.StringValue("UpdateApplicationScalingRule.RequestId");
			updateApplicationScalingRuleResponse.Code = _ctx.IntegerValue("UpdateApplicationScalingRule.Code");
			updateApplicationScalingRuleResponse.Message = _ctx.StringValue("UpdateApplicationScalingRule.Message");

			UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule appScalingRule = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule();
			appScalingRule.AppId = _ctx.StringValue("UpdateApplicationScalingRule.AppScalingRule.AppId");
			appScalingRule.ScaleRuleName = _ctx.StringValue("UpdateApplicationScalingRule.AppScalingRule.ScaleRuleName");
			appScalingRule.ScaleRuleType = _ctx.StringValue("UpdateApplicationScalingRule.AppScalingRule.ScaleRuleType");
			appScalingRule.ScaleRuleEnabled = _ctx.BooleanValue("UpdateApplicationScalingRule.AppScalingRule.ScaleRuleEnabled");
			appScalingRule.MinReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.AppScalingRule.MinReplicas");
			appScalingRule.MaxReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.AppScalingRule.MaxReplicas");
			appScalingRule.CreateTime = _ctx.LongValue("UpdateApplicationScalingRule.AppScalingRule.CreateTime");
			appScalingRule.UpdateTime = _ctx.LongValue("UpdateApplicationScalingRule.AppScalingRule.UpdateTime");
			appScalingRule.LastDisableTime = _ctx.LongValue("UpdateApplicationScalingRule.AppScalingRule.LastDisableTime");

			UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Metric metric = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Metric();
			metric.MaxReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.AppScalingRule.Metric.MaxReplicas");
			metric.MinReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.AppScalingRule.Metric.MinReplicas");

			List<UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Metric.UpdateApplicationScalingRule_Metric1> metric_metrics = new List<UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Metric.UpdateApplicationScalingRule_Metric1>();
			for (int i = 0; i < _ctx.Length("UpdateApplicationScalingRule.AppScalingRule.Metric.Metrics.Length"); i++) {
				UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Metric.UpdateApplicationScalingRule_Metric1 metric1 = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Metric.UpdateApplicationScalingRule_Metric1();
				metric1.MetricType = _ctx.StringValue("UpdateApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricType");
				metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("UpdateApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricTargetAverageUtilization");

				metric_metrics.Add(metric1);
			}
			metric.Metrics = metric_metrics;
			appScalingRule.Metric = metric;

			UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Trigger trigger = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Trigger();
			trigger.MaxReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.AppScalingRule.Trigger.MaxReplicas");
			trigger.MinReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.AppScalingRule.Trigger.MinReplicas");

			List<UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Trigger.UpdateApplicationScalingRule_Trigger2> trigger_triggers = new List<UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Trigger.UpdateApplicationScalingRule_Trigger2>();
			for (int i = 0; i < _ctx.Length("UpdateApplicationScalingRule.AppScalingRule.Trigger.Triggers.Length"); i++) {
				UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Trigger.UpdateApplicationScalingRule_Trigger2 trigger2 = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_AppScalingRule.UpdateApplicationScalingRule_Trigger.UpdateApplicationScalingRule_Trigger2();
				trigger2.Type = _ctx.StringValue("UpdateApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].Type");
				trigger2.Name = _ctx.StringValue("UpdateApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].Name");
				trigger2.MetaData = _ctx.StringValue("UpdateApplicationScalingRule.AppScalingRule.Trigger.Triggers["+ i +"].MetaData");

				trigger_triggers.Add(trigger2);
			}
			trigger.Triggers = trigger_triggers;
			appScalingRule.Trigger = trigger;
			updateApplicationScalingRuleResponse.AppScalingRule = appScalingRule;
        
			return updateApplicationScalingRuleResponse;
        }
    }
}
