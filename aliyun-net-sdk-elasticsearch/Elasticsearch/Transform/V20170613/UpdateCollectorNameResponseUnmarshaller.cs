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
    public class UpdateCollectorNameResponseUnmarshaller
    {
        public static UpdateCollectorNameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateCollectorNameResponse updateCollectorNameResponse = new UpdateCollectorNameResponse();

			updateCollectorNameResponse.HttpResponse = _ctx.HttpResponse;
			updateCollectorNameResponse.RequestId = _ctx.StringValue("UpdateCollectorName.RequestId");

			UpdateCollectorNameResponse.UpdateCollectorName_Result result = new UpdateCollectorNameResponse.UpdateCollectorName_Result();
			result.GmtCreatedTime = _ctx.StringValue("UpdateCollectorName.Result.gmtCreatedTime");
			result.GmtUpdateTime = _ctx.StringValue("UpdateCollectorName.Result.gmtUpdateTime");
			result.Name = _ctx.StringValue("UpdateCollectorName.Result.name");
			result.ResId = _ctx.StringValue("UpdateCollectorName.Result.resId");
			result.ResVersion = _ctx.StringValue("UpdateCollectorName.Result.resVersion");
			result.VpcId = _ctx.StringValue("UpdateCollectorName.Result.vpcId");
			result.ResType = _ctx.StringValue("UpdateCollectorName.Result.resType");
			result.OwnerId = _ctx.StringValue("UpdateCollectorName.Result.ownerId");
			result.Status = _ctx.StringValue("UpdateCollectorName.Result.status");
			result.DryRun = _ctx.BooleanValue("UpdateCollectorName.Result.dryRun");

			List<string> result_collectorPaths = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateCollectorName.Result.CollectorPaths.Length"); i++) {
				result_collectorPaths.Add(_ctx.StringValue("UpdateCollectorName.Result.CollectorPaths["+ i +"]"));
			}
			result.CollectorPaths = result_collectorPaths;

			List<UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ConfigsItem> result_configs = new List<UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ConfigsItem>();
			for (int i = 0; i < _ctx.Length("UpdateCollectorName.Result.Configs.Length"); i++) {
				UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ConfigsItem configsItem = new UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ConfigsItem();
				configsItem.FileName = _ctx.StringValue("UpdateCollectorName.Result.Configs["+ i +"].fileName");
				configsItem.Content = _ctx.StringValue("UpdateCollectorName.Result.Configs["+ i +"].content");

				result_configs.Add(configsItem);
			}
			result.Configs = result_configs;

			List<UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ExtendConfigsItem> result_extendConfigs = new List<UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ExtendConfigsItem>();
			for (int i = 0; i < _ctx.Length("UpdateCollectorName.Result.ExtendConfigs.Length"); i++) {
				UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ExtendConfigsItem extendConfigsItem = new UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ExtendConfigsItem();
				extendConfigsItem.ConfigType = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].configType");
				extendConfigsItem.InstanceId = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].instanceId");
				extendConfigsItem.InstanceType = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].instanceType");
				extendConfigsItem.Protocol = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].protocol");
				extendConfigsItem.UserName = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].userName");
				extendConfigsItem.EnableMonitoring = _ctx.BooleanValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].enableMonitoring");
				extendConfigsItem.Type = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].type");
				extendConfigsItem.GroupId = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].groupId");
				extendConfigsItem.Host = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].host");
				extendConfigsItem.KibanaHost = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].kibanaHost");
				extendConfigsItem.TotalPodsCount = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].totalPodsCount");
				extendConfigsItem.SuccessPodsCount = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].successPodsCount");

				List<string> extendConfigsItem_hosts = new List<string>();
				for (int j = 0; j < _ctx.Length("UpdateCollectorName.Result.ExtendConfigs["+ i +"].Hosts.Length"); j++) {
					extendConfigsItem_hosts.Add(_ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].Hosts["+ j +"]"));
				}
				extendConfigsItem.Hosts = extendConfigsItem_hosts;

				List<UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ExtendConfigsItem.UpdateCollectorName_MachinesItem> extendConfigsItem_machines = new List<UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ExtendConfigsItem.UpdateCollectorName_MachinesItem>();
				for (int j = 0; j < _ctx.Length("UpdateCollectorName.Result.ExtendConfigs["+ i +"].Machines.Length"); j++) {
					UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ExtendConfigsItem.UpdateCollectorName_MachinesItem machinesItem = new UpdateCollectorNameResponse.UpdateCollectorName_Result.UpdateCollectorName_ExtendConfigsItem.UpdateCollectorName_MachinesItem();
					machinesItem.InstanceId = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].Machines["+ j +"].instanceId");
					machinesItem.AgentStatus = _ctx.StringValue("UpdateCollectorName.Result.ExtendConfigs["+ i +"].Machines["+ j +"].agentStatus");

					extendConfigsItem_machines.Add(machinesItem);
				}
				extendConfigsItem.Machines = extendConfigsItem_machines;

				result_extendConfigs.Add(extendConfigsItem);
			}
			result.ExtendConfigs = result_extendConfigs;
			updateCollectorNameResponse.Result = result;
        
			return updateCollectorNameResponse;
        }
    }
}
