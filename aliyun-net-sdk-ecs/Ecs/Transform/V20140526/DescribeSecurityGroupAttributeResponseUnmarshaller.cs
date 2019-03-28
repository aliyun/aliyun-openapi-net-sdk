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
        public static DescribeSecurityGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSecurityGroupAttributeResponse describeSecurityGroupAttributeResponse = new DescribeSecurityGroupAttributeResponse();

			describeSecurityGroupAttributeResponse.HttpResponse = context.HttpResponse;
			describeSecurityGroupAttributeResponse.RequestId = context.StringValue("DescribeSecurityGroupAttribute.RequestId");
			describeSecurityGroupAttributeResponse.RegionId = context.StringValue("DescribeSecurityGroupAttribute.RegionId");
			describeSecurityGroupAttributeResponse.SecurityGroupId = context.StringValue("DescribeSecurityGroupAttribute.SecurityGroupId");
			describeSecurityGroupAttributeResponse.Description = context.StringValue("DescribeSecurityGroupAttribute.Description");
			describeSecurityGroupAttributeResponse.SecurityGroupName = context.StringValue("DescribeSecurityGroupAttribute.SecurityGroupName");
			describeSecurityGroupAttributeResponse.VpcId = context.StringValue("DescribeSecurityGroupAttribute.VpcId");
			describeSecurityGroupAttributeResponse.InnerAccessPolicy = context.StringValue("DescribeSecurityGroupAttribute.InnerAccessPolicy");

			List<DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_Permission> describeSecurityGroupAttributeResponse_permissions = new List<DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_Permission>();
			for (int i = 0; i < context.Length("DescribeSecurityGroupAttribute.Permissions.Length"); i++) {
				DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_Permission permission = new DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_Permission();
				permission.IpProtocol = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].IpProtocol");
				permission.PortRange = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].PortRange");
				permission.SourcePortRange = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourcePortRange");
				permission.SourceGroupId = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourceGroupId");
				permission.SourceGroupName = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourceGroupName");
				permission.SourceCidrIp = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourceCidrIp");
				permission.Ipv6SourceCidrIp = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Ipv6SourceCidrIp");
				permission.Policy = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Policy");
				permission.NicType = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].NicType");
				permission.SourceGroupOwnerAccount = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].SourceGroupOwnerAccount");
				permission.DestGroupId = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestGroupId");
				permission.DestGroupName = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestGroupName");
				permission.DestCidrIp = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestCidrIp");
				permission.Ipv6DestCidrIp = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Ipv6DestCidrIp");
				permission.DestGroupOwnerAccount = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].DestGroupOwnerAccount");
				permission.Priority = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Priority");
				permission.Direction = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Direction");
				permission.Description = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].Description");
				permission.CreateTime = context.StringValue("DescribeSecurityGroupAttribute.Permissions["+ i +"].CreateTime");

				describeSecurityGroupAttributeResponse_permissions.Add(permission);
			}
			describeSecurityGroupAttributeResponse.Permissions = describeSecurityGroupAttributeResponse_permissions;
        
			return describeSecurityGroupAttributeResponse;
        }
    }
}
