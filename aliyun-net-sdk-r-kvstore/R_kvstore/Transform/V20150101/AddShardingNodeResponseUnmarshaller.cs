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
    public class AddShardingNodeResponseUnmarshaller
    {
        public static AddShardingNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddShardingNodeResponse addShardingNodeResponse = new AddShardingNodeResponse();

			addShardingNodeResponse.HttpResponse = _ctx.HttpResponse;
			addShardingNodeResponse.RequestId = _ctx.StringValue("AddShardingNode.RequestId");
			addShardingNodeResponse.OrderId = _ctx.LongValue("AddShardingNode.OrderId");
			addShardingNodeResponse.NodeId = _ctx.StringValue("AddShardingNode.NodeId");

			List<string> addShardingNodeResponse_nodeIds = new List<string>();
			for (int i = 0; i < _ctx.Length("AddShardingNode.NodeIds.Length"); i++) {
				addShardingNodeResponse_nodeIds.Add(_ctx.StringValue("AddShardingNode.NodeIds["+ i +"]"));
			}
			addShardingNodeResponse.NodeIds = addShardingNodeResponse_nodeIds;
        
			return addShardingNodeResponse;
        }
    }
}
