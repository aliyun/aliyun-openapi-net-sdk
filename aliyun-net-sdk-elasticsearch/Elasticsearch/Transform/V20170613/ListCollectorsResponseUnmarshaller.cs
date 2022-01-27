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
    public class ListCollectorsResponseUnmarshaller
    {
        public static ListCollectorsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCollectorsResponse listCollectorsResponse = new ListCollectorsResponse();

			listCollectorsResponse.HttpResponse = _ctx.HttpResponse;
			listCollectorsResponse.RequestId = _ctx.StringValue("ListCollectors.RequestId");

			ListCollectorsResponse.ListCollectors_Headers headers = new ListCollectorsResponse.ListCollectors_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListCollectors.Headers.X-Total-Count");
			listCollectorsResponse.Headers = headers;

			List<ListCollectorsResponse.ListCollectors_ResultItem> listCollectorsResponse_result = new List<ListCollectorsResponse.ListCollectors_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListCollectors.Result.Length"); i++) {
				ListCollectorsResponse.ListCollectors_ResultItem resultItem = new ListCollectorsResponse.ListCollectors_ResultItem();
				resultItem.GmtCreatedTime = _ctx.StringValue("ListCollectors.Result["+ i +"].gmtCreatedTime");
				resultItem.GmtUpdateTime = _ctx.StringValue("ListCollectors.Result["+ i +"].gmtUpdateTime");
				resultItem.Name = _ctx.StringValue("ListCollectors.Result["+ i +"].name");
				resultItem.ResId = _ctx.StringValue("ListCollectors.Result["+ i +"].resId");
				resultItem.ResVersion = _ctx.StringValue("ListCollectors.Result["+ i +"].resVersion");
				resultItem.VpcId = _ctx.StringValue("ListCollectors.Result["+ i +"].vpcId");
				resultItem.ResType = _ctx.StringValue("ListCollectors.Result["+ i +"].resType");
				resultItem.OwnerId = _ctx.StringValue("ListCollectors.Result["+ i +"].ownerId");
				resultItem.Status = _ctx.StringValue("ListCollectors.Result["+ i +"].status");
				resultItem.DryRun = _ctx.BooleanValue("ListCollectors.Result["+ i +"].dryRun");

				List<string> resultItem_collectorPaths = new List<string>();
				for (int j = 0; j < _ctx.Length("ListCollectors.Result["+ i +"].CollectorPaths.Length"); j++) {
					resultItem_collectorPaths.Add(_ctx.StringValue("ListCollectors.Result["+ i +"].CollectorPaths["+ j +"]"));
				}
				resultItem.CollectorPaths = resultItem_collectorPaths;

				List<ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ConfigsItem> resultItem_configs = new List<ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ConfigsItem>();
				for (int j = 0; j < _ctx.Length("ListCollectors.Result["+ i +"].Configs.Length"); j++) {
					ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ConfigsItem configsItem = new ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ConfigsItem();
					configsItem.FileName = _ctx.StringValue("ListCollectors.Result["+ i +"].Configs["+ j +"].fileName");
					configsItem.Content = _ctx.StringValue("ListCollectors.Result["+ i +"].Configs["+ j +"].content");

					resultItem_configs.Add(configsItem);
				}
				resultItem.Configs = resultItem_configs;

				List<ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ExtendConfigsItem> resultItem_extendConfigs = new List<ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ExtendConfigsItem>();
				for (int j = 0; j < _ctx.Length("ListCollectors.Result["+ i +"].ExtendConfigs.Length"); j++) {
					ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ExtendConfigsItem extendConfigsItem = new ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ExtendConfigsItem();
					extendConfigsItem.ConfigType = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].configType");
					extendConfigsItem.InstanceId = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].instanceId");
					extendConfigsItem.InstanceType = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].instanceType");
					extendConfigsItem.Protocol = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].protocol");
					extendConfigsItem.UserName = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].userName");
					extendConfigsItem.EnableMonitoring = _ctx.BooleanValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].enableMonitoring");
					extendConfigsItem.Type = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].type");
					extendConfigsItem.GroupId = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].groupId");
					extendConfigsItem.Host = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].host");
					extendConfigsItem.KibanaHost = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].kibanaHost");
					extendConfigsItem.TotalPodsCount = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].totalPodsCount");
					extendConfigsItem.SuccessPodsCount = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].successPodsCount");

					List<string> extendConfigsItem_hosts = new List<string>();
					for (int k = 0; k < _ctx.Length("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].Hosts.Length"); k++) {
						extendConfigsItem_hosts.Add(_ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].Hosts["+ k +"]"));
					}
					extendConfigsItem.Hosts = extendConfigsItem_hosts;

					List<ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ExtendConfigsItem.ListCollectors_MachinesItem> extendConfigsItem_machines = new List<ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ExtendConfigsItem.ListCollectors_MachinesItem>();
					for (int k = 0; k < _ctx.Length("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].Machines.Length"); k++) {
						ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ExtendConfigsItem.ListCollectors_MachinesItem machinesItem = new ListCollectorsResponse.ListCollectors_ResultItem.ListCollectors_ExtendConfigsItem.ListCollectors_MachinesItem();
						machinesItem.InstanceId = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].Machines["+ k +"].instanceId");
						machinesItem.AgentStatus = _ctx.StringValue("ListCollectors.Result["+ i +"].ExtendConfigs["+ j +"].Machines["+ k +"].agentStatus");

						extendConfigsItem_machines.Add(machinesItem);
					}
					extendConfigsItem.Machines = extendConfigsItem_machines;

					resultItem_extendConfigs.Add(extendConfigsItem);
				}
				resultItem.ExtendConfigs = resultItem_extendConfigs;

				listCollectorsResponse_result.Add(resultItem);
			}
			listCollectorsResponse.Result = listCollectorsResponse_result;
        
			return listCollectorsResponse;
        }
    }
}
