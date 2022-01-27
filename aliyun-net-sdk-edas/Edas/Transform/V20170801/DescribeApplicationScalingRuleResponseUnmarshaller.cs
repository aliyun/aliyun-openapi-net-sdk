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
    public class DescribeApplicationScalingRuleResponseUnmarshaller
    {
        public static DescribeApplicationScalingRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationScalingRuleResponse describeApplicationScalingRuleResponse = new DescribeApplicationScalingRuleResponse();

			describeApplicationScalingRuleResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationScalingRuleResponse.RequestId = _ctx.StringValue("DescribeApplicationScalingRule.RequestId");
			describeApplicationScalingRuleResponse.Code = _ctx.IntegerValue("DescribeApplicationScalingRule.Code");
			describeApplicationScalingRuleResponse.Message = _ctx.StringValue("DescribeApplicationScalingRule.Message");

			DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_AppScalingRule appScalingRule = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_AppScalingRule();
			appScalingRule.AppId = _ctx.StringValue("DescribeApplicationScalingRule.AppScalingRule.AppId");
			appScalingRule.ScaleRuleName = _ctx.StringValue("DescribeApplicationScalingRule.AppScalingRule.ScaleRuleName");
			appScalingRule.ScaleRuleType = _ctx.StringValue("DescribeApplicationScalingRule.AppScalingRule.ScaleRuleType");
			appScalingRule.ScaleRuleEnabled = _ctx.BooleanValue("DescribeApplicationScalingRule.AppScalingRule.ScaleRuleEnabled");
			appScalingRule.MinReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.AppScalingRule.MinReplicas");
			appScalingRule.MaxReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.AppScalingRule.MaxReplicas");
			appScalingRule.CreateTime = _ctx.LongValue("DescribeApplicationScalingRule.AppScalingRule.CreateTime");
			appScalingRule.UpdateTime = _ctx.LongValue("DescribeApplicationScalingRule.AppScalingRule.UpdateTime");
			appScalingRule.LastDisableTime = _ctx.LongValue("DescribeApplicationScalingRule.AppScalingRule.LastDisableTime");

			DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_AppScalingRule.DescribeApplicationScalingRule_Metric metric = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_AppScalingRule.DescribeApplicationScalingRule_Metric();
			metric.MaxReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.AppScalingRule.Metric.MaxReplicas");
			metric.MinReplicas = _ctx.IntegerValue("DescribeApplicationScalingRule.AppScalingRule.Metric.MinReplicas");

			List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_AppScalingRule.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_Metric1> metric_metrics = new List<DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_AppScalingRule.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_Metric1>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationScalingRule.AppScalingRule.Metric.Metrics.Length"); i++) {
				DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_AppScalingRule.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_Metric1 metric1 = new DescribeApplicationScalingRuleResponse.DescribeApplicationScalingRule_AppScalingRule.DescribeApplicationScalingRule_Metric.DescribeApplicationScalingRule_Metric1();
				metric1.MetricType = _ctx.StringValue("DescribeApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricType");
				metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("DescribeApplicationScalingRule.AppScalingRule.Metric.Metrics["+ i +"].MetricTargetAverageUtilization");

				metric_metrics.Add(metric1);
			}
			metric.Metrics = metric_metrics;
			appScalingRule.Metric = metric;
			describeApplicationScalingRuleResponse.AppScalingRule = appScalingRule;
        
			return describeApplicationScalingRuleResponse;
        }
    }
}
