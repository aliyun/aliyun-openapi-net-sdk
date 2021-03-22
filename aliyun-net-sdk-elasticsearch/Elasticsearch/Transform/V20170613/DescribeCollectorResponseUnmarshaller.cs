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
    public class DescribeCollectorResponseUnmarshaller
    {
        public static DescribeCollectorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCollectorResponse describeCollectorResponse = new DescribeCollectorResponse();

			describeCollectorResponse.HttpResponse = _ctx.HttpResponse;
			describeCollectorResponse.RequestId = _ctx.StringValue("DescribeCollector.RequestId");

			DescribeCollectorResponse.DescribeCollector_Result result = new DescribeCollectorResponse.DescribeCollector_Result();
			result.GmtCreatedTime = _ctx.StringValue("DescribeCollector.Result.gmtCreatedTime");
			result.GmtUpdateTime = _ctx.StringValue("DescribeCollector.Result.gmtUpdateTime");
			result.Name = _ctx.StringValue("DescribeCollector.Result.name");
			result.ResId = _ctx.StringValue("DescribeCollector.Result.resId");
			result.ResVersion = _ctx.StringValue("DescribeCollector.Result.resVersion");
			result.VpcId = _ctx.StringValue("DescribeCollector.Result.vpcId");
			result.ResType = _ctx.StringValue("DescribeCollector.Result.resType");
			result.OwnerId = _ctx.StringValue("DescribeCollector.Result.ownerId");
			result.Status = _ctx.StringValue("DescribeCollector.Result.status");
			result.DryRun = _ctx.BooleanValue("DescribeCollector.Result.dryRun");

			List<string> result_collectorPaths = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeCollector.Result.CollectorPaths.Length"); i++) {
				result_collectorPaths.Add(_ctx.StringValue("DescribeCollector.Result.CollectorPaths["+ i +"]"));
			}
			result.CollectorPaths = result_collectorPaths;

			List<DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ConfigsItem> result_configs = new List<DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ConfigsItem>();
			for (int i = 0; i < _ctx.Length("DescribeCollector.Result.Configs.Length"); i++) {
				DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ConfigsItem configsItem = new DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ConfigsItem();
				configsItem.FileName = _ctx.StringValue("DescribeCollector.Result.Configs["+ i +"].fileName");
				configsItem.Content = _ctx.StringValue("DescribeCollector.Result.Configs["+ i +"].content");

				result_configs.Add(configsItem);
			}
			result.Configs = result_configs;

			List<DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ExtendConfigsItem> result_extendConfigs = new List<DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ExtendConfigsItem>();
			for (int i = 0; i < _ctx.Length("DescribeCollector.Result.ExtendConfigs.Length"); i++) {
				DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ExtendConfigsItem extendConfigsItem = new DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ExtendConfigsItem();
				extendConfigsItem.ConfigType = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].configType");
				extendConfigsItem.InstanceId = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].instanceId");
				extendConfigsItem.InstanceType = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].instanceType");
				extendConfigsItem.Protocol = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].protocol");
				extendConfigsItem.UserName = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].userName");
				extendConfigsItem.EnableMonitoring = _ctx.BooleanValue("DescribeCollector.Result.ExtendConfigs["+ i +"].enableMonitoring");
				extendConfigsItem.Type = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].type");
				extendConfigsItem.GroupId = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].groupId");
				extendConfigsItem.Host = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].host");
				extendConfigsItem.KibanaHost = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].kibanaHost");
				extendConfigsItem.TotalPodsCount = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].totalPodsCount");
				extendConfigsItem.SuccessPodsCount = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].successPodsCount");

				List<string> extendConfigsItem_hosts = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCollector.Result.ExtendConfigs["+ i +"].Hosts.Length"); j++) {
					extendConfigsItem_hosts.Add(_ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].Hosts["+ j +"]"));
				}
				extendConfigsItem.Hosts = extendConfigsItem_hosts;

				List<DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ExtendConfigsItem.DescribeCollector_MachinesItem> extendConfigsItem_machines = new List<DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ExtendConfigsItem.DescribeCollector_MachinesItem>();
				for (int j = 0; j < _ctx.Length("DescribeCollector.Result.ExtendConfigs["+ i +"].Machines.Length"); j++) {
					DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ExtendConfigsItem.DescribeCollector_MachinesItem machinesItem = new DescribeCollectorResponse.DescribeCollector_Result.DescribeCollector_ExtendConfigsItem.DescribeCollector_MachinesItem();
					machinesItem.InstanceId = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].Machines["+ j +"].instanceId");
					machinesItem.AgentStatus = _ctx.StringValue("DescribeCollector.Result.ExtendConfigs["+ i +"].Machines["+ j +"].agentStatus");

					extendConfigsItem_machines.Add(machinesItem);
				}
				extendConfigsItem.Machines = extendConfigsItem_machines;

				result_extendConfigs.Add(extendConfigsItem);
			}
			result.ExtendConfigs = result_extendConfigs;
			describeCollectorResponse.Result = result;
        
			return describeCollectorResponse;
        }
    }
}
