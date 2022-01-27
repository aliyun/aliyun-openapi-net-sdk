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
    public class DescribeInstanceRamRoleResponseUnmarshaller
    {
        public static DescribeInstanceRamRoleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceRamRoleResponse describeInstanceRamRoleResponse = new DescribeInstanceRamRoleResponse();

			describeInstanceRamRoleResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceRamRoleResponse.RequestId = _ctx.StringValue("DescribeInstanceRamRole.RequestId");
			describeInstanceRamRoleResponse.TotalCount = _ctx.IntegerValue("DescribeInstanceRamRole.TotalCount");
			describeInstanceRamRoleResponse.RegionId = _ctx.StringValue("DescribeInstanceRamRole.RegionId");

			List<DescribeInstanceRamRoleResponse.DescribeInstanceRamRole_InstanceRamRoleSet> describeInstanceRamRoleResponse_instanceRamRoleSets = new List<DescribeInstanceRamRoleResponse.DescribeInstanceRamRole_InstanceRamRoleSet>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceRamRole.InstanceRamRoleSets.Length"); i++) {
				DescribeInstanceRamRoleResponse.DescribeInstanceRamRole_InstanceRamRoleSet instanceRamRoleSet = new DescribeInstanceRamRoleResponse.DescribeInstanceRamRole_InstanceRamRoleSet();
				instanceRamRoleSet.RamRoleName = _ctx.StringValue("DescribeInstanceRamRole.InstanceRamRoleSets["+ i +"].RamRoleName");
				instanceRamRoleSet.InstanceId = _ctx.StringValue("DescribeInstanceRamRole.InstanceRamRoleSets["+ i +"].InstanceId");

				describeInstanceRamRoleResponse_instanceRamRoleSets.Add(instanceRamRoleSet);
			}
			describeInstanceRamRoleResponse.InstanceRamRoleSets = describeInstanceRamRoleResponse_instanceRamRoleSets;
        
			return describeInstanceRamRoleResponse;
        }
    }
}
