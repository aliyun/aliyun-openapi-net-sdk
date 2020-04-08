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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Cassandra.Model.V20190101
{
	public class DescribeClusterDashboardResponse : AcsResponse
	{

		private string requestId;

		private DescribeClusterDashboard_Dashboard dashboard;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public DescribeClusterDashboard_Dashboard Dashboard
		{
			get
			{
				return dashboard;
			}
			set	
			{
				dashboard = value;
			}
		}

		public class DescribeClusterDashboard_Dashboard
		{

			private string clusterId;

			private List<DescribeClusterDashboard_DataCenter> dataCenters;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public List<DescribeClusterDashboard_DataCenter> DataCenters
			{
				get
				{
					return dataCenters;
				}
				set	
				{
					dataCenters = value;
				}
			}

			public class DescribeClusterDashboard_DataCenter
			{

				private string dataCenterId;

				private List<DescribeClusterDashboard_Node> nodes;

				public string DataCenterId
				{
					get
					{
						return dataCenterId;
					}
					set	
					{
						dataCenterId = value;
					}
				}

				public List<DescribeClusterDashboard_Node> Nodes
				{
					get
					{
						return nodes;
					}
					set	
					{
						nodes = value;
					}
				}

				public class DescribeClusterDashboard_Node
				{

					private string address;

					private string status;

					private string load;

					public string Address
					{
						get
						{
							return address;
						}
						set	
						{
							address = value;
						}
					}

					public string Status
					{
						get
						{
							return status;
						}
						set	
						{
							status = value;
						}
					}

					public string Load
					{
						get
						{
							return load;
						}
						set	
						{
							load = value;
						}
					}
				}
			}
		}
	}
}
