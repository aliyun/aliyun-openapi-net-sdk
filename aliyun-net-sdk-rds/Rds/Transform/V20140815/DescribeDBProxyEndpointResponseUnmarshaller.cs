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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBProxyEndpointResponseUnmarshaller
    {
        public static DescribeDBProxyEndpointResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBProxyEndpointResponse describeDBProxyEndpointResponse = new DescribeDBProxyEndpointResponse();

			describeDBProxyEndpointResponse.HttpResponse = _ctx.HttpResponse;
			describeDBProxyEndpointResponse.DBProxyConnectStringNetType = _ctx.StringValue("DescribeDBProxyEndpoint.DBProxyConnectStringNetType");
			describeDBProxyEndpointResponse.DBProxyFeatures = _ctx.StringValue("DescribeDBProxyEndpoint.DBProxyFeatures");
			describeDBProxyEndpointResponse.RequestId = _ctx.StringValue("DescribeDBProxyEndpoint.RequestId");
			describeDBProxyEndpointResponse.ReadOnlyInstanceWeight = _ctx.StringValue("DescribeDBProxyEndpoint.ReadOnlyInstanceWeight");
			describeDBProxyEndpointResponse.ReadOnlyInstanceDistributionType = _ctx.StringValue("DescribeDBProxyEndpoint.ReadOnlyInstanceDistributionType");
			describeDBProxyEndpointResponse.ReadOnlyInstanceMaxDelayTime = _ctx.StringValue("DescribeDBProxyEndpoint.ReadOnlyInstanceMaxDelayTime");
			describeDBProxyEndpointResponse.DbProxyEndpointReadWriteMode = _ctx.StringValue("DescribeDBProxyEndpoint.DbProxyEndpointReadWriteMode");
			describeDBProxyEndpointResponse.DbProxyEndpointAliases = _ctx.StringValue("DescribeDBProxyEndpoint.DbProxyEndpointAliases");
			describeDBProxyEndpointResponse.DBProxyEndpointId = _ctx.StringValue("DescribeDBProxyEndpoint.DBProxyEndpointId");
			describeDBProxyEndpointResponse.DBProxyConnectStringPort = _ctx.StringValue("DescribeDBProxyEndpoint.DBProxyConnectStringPort");
			describeDBProxyEndpointResponse.DBProxyConnectString = _ctx.StringValue("DescribeDBProxyEndpoint.DBProxyConnectString");
			describeDBProxyEndpointResponse.DBProxyEngineType = _ctx.StringValue("DescribeDBProxyEndpoint.DBProxyEngineType");

			List<DescribeDBProxyEndpointResponse.DescribeDBProxyEndpoint_EndpointConnectItemsItem> describeDBProxyEndpointResponse_endpointConnectItems = new List<DescribeDBProxyEndpointResponse.DescribeDBProxyEndpoint_EndpointConnectItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBProxyEndpoint.EndpointConnectItems.Length"); i++) {
				DescribeDBProxyEndpointResponse.DescribeDBProxyEndpoint_EndpointConnectItemsItem endpointConnectItemsItem = new DescribeDBProxyEndpointResponse.DescribeDBProxyEndpoint_EndpointConnectItemsItem();
				endpointConnectItemsItem.DbProxyEndpointPort = _ctx.StringValue("DescribeDBProxyEndpoint.EndpointConnectItems["+ i +"].DbProxyEndpointPort");
				endpointConnectItemsItem.DbProxyEndpointConnectString = _ctx.StringValue("DescribeDBProxyEndpoint.EndpointConnectItems["+ i +"].DbProxyEndpointConnectString");
				endpointConnectItemsItem.DbProxyEndpointNetType = _ctx.StringValue("DescribeDBProxyEndpoint.EndpointConnectItems["+ i +"].DbProxyEndpointNetType");

				describeDBProxyEndpointResponse_endpointConnectItems.Add(endpointConnectItemsItem);
			}
			describeDBProxyEndpointResponse.EndpointConnectItems = describeDBProxyEndpointResponse_endpointConnectItems;
        
			return describeDBProxyEndpointResponse;
        }
    }
}
