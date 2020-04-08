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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeClusterDashboardResponseUnmarshaller
    {
        public static DescribeClusterDashboardResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterDashboardResponse describeClusterDashboardResponse = new DescribeClusterDashboardResponse();

			describeClusterDashboardResponse.HttpResponse = context.HttpResponse;
			describeClusterDashboardResponse.RequestId = context.StringValue("DescribeClusterDashboard.RequestId");

			DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard dashboard = new DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard();
			dashboard.ClusterId = context.StringValue("DescribeClusterDashboard.Dashboard.ClusterId");

			List<DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard.DescribeClusterDashboard_DataCenter> dashboard_dataCenters = new List<DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard.DescribeClusterDashboard_DataCenter>();
			for (int i = 0; i < context.Length("DescribeClusterDashboard.Dashboard.DataCenters.Length"); i++) {
				DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard.DescribeClusterDashboard_DataCenter dataCenter = new DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard.DescribeClusterDashboard_DataCenter();
				dataCenter.DataCenterId = context.StringValue("DescribeClusterDashboard.Dashboard.DataCenters["+ i +"].DataCenterId");

				List<DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard.DescribeClusterDashboard_DataCenter.DescribeClusterDashboard_Node> dataCenter_nodes = new List<DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard.DescribeClusterDashboard_DataCenter.DescribeClusterDashboard_Node>();
				for (int j = 0; j < context.Length("DescribeClusterDashboard.Dashboard.DataCenters["+ i +"].Nodes.Length"); j++) {
					DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard.DescribeClusterDashboard_DataCenter.DescribeClusterDashboard_Node node = new DescribeClusterDashboardResponse.DescribeClusterDashboard_Dashboard.DescribeClusterDashboard_DataCenter.DescribeClusterDashboard_Node();
					node.Address = context.StringValue("DescribeClusterDashboard.Dashboard.DataCenters["+ i +"].Nodes["+ j +"].Address");
					node.Status = context.StringValue("DescribeClusterDashboard.Dashboard.DataCenters["+ i +"].Nodes["+ j +"].Status");
					node.Load = context.StringValue("DescribeClusterDashboard.Dashboard.DataCenters["+ i +"].Nodes["+ j +"].Load");

					dataCenter_nodes.Add(node);
				}
				dataCenter.Nodes = dataCenter_nodes;

				dashboard_dataCenters.Add(dataCenter);
			}
			dashboard.DataCenters = dashboard_dataCenters;
			describeClusterDashboardResponse.Dashboard = dashboard;
        
			return describeClusterDashboardResponse;
        }
    }
}
