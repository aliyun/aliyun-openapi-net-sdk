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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListScalingTaskGroupResponseUnmarshaller
    {
        public static ListScalingTaskGroupResponse Unmarshall(UnmarshallerContext context)
        {
			ListScalingTaskGroupResponse listScalingTaskGroupResponse = new ListScalingTaskGroupResponse();

			listScalingTaskGroupResponse.HttpResponse = context.HttpResponse;
			listScalingTaskGroupResponse.RequestId = context.StringValue("ListScalingTaskGroup.RequestId");

			List<ListScalingTaskGroupResponse.ListScalingTaskGroup_Group> listScalingTaskGroupResponse_groupList = new List<ListScalingTaskGroupResponse.ListScalingTaskGroup_Group>();
			for (int i = 0; i < context.Length("ListScalingTaskGroup.GroupList.Length"); i++) {
				ListScalingTaskGroupResponse.ListScalingTaskGroup_Group group = new ListScalingTaskGroupResponse.ListScalingTaskGroup_Group();
				group.ScalingGroupId = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingGroupId");
				group.HostGroupId = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].HostGroupId");
				group.MinSize = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].MinSize");
				group.MaxSize = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].MaxSize");
				group.DefaultCooldown = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].DefaultCooldown");
				group.ActiveRuleCategory = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ActiveRuleCategory");
				group.Status = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].Status");
				group.PayType = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].PayType");
				group.DataDiskCategory = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].DataDiskCategory");
				group.DataDiskSize = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].DataDiskSize");
				group.DataDiskCount = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].DataDiskCount");
				group.SysDiskCategory = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].SysDiskCategory");
				group.SysDiskSize = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].SysDiskSize");
				group.CpuCount = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].CpuCount");
				group.MemSize = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].MemSize");
				group.SpotStrategy = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].SpotStrategy");

				List<string> group_instanceTypeList = new List<string>();
				for (int j = 0; j < context.Length("ListScalingTaskGroup.GroupList["+ i +"].InstanceTypeList.Length"); j++) {
					group_instanceTypeList.Add(context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].InstanceTypeList["+ j +"]"));
				}
				group.InstanceTypeList = group_instanceTypeList;

				ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingConfig scalingConfig = new ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingConfig();
				scalingConfig.PayType = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.PayType");
				scalingConfig.DataDiskCategory = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.DataDiskCategory");
				scalingConfig.DataDiskSize = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.DataDiskSize");
				scalingConfig.DataDiskCount = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.DataDiskCount");
				scalingConfig.SysDiskCategory = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.SysDiskCategory");
				scalingConfig.SysDiskSize = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.SysDiskSize");
				scalingConfig.CpuCount = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.CpuCount");
				scalingConfig.MemSize = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.MemSize");
				scalingConfig.SpotStrategy = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.SpotStrategy");

				List<string> scalingConfig_instanceTypeList1 = new List<string>();
				for (int j = 0; j < context.Length("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.InstanceTypeList.Length"); j++) {
					scalingConfig_instanceTypeList1.Add(context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.InstanceTypeList["+ j +"]"));
				}
				scalingConfig.InstanceTypeList1 = scalingConfig_instanceTypeList1;

				List<ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingConfig.ListScalingTaskGroup_SpotPriceLimit3> scalingConfig_spotPriceLimits2 = new List<ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingConfig.ListScalingTaskGroup_SpotPriceLimit3>();
				for (int j = 0; j < context.Length("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.SpotPriceLimits.Length"); j++) {
					ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingConfig.ListScalingTaskGroup_SpotPriceLimit3 spotPriceLimit3 = new ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingConfig.ListScalingTaskGroup_SpotPriceLimit3();
					spotPriceLimit3.InstanceType = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.SpotPriceLimits["+ j +"].InstanceType");
					spotPriceLimit3.PriceLimit = context.FloatValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingConfig.SpotPriceLimits["+ j +"].PriceLimit");

					scalingConfig_spotPriceLimits2.Add(spotPriceLimit3);
				}
				scalingConfig.SpotPriceLimits2 = scalingConfig_spotPriceLimits2;
				group.ScalingConfig = scalingConfig;

				List<ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_SpotPriceLimit> group_spotPriceLimits = new List<ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_SpotPriceLimit>();
				for (int j = 0; j < context.Length("ListScalingTaskGroup.GroupList["+ i +"].SpotPriceLimits.Length"); j++) {
					ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_SpotPriceLimit spotPriceLimit = new ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_SpotPriceLimit();
					spotPriceLimit.InstanceType = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].SpotPriceLimits["+ j +"].InstanceType");
					spotPriceLimit.PriceLimit = context.FloatValue("ListScalingTaskGroup.GroupList["+ i +"].SpotPriceLimits["+ j +"].PriceLimit");

					group_spotPriceLimits.Add(spotPriceLimit);
				}
				group.SpotPriceLimits = group_spotPriceLimits;

				List<ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingRule> group_scalingRuleList = new List<ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingRule>();
				for (int j = 0; j < context.Length("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList.Length"); j++) {
					ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingRule scalingRule = new ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingRule();
					scalingRule.Id = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].Id");
					scalingRule.RuleCategory = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].RuleCategory");
					scalingRule.RuleName = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].RuleName");
					scalingRule.AdjustmentType = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].AdjustmentType");
					scalingRule.AdjustmentValue = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].AdjustmentValue");
					scalingRule.Cooldown = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].Cooldown");
					scalingRule.Status = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].Status");
					scalingRule.LaunchTime = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].LaunchTime");
					scalingRule.LaunchExpirationTime = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].LaunchExpirationTime");
					scalingRule.RecurrenceType = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].RecurrenceType");
					scalingRule.RecurrenceValue = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].RecurrenceValue");
					scalingRule.RecurrenceEndTime = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].RecurrenceEndTime");

					ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingRule.ListScalingTaskGroup_SchedulerTrigger schedulerTrigger = new ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingRule.ListScalingTaskGroup_SchedulerTrigger();
					schedulerTrigger.LaunchTime = context.LongValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].SchedulerTrigger.LaunchTime");
					schedulerTrigger.LaunchExpirationTime = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].SchedulerTrigger.LaunchExpirationTime");
					schedulerTrigger.RecurrenceType = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].SchedulerTrigger.RecurrenceType");
					schedulerTrigger.RecurrenceValue = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].SchedulerTrigger.RecurrenceValue");
					schedulerTrigger.RecurrenceEndTime = context.LongValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].SchedulerTrigger.RecurrenceEndTime");
					scalingRule.SchedulerTrigger = schedulerTrigger;

					ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingRule.ListScalingTaskGroup_CloudWatchTrigger cloudWatchTrigger = new ListScalingTaskGroupResponse.ListScalingTaskGroup_Group.ListScalingTaskGroup_ScalingRule.ListScalingTaskGroup_CloudWatchTrigger();
					cloudWatchTrigger.MetricName = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].CloudWatchTrigger.MetricName");
					cloudWatchTrigger.Period = context.IntegerValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].CloudWatchTrigger.Period");
					cloudWatchTrigger.Statistics = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].CloudWatchTrigger.Statistics");
					cloudWatchTrigger.ComparisonOperator = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].CloudWatchTrigger.ComparisonOperator");
					cloudWatchTrigger.Threshold = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].CloudWatchTrigger.Threshold");
					cloudWatchTrigger.EvaluationCount = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].CloudWatchTrigger.EvaluationCount");
					cloudWatchTrigger.Unit = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].CloudWatchTrigger.Unit");
					cloudWatchTrigger.MetricDisplayName = context.StringValue("ListScalingTaskGroup.GroupList["+ i +"].ScalingRuleList["+ j +"].CloudWatchTrigger.MetricDisplayName");
					scalingRule.CloudWatchTrigger = cloudWatchTrigger;

					group_scalingRuleList.Add(scalingRule);
				}
				group.ScalingRuleList = group_scalingRuleList;

				listScalingTaskGroupResponse_groupList.Add(group);
			}
			listScalingTaskGroupResponse.GroupList = listScalingTaskGroupResponse_groupList;
        
			return listScalingTaskGroupResponse;
        }
    }
}
