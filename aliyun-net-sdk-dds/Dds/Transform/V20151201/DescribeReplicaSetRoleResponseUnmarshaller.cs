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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeReplicaSetRoleResponseUnmarshaller
    {
        public static DescribeReplicaSetRoleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeReplicaSetRoleResponse describeReplicaSetRoleResponse = new DescribeReplicaSetRoleResponse();

			describeReplicaSetRoleResponse.HttpResponse = _ctx.HttpResponse;
			describeReplicaSetRoleResponse.RequestId = _ctx.StringValue("DescribeReplicaSetRole.RequestId");
			describeReplicaSetRoleResponse.DBInstanceId = _ctx.StringValue("DescribeReplicaSetRole.DBInstanceId");

			List<DescribeReplicaSetRoleResponse.DescribeReplicaSetRole_ReplicaSet> describeReplicaSetRoleResponse_replicaSets = new List<DescribeReplicaSetRoleResponse.DescribeReplicaSetRole_ReplicaSet>();
			for (int i = 0; i < _ctx.Length("DescribeReplicaSetRole.ReplicaSets.Length"); i++) {
				DescribeReplicaSetRoleResponse.DescribeReplicaSetRole_ReplicaSet replicaSet = new DescribeReplicaSetRoleResponse.DescribeReplicaSetRole_ReplicaSet();
				replicaSet.ReplicaSetRole = _ctx.StringValue("DescribeReplicaSetRole.ReplicaSets["+ i +"].ReplicaSetRole");
				replicaSet.RoleId = _ctx.StringValue("DescribeReplicaSetRole.ReplicaSets["+ i +"].RoleId");
				replicaSet.ConnectionDomain = _ctx.StringValue("DescribeReplicaSetRole.ReplicaSets["+ i +"].ConnectionDomain");
				replicaSet.ConnectionPort = _ctx.StringValue("DescribeReplicaSetRole.ReplicaSets["+ i +"].ConnectionPort");
				replicaSet.ExpiredTime = _ctx.StringValue("DescribeReplicaSetRole.ReplicaSets["+ i +"].ExpiredTime");
				replicaSet.NetworkType = _ctx.StringValue("DescribeReplicaSetRole.ReplicaSets["+ i +"].NetworkType");

				describeReplicaSetRoleResponse_replicaSets.Add(replicaSet);
			}
			describeReplicaSetRoleResponse.ReplicaSets = describeReplicaSetRoleResponse_replicaSets;
        
			return describeReplicaSetRoleResponse;
        }
    }
}
