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
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeDeploymentSetTopologyResponseUnmarshaller
    {
        public static DescribeDeploymentSetTopologyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeploymentSetTopologyResponse describeDeploymentSetTopologyResponse = new DescribeDeploymentSetTopologyResponse();

			describeDeploymentSetTopologyResponse.HttpResponse = context.HttpResponse;
			describeDeploymentSetTopologyResponse.RequestId = context.StringValue("DescribeDeploymentSetTopology.RequestId");

			List<DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology__Switch> describeDeploymentSetTopologyResponse_switchs = new List<DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology__Switch>();
			for (int i = 0; i < context.Length("DescribeDeploymentSetTopology.Switchs.Length"); i++) {
				DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology__Switch _switch = new DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology__Switch();
				_switch.SwitchId = context.StringValue("DescribeDeploymentSetTopology.Switchs["+ i +"].SwitchId");

				List<DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology__Switch.DescribeDeploymentSetTopology_Host> _switch_hosts = new List<DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology__Switch.DescribeDeploymentSetTopology_Host>();
				for (int j = 0; j < context.Length("DescribeDeploymentSetTopology.Switchs["+ i +"].Hosts.Length"); j++) {
					DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology__Switch.DescribeDeploymentSetTopology_Host host = new DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology__Switch.DescribeDeploymentSetTopology_Host();
					host.HostId = context.StringValue("DescribeDeploymentSetTopology.Switchs["+ i +"].Hosts["+ j +"].HostId");

					List<string> host_instanceIds = new List<string>();
					for (int k = 0; k < context.Length("DescribeDeploymentSetTopology.Switchs["+ i +"].Hosts["+ j +"].InstanceIds.Length"); k++) {
						host_instanceIds.Add(context.StringValue("DescribeDeploymentSetTopology.Switchs["+ i +"].Hosts["+ j +"].InstanceIds["+ k +"]"));
					}
					host.InstanceIds = host_instanceIds;

					_switch_hosts.Add(host);
				}
				_switch.Hosts = _switch_hosts;

				describeDeploymentSetTopologyResponse_switchs.Add(_switch);
			}
			describeDeploymentSetTopologyResponse.Switchs = describeDeploymentSetTopologyResponse_switchs;

			List<DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology_Rack> describeDeploymentSetTopologyResponse_racks = new List<DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology_Rack>();
			for (int i = 0; i < context.Length("DescribeDeploymentSetTopology.Racks.Length"); i++) {
				DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology_Rack rack = new DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology_Rack();
				rack.RackId = context.StringValue("DescribeDeploymentSetTopology.Racks["+ i +"].RackId");

				List<DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology_Rack.DescribeDeploymentSetTopology_Host2> rack_hosts1 = new List<DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology_Rack.DescribeDeploymentSetTopology_Host2>();
				for (int j = 0; j < context.Length("DescribeDeploymentSetTopology.Racks["+ i +"].Hosts.Length"); j++) {
					DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology_Rack.DescribeDeploymentSetTopology_Host2 host2 = new DescribeDeploymentSetTopologyResponse.DescribeDeploymentSetTopology_Rack.DescribeDeploymentSetTopology_Host2();
					host2.HostId3 = context.StringValue("DescribeDeploymentSetTopology.Racks["+ i +"].Hosts["+ j +"].HostId");

					List<string> host2_instanceIds4 = new List<string>();
					for (int k = 0; k < context.Length("DescribeDeploymentSetTopology.Racks["+ i +"].Hosts["+ j +"].InstanceIds.Length"); k++) {
						host2_instanceIds4.Add(context.StringValue("DescribeDeploymentSetTopology.Racks["+ i +"].Hosts["+ j +"].InstanceIds["+ k +"]"));
					}
					host2.InstanceIds4 = host2_instanceIds4;

					rack_hosts1.Add(host2);
				}
				rack.Hosts1 = rack_hosts1;

				describeDeploymentSetTopologyResponse_racks.Add(rack);
			}
			describeDeploymentSetTopologyResponse.Racks = describeDeploymentSetTopologyResponse_racks;
        
			return describeDeploymentSetTopologyResponse;
        }
    }
}