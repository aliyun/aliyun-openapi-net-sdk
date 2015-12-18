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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsDescribeGroupAttributeResponseUnmarshaller
    {
        public static OpsDescribeGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDescribeGroupAttributeResponse opsDescribeGroupAttributeResponse = new OpsDescribeGroupAttributeResponse();

			opsDescribeGroupAttributeResponse.HttpResponse = context.HttpResponse;
			opsDescribeGroupAttributeResponse.RequestId = context.StringValue("OpsDescribeGroupAttribute.RequestId");

			List<OpsDescribeGroupAttributeResponse.GroupPermission> groupPermissions = new List<OpsDescribeGroupAttributeResponse.GroupPermission>();
			for (int i = 0; i < context.Length("OpsDescribeGroupAttribute.GroupPermissions.Length"); i++) {
				OpsDescribeGroupAttributeResponse.GroupPermission groupPermission = new OpsDescribeGroupAttributeResponse.GroupPermission();
				groupPermission.IpProtocal = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].IpProtocal");
				groupPermission.PortRange = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].PortRange");
				groupPermission.SourceGroupId = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].SourceGroupId");
				groupPermission.DestGroupId = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].DestGroupId");
				groupPermission.SourceCidrIp = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].SourceCidrIp");
				groupPermission.DestCidrIp = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].DestCidrIp");
				groupPermission.NicType = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].NicType");
				groupPermission.Policy = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].Policy");
				groupPermission.Level = context.IntegerValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].Level");
				groupPermission.SourceGroupOwnerUserAccount = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].SourceGroupOwnerUserAccount");
				groupPermission.DestGroupOwnerUserAccount = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].DestGroupOwnerUserAccount");
				groupPermission.Direction = context.StringValue("OpsDescribeGroupAttribute.GroupPermissions["+ i +"].Direction");

				groupPermissions.Add(groupPermission);
			}
			opsDescribeGroupAttributeResponse.GroupPermissions = groupPermissions;
        
			return opsDescribeGroupAttributeResponse;
        }
    }
}