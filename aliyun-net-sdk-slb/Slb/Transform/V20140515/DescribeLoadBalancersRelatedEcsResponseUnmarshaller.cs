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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeLoadBalancersRelatedEcsResponseUnmarshaller
    {
        public static DescribeLoadBalancersRelatedEcsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoadBalancersRelatedEcsResponse describeLoadBalancersRelatedEcsResponse = new DescribeLoadBalancersRelatedEcsResponse();

			describeLoadBalancersRelatedEcsResponse.HttpResponse = context.HttpResponse;
			describeLoadBalancersRelatedEcsResponse.Message = context.StringValue("DescribeLoadBalancersRelatedEcs.Message");
			describeLoadBalancersRelatedEcsResponse.Success = context.BooleanValue("DescribeLoadBalancersRelatedEcs.Success");
			describeLoadBalancersRelatedEcsResponse.RequestId = context.StringValue("DescribeLoadBalancersRelatedEcs.RequestId");

			List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer> describeLoadBalancersRelatedEcsResponse_loadBalancers = new List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer>();
			for (int i = 0; i < context.Length("DescribeLoadBalancersRelatedEcs.LoadBalancers.Length"); i++) {
				DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer loadBalancer = new DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer();
				loadBalancer.LoadBalancerId = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].LoadBalancerId");
				loadBalancer.Count = context.IntegerValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].Count");

				List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup> loadBalancer_masterSlaveVServerGroups = new List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup>();
				for (int j = 0; j < context.Length("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].MasterSlaveVServerGroups.Length"); j++) {
					DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup masterSlaveVServerGroup = new DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup();
					masterSlaveVServerGroup.GroupId = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].MasterSlaveVServerGroups["+ j +"].GroupId");
					masterSlaveVServerGroup.GroupName = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].MasterSlaveVServerGroups["+ j +"].GroupName");

					List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup.DescribeLoadBalancersRelatedEcs_BackendServer> masterSlaveVServerGroup_backendServers1 = new List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup.DescribeLoadBalancersRelatedEcs_BackendServer>();
					for (int k = 0; k < context.Length("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].MasterSlaveVServerGroups["+ j +"].BackendServers.Length"); k++) {
						DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup.DescribeLoadBalancersRelatedEcs_BackendServer backendServer = new DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup.DescribeLoadBalancersRelatedEcs_BackendServer();
						backendServer.VmName = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].MasterSlaveVServerGroups["+ j +"].BackendServers["+ k +"].VmName");
						backendServer.Weight = context.IntegerValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].MasterSlaveVServerGroups["+ j +"].BackendServers["+ k +"].Weight");
						backendServer.Port = context.IntegerValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].MasterSlaveVServerGroups["+ j +"].BackendServers["+ k +"].Port");
						backendServer.NetworkType = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].MasterSlaveVServerGroups["+ j +"].BackendServers["+ k +"].NetworkType");

						masterSlaveVServerGroup_backendServers1.Add(backendServer);
					}
					masterSlaveVServerGroup.BackendServers1 = masterSlaveVServerGroup_backendServers1;

					loadBalancer_masterSlaveVServerGroups.Add(masterSlaveVServerGroup);
				}
				loadBalancer.MasterSlaveVServerGroups = loadBalancer_masterSlaveVServerGroups;

				List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_VServerGroup> loadBalancer_vServerGroups = new List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_VServerGroup>();
				for (int j = 0; j < context.Length("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].VServerGroups.Length"); j++) {
					DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_VServerGroup vServerGroup = new DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_VServerGroup();
					vServerGroup.GroupId = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].VServerGroups["+ j +"].GroupId");
					vServerGroup.GroupName = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].VServerGroups["+ j +"].GroupName");

					List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_VServerGroup.DescribeLoadBalancersRelatedEcs_BackendServer3> vServerGroup_backendServers2 = new List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_VServerGroup.DescribeLoadBalancersRelatedEcs_BackendServer3>();
					for (int k = 0; k < context.Length("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].VServerGroups["+ j +"].BackendServers.Length"); k++) {
						DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_VServerGroup.DescribeLoadBalancersRelatedEcs_BackendServer3 backendServer3 = new DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_VServerGroup.DescribeLoadBalancersRelatedEcs_BackendServer3();
						backendServer3.VmName = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].VServerGroups["+ j +"].BackendServers["+ k +"].VmName");
						backendServer3.Weight = context.IntegerValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].VServerGroups["+ j +"].BackendServers["+ k +"].Weight");
						backendServer3.Port = context.IntegerValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].VServerGroups["+ j +"].BackendServers["+ k +"].Port");
						backendServer3.NetworkType = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].VServerGroups["+ j +"].BackendServers["+ k +"].NetworkType");

						vServerGroup_backendServers2.Add(backendServer3);
					}
					vServerGroup.BackendServers2 = vServerGroup_backendServers2;

					loadBalancer_vServerGroups.Add(vServerGroup);
				}
				loadBalancer.VServerGroups = loadBalancer_vServerGroups;

				List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_BackendServer4> loadBalancer_backendServers = new List<DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_BackendServer4>();
				for (int j = 0; j < context.Length("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].BackendServers.Length"); j++) {
					DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_BackendServer4 backendServer4 = new DescribeLoadBalancersRelatedEcsResponse.DescribeLoadBalancersRelatedEcs_LoadBalancer.DescribeLoadBalancersRelatedEcs_BackendServer4();
					backendServer4.VmName = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].BackendServers["+ j +"].VmName");
					backendServer4.Weight = context.IntegerValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].BackendServers["+ j +"].Weight");
					backendServer4.Port = context.IntegerValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].BackendServers["+ j +"].Port");
					backendServer4.NetworkType = context.StringValue("DescribeLoadBalancersRelatedEcs.LoadBalancers["+ i +"].BackendServers["+ j +"].NetworkType");

					loadBalancer_backendServers.Add(backendServer4);
				}
				loadBalancer.BackendServers = loadBalancer_backendServers;

				describeLoadBalancersRelatedEcsResponse_loadBalancers.Add(loadBalancer);
			}
			describeLoadBalancersRelatedEcsResponse.LoadBalancers = describeLoadBalancersRelatedEcsResponse_loadBalancers;
        
			return describeLoadBalancersRelatedEcsResponse;
        }
    }
}