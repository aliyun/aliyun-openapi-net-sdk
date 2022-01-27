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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribePortFlowListResponseUnmarshaller
    {
        public static DescribePortFlowListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePortFlowListResponse describePortFlowListResponse = new DescribePortFlowListResponse();

			describePortFlowListResponse.HttpResponse = _ctx.HttpResponse;
			describePortFlowListResponse.RequestId = _ctx.StringValue("DescribePortFlowList.RequestId");

			List<DescribePortFlowListResponse.DescribePortFlowList_PortFlow> describePortFlowListResponse_portFlowList = new List<DescribePortFlowListResponse.DescribePortFlowList_PortFlow>();
			for (int i = 0; i < _ctx.Length("DescribePortFlowList.PortFlowList.Length"); i++) {
				DescribePortFlowListResponse.DescribePortFlowList_PortFlow portFlow = new DescribePortFlowListResponse.DescribePortFlowList_PortFlow();
				portFlow.AttackBps = _ctx.LongValue("DescribePortFlowList.PortFlowList["+ i +"].AttackBps");
				portFlow.AttackPps = _ctx.LongValue("DescribePortFlowList.PortFlowList["+ i +"].AttackPps");
				portFlow.OutPps = _ctx.LongValue("DescribePortFlowList.PortFlowList["+ i +"].OutPps");
				portFlow.Index = _ctx.LongValue("DescribePortFlowList.PortFlowList["+ i +"].Index");
				portFlow.Time = _ctx.LongValue("DescribePortFlowList.PortFlowList["+ i +"].Time");
				portFlow.InBps = _ctx.LongValue("DescribePortFlowList.PortFlowList["+ i +"].InBps");
				portFlow.OutBps = _ctx.LongValue("DescribePortFlowList.PortFlowList["+ i +"].OutBps");
				portFlow.InPps = _ctx.LongValue("DescribePortFlowList.PortFlowList["+ i +"].InPps");
				portFlow.Region = _ctx.StringValue("DescribePortFlowList.PortFlowList["+ i +"].Region");

				describePortFlowListResponse_portFlowList.Add(portFlow);
			}
			describePortFlowListResponse.PortFlowList = describePortFlowListResponse_portFlowList;
        
			return describePortFlowListResponse;
        }
    }
}
