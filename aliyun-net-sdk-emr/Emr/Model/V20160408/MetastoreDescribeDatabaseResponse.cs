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
	public class MetastoreDescribeDatabaseResponse : AcsResponse
	{

		private string requestId;

		private string dbName;

		private string description;

		private string locationUri;

		private List<MetastoreDescribeDatabase_Parameter> parameters;

		private MetastoreDescribeDatabase_Database database;

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

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
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

		public string LocationUri
		{
			get
			{
				return locationUri;
			}
			set	
			{
				locationUri = value;
			}
		}

		public List<MetastoreDescribeDatabase_Parameter> Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
			}
		}

		public MetastoreDescribeDatabase_Database Database
		{
			get
			{
				return database;
			}
			set	
			{
				database = value;
			}
		}

		public class MetastoreDescribeDatabase_Parameter
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
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

		public class MetastoreDescribeDatabase_Database
		{

			private string id;

			private string clusterBizId;

			private string clusterName;

			private string databaseName;

			private string databaseType;

			private string owner;

			private string ownerType;

			private string location;

			private string status;

			private string databaseParameters;

			private long? gmtCreate;

			private long? gmtModified;

			private string dataSourceId;

			private string dataSourceType;

			private string locationType;

			private string databaseComment;

			private string projectId;

			private string projectName;

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

			public string DatabaseName
			{
				get
				{
					return databaseName;
				}
				set	
				{
					databaseName = value;
				}
			}

			public string DatabaseType
			{
				get
				{
					return databaseType;
				}
				set	
				{
					databaseType = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string OwnerType
			{
				get
				{
					return ownerType;
				}
				set	
				{
					ownerType = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
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

			public string DatabaseParameters
			{
				get
				{
					return databaseParameters;
				}
				set	
				{
					databaseParameters = value;
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

			public string DataSourceId
			{
				get
				{
					return dataSourceId;
				}
				set	
				{
					dataSourceId = value;
				}
			}

			public string DataSourceType
			{
				get
				{
					return dataSourceType;
				}
				set	
				{
					dataSourceType = value;
				}
			}

			public string LocationType
			{
				get
				{
					return locationType;
				}
				set	
				{
					locationType = value;
				}
			}

			public string DatabaseComment
			{
				get
				{
					return databaseComment;
				}
				set	
				{
					databaseComment = value;
				}
			}

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}
		}
	}
}
