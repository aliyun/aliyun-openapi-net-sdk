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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeSecurityGroupAttributeResponseUnmarshaller
    {
        public static DescribeSecurityGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSecurityGroupAttributeResponse describeSecurityGroupAttributeResponse = new DescribeSecurityGroupAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeSecurityGroupAttribute.RequestId"),
                RegionId = context.StringValue("DescribeSecurityGroupAttribute.RegionId"),
                SecurityGroupId = context.StringValue("DescribeSecurityGroupAttribute.SecurityGroupId"),
                Description = context.StringValue("DescribeSecurityGroupAttribute.Description"),
                SecurityGroupName = context.StringValue("DescribeSecurityGroupAttribute.SecurityGroupName"),
                VpcId = context.StringValue("DescribeSecurityGroupAttribute.VpcId")
            };
            List<DescribeSecurityGroupAttributeResponse.Permission> permissions = new List<DescribeSecurityGroupAttributeResponse.Permission>();
			for (int i = 0; i < context.Length("DescribeSecurityGroupAttribute.Permissions.Length"); i++) {
                DescribeSecurityGroupAttributeResponse.Permission permission = new DescribeSecurityGroupAttributeResponse.Permission()
                {
                    IpProtocol = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].IpProtocol"),
                    PortRange = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].PortRange"),
                    SourceGroupId = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].SourceGroupId"),
                    SourceCidrIp = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].SourceCidrIp"),
                    Policy = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].Policy"),
                    NicType = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].NicType"),
                    SourceGroupOwnerAccount = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].SourceGroupOwnerAccount"),
                    DestGroupId = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].DestGroupId"),
                    DestCidrIp = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].DestCidrIp"),
                    DestGroupOwnerAccount = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].DestGroupOwnerAccount"),
                    Priority = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].Priority"),
                    Direction = context.StringValue($"DescribeSecurityGroupAttribute.Permissions[{i}].Direction")
                };
                permissions.Add(permission);
			}
			describeSecurityGroupAttributeResponse.Permissions = permissions;
        
			return describeSecurityGroupAttributeResponse;
        }
    }
}