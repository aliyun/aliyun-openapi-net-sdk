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
        public static ListEcsInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListEcsInstancesResponse listEcsInstancesResponse = new ListEcsInstancesResponse();

			listEcsInstancesResponse.HttpResponse = context.HttpResponse;
			listEcsInstancesResponse.RequestId = context.StringValue("ListEcsInstances.RequestId");

			ListEcsInstancesResponse.ListEcsInstances_Headers headers = new ListEcsInstancesResponse.ListEcsInstances_Headers();
			headers.XTotalCount = context.IntegerValue("ListEcsInstances.Headers.X-Total-Count");
			listEcsInstancesResponse.Headers = headers;

			List<ListEcsInstancesResponse.ListEcsInstances_ResultItem> listEcsInstancesResponse_result = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem>();
			for (int i = 0; i < context.Length("ListEcsInstances.Result.Length"); i++) {
				ListEcsInstancesResponse.ListEcsInstances_ResultItem resultItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem();
				resultItem.EcsInstanceId = context.StringValue("ListEcsInstances.Result["+ i +"].ecsInstanceId");
				resultItem.EcsInstanceName = context.StringValue("ListEcsInstances.Result["+ i +"].ecsInstanceName");
				resultItem.Status = context.StringValue("ListEcsInstances.Result["+ i +"].status");
				resultItem.Tags = context.StringValue("ListEcsInstances.Result["+ i +"].tags");
				resultItem.OsType = context.StringValue("ListEcsInstances.Result["+ i +"].osType");
				resultItem.CloudAssistantStatus = context.StringValue("ListEcsInstances.Result["+ i +"].cloudAssistantStatus");

				List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_IpAddressItem> resultItem_ipAddress = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_IpAddressItem>();
				for (int j = 0; j < context.Length("ListEcsInstances.Result["+ i +"].IpAddress.Length"); j++) {
					ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_IpAddressItem ipAddressItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_IpAddressItem();
					ipAddressItem.Host = context.StringValue("ListEcsInstances.Result["+ i +"].IpAddress["+ j +"].host");
					ipAddressItem.IpType = context.StringValue("ListEcsInstances.Result["+ i +"].IpAddress["+ j +"].ipType");

					resultItem_ipAddress.Add(ipAddressItem);
				}
				resultItem.IpAddress = resultItem_ipAddress;

				List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem> resultItem_collectors = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem>();
				for (int j = 0; j < context.Length("ListEcsInstances.Result["+ i +"].Collectors.Length"); j++) {
					ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem collectorsItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem();
					collectorsItem.GmtCreatedTime = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].gmtCreatedTime");
					collectorsItem.GmtUpdateTime = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].gmtUpdateTime");
					collectorsItem.Name = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].name");
					collectorsItem.ResId = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].resId");
					collectorsItem.ResVersion = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].resVersion");
					collectorsItem.VpcId = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].vpcId");
					collectorsItem.ResType = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].resType");
					collectorsItem.OwnerId = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ownerId");
					collectorsItem.Status = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].status");
					collectorsItem.DryRun = context.BooleanValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].dryRun");

					List<string> collectorsItem_collectorPaths = new List<string>();
					for (int k = 0; k < context.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].CollectorPaths.Length"); k++) {
						collectorsItem_collectorPaths.Add(context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].CollectorPaths["+ k +"]"));
					}
					collectorsItem.CollectorPaths = collectorsItem_collectorPaths;

					List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ConfigsItem> collectorsItem_configs = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ConfigsItem>();
					for (int k = 0; k < context.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].Configs.Length"); k++) {
						ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ConfigsItem configsItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ConfigsItem();
						configsItem.FileName = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].Configs["+ k +"].fileName");
						configsItem.Content = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].Configs["+ k +"].content");

						collectorsItem_configs.Add(configsItem);
					}
					collectorsItem.Configs = collectorsItem_configs;

					List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem> collectorsItem_extendConfigs = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem>();
					for (int k = 0; k < context.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs.Length"); k++) {
						ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem extendConfigsItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem();
						extendConfigsItem.ConfigType = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].configType");
						extendConfigsItem.InstanceId = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].instanceId");
						extendConfigsItem.InstanceType = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].instanceType");
						extendConfigsItem.Protocol = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].protocol");
						extendConfigsItem.UserName = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].userName");
						extendConfigsItem.EnableMonitoring = context.BooleanValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].enableMonitoring");
						extendConfigsItem.Type = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].type");
						extendConfigsItem.GroupId = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].groupId");

						List<string> extendConfigsItem_hosts = new List<string>();
						for (int l = 0; l < context.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Hosts.Length"); l++) {
							extendConfigsItem_hosts.Add(context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Hosts["+ l +"]"));
						}
						extendConfigsItem.Hosts = extendConfigsItem_hosts;

						List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem.ListEcsInstances_MachinesItem> extendConfigsItem_machines = new List<ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem.ListEcsInstances_MachinesItem>();
						for (int l = 0; l < context.Length("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Machines.Length"); l++) {
							ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem.ListEcsInstances_MachinesItem machinesItem = new ListEcsInstancesResponse.ListEcsInstances_ResultItem.ListEcsInstances_CollectorsItem.ListEcsInstances_ExtendConfigsItem.ListEcsInstances_MachinesItem();
							machinesItem.InstanceId = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Machines["+ l +"].instanceId");
							machinesItem.AgentStatus = context.StringValue("ListEcsInstances.Result["+ i +"].Collectors["+ j +"].ExtendConfigs["+ k +"].Machines["+ l +"].agentStatus");

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
