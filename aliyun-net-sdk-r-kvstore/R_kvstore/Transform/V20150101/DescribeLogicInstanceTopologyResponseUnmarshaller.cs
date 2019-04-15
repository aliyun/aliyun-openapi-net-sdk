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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeLogicInstanceTopologyResponseUnmarshaller
    {
        public static DescribeLogicInstanceTopologyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLogicInstanceTopologyResponse describeLogicInstanceTopologyResponse = new DescribeLogicInstanceTopologyResponse();

			describeLogicInstanceTopologyResponse.HttpResponse = context.HttpResponse;
			describeLogicInstanceTopologyResponse.RequestId = context.StringValue("DescribeLogicInstanceTopology.RequestId");
			describeLogicInstanceTopologyResponse.InstanceId = context.StringValue("DescribeLogicInstanceTopology.InstanceId");

			List<DescribeLogicInstanceTopologyResponse.DescribeLogicInstanceTopology_NodeInfo> describeLogicInstanceTopologyResponse_redisProxyList = new List<DescribeLogicInstanceTopologyResponse.DescribeLogicInstanceTopology_NodeInfo>();
			for (int i = 0; i < context.Length("DescribeLogicInstanceTopology.RedisProxyList.Length"); i++) {
				DescribeLogicInstanceTopologyResponse.DescribeLogicInstanceTopology_NodeInfo nodeInfo = new DescribeLogicInstanceTopologyResponse.DescribeLogicInstanceTopology_NodeInfo();
				nodeInfo.NodeId = context.StringValue("DescribeLogicInstanceTopology.RedisProxyList["+ i +"].NodeId");
				nodeInfo.Connection = context.StringValue("DescribeLogicInstanceTopology.RedisProxyList["+ i +"].Connection");
				nodeInfo.Bandwidth = context.StringValue("DescribeLogicInstanceTopology.RedisProxyList["+ i +"].Bandwidth");
				nodeInfo.Capacity = context.StringValue("DescribeLogicInstanceTopology.RedisProxyList["+ i +"].Capacity");
				nodeInfo.NodeType = context.StringValue("DescribeLogicInstanceTopology.RedisProxyList["+ i +"].NodeType");

				describeLogicInstanceTopologyResponse_redisProxyList.Add(nodeInfo);
			}
			describeLogicInstanceTopologyResponse.RedisProxyList = describeLogicInstanceTopologyResponse_redisProxyList;

			List<DescribeLogicInstanceTopologyResponse.DescribeLogicInstanceTopology_NodeInfo> describeLogicInstanceTopologyResponse_redisShardList = new List<DescribeLogicInstanceTopologyResponse.DescribeLogicInstanceTopology_NodeInfo>();
			for (int i = 0; i < context.Length("DescribeLogicInstanceTopology.RedisShardList.Length"); i++) {
				DescribeLogicInstanceTopologyResponse.DescribeLogicInstanceTopology_NodeInfo nodeInfo = new DescribeLogicInstanceTopologyResponse.DescribeLogicInstanceTopology_NodeInfo();
				nodeInfo.NodeId = context.StringValue("DescribeLogicInstanceTopology.RedisShardList["+ i +"].NodeId");
				nodeInfo.Connection = context.StringValue("DescribeLogicInstanceTopology.RedisShardList["+ i +"].Connection");
				nodeInfo.Bandwidth = context.StringValue("DescribeLogicInstanceTopology.RedisShardList["+ i +"].Bandwidth");
				nodeInfo.Capacity = context.StringValue("DescribeLogicInstanceTopology.RedisShardList["+ i +"].Capacity");
				nodeInfo.NodeType = context.StringValue("DescribeLogicInstanceTopology.RedisShardList["+ i +"].NodeType");

				describeLogicInstanceTopologyResponse_redisShardList.Add(nodeInfo);
			}
			describeLogicInstanceTopologyResponse.RedisShardList = describeLogicInstanceTopologyResponse_redisShardList;
        
			return describeLogicInstanceTopologyResponse;
        }
    }
}
