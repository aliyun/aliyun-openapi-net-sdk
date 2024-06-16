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
    public class DescribeApplicationScalingRuleResponseUnmarshaller
    {
        public static DescribeApplicationScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationScalingRuleResponse describeApplicationScalingRuleResponse = new DescribeApplicationScalingRuleResponse();

			describeApplicationScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationScalingRuleResponse.RequestId = _ctx.StringValue("DescribeApplicationScalingRule.RequestId");
			describeApplicationScalingRuleResponse.TraceId = _ctx.StringValue("DescribeApplicationScalingRule.TraceId");
			describeApplicationScalingRuleResponse.Message = _ctx.StringValue("DescribeApplicationScalingRule.Message");
			describeApplicationScalingRuleResponse.ErrorCode = _ctx.StringValue("DescribeApplicationScalingRule.ErrorCode");
			describeApplicationScalingRuleResponse.Code = _ctx.StringValue("DescribeApplicationScalingRule.Code");
			describeApplicationScalingRuleResponse.Success = _ctx.BooleanValue("DescribeApplicationScalingRule.Success");

			DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data data = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data();
			data.UpdateTime = _ctx.LongValue("DescribeApplicationScalingRule.Data.UpdateTime");
			data.AppId = _ctx.StringValue("DescribeApplicationScalingRule.Data.AppId");
			data.CreateTime = _ctx.LongValue("DescribeApplicationScalingRule.Data.CreateTime");
			data.LastDisableTime = _ctx.LongValue("DescribeApplicationScalingRule.Data.LastDisableTime");
			data.ScaleRuleEnabled = _ctx.BooleanValue("DescribeApplicationScalingRule.Data.ScaleRuleEnabled");
			data.ScaleRuleType = _ctx.StringValue("DescribeApplicationScalingRule.Data.ScaleRuleType");
			data.ScaleRuleName = _ctx.StringValue("DescribeApplicationScalingRule.Data.ScaleRuleName");
			data.MinReadyInstances = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.MinReadyInstances");
			data.MinReadyInstanceRatio = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.MinReadyInstanceRatio");

			DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Timer timer = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Timer();
			timer.EndDate = _ctx.StringValue("DescribeApplicationScalingRule.Data.Timer.EndDate");
			timer.BeginDate = _ctx.StringValue("DescribeApplicationScalingRule.Data.Timer.BeginDate");
			timer.Period = _ctx.StringValue("DescribeApplicationScalingRule.Data.Timer.Period");

			List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Timer.DescribeApplicationScalingRule_Schedule> timer_schedules = new List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Timer.DescribeApplicationScalingRule_Schedule>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationScalingRule.Data.Timer.Schedules.Length"); i++) {
				DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Timer.DescribeApplicationScalingRule_Schedule schedule = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Timer.DescribeApplicationScalingRule_Schedule();
				schedule.AtTime = _ctx.StringValue("DescribeApplicationScalingRule.Data.Timer.Schedules["+ i +"].AtTime");
				schedule.TargetReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Timer.Schedules["+ i +"].TargetReplicas");
				schedule.MinReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Timer.Schedules["+ i +"].MinReplicas");
				schedule.MaxReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Timer.Schedules["+ i +"].MaxReplicas");

				timer_schedules.Add(schedule);
			}
			timer.Schedules = timer_schedules;
			data.Timer = timer;

			DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric metric = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric();
			metric.MaxReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Metric.MaxReplicas");
			metric.MinReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Metric.MinReplicas");

			DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus metricsStatus = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus();
			metricsStatus.DesiredReplicas = _ctx.LongValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.DesiredReplicas");
			metricsStatus.NextScaleTimePeriod = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.NextScaleTimePeriod");
			metricsStatus.CurrentReplicas = _ctx.LongValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.CurrentReplicas");
			metricsStatus.LastScaleTime = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.LastScaleTime");

			List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus.DescribeApplicationScalingRule_CurrentMetric> metricsStatus_currentMetrics = new List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus.DescribeApplicationScalingRule_CurrentMetric>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.CurrentMetrics.Length"); i++) {
				DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus.DescribeApplicationScalingRule_CurrentMetric currentMetric = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus.DescribeApplicationScalingRule_CurrentMetric();
				currentMetric.Type = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.CurrentMetrics["+ i +"].Type");
				currentMetric.CurrentValue = _ctx.LongValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.CurrentMetrics["+ i +"].CurrentValue");
				currentMetric.Name = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.CurrentMetrics["+ i +"].Name");

				metricsStatus_currentMetrics.Add(currentMetric);
			}
			metricsStatus.CurrentMetrics = metricsStatus_currentMetrics;

			List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus.DescribeApplicationScalingRule_NextScaleMetric> metricsStatus_nextScaleMetrics = new List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus.DescribeApplicationScalingRule_NextScaleMetric>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.NextScaleMetrics.Length"); i++) {
				DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus.DescribeApplicationScalingRule_NextScaleMetric nextScaleMetric = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_MetricsStatus.DescribeApplicationScalingRule_NextScaleMetric();
				nextScaleMetric.NextScaleOutAverageUtilization = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.NextScaleMetrics["+ i +"].NextScaleOutAverageUtilization");
				nextScaleMetric.NextScaleInAverageUtilization = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.NextScaleMetrics["+ i +"].NextScaleInAverageUtilization");
				nextScaleMetric.Name = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.MetricsStatus.NextScaleMetrics["+ i +"].Name");

				metricsStatus_nextScaleMetrics.Add(nextScaleMetric);
			}
			metricsStatus.NextScaleMetrics = metricsStatus_nextScaleMetrics;
			metric.MetricsStatus = metricsStatus;

			DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_ScaleUpRules scaleUpRules = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_ScaleUpRules();
			scaleUpRules.Step = _ctx.LongValue("DescribeApplicationScalingRule.Data.Metric.ScaleUpRules.Step");
			scaleUpRules.StabilizationWindowSeconds = _ctx.LongValue("DescribeApplicationScalingRule.Data.Metric.ScaleUpRules.StabilizationWindowSeconds");
			scaleUpRules.Disabled = _ctx.BooleanValue("DescribeApplicationScalingRule.Data.Metric.ScaleUpRules.Disabled");
			metric.ScaleUpRules = scaleUpRules;

			DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_ScaleDownRules scaleDownRules = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_ScaleDownRules();
			scaleDownRules.Step = _ctx.LongValue("DescribeApplicationScalingRule.Data.Metric.ScaleDownRules.Step");
			scaleDownRules.StabilizationWindowSeconds = _ctx.LongValue("DescribeApplicationScalingRule.Data.Metric.ScaleDownRules.StabilizationWindowSeconds");
			scaleDownRules.Disabled = _ctx.BooleanValue("DescribeApplicationScalingRule.Data.Metric.ScaleDownRules.Disabled");
			metric.ScaleDownRules = scaleDownRules;

			List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_Metric1> metric_metrics = new List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_Metric1>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationScalingRule.Data.Metric.Metrics.Length"); i++) {
				DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_Metric1 metric1 = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_Data.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_Metric1();
				metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("DescribeApplicationScalingRule.Data.Metric.Metrics["+ i +"].MetricTargetAverageUtilization");
				metric1.MetricType = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.Metrics["+ i +"].MetricType");
				metric1.SlbProject = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.Metrics["+ i +"].SlbProject");
				metric1.SlbLogstore = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.Metrics["+ i +"].SlbLogstore");
				metric1.Vport = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.Metrics["+ i +"].Vport");
				metric1.SlbId = _ctx.StringValue("DescribeApplicationScalingRule.Data.Metric.Metrics["+ i +"].SlbId");

				metric_metrics.Add(metric1);
			}
			metric.Metrics = metric_metrics;
			data.Metric = metric;
			describeApplicationScalingRuleResponse.Data = data;
        
			return describeApplicationScalingRuleResponse;
        }
    }
}
