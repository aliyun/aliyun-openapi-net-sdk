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
    public class DescribePortConnsListResponseUnmarshaller
    {
        public static DescribePortConnsListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePortConnsListResponse describePortConnsListResponse = new DescribePortConnsListResponse();

			describePortConnsListResponse.HttpResponse = _ctx.HttpResponse;
			describePortConnsListResponse.RequestId = _ctx.StringValue("DescribePortConnsList.RequestId");

			List<DescribePortConnsListResponse.DescribePortConnsList_Conn> describePortConnsListResponse_connsList = new List<DescribePortConnsListResponse.DescribePortConnsList_Conn>();
			for (int i = 0; i < _ctx.Length("DescribePortConnsList.ConnsList.Length"); i++) {
				DescribePortConnsListResponse.DescribePortConnsList_Conn conn = new DescribePortConnsListResponse.DescribePortConnsList_Conn();
				conn.Conns = _ctx.LongValue("DescribePortConnsList.ConnsList["+ i +"].Conns");
				conn.ActConns = _ctx.LongValue("DescribePortConnsList.ConnsList["+ i +"].ActConns");
				conn.InActConns = _ctx.LongValue("DescribePortConnsList.ConnsList["+ i +"].InActConns");
				conn.Cps = _ctx.LongValue("DescribePortConnsList.ConnsList["+ i +"].Cps");
				conn.Index = _ctx.LongValue("DescribePortConnsList.ConnsList["+ i +"].Index");
				conn.Time = _ctx.LongValue("DescribePortConnsList.ConnsList["+ i +"].Time");

				describePortConnsListResponse_connsList.Add(conn);
			}
			describePortConnsListResponse.ConnsList = describePortConnsListResponse_connsList;
        
			return describePortConnsListResponse;
        }
    }
}
