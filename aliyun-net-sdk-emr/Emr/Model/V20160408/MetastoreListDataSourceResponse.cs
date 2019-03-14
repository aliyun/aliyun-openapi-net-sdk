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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class MetastoreListDataSourceResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<MetastoreListDataSource_DataSource> dataSourceList;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<MetastoreListDataSource_DataSource> DataSourceList
		{
			get
			{
				return dataSourceList;
			}
			set	
			{
				dataSourceList = value;
			}
		}

		public class MetastoreListDataSource_DataSource
		{

			private string id;

			private string name;

			private string sourceType;

			private string description;

			private string connectionInfo;

			private string clusterBizId;

			private string clusterName;

			private string userId;

			private long? gmtCreate;

			private long? gmtModified;

			private long? capacity;

			private long? usedSize;

			private List<MetastoreListDataSource_Config> configList;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string ConnectionInfo
			{
				get
				{
					return connectionInfo;
				}
				set	
				{
					connectionInfo = value;
				}
			}

			public string ClusterBizId
			{
				get
				{
					return clusterBizId;
				}
				set	
				{
					clusterBizId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public long? Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public long? UsedSize
			{
				get
				{
					return usedSize;
				}
				set	
				{
					usedSize = value;
				}
			}

			public List<MetastoreListDataSource_Config> ConfigList
			{
				get
				{
					return configList;
				}
				set	
				{
					configList = value;
				}
			}

			public class MetastoreListDataSource_Config
			{

				private string configName;

				private string _value;

				public string ConfigName
				{
					get
					{
						return configName;
					}
					set	
					{
						configName = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
