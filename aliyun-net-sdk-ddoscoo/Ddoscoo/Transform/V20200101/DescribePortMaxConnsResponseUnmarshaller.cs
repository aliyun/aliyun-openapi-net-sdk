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
    public class DescribePortMaxConnsResponseUnmarshaller
    {
        public static DescribePortMaxConnsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePortMaxConnsResponse describePortMaxConnsResponse = new DescribePortMaxConnsResponse();

			describePortMaxConnsResponse.HttpResponse = _ctx.HttpResponse;
			describePortMaxConnsResponse.RequestId = _ctx.StringValue("DescribePortMaxConns.RequestId");

			List<DescribePortMaxConnsResponse.DescribePortMaxConns_PortMaxConnsItem> describePortMaxConnsResponse_portMaxConns = new List<DescribePortMaxConnsResponse.DescribePortMaxConns_PortMaxConnsItem>();
			for (int i = 0; i < _ctx.Length("DescribePortMaxConns.PortMaxConns.Length"); i++) {
				DescribePortMaxConnsResponse.DescribePortMaxConns_PortMaxConnsItem portMaxConnsItem = new DescribePortMaxConnsResponse.DescribePortMaxConns_PortMaxConnsItem();
				portMaxConnsItem.Port = _ctx.StringValue("DescribePortMaxConns.PortMaxConns["+ i +"].Port");
				portMaxConnsItem.Ip = _ctx.StringValue("DescribePortMaxConns.PortMaxConns["+ i +"].Ip");
				portMaxConnsItem.Cps = _ctx.LongValue("DescribePortMaxConns.PortMaxConns["+ i +"].Cps");

				describePortMaxConnsResponse_portMaxConns.Add(portMaxConnsItem);
			}
			describePortMaxConnsResponse.PortMaxConns = describePortMaxConnsResponse_portMaxConns;
        
			return describePortMaxConnsResponse;
        }
    }
}
