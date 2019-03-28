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
    public class DescribeInstanceTopologyResponseUnmarshaller
    {
        public static DescribeInstanceTopologyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceTopologyResponse describeInstanceTopologyResponse = new DescribeInstanceTopologyResponse();

			describeInstanceTopologyResponse.HttpResponse = context.HttpResponse;
			describeInstanceTopologyResponse.RequestId = context.StringValue("DescribeInstanceTopology.RequestId");

			List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_Topology> describeInstanceTopologyResponse_topologys = new List<DescribeInstanceTopologyResponse.DescribeInstanceTopology_Topology>();
			for (int i = 0; i < context.Length("DescribeInstanceTopology.Topologys.Length"); i++) {
				DescribeInstanceTopologyResponse.DescribeInstanceTopology_Topology topology = new DescribeInstanceTopologyResponse.DescribeInstanceTopology_Topology();
				topology.InstanceId = context.StringValue("DescribeInstanceTopology.Topologys["+ i +"].InstanceId");
				topology.HostId = context.StringValue("DescribeInstanceTopology.Topologys["+ i +"].HostId");

				describeInstanceTopologyResponse_topologys.Add(topology);
			}
			describeInstanceTopologyResponse.Topologys = describeInstanceTopologyResponse_topologys;
        
			return describeInstanceTopologyResponse;
        }
    }
}
