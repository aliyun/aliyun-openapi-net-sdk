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
    public class DescribeSecurityGroupAttributeResponseUnmarshaller
    {
        public static DescribeSecurityGroupAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecurityGroupAttributeResponse describeSecurityGroupAttributeResponse = new DescribeSecurityGroupAttributeResponse();

			describeSecurityGroupAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeSecurityGroupAttributeResponse.VpcId = _ctx.StringValue("DescribeSecurityGroupAttribute.VpcId");
			describeSecurityGroupAttributeResponse.RequestId = _ctx.StringValue("DescribeSecurityGroupAttribute.RequestId");
			describeSecurityGroupAttributeResponse.InnerAccessPolicy = _ctx.StringValue("DescribeSecurityGroupAttribute.InnerAccessPolicy");
			describeSecurityGroupAttributeResponse.Description = _ctx.StringValue("DescribeSecurityGroupAttribute.Description");
			describeSecurityGroupAttributeResponse.SecurityGroupId = _ctx.StringValue("DescribeSecurityGroupAttribute.SecurityGroupId");
			describeSecurityGroupAttributeResponse.SecurityGroupName = _ctx.StringValue("DescribeSecurityGroupAttribute.SecurityGroupName");
			describeSecurityGroupAttributeResponse.RegionId = _ctx.StringValue("DescribeSecurityGroupAttribute.RegionId");

			List<DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_Permission> describeSecurityGroupAttributeResponse_permissions = new List<DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_Permission>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityGroupAttribute.Permissions.Length"); i++) {
				DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_Permission permission = new DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_Permission();
				permission.Direction = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Direction");
				permission.SourceGroupId = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourceGroupId");
				permission.DestGroupOwnerAccount = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestGroupOwnerAccount");
				permission.DestPrefixListId = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestPrefixListId");
				permission.DestPrefixListName = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestPrefixListName");
				permission.SourceCidrIp = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourceCidrIp");
				permission.Ipv6DestCidrIp = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Ipv6DestCidrIp");
				permission.CreateTime = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].CreateTime");
				permission.Ipv6SourceCidrIp = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Ipv6SourceCidrIp");
				permission.DestGroupId = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestGroupId");
				permission.DestCidrIp = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestCidrIp");
				permission.IpProtocol = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].IpProtocol");
				permission.Priority = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Priority");
				permission.DestGroupName = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestGroupName");
				permission.NicType = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].NicType");
				permission.Policy = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Policy");
				permission.Description = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Description");
				permission.PortRange = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].PortRange");
				permission.SourcePrefixListName = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourcePrefixListName");
				permission.SourcePrefixListId = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourcePrefixListId");
				permission.SourceGroupOwnerAccount = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourceGroupOwnerAccount");
				permission.SourceGroupName = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourceGroupName");
				permission.SourcePortRange = _ctx.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourcePortRange");

				describeSecurityGroupAttributeResponse_permissions.Add(permission);
			}
			describeSecurityGroupAttributeResponse.Permissions = describeSecurityGroupAttributeResponse_permissions;
        
			return describeSecurityGroupAttributeResponse;
        }
    }
}
