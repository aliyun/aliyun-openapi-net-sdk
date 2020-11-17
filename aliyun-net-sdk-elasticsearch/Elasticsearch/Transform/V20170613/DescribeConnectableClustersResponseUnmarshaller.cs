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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class DescribeConnectableClustersResponseUnmarshaller
    {
        public static DescribeConnectableClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConnectableClustersResponse describeConnectableClustersResponse = new DescribeConnectableClustersResponse();

			describeConnectableClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeConnectableClustersResponse.RequestId = _ctx.StringValue("DescribeConnectableClusters.RequestId");

			List<DescribeConnectableClustersResponse.DescribeConnectableClusters_ConnectableClustersInfo> describeConnectableClustersResponse_result = new List<DescribeConnectableClustersResponse.DescribeConnectableClusters_ConnectableClustersInfo>();
			for (int i = 0; i < _ctx.Length("DescribeConnectableClusters.Result.Length"); i++) {
				DescribeConnectableClustersResponse.DescribeConnectableClusters_ConnectableClustersInfo connectableClustersInfo = new DescribeConnectableClustersResponse.DescribeConnectableClusters_ConnectableClustersInfo();
				connectableClustersInfo.Instances = _ctx.StringValue("DescribeConnectableClusters.Result["+ i +"].instances");
				connectableClustersInfo.NetworkType = _ctx.StringValue("DescribeConnectableClusters.Result["+ i +"].networkType");

				describeConnectableClustersResponse_result.Add(connectableClustersInfo);
			}
			describeConnectableClustersResponse.Result = describeConnectableClustersResponse_result;
        
			return describeConnectableClustersResponse;
        }
    }
}
