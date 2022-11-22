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
    public class DescribeDBInstanceEndpointsResponseUnmarshaller
    {
        public static DescribeDBInstanceEndpointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceEndpointsResponse describeDBInstanceEndpointsResponse = new DescribeDBInstanceEndpointsResponse();

			describeDBInstanceEndpointsResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceEndpointsResponse.RequestId = _ctx.StringValue("DescribeDBInstanceEndpoints.RequestId");

			DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data data = new DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data();
			data.DBInstanceName = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceName");
			data.IpVersion = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.IpVersion");

			List<DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint> data_dBInstanceEndpoints = new List<DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints.Length"); i++) {
				DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint dBInstanceEndpoint = new DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint();
				dBInstanceEndpoint.EndpointId = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].EndpointId");
				dBInstanceEndpoint.EndpointType = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].EndpointType");
				dBInstanceEndpoint.EndpointDescription = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].EndpointDescription");

				List<DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint.DescribeDBInstanceEndpoints_NodeItem> dBInstanceEndpoint_nodeItems = new List<DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint.DescribeDBInstanceEndpoints_NodeItem>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].NodeItems.Length"); j++) {
					DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint.DescribeDBInstanceEndpoints_NodeItem nodeItem = new DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint.DescribeDBInstanceEndpoints_NodeItem();
					nodeItem.NodeId = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].NodeItems["+ j +"].NodeId");
					nodeItem.DBInstanceId = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].NodeItems["+ j +"].DBInstanceId");
					nodeItem.Weight = _ctx.IntegerValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].NodeItems["+ j +"].Weight");

					dBInstanceEndpoint_nodeItems.Add(nodeItem);
				}
				dBInstanceEndpoint.NodeItems = dBInstanceEndpoint_nodeItems;

				List<DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint.DescribeDBInstanceEndpoints_AddressItem> dBInstanceEndpoint_addressItems = new List<DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint.DescribeDBInstanceEndpoints_AddressItem>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].AddressItems.Length"); j++) {
					DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint.DescribeDBInstanceEndpoints_AddressItem addressItem = new DescribeDBInstanceEndpointsResponse.DescribeDBInstanceEndpoints_Data.DescribeDBInstanceEndpoints_DBInstanceEndpoint.DescribeDBInstanceEndpoints_AddressItem();
					addressItem.VpcId = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].AddressItems["+ j +"].VpcId");
					addressItem.VSwitchId = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].AddressItems["+ j +"].VSwitchId");
					addressItem.IpType = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].AddressItems["+ j +"].IpType");
					addressItem.Port = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].AddressItems["+ j +"].Port");
					addressItem.ConnectionString = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].AddressItems["+ j +"].ConnectionString");
					addressItem.IpAddress = _ctx.StringValue("DescribeDBInstanceEndpoints.Data.DBInstanceEndpoints["+ i +"].AddressItems["+ j +"].IpAddress");

					dBInstanceEndpoint_addressItems.Add(addressItem);
				}
				dBInstanceEndpoint.AddressItems = dBInstanceEndpoint_addressItems;

				data_dBInstanceEndpoints.Add(dBInstanceEndpoint);
			}
			data.DBInstanceEndpoints = data_dBInstanceEndpoints;
			describeDBInstanceEndpointsResponse.Data = data;
        
			return describeDBInstanceEndpointsResponse;
        }
    }
}
