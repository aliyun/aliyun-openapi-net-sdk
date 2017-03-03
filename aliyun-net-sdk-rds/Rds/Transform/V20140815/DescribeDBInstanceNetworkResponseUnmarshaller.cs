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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceNetworkResponseUnmarshaller
    {
        public static DescribeDBInstanceNetworkResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceNetworkResponse describeDBInstanceNetworkResponse = new DescribeDBInstanceNetworkResponse();

			describeDBInstanceNetworkResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceNetworkResponse.RequestId = context.StringValue("DescribeDBInstanceNetwork.RequestId");
			describeDBInstanceNetworkResponse.DBInstanceId = context.StringValue("DescribeDBInstanceNetwork.DBInstanceId");
			describeDBInstanceNetworkResponse.StartTime = context.StringValue("DescribeDBInstanceNetwork.StartTime");
			describeDBInstanceNetworkResponse.EndTime = context.StringValue("DescribeDBInstanceNetwork.EndTime");

			List<DescribeDBInstanceNetworkResponse.Topology> topologys = new List<DescribeDBInstanceNetworkResponse.Topology>();
			for (int i = 0; i < context.Length("DescribeDBInstanceNetwork.Topologys.Length"); i++) {
				DescribeDBInstanceNetworkResponse.Topology topology = new DescribeDBInstanceNetworkResponse.Topology();
				topology.StartPoint = context.StringValue("DescribeDBInstanceNetwork.Topologys["+ i +"].StartPoint");
				topology.EndPoint = context.StringValue("DescribeDBInstanceNetwork.Topologys["+ i +"].EndPoint");
				topology.NetworkTrafficIn = context.StringValue("DescribeDBInstanceNetwork.Topologys["+ i +"].NetworkTrafficIn");
				topology.NetworkTrafficOut = context.StringValue("DescribeDBInstanceNetwork.Topologys["+ i +"].NetworkTrafficOut");
				topology.NetworkLatency = context.StringValue("DescribeDBInstanceNetwork.Topologys["+ i +"].NetworkLatency");
				topology.BackendLatency = context.StringValue("DescribeDBInstanceNetwork.Topologys["+ i +"].BackendLatency");
				topology.NetworkErrors = context.StringValue("DescribeDBInstanceNetwork.Topologys["+ i +"].NetworkErrors");

				topologys.Add(topology);
			}
			describeDBInstanceNetworkResponse.Topologys = topologys;
        
			return describeDBInstanceNetworkResponse;
        }
    }
}