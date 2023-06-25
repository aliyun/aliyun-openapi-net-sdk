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
using Aliyun.Acs.ddosbgp.Model.V20180720;

namespace Aliyun.Acs.ddosbgp.Transform.V20180720
{
    public class DescribeTrafficResponseUnmarshaller
    {
        public static DescribeTrafficResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTrafficResponse describeTrafficResponse = new DescribeTrafficResponse();

			describeTrafficResponse.HttpResponse = _ctx.HttpResponse;
			describeTrafficResponse.RequestId = _ctx.StringValue("DescribeTraffic.RequestId");

			List<DescribeTrafficResponse.DescribeTraffic_Flow> describeTrafficResponse_flowList = new List<DescribeTrafficResponse.DescribeTraffic_Flow>();
			for (int i = 0; i < _ctx.Length("DescribeTraffic.FlowList.Length"); i++) {
				DescribeTrafficResponse.DescribeTraffic_Flow flow = new DescribeTrafficResponse.DescribeTraffic_Flow();
				flow.Time = _ctx.IntegerValue("DescribeTraffic.FlowList["+ i +"].Time");
				flow.FlowType = _ctx.StringValue("DescribeTraffic.FlowList["+ i +"].FlowType");
				flow.AttackPps = _ctx.LongValue("DescribeTraffic.FlowList["+ i +"].AttackPps");
				flow.Name = _ctx.StringValue("DescribeTraffic.FlowList["+ i +"].Name");
				flow.Pps = _ctx.IntegerValue("DescribeTraffic.FlowList["+ i +"].Pps");
				flow.Kbps = _ctx.IntegerValue("DescribeTraffic.FlowList["+ i +"].Kbps");
				flow.AttackBps = _ctx.LongValue("DescribeTraffic.FlowList["+ i +"].AttackBps");

				describeTrafficResponse_flowList.Add(flow);
			}
			describeTrafficResponse.FlowList = describeTrafficResponse_flowList;
        
			return describeTrafficResponse;
        }
    }
}
