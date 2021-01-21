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
using Aliyun.Acs.Privatelink.Model.V20200415;

namespace Aliyun.Acs.Privatelink.Transform.V20200415
{
    public class ListVpcEndpointSecurityGroupsResponseUnmarshaller
    {
        public static ListVpcEndpointSecurityGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointSecurityGroupsResponse listVpcEndpointSecurityGroupsResponse = new ListVpcEndpointSecurityGroupsResponse();

			listVpcEndpointSecurityGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointSecurityGroupsResponse.MaxResults = _ctx.StringValue("ListVpcEndpointSecurityGroups.MaxResults");
			listVpcEndpointSecurityGroupsResponse.NextToken = _ctx.StringValue("ListVpcEndpointSecurityGroups.NextToken");
			listVpcEndpointSecurityGroupsResponse.RequestId = _ctx.StringValue("ListVpcEndpointSecurityGroups.RequestId");

			List<ListVpcEndpointSecurityGroupsResponse.ListVpcEndpointSecurityGroups_SecurityGroup> listVpcEndpointSecurityGroupsResponse_securityGroups = new List<ListVpcEndpointSecurityGroupsResponse.ListVpcEndpointSecurityGroups_SecurityGroup>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpointSecurityGroups.SecurityGroups.Length"); i++) {
				ListVpcEndpointSecurityGroupsResponse.ListVpcEndpointSecurityGroups_SecurityGroup securityGroup = new ListVpcEndpointSecurityGroupsResponse.ListVpcEndpointSecurityGroups_SecurityGroup();
				securityGroup.SecurityGroupId = _ctx.StringValue("ListVpcEndpointSecurityGroups.SecurityGroups["+ i +"].SecurityGroupId");

				listVpcEndpointSecurityGroupsResponse_securityGroups.Add(securityGroup);
			}
			listVpcEndpointSecurityGroupsResponse.SecurityGroups = listVpcEndpointSecurityGroupsResponse_securityGroups;
        
			return listVpcEndpointSecurityGroupsResponse;
        }
    }
}
