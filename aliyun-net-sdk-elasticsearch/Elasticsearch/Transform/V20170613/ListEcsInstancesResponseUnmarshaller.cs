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
    public class ListEcsInstancesResponseUnmarshaller
    {
        public static ListEcsInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEcsInstancesResponse listEcsInstancesResponse = new ListEcsInstancesResponse();

			listEcsInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listEcsInstancesResponse.RequestId = _ctx.StringValue("ListEcsInstances.RequestId");

			ListEcsInstancesResponse.ListEcsInstances_Headers headers = new ListEcsInstancesResponse.ListEcsInstances_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListEcsInstances.Headers.X-Total-Count");
			listEcsInstancesResponse.Headers = headers;

			List<ListEcsInstancesResponse.ListEcsInstances_ResultItem> listEcsInstancesResponse_result = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListEcsInstances.Result.Length"); i++) {
				ListEcsInstancesResponse.ListEcsInstances_ResultItem resultItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem();
				resultItem.EcsInstanceId = _ctx.StringValue("ListEcsInstances.Result["+ i +"].ecsInstanceId");
				resultItem.EcsInstanceName = _ctx.StringValue("ListEcsInstances.Result["+ i +"].ecsInstanceName");
				resultItem.Status = _ctx.StringValue("ListEcsInstances.Result["+ i +"].status");
				resultItem.Tags = _ctx.StringValue("ListEcsInstances.Result["+ i +"].tags");
				resultItem.OsType = _ctx.StringValue("ListEcsInstances.Result["+ i +"].osType");
				resultItem.CloudAssistantStatus = _ctx.StringValue("ListEcsInstances.Result["+ i +"].cloudAssistantStatus");

				List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_IpAddressItem> resultItem_ipAddress = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_IpAddressItem>();
				for (int j = 0; j < _ctx.Length("ListEcsInstances.Result["+ i +"].IpAddress.Length"); j++) {
					ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_IpAddressItem ipAddressItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_IpAddressItem();
					ipAddressItem.Host = _ctx.StringValue("ListEcsInstances.Result["+ i +"].IpAddress["+ j +"].host");
					ipAddressItem.IpType = _ctx.StringValue("ListEcsInstances.Result["+ i +"].IpAddress["+ j +"].ipType");

					resultItem_ipAddress.Add(ipAddressItem);
				}
				resultItem.IpAddress = resultItem_ipAddress;

				List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem> resultItem_collectors = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem>();
				for (int j = 0; j < _ctx.Length("ListEcsInstances.Result["+ i +"].Collectors.Length"); j++) {
					ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem collectorsItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem();
					collectorsItem.GmtCreatedTime = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].gmtCreatedTime");
					collectorsItem.GmtUpdateTime = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].gmtUpdateTime");
					collectorsItem.Name = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].name");
					collectorsItem.ResId = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].resId");
					collectorsItem.ResVersion = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].resVersion");
					collectorsItem.VpcId = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].vpcId");
					collectorsItem.ResType = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].resType");
					collectorsItem.OwnerId = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ownerId");
					collectorsItem.Status = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].status");
					collectorsItem.DryRun = _ctx.BooleanValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].dryRun");

					List<string> collectorsItem_collectorPaths = new List<string>();
					for (int k = 0; k < _ctx.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].CollectorPaths.Length"); k++) {
						collectorsItem_collectorPaths.Add(_ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].CollectorPaths["+ k +"]"));
					}
					collectorsItem.CollectorPaths = collectorsItem_collectorPaths;

					List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ConfigsItem> collectorsItem_configs = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ConfigsItem>();
					for (int k = 0; k < _ctx.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].Configs.Length"); k++) {
						ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ConfigsItem configsItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ConfigsItem();
						configsItem.FileName = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].Configs["+ k +"].fileName");
						configsItem.Content = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].Configs["+ k +"].content");

						collectorsItem_configs.Add(configsItem);
					}
					collectorsItem.Configs = collectorsItem_configs;

					List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem> collectorsItem_extendConfigs = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem>();
					for (int k = 0; k < _ctx.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs.Length"); k++) {
						ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem extendConfigsItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem();
						extendConfigsItem.ConfigType = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].configType");
						extendConfigsItem.InstanceId = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].instanceId");
						extendConfigsItem.InstanceType = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].instanceType");
						extendConfigsItem.Protocol = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].protocol");
						extendConfigsItem.UserName = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].userName");
						extendConfigsItem.EnableMonitoring = _ctx.BooleanValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].enableMonitoring");
						extendConfigsItem.Type = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].type");
						extendConfigsItem.GroupId = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].groupId");

						List<string> extendConfigsItem_hosts = new List<string>();
						for (int l = 0; l < _ctx.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Hosts.Length"); l++) {
							extendConfigsItem_hosts.Add(_ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Hosts["+ l +"]"));
						}
						extendConfigsItem.Hosts = extendConfigsItem_hosts;

						List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem.ListEcsInstances_MachinesItem> extendConfigsItem_machines = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem.ListEcsInstances_MachinesItem>();
						for (int l = 0; l < _ctx.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Machines.Length"); l++) {
							ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem.ListEcsInstances_MachinesItem machinesItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem.ListEcsInstances_MachinesItem();
							machinesItem.InstanceId = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Machines["+ l +"].instanceId");
							machinesItem.AgentStatus = _ctx.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Machines["+ l +"].agentStatus");

							extendConfigsItem_machines.Add(machinesItem);
						}
						extendConfigsItem.Machines = extendConfigsItem_machines;

						collectorsItem_extendConfigs.Add(extendConfigsItem);
					}
					collectorsItem.ExtendConfigs = collectorsItem_extendConfigs;

					resultItem_collectors.Add(collectorsItem);
				}
				resultItem.Collectors = resultItem_collectors;

				listEcsInstancesResponse_result.Add(resultItem);
			}
			listEcsInstancesResponse.Result = listEcsInstancesResponse_result;
        
			return listEcsInstancesResponse;
        }
    }
}
