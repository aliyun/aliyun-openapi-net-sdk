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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeLoghubDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeLoghubDetail_LoghubInfo loghubInfo;

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

		public DescribeLoghubDetail_LoghubInfo LoghubInfo
		{
			get
			{
				return loghubInfo;
			}
			set	
			{
				loghubInfo = value;
			}
		}

		public class DescribeLoghubDetail_LoghubInfo
		{

			private string projectName;

			private string logStoreName;

			private string deliverName;

			private string deliverTime;

			private string domainUrl;

			private string description;

			private string schemaName;

			private string tableName;

			private string regionId;

			private string zoneId;

			private string userName;

			private string password;

			private bool? filterDirtyData;

			private string accessKey;

			private string accessSecret;

			private string dBType;

			private string dBClusterId;

			private List<DescribeLoghubDetail_LogHubStore> logHubStores;

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

			public string LogStoreName
			{
				get
				{
					return logStoreName;
				}
				set	
				{
					logStoreName = value;
				}
			}

			public string DeliverName
			{
				get
				{
					return deliverName;
				}
				set	
				{
					deliverName = value;
				}
			}

			public string DeliverTime
			{
				get
				{
					return deliverTime;
				}
				set	
				{
					deliverTime = value;
				}
			}

			public string DomainUrl
			{
				get
				{
					return domainUrl;
				}
				set	
				{
					domainUrl = value;
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

			public string SchemaName
			{
				get
				{
					return schemaName;
				}
				set	
				{
					schemaName = value;
				}
			}

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
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

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
				}
			}

			public bool? FilterDirtyData
			{
				get
				{
					return filterDirtyData;
				}
				set	
				{
					filterDirtyData = value;
				}
			}

			public string AccessKey
			{
				get
				{
					return accessKey;
				}
				set	
				{
					accessKey = value;
				}
			}

			public string AccessSecret
			{
				get
				{
					return accessSecret;
				}
				set	
				{
					accessSecret = value;
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

			public List<DescribeLoghubDetail_LogHubStore> LogHubStores
			{
				get
				{
					return logHubStores;
				}
				set	
				{
					logHubStores = value;
				}
			}

			public class DescribeLoghubDetail_LogHubStore
			{

				private string logKey;

				private string fieldKey;

				private string type;

				public string LogKey
				{
					get
					{
						return logKey;
					}
					set	
					{
						logKey = value;
					}
				}

				public string FieldKey
				{
					get
					{
						return fieldKey;
					}
					set	
					{
						fieldKey = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}
			}
		}
	}
}
