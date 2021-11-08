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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class CapacityPlanResponseUnmarshaller
    {
        public static CapacityPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CapacityPlanResponse capacityPlanResponse = new CapacityPlanResponse();

			capacityPlanResponse.HttpResponse = _ctx.HttpResponse;
			capacityPlanResponse.RequestId = _ctx.StringValue("CapacityPlan.RequestId");

			CapacityPlanResponse.CapacityPlan_Result result = new CapacityPlanResponse.CapacityPlan_Result();
			result.InstanceCategory = _ctx.StringValue("CapacityPlan.Result.InstanceCategory");
			result.OversizedCluster = _ctx.BooleanValue("CapacityPlan.Result.OversizedCluster");

			List<CapacityPlanResponse.CapacityPlan_Result.CapacityPlan_ExtendConfigsItem> result_extendConfigs = new List<CapacityPlanResponse.CapacityPlan_Result.CapacityPlan_ExtendConfigsItem>();
			for (int i = 0; i < _ctx.Length("CapacityPlan.Result.ExtendConfigs.Length"); i++) {
				CapacityPlanResponse.CapacityPlan_Result.CapacityPlan_ExtendConfigsItem extendConfigsItem = new CapacityPlanResponse.CapacityPlan_Result.CapacityPlan_ExtendConfigsItem();
				extendConfigsItem.ConfigType = _ctx.StringValue("CapacityPlan.Result.ExtendConfigs["+ i +"].ConfigType");
				extendConfigsItem.Disk = _ctx.LongValue("CapacityPlan.Result.ExtendConfigs["+ i +"].Disk");
				extendConfigsItem.DiskType = _ctx.StringValue("CapacityPlan.Result.ExtendConfigs["+ i +"].DiskType");

				result_extendConfigs.Add(extendConfigsItem);
			}
			result.ExtendConfigs = result_extendConfigs;

			List<CapacityPlanResponse.CapacityPlan_Result.CapacityPlan_NodeConfigurationsItem> result_nodeConfigurations = new List<CapacityPlanResponse.CapacityPlan_Result.CapacityPlan_NodeConfigurationsItem>();
			for (int i = 0; i < _ctx.Length("CapacityPlan.Result.NodeConfigurations.Length"); i++) {
				CapacityPlanResponse.CapacityPlan_Result.CapacityPlan_NodeConfigurationsItem nodeConfigurationsItem = new CapacityPlanResponse.CapacityPlan_Result.CapacityPlan_NodeConfigurationsItem();
				nodeConfigurationsItem.Amount = _ctx.LongValue("CapacityPlan.Result.NodeConfigurations["+ i +"].Amount");
				nodeConfigurationsItem.Cpu = _ctx.LongValue("CapacityPlan.Result.NodeConfigurations["+ i +"].Cpu");
				nodeConfigurationsItem.Disk = _ctx.LongValue("CapacityPlan.Result.NodeConfigurations["+ i +"].Disk");
				nodeConfigurationsItem.DiskType = _ctx.StringValue("CapacityPlan.Result.NodeConfigurations["+ i +"].DiskType");
				nodeConfigurationsItem.Memory = _ctx.LongValue("CapacityPlan.Result.NodeConfigurations["+ i +"].Memory");
				nodeConfigurationsItem.NodeType = _ctx.StringValue("CapacityPlan.Result.NodeConfigurations["+ i +"].NodeType");

				result_nodeConfigurations.Add(nodeConfigurationsItem);
			}
			result.NodeConfigurations = result_nodeConfigurations;
			capacityPlanResponse.Result = result;
        
			return capacityPlanResponse;
        }
    }
}
