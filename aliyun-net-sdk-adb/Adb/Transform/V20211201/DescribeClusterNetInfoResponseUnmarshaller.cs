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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeClusterNetInfoResponseUnmarshaller
    {
        public static DescribeClusterNetInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterNetInfoResponse describeClusterNetInfoResponse = new DescribeClusterNetInfoResponse();

			describeClusterNetInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterNetInfoResponse.ClusterNetworkType = _ctx.StringValue("DescribeClusterNetInfo.ClusterNetworkType");
			describeClusterNetInfoResponse.RequestId = _ctx.StringValue("DescribeClusterNetInfo.RequestId");

			List<DescribeClusterNetInfoResponse.DescribeClusterNetInfo_Address> describeClusterNetInfoResponse_items = new List<DescribeClusterNetInfoResponse.DescribeClusterNetInfo_Address>();
			for (int i = 0; i < _ctx.Length("DescribeClusterNetInfo.Items.Length"); i++) {
				DescribeClusterNetInfoResponse.DescribeClusterNetInfo_Address address = new DescribeClusterNetInfoResponse.DescribeClusterNetInfo_Address();
				address.VSwitchId = _ctx.StringValue("DescribeClusterNetInfo.Items["+ i +"].VSwitchId");
				address.ConnectionString = _ctx.StringValue("DescribeClusterNetInfo.Items["+ i +"].ConnectionString");
				address.NetType = _ctx.StringValue("DescribeClusterNetInfo.Items["+ i +"].NetType");
				address.Port = _ctx.StringValue("DescribeClusterNetInfo.Items["+ i +"].Port");
				address.VPCId = _ctx.StringValue("DescribeClusterNetInfo.Items["+ i +"].VPCId");
				address.IPAddress = _ctx.StringValue("DescribeClusterNetInfo.Items["+ i +"].IPAddress");
				address.ConnectionStringPrefix = _ctx.StringValue("DescribeClusterNetInfo.Items["+ i +"].ConnectionStringPrefix");

				describeClusterNetInfoResponse_items.Add(address);
			}
			describeClusterNetInfoResponse.Items = describeClusterNetInfoResponse_items;
        
			return describeClusterNetInfoResponse;
        }
    }
}
