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
        public static CreateNetworkInterfaceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateNetworkInterfaceResponse createNetworkInterfaceResponse = new CreateNetworkInterfaceResponse();

			createNetworkInterfaceResponse.HttpResponse = context.HttpResponse;
			createNetworkInterfaceResponse.RequestId = context.StringValue("CreateNetworkInterface.RequestId");
			createNetworkInterfaceResponse.NetworkInterfaceId = context.StringValue("CreateNetworkInterface.NetworkInterfaceId");
			createNetworkInterfaceResponse.Status = context.StringValue("CreateNetworkInterface.Status");
			createNetworkInterfaceResponse.Type = context.StringValue("CreateNetworkInterface.Type");
			createNetworkInterfaceResponse.VpcId = context.StringValue("CreateNetworkInterface.VpcId");
			createNetworkInterfaceResponse.VSwitchId = context.StringValue("CreateNetworkInterface.VSwitchId");
			createNetworkInterfaceResponse.ZoneId = context.StringValue("CreateNetworkInterface.ZoneId");
			createNetworkInterfaceResponse.PrivateIpAddress = context.StringValue("CreateNetworkInterface.PrivateIpAddress");
			createNetworkInterfaceResponse.MacAddress = context.StringValue("CreateNetworkInterface.MacAddress");
			createNetworkInterfaceResponse.NetworkInterfaceName = context.StringValue("CreateNetworkInterface.NetworkInterfaceName");
			createNetworkInterfaceResponse.Description = context.StringValue("CreateNetworkInterface.Description");
			createNetworkInterfaceResponse.ResourceGroupId = context.StringValue("CreateNetworkInterface.ResourceGroupId");
			createNetworkInterfaceResponse.ServiceID = context.LongValue("CreateNetworkInterface.ServiceID");
			createNetworkInterfaceResponse.ServiceManaged = context.BooleanValue("CreateNetworkInterface.ServiceManaged");
			createNetworkInterfaceResponse.OwnerId = context.StringValue("CreateNetworkInterface.OwnerId");

			List<string> createNetworkInterfaceResponse_securityGroupIds = new List<string>();
			for (int i = 0; i < context.Length("CreateNetworkInterface.SecurityGroupIds.Length"); i++) {
				createNetworkInterfaceResponse_securityGroupIds.Add(context.StringValue("CreateNetworkInterface.SecurityGroupIds["+ i +"]"));
			}
			createNetworkInterfaceResponse.SecurityGroupIds = createNetworkInterfaceResponse_securityGroupIds;

			List<CreateNetworkInterfaceResponse.CreateNetworkInterface_PrivateIpSet> createNetworkInterfaceResponse_privateIpSets = new List<CreateNetworkInterfaceResponse.CreateNetworkInterface_PrivateIpSet>();
			for (int i = 0; i < context.Length("CreateNetworkInterface.PrivateIpSets.Length"); i++) {
				CreateNetworkInterfaceResponse.CreateNetworkInterface_PrivateIpSet privateIpSet = new CreateNetworkInterfaceResponse.CreateNetworkInterface_PrivateIpSet();
				privateIpSet.PrivateIpAddress = context.StringValue("CreateNetworkInterface.PrivateIpSets["+ i +"].PrivateIpAddress");
				privateIpSet.Primary = context.BooleanValue("CreateNetworkInterface.PrivateIpSets["+ i +"].Primary");

				createNetworkInterfaceResponse_privateIpSets.Add(privateIpSet);
			}
			createNetworkInterfaceResponse.PrivateIpSets = createNetworkInterfaceResponse_privateIpSets;

			List<CreateNetworkInterfaceResponse.CreateNetworkInterface_Tag> createNetworkInterfaceResponse_tags = new List<CreateNetworkInterfaceResponse.CreateNetworkInterface_Tag>();
			for (int i = 0; i < context.Length("CreateNetworkInterface.Tags.Length"); i++) {
				CreateNetworkInterfaceResponse.CreateNetworkInterface_Tag tag = new CreateNetworkInterfaceResponse.CreateNetworkInterface_Tag();
				tag.TagKey = context.StringValue("CreateNetworkInterface.Tags["+ i +"].TagKey");
				tag.TagValue = context.StringValue("CreateNetworkInterface.Tags["+ i +"].TagValue");

				createNetworkInterfaceResponse_tags.Add(tag);
			}
			createNetworkInterfaceResponse.Tags = createNetworkInterfaceResponse_tags;
        
			return createNetworkInterfaceResponse;
        }
    }
}
