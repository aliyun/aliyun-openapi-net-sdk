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

			private List<DescribeGlobalDatabaseNetworks_DBCluster> dBClusters;

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
		}
	}
}
