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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDBClusterNetInfoResponseUnmarshaller
    {
        public static DescribeDBClusterNetInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterNetInfoResponse describeDBClusterNetInfoResponse = new DescribeDBClusterNetInfoResponse();

			describeDBClusterNetInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterNetInfoResponse.RequestId = _ctx.StringValue("DescribeDBClusterNetInfo.RequestId");
			describeDBClusterNetInfoResponse.ClusterNetworkType = _ctx.StringValue("DescribeDBClusterNetInfo.ClusterNetworkType");

			List<DescribeDBClusterNetInfoResponse.DescribeDBClusterNetInfo_Address> describeDBClusterNetInfoResponse_items = new List<DescribeDBClusterNetInfoResponse.DescribeDBClusterNetInfo_Address>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterNetInfo.Items.Length"); i++) {
				DescribeDBClusterNetInfoResponse.DescribeDBClusterNetInfo_Address address = new DescribeDBClusterNetInfoResponse.DescribeDBClusterNetInfo_Address();
				address.ConnectionString = _ctx.StringValue("DescribeDBClusterNetInfo.Items["+ i +"].ConnectionString");
				address.IPAddress = _ctx.StringValue("DescribeDBClusterNetInfo.Items["+ i +"].IPAddress");
				address.NetType = _ctx.StringValue("DescribeDBClusterNetInfo.Items["+ i +"].NetType");
				address.Port = _ctx.StringValue("DescribeDBClusterNetInfo.Items["+ i +"].Port");
				address.VPCId = _ctx.StringValue("DescribeDBClusterNetInfo.Items["+ i +"].VPCId");
				address.VSwitchId = _ctx.StringValue("DescribeDBClusterNetInfo.Items["+ i +"].VSwitchId");

				describeDBClusterNetInfoResponse_items.Add(address);
			}
			describeDBClusterNetInfoResponse.Items = describeDBClusterNetInfoResponse_items;
        
			return describeDBClusterNetInfoResponse;
        }
    }
}
