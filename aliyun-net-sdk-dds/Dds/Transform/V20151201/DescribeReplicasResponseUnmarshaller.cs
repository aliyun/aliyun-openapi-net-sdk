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
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeReplicasResponseUnmarshaller
    {
        public static DescribeReplicasResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReplicasResponse describeReplicasResponse = new DescribeReplicasResponse();

			describeReplicasResponse.HttpResponse = context.HttpResponse;
			describeReplicasResponse.RequestId = context.StringValue("DescribeReplicas.RequestId");
			describeReplicasResponse.PageNumber = context.StringValue("DescribeReplicas.PageNumber");
			describeReplicasResponse.TotalRecordCount = context.IntegerValue("DescribeReplicas.TotalRecordCount");
			describeReplicasResponse.PageRecordCount = context.IntegerValue("DescribeReplicas.PageRecordCount");

			List<DescribeReplicasResponse.DescribeReplicas_Items> describeReplicasResponse_replicas = new List<DescribeReplicasResponse.DescribeReplicas_Items>();
			for (int i = 0; i < context.Length("DescribeReplicas.Replicas.Length"); i++) {
				DescribeReplicasResponse.DescribeReplicas_Items items = new DescribeReplicasResponse.DescribeReplicas_Items();
				items.ReplicaId = context.StringValue("DescribeReplicas.Replicas["+ i +"].ReplicaId");
				items.ReplicaDescription = context.StringValue("DescribeReplicas.Replicas["+ i +"].ReplicaDescription");
				items.ReplicaStatus = context.StringValue("DescribeReplicas.Replicas["+ i +"].ReplicaStatus");

				List<DescribeReplicasResponse.DescribeReplicas_Items.DescribeReplicas_Items1> items_dBInstances = new List<DescribeReplicasResponse.DescribeReplicas_Items.DescribeReplicas_Items1>();
				for (int j = 0; j < context.Length("DescribeReplicas.Replicas["+ i +"].DBInstances.Length"); j++) {
					DescribeReplicasResponse.DescribeReplicas_Items.DescribeReplicas_Items1 items1 = new DescribeReplicasResponse.DescribeReplicas_Items.DescribeReplicas_Items1();
					items1.DBInstanceId = context.StringValue("DescribeReplicas.Replicas["+ i +"].DBInstances["+ j +"].DBInstanceId");
					items1.Role = context.StringValue("DescribeReplicas.Replicas["+ i +"].DBInstances["+ j +"].Role");

					items_dBInstances.Add(items1);
				}
				items.DBInstances = items_dBInstances;

				describeReplicasResponse_replicas.Add(items);
			}
			describeReplicasResponse.Replicas = describeReplicasResponse_replicas;
        
			return describeReplicasResponse;
        }
    }
}