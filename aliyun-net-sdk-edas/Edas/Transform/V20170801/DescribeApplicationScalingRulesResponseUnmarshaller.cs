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
    public class DescribeApplicationScalingRulesResponseUnmarshaller
    {
        public static DescribeApplicationScalingRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationScalingRulesResponse describeApplicationScalingRulesResponse = new DescribeApplicationScalingRulesResponse();

			describeApplicationScalingRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationScalingRulesResponse.RequestId = _ctx.StringValue("DescribeApplicationScalingRules.RequestId");
			describeApplicationScalingRulesResponse.Code = _ctx.IntegerValue("DescribeApplicationScalingRules.Code");
			describeApplicationScalingRulesResponse.Message = _ctx.StringValue("DescribeApplicationScalingRules.Message");

			DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules appScalingRules = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules();
			appScalingRules.CurrentPage = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.CurrentPage");
			appScalingRules.PageSize = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.PageSize");
			appScalingRules.TotalSize = _ctx.LongValue("DescribeApplicationScalingRules.AppScalingRules.TotalSize");

			List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule> appScalingRules_result = new List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationScalingRules.AppScalingRules.Result.Length"); i++) {
				DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule rule = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule();
				rule.AppId = _ctx.StringValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].AppId");
				rule.ScaleRuleName = _ctx.StringValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].ScaleRuleName");
				rule.ScaleRuleType = _ctx.StringValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].ScaleRuleType");
				rule.ScaleRuleEnabled = _ctx.BooleanValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].ScaleRuleEnabled");
				rule.MinReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].MinReplicas");
				rule.MaxReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].MaxReplicas");
				rule.CreateTime = _ctx.LongValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].CreateTime");
				rule.UpdateTime = _ctx.LongValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].UpdateTime");
				rule.LastDisableTime = _ctx.LongValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].LastDisableTime");

				DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Metric metric = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Metric();
				metric.MaxReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Metric.MaxReplicas");
				metric.MinReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Metric.MinReplicas");

				List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_Metric1> metric_metrics = new List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_Metric1>();
				for (int j = 0; j < _ctx.Length("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Metric.Metrics.Length"); j++) {
					DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_Metric1 metric1 = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Metric.DescribeApplicationScalingRules_Metric1();
					metric1.MetricType = _ctx.StringValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Metric.Metrics["+ j +"].MetricType");
					metric1.MetricTargetAverageUtilization = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Metric.Metrics["+ j +"].MetricTargetAverageUtilization");

					metric_metrics.Add(metric1);
				}
				metric.Metrics = metric_metrics;
				rule.Metric = metric;

				DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Trigger trigger = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Trigger();
				trigger.MaxReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Trigger.MaxReplicas");
				trigger.MinReplicas = _ctx.IntegerValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Trigger.MinReplicas");

				List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Trigger.DescribeApplicationScalingRules_Trigger2> trigger_triggers = new List<DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Trigger.DescribeApplicationScalingRules_Trigger2>();
				for (int j = 0; j < _ctx.Length("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Trigger.Triggers.Length"); j++) {
					DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Trigger.DescribeApplicationScalingRules_Trigger2 trigger2 = new DescribeApplicationScalingRulesResponse.DescribeApplicationScalingRules_AppScalingRules.DescribeApplicationScalingRules_Rule.DescribeApplicationScalingRules_Trigger.DescribeApplicationScalingRules_Trigger2();
					trigger2.Type = _ctx.StringValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Trigger.Triggers["+ j +"].Type");
					trigger2.Name = _ctx.StringValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Trigger.Triggers["+ j +"].Name");
					trigger2.MetaData = _ctx.StringValue("DescribeApplicationScalingRules.AppScalingRules.Result["+ i +"].Trigger.Triggers["+ j +"].MetaData");

					trigger_triggers.Add(trigger2);
				}
				trigger.Triggers = trigger_triggers;
				rule.Trigger = trigger;

				appScalingRules_result.Add(rule);
			}
			appScalingRules.Result = appScalingRules_result;
			describeApplicationScalingRulesResponse.AppScalingRules = appScalingRules;
        
			return describeApplicationScalingRulesResponse;
        }
    }
}
