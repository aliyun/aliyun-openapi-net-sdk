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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeGlobalDatabaseNetworksResponse : AcsResponse
	{

		private int? totalRecordCount;

		private int? pageRecordCount;

		private string requestId;

		private int? pageNumber;

		private List<DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork> items;

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork
		{

			private string dBVersion;

			private string gDNId;

			private string createTime;

			private string gDNStatus;

			private string dBType;

			private string gDNDescription;

			private string zoneId;

			private List<DescribeGlobalDatabaseNetworks_DBCluster> dBClusters;

			private List<DescribeGlobalDatabaseNetworks_OutCloudDBCluster> outCloudDBClusters;

			private DescribeGlobalDatabaseNetworks_Labels labels;

			public string DBVersion
			{
				get
				{
					return dBVersion;
				}
				set	
				{
					dBVersion = value;
				}
			}

			public string GDNId
			{
				get
				{
					return gDNId;
				}
				set	
				{
					gDNId = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string GDNStatus
			{
				get
				{
					return gDNStatus;
				}
				set	
				{
					gDNStatus = value;
				}
			}

			public string DBType
			{
				get
				{
					return dBType;
				}
				set	
				{
					dBType = value;
				}
			}

			public string GDNDescription
			{
				get
				{
					return gDNDescription;
				}
				set	
				{
					gDNDescription = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public List<DescribeGlobalDatabaseNetworks_DBCluster> DBClusters
			{
				get
				{
					return dBClusters;
				}
				set	
				{
					dBClusters = value;
				}
			}

			public List<DescribeGlobalDatabaseNetworks_OutCloudDBCluster> OutCloudDBClusters
			{
				get
				{
					return outCloudDBClusters;
				}
				set	
				{
					outCloudDBClusters = value;
				}
			}

			public DescribeGlobalDatabaseNetworks_Labels Labels
			{
				get
				{
					return labels;
				}
				set	
				{
					labels = value;
				}
			}

			public class DescribeGlobalDatabaseNetworks_DBCluster
			{

				private string dBClusterId;

				private string role;

				private string regionId;

				public string DBClusterId
				{
					get
					{
						return dBClusterId;
					}
					set	
					{
						dBClusterId = value;
					}
				}

				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}
			}

			public class DescribeGlobalDatabaseNetworks_OutCloudDBCluster
			{

				private string outCloudType;

				private string dBClusterId;

				private string role;

				private string regionId;

				public string OutCloudType
				{
					get
					{
						return outCloudType;
					}
					set	
					{
						outCloudType = value;
					}
				}

				public string DBClusterId
				{
					get
					{
						return dBClusterId;
					}
					set	
					{
						dBClusterId = value;
					}
				}

				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}
			}

			public class DescribeGlobalDatabaseNetworks_Labels
			{

				private string gDNVersion;

				public string GDNVersion
				{
					get
					{
						return gDNVersion;
					}
					set	
					{
						gDNVersion = value;
					}
				}
			}
		}
	}
}
