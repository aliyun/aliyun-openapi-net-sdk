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
    public class UpdateCollectorResponseUnmarshaller
    {
        public static UpdateCollectorResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateCollectorResponse updateCollectorResponse = new UpdateCollectorResponse();

			updateCollectorResponse.HttpResponse = context.HttpResponse;
			updateCollectorResponse.RequestId = context.StringValue("UpdateCollector.RequestId");

			UpdateCollectorResponse.UpdateCollector_Result result = new UpdateCollectorResponse.UpdateCollector_Result();
			result.GmtCreatedTime = context.StringValue("UpdateCollector.Result.gmtCreatedTime");
			result.GmtUpdateTime = context.StringValue("UpdateCollector.Result.gmtUpdateTime");
			result.Name = context.StringValue("UpdateCollector.Result.name");
			result.ResId = context.StringValue("UpdateCollector.Result.resId");
			result.ResVersion = context.StringValue("UpdateCollector.Result.resVersion");
			result.VpcId = context.StringValue("UpdateCollector.Result.vpcId");
			result.ResType = context.StringValue("UpdateCollector.Result.resType");
			result.OwnerId = context.StringValue("UpdateCollector.Result.ownerId");
			result.Status = context.StringValue("UpdateCollector.Result.status");
			result.DryRun = context.BooleanValue("UpdateCollector.Result.dryRun");

			List<string> result_collectorPaths = new List<string>();
			for (int i = 0; i < context.Length("UpdateCollector.Result.CollectorPaths.Length"); i++) {
				result_collectorPaths.Add(context.StringValue("UpdateCollector.Result.CollectorPaths["+ i +"]"));
			}
			result.CollectorPaths = result_collectorPaths;

			List<UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ConfigsItem> result_configs = new List<UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ConfigsItem>();
			for (int i = 0; i < context.Length("UpdateCollector.Result.Configs.Length"); i++) {
				UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ConfigsItem configsItem = new UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ConfigsItem();
				configsItem.FileName = context.StringValue("UpdateCollector.Result.Configs["+ i +"].fileName");
				configsItem.Content = context.StringValue("UpdateCollector.Result.Configs["+ i +"].content");

				result_configs.Add(configsItem);
			}
			result.Configs = result_configs;

			List<UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ExtendConfigsItem> result_extendConfigs = new List<UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ExtendConfigsItem>();
			for (int i = 0; i < context.Length("UpdateCollector.Result.ExtendConfigs.Length"); i++) {
				UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ExtendConfigsItem extendConfigsItem = new UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ExtendConfigsItem();
				extendConfigsItem.ConfigType = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].configType");
				extendConfigsItem.InstanceId = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].instanceId");
				extendConfigsItem.InstanceType = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].instanceType");
				extendConfigsItem.Protocol = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].protocol");
				extendConfigsItem.UserName = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].userName");
				extendConfigsItem.EnableMonitoring = context.BooleanValue("UpdateCollector.Result.ExtendConfigs["+ i +"].enableMonitoring");
				extendConfigsItem.Type = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].type");
				extendConfigsItem.GroupId = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].groupId");

				List<string> extendConfigsItem_hosts = new List<string>();
				for (int j = 0; j < context.Length("UpdateCollector.Result.ExtendConfigs["+ i +"].Hosts.Length"); j++) {
					extendConfigsItem_hosts.Add(context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].Hosts["+ j +"]"));
				}
				extendConfigsItem.Hosts = extendConfigsItem_hosts;

				List<UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ExtendConfigsItem.UpdateCollector_MachinesItem> extendConfigsItem_machines = new List<UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ExtendConfigsItem.UpdateCollector_MachinesItem>();
				for (int j = 0; j < context.Length("UpdateCollector.Result.ExtendConfigs["+ i +"].Machines.Length"); j++) {
					UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ExtendConfigsItem.UpdateCollector_MachinesItem machinesItem = new UpdateCollectorResponse.UpdateCollector_Result.UpdateCollector_ExtendConfigsItem.UpdateCollector_MachinesItem();
					machinesItem.InstanceId = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].Machines["+ j +"].instanceId");
					machinesItem.AgentStatus = context.StringValue("UpdateCollector.Result.ExtendConfigs["+ i +"].Machines["+ j +"].agentStatus");

					extendConfigsItem_machines.Add(machinesItem);
				}
				extendConfigsItem.Machines = extendConfigsItem_machines;

				result_extendConfigs.Add(extendConfigsItem);
			}
			result.ExtendConfigs = result_extendConfigs;
			updateCollectorResponse.Result = result;
        
			return updateCollectorResponse;
        }
    }
}
