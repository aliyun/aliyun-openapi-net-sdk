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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class CreateNetworkInterfaceResponseUnmarshaller
    {
        public static CreateNetworkInterfaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateNetworkInterfaceResponse createNetworkInterfaceResponse = new CreateNetworkInterfaceResponse();

			createNetworkInterfaceResponse.HttpResponse = _ctx.HttpResponse;
			createNetworkInterfaceResponse.RequestId = _ctx.StringValue("CreateNetworkInterface.RequestId");
			createNetworkInterfaceResponse.NetworkInterfaceId = _ctx.StringValue("CreateNetworkInterface.NetworkInterfaceId");
			createNetworkInterfaceResponse.Status = _ctx.StringValue("CreateNetworkInterface.Status");
			createNetworkInterfaceResponse.Type = _ctx.StringValue("CreateNetworkInterface.Type");
			createNetworkInterfaceResponse.VpcId = _ctx.StringValue("CreateNetworkInterface.VpcId");
			createNetworkInterfaceResponse.VSwitchId = _ctx.StringValue("CreateNetworkInterface.VSwitchId");
			createNetworkInterfaceResponse.ZoneId = _ctx.StringValue("CreateNetworkInterface.ZoneId");
			createNetworkInterfaceResponse.PrivateIpAddress = _ctx.StringValue("CreateNetworkInterface.PrivateIpAddress");
			createNetworkInterfaceResponse.MacAddress = _ctx.StringValue("CreateNetworkInterface.MacAddress");
			createNetworkInterfaceResponse.NetworkInterfaceName = _ctx.StringValue("CreateNetworkInterface.NetworkInterfaceName");
			createNetworkInterfaceResponse.Description = _ctx.StringValue("CreateNetworkInterface.Description");
			createNetworkInterfaceResponse.ResourceGroupId = _ctx.StringValue("CreateNetworkInterface.ResourceGroupId");
			createNetworkInterfaceResponse.ServiceID = _ctx.LongValue("CreateNetworkInterface.ServiceID");
			createNetworkInterfaceResponse.ServiceManaged = _ctx.BooleanValue("CreateNetworkInterface.ServiceManaged");
			createNetworkInterfaceResponse.OwnerId = _ctx.StringValue("CreateNetworkInterface.OwnerId");

			List<string> createNetworkInterfaceResponse_securityGroupIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateNetworkInterface.SecurityGroupIds.Length"); i++) {
				createNetworkInterfaceResponse_securityGroupIds.Add(_ctx.StringValue("CreateNetworkInterface.SecurityGroupIds["+ i +"]"));
			}
			createNetworkInterfaceResponse.SecurityGroupIds = createNetworkInterfaceResponse_securityGroupIds;

			List<CreateNetworkInterfaceResponse.CreateNetworkInterface_PrivateIpSet> createNetworkInterfaceResponse_privateIpSets = new List<CreateNetworkInterfaceResponse.CreateNetworkInterface_PrivateIpSet>();
			for (int i = 0; i < _ctx.Length("CreateNetworkInterface.PrivateIpSets.Length"); i++) {
				CreateNetworkInterfaceResponse.CreateNetworkInterface_PrivateIpSet privateIpSet = new CreateNetworkInterfaceResponse.CreateNetworkInterface_PrivateIpSet();
				privateIpSet.PrivateIpAddress = _ctx.StringValue("CreateNetworkInterface.PrivateIpSets["+ i +"].PrivateIpAddress");
				privateIpSet.Primary = _ctx.BooleanValue("CreateNetworkInterface.PrivateIpSets["+ i +"].Primary");

				createNetworkInterfaceResponse_privateIpSets.Add(privateIpSet);
			}
			createNetworkInterfaceResponse.PrivateIpSets = createNetworkInterfaceResponse_privateIpSets;

			List<CreateNetworkInterfaceResponse.CreateNetworkInterface_Tag> createNetworkInterfaceResponse_tags = new List<CreateNetworkInterfaceResponse.CreateNetworkInterface_Tag>();
			for (int i = 0; i < _ctx.Length("CreateNetworkInterface.Tags.Length"); i++) {
				CreateNetworkInterfaceResponse.CreateNetworkInterface_Tag tag = new CreateNetworkInterfaceResponse.CreateNetworkInterface_Tag();
				tag.TagKey = _ctx.StringValue("CreateNetworkInterface.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("CreateNetworkInterface.Tags["+ i +"].TagValue");

				createNetworkInterfaceResponse_tags.Add(tag);
			}
			createNetworkInterfaceResponse.Tags = createNetworkInterfaceResponse_tags;
        
			return createNetworkInterfaceResponse;
        }
    }
}
