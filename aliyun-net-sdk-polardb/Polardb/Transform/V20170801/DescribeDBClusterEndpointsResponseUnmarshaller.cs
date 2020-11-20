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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterEndpointsResponseUnmarshaller
    {
        public static DescribeDBClusterEndpointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterEndpointsResponse describeDBClusterEndpointsResponse = new DescribeDBClusterEndpointsResponse();

			describeDBClusterEndpointsResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterEndpointsResponse.RequestId = _ctx.StringValue("DescribeDBClusterEndpoints.RequestId");

			List<DescribeDBClusterEndpointsResponse.DescribeDBClusterEndpoints_DBEndpoint> describeDBClusterEndpointsResponse_items = new List<DescribeDBClusterEndpointsResponse.DescribeDBClusterEndpoints_DBEndpoint>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterEndpoints.Items.Length"); i++) {
				DescribeDBClusterEndpointsResponse.DescribeDBClusterEndpoints_DBEndpoint dBEndpoint = new DescribeDBClusterEndpointsResponse.DescribeDBClusterEndpoints_DBEndpoint();
				dBEndpoint.DBEndpointId = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].DBEndpointId");
				dBEndpoint.EndpointType = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].EndpointType");
				dBEndpoint.Nodes = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].Nodes");
				dBEndpoint.ReadWriteMode = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].ReadWriteMode");
				dBEndpoint.AutoAddNewNodes = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AutoAddNewNodes");
				dBEndpoint.EndpointConfig = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].EndpointConfig");
				dBEndpoint.NodeWithRoles = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].NodeWithRoles");
				dBEndpoint.DBEndpointDescription = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].DBEndpointDescription");

				List<DescribeDBClusterEndpointsResponse.DescribeDBClusterEndpoints_DBEndpoint.DescribeDBClusterEndpoints_Address> dBEndpoint_addressItems = new List<DescribeDBClusterEndpointsResponse.DescribeDBClusterEndpoints_DBEndpoint.DescribeDBClusterEndpoints_Address>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems.Length"); j++) {
					DescribeDBClusterEndpointsResponse.DescribeDBClusterEndpoints_DBEndpoint.DescribeDBClusterEndpoints_Address address = new DescribeDBClusterEndpointsResponse.DescribeDBClusterEndpoints_DBEndpoint.DescribeDBClusterEndpoints_Address();
					address.ConnectionString = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems["+ j +"].ConnectionString");
					address.IPAddress = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems["+ j +"].IPAddress");
					address.NetType = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems["+ j +"].NetType");
					address.Port = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems["+ j +"].Port");
					address.VPCId = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems["+ j +"].VPCId");
					address.VSwitchId = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems["+ j +"].VSwitchId");
					address.VpcInstanceId = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems["+ j +"].VpcInstanceId");
					address.PrivateZoneConnectionString = _ctx.StringValue("DescribeDBClusterEndpoints.Items["+ i +"].AddressItems["+ j +"].PrivateZoneConnectionString");

					dBEndpoint_addressItems.Add(address);
				}
				dBEndpoint.AddressItems = dBEndpoint_addressItems;

				describeDBClusterEndpointsResponse_items.Add(dBEndpoint);
			}
			describeDBClusterEndpointsResponse.Items = describeDBClusterEndpointsResponse_items;
        
			return describeDBClusterEndpointsResponse;
        }
    }
}
