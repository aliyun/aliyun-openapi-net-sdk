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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class UpdateApplicationScalingRuleResponseUnmarshaller
    {
        public static UpdateApplicationScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateApplicationScalingRuleResponse updateApplicationScalingRuleResponse = new UpdateApplicationScalingRuleResponse();

			updateApplicationScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			updateApplicationScalingRuleResponse.RequestId = _ctx.StringValue("UpdateApplicationScalingRule.RequestId");
			updateApplicationScalingRuleResponse.TraceId = _ctx.StringValue("UpdateApplicationScalingRule.TraceId");

			UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data data = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data();
			data.ScaleRuleEnabled = _ctx.BooleanValue("UpdateApplicationScalingRule.Data.ScaleRuleEnabled");
			data.LastDisableTime = _ctx.LongValue("UpdateApplicationScalingRule.Data.LastDisableTime");
			data.AppId = _ctx.StringValue("UpdateApplicationScalingRule.Data.AppId");
			data.CreateTime = _ctx.LongValue("UpdateApplicationScalingRule.Data.CreateTime");
			data.UpdateTime = _ctx.LongValue("UpdateApplicationScalingRule.Data.UpdateTime");
			data.ScaleRuleName = _ctx.StringValue("UpdateApplicationScalingRule.Data.ScaleRuleName");
			data.ScaleRuleType = _ctx.StringValue("UpdateApplicationScalingRule.Data.ScaleRuleType");

			UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Timer timer = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Timer();
			timer.Period = _ctx.StringValue("UpdateApplicationScalingRule.Data.Timer.Period");
			timer.EndDate = _ctx.StringValue("UpdateApplicationScalingRule.Data.Timer.EndDate");
			timer.BeginDate = _ctx.StringValue("UpdateApplicationScalingRule.Data.Timer.BeginDate");

			List<UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Timer.UpdateApplicationScalingRule_Schedule> timer_schedules = new List<UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Timer.UpdateApplicationScalingRule_Schedule>();
			for (int i = 0; i < _ctx.Length("UpdateApplicationScalingRule.Data.Timer.Schedules.Length"); i++) {
				UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Timer.UpdateApplicationScalingRule_Schedule schedule = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Timer.UpdateApplicationScalingRule_Schedule();
				schedule.TargetReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.Data.Timer.Schedules["+ i +"].TargetReplicas");
				schedule.AtTime = _ctx.StringValue("UpdateApplicationScalingRule.Data.Timer.Schedules["+ i +"].AtTime");

				timer_schedules.Add(schedule);
			}
			timer.Schedules = timer_schedules;
			data.Timer = timer;

			UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Metric metric = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Metric();
			metric.MinReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.Data.Metric.MinReplicas");
			metric.MaxReplicas = _ctx.IntegerValue("UpdateApplicationScalingRule.Data.Metric.MaxReplicas");

			List<UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Metric.UpdateApplicationScalingRule_Metric1> metric_metrics = new List<UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Metric.UpdateApplicationScalingRule_Metric1>();
			for (int i = 0; i < _ctx.Length("UpdateApplicationScalingRule.Data.Metric.Metrics.Length"); i++) {
				UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Metric.UpdateApplicationScalingRule_Metric1 metric1 = new UpdateApplicationScalingRuleResponse.UpdateApplicationScalingRule_Data.UpdateApplicationScalingRule_Metric.UpdateApplicationScalingRule_Metric1();
				metric1.MetricType = _ctx.StringValue("UpdateApplicationScalingRule.Data.Metric.Metrics["+ i +"].MetricType");
				metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("UpdateApplicationScalingRule.Data.Metric.Metrics["+ i +"].MetricTargetAverageUtilization");

				metric_metrics.Add(metric1);
			}
			metric.Metrics = metric_metrics;
			data.Metric = metric;
			updateApplicationScalingRuleResponse.Data = data;
        
			return updateApplicationScalingRuleResponse;
        }
    }
}
