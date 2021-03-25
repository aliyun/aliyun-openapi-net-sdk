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
    public class DescribeApplicationScalingRulesResponseUnmarshaller
    {
        public static DescribeApplicationScalingRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationScalingRulesResponse describeApplicationScalingRulesResponse = new DescribeApplicationScalingRulesResponse();

			describeApplicationScalingRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationScalingRulesResponse.RequestId = _ctx.StringValue("DescribeApplicationScalingRules.RequestId");
			describeApplicationScalingRulesResponse.TraceId = _ctx.StringValue("DescribeApplicationScalingRules.TraceId");

			DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data data = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data();
			data.PageSize = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.CurrentPage");
			data.TotalSize = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.TotalSize");

			List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule> data_applicationScalingRules = new List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationScalingRules.Data.ApplicationScalingRules.Length"); i++) {
				DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule applicationScalingRule = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule();
				applicationScalingRule.ScaleRuleEnabled = _ctx.BooleanValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].ScaleRuleEnabled");
				applicationScalingRule.LastDisableTime = _ctx.LongValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].LastDisableTime");
				applicationScalingRule.AppId = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].AppId");
				applicationScalingRule.CreateTime = _ctx.LongValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].CreateTime");
				applicationScalingRule.UpdateTime = _ctx.LongValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].UpdateTime");
				applicationScalingRule.ScaleRuleName = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].ScaleRuleName");
				applicationScalingRule.ScaleRuleType = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].ScaleRuleType");

				DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Timer timer = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Timer();
				timer.Period = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Timer.Period");
				timer.EndDate = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Timer.EndDate");
				timer.BeginDate = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Timer.BeginDate");

				List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Timer.DescribeApplicationScalingRules_Schedule> timer_schedules = new List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Timer.DescribeApplicationScalingRules_Schedule>();
				for (int j = 0; j < _ctx.Length("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Timer.Schedules.Length"); j++) {
					DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Timer.DescribeApplicationScalingRules_Schedule schedule = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Timer.DescribeApplicationScalingRules_Schedule();
					schedule.TargetReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Timer.Schedules["+ j +"].TargetReplicas");
					schedule.AtTime = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Timer.Schedules["+ j +"].AtTime");

					timer_schedules.Add(schedule);
				}
				timer.Schedules = timer_schedules;
				applicationScalingRule.Timer = timer;

				DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric metric = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric();
				metric.MinReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MinReplicas");
				metric.MaxReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MaxReplicas");

				DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus metricsStatus = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus();
				metricsStatus.DesiredReplicas = _ctx.LongValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.DesiredReplicas");
				metricsStatus.CurrentReplicas = _ctx.LongValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.CurrentReplicas");
				metricsStatus.NextScaleTimePeriod = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.NextScaleTimePeriod");
				metricsStatus.LastScaleTime = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.LastScaleTime");

				List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus.DescribeApplicationScalingRules_NextScaleMetric> metricsStatus_nextScaleMetrics = new List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus.DescribeApplicationScalingRules_NextScaleMetric>();
				for (int j = 0; j < _ctx.Length("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.NextScaleMetrics.Length"); j++) {
					DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus.DescribeApplicationScalingRules_NextScaleMetric nextScaleMetric = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus.DescribeApplicationScalingRules_NextScaleMetric();
					nextScaleMetric.NextScaleInAverageUtilization = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.NextScaleMetrics["+ j +"].NextScaleInAverageUtilization");
					nextScaleMetric.Name = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.NextScaleMetrics["+ j +"].Name");
					nextScaleMetric.NextScaleOutAverageUtilization = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.NextScaleMetrics["+ j +"].NextScaleOutAverageUtilization");

					metricsStatus_nextScaleMetrics.Add(nextScaleMetric);
				}
				metricsStatus.NextScaleMetrics = metricsStatus_nextScaleMetrics;

				List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus.DescribeApplicationScalingRules_CurrentMetric> metricsStatus_currentMetrics = new List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus.DescribeApplicationScalingRules_CurrentMetric>();
				for (int j = 0; j < _ctx.Length("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.CurrentMetrics.Length"); j++) {
					DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus.DescribeApplicationScalingRules_CurrentMetric currentMetric = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_MetricsStatus.DescribeApplicationScalingRules_CurrentMetric();
					currentMetric.Type = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.CurrentMetrics["+ j +"].Type");
					currentMetric.CurrentValue = _ctx.LongValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.CurrentMetrics["+ j +"].CurrentValue");
					currentMetric.Name = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.MetricsStatus.CurrentMetrics["+ j +"].Name");

					metricsStatus_currentMetrics.Add(currentMetric);
				}
				metricsStatus.CurrentMetrics = metricsStatus_currentMetrics;
				metric.MetricsStatus = metricsStatus;

				List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_Metric1> metric_metrics = new List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_Metric1>();
				for (int j = 0; j < _ctx.Length("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.Metrics.Length"); j++) {
					DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_Metric1 metric1 = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_Data.DescribeApplicationScalingRules_ApplicationScalingRule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_Metric1();
					metric1.MetricType = _ctx.StringValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.Metrics["+ j +"].MetricType");
					metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("DescribeApplicationScalingRules.Data.ApplicationScalingRules["+ i +"].Metric.Metrics["+ j +"].MetricTargetAverageUtilization");

					metric_metrics.Add(metric1);
				}
				metric.Metrics = metric_metrics;
				applicationScalingRule.Metric = metric;

				data_applicationScalingRules.Add(applicationScalingRule);
			}
			data.ApplicationScalingRules = data_applicationScalingRules;
			describeApplicationScalingRulesResponse.Data = data;
        
			return describeApplicationScalingRulesResponse;
        }
    }
}
