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
    public class DescribeETLJobResponseUnmarshaller
    {
        public static DescribeETLJobResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeETLJobResponse describeETLJobResponse = new DescribeETLJobResponse();

			describeETLJobResponse.HttpResponse = context.HttpResponse;
			describeETLJobResponse.RequestId = context.StringValue("DescribeETLJob.RequestId");
			describeETLJobResponse.Id = context.StringValue("DescribeETLJob.Id");
			describeETLJobResponse.Name = context.StringValue("DescribeETLJob.Name");
			describeETLJobResponse.Description = context.StringValue("DescribeETLJob.Description");
			describeETLJobResponse.CategoryId = context.StringValue("DescribeETLJob.CategoryId");
			describeETLJobResponse.Graph = context.StringValue("DescribeETLJob.Graph");

			DescribeETLJobResponse.DescribeETLJob_ClusterConfig clusterConfig = new DescribeETLJobResponse.DescribeETLJob_ClusterConfig();
			clusterConfig.IsOnDemand = context.BooleanValue("DescribeETLJob.ClusterConfig.IsOnDemand");
			clusterConfig.ClusterId = context.StringValue("DescribeETLJob.ClusterConfig.ClusterId");
			clusterConfig.Queue = context.StringValue("DescribeETLJob.ClusterConfig.Queue");
			clusterConfig.UserName = context.StringValue("DescribeETLJob.ClusterConfig.UserName");
			clusterConfig.RecordRate = context.LongValue("DescribeETLJob.ClusterConfig.RecordRate");
			clusterConfig.SizeRate = context.LongValue("DescribeETLJob.ClusterConfig.SizeRate");

			DescribeETLJobResponse.DescribeETLJob_ClusterConfig.DescribeETLJob_DriverResource driverResource = new DescribeETLJobResponse.DescribeETLJob_ClusterConfig.DescribeETLJob_DriverResource();
			driverResource.Vcores = context.IntegerValue("DescribeETLJob.ClusterConfig.DriverResource.Vcores");
			driverResource.MemSize = context.IntegerValue("DescribeETLJob.ClusterConfig.DriverResource.MemSize");
			clusterConfig.DriverResource = driverResource;

			DescribeETLJobResponse.DescribeETLJob_ClusterConfig.DescribeETLJob_ExecutorResource executorResource = new DescribeETLJobResponse.DescribeETLJob_ClusterConfig.DescribeETLJob_ExecutorResource();
			executorResource.Vcores = context.IntegerValue("DescribeETLJob.ClusterConfig.ExecutorResource.Vcores");
			executorResource.MemSize = context.IntegerValue("DescribeETLJob.ClusterConfig.ExecutorResource.MemSize");
			clusterConfig.ExecutorResource = executorResource;
			describeETLJobResponse.ClusterConfig = clusterConfig;

			DescribeETLJobResponse.DescribeETLJob_AlertConfig alertConfig = new DescribeETLJobResponse.DescribeETLJob_AlertConfig();

			List<DescribeETLJobResponse.DescribeETLJob_AlertConfig.DescribeETLJob_Item> alertConfig_items = new List<DescribeETLJobResponse.DescribeETLJob_AlertConfig.DescribeETLJob_Item>();
			for (int i = 0; i < context.Length("DescribeETLJob.AlertConfig.Items.Length"); i++) {
				DescribeETLJobResponse.DescribeETLJob_AlertConfig.DescribeETLJob_Item item = new DescribeETLJobResponse.DescribeETLJob_AlertConfig.DescribeETLJob_Item();
				item.Enable = context.BooleanValue("DescribeETLJob.AlertConfig.Items["+ i +"].Enable");
				item.EventId = context.StringValue("DescribeETLJob.AlertConfig.Items["+ i +"].EventId");

				List<string> item_alertUserGroupIdList = new List<string>();
				for (int j = 0; j < context.Length("DescribeETLJob.AlertConfig.Items["+ i +"].AlertUserGroupIdList.Length"); j++) {
					item_alertUserGroupIdList.Add(context.StringValue("DescribeETLJob.AlertConfig.Items["+ i +"].AlertUserGroupIdList["+ j +"]"));
				}
				item.AlertUserGroupIdList = item_alertUserGroupIdList;

				List<string> item_alertDingDingGroupIdList = new List<string>();
				for (int j = 0; j < context.Length("DescribeETLJob.AlertConfig.Items["+ i +"].AlertDingDingGroupIdList.Length"); j++) {
					item_alertDingDingGroupIdList.Add(context.StringValue("DescribeETLJob.AlertConfig.Items["+ i +"].AlertDingDingGroupIdList["+ j +"]"));
				}
				item.AlertDingDingGroupIdList = item_alertDingDingGroupIdList;

				alertConfig_items.Add(item);
			}
			alertConfig.Items = alertConfig_items;
			describeETLJobResponse.AlertConfig = alertConfig;

			List<DescribeETLJobResponse.DescribeETLJob_TriggerRule> describeETLJobResponse_triggerRuleList = new List<DescribeETLJobResponse.DescribeETLJob_TriggerRule>();
			for (int i = 0; i < context.Length("DescribeETLJob.TriggerRuleList.Length"); i++) {
				DescribeETLJobResponse.DescribeETLJob_TriggerRule triggerRule = new DescribeETLJobResponse.DescribeETLJob_TriggerRule();
				triggerRule.Enabled = context.BooleanValue("DescribeETLJob.TriggerRuleList["+ i +"].Enabled");
				triggerRule.StartTime = context.LongValue("DescribeETLJob.TriggerRuleList["+ i +"].StartTime");
				triggerRule.EndTime = context.LongValue("DescribeETLJob.TriggerRuleList["+ i +"].EndTime");
				triggerRule.CronExpr = context.StringValue("DescribeETLJob.TriggerRuleList["+ i +"].CronExpr");

				describeETLJobResponse_triggerRuleList.Add(triggerRule);
			}
			describeETLJobResponse.TriggerRuleList = describeETLJobResponse_triggerRuleList;

			List<DescribeETLJobResponse.DescribeETLJob_Stage> describeETLJobResponse_stageList = new List<DescribeETLJobResponse.DescribeETLJob_Stage>();
			for (int i = 0; i < context.Length("DescribeETLJob.StageList.Length"); i++) {
				DescribeETLJobResponse.DescribeETLJob_Stage stage = new DescribeETLJobResponse.DescribeETLJob_Stage();
				stage.StageName = context.StringValue("DescribeETLJob.StageList["+ i +"].StageName");
				stage.StageType = context.StringValue("DescribeETLJob.StageList["+ i +"].StageType");
				stage.StagePlugin = context.StringValue("DescribeETLJob.StageList["+ i +"].StagePlugin");
				stage.StageConf = context.StringValue("DescribeETLJob.StageList["+ i +"].StageConf");

				describeETLJobResponse_stageList.Add(stage);
			}
			describeETLJobResponse.StageList = describeETLJobResponse_stageList;

			List<DescribeETLJobResponse.DescribeETLJob_StageConnection> describeETLJobResponse_stageConnectionList = new List<DescribeETLJobResponse.DescribeETLJob_StageConnection>();
			for (int i = 0; i < context.Length("DescribeETLJob.StageConnectionList.Length"); i++) {
				DescribeETLJobResponse.DescribeETLJob_StageConnection stageConnection = new DescribeETLJobResponse.DescribeETLJob_StageConnection();
				stageConnection.From = context.StringValue("DescribeETLJob.StageConnectionList["+ i +"].From");
				stageConnection.To = context.StringValue("DescribeETLJob.StageConnectionList["+ i +"].To");
				stageConnection.Port = context.StringValue("DescribeETLJob.StageConnectionList["+ i +"].Port");

				describeETLJobResponse_stageConnectionList.Add(stageConnection);
			}
			describeETLJobResponse.StageConnectionList = describeETLJobResponse_stageConnectionList;
        
			return describeETLJobResponse;
        }
    }
}
