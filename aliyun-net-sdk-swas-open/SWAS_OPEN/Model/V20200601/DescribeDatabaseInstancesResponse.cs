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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class DescribeDatabaseInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeDatabaseInstances_DatabaseInstance> databaseInstances;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "DatabaseInstances")]
		public List<DescribeDatabaseInstances_DatabaseInstance> DatabaseInstances
		{
			get
			{
				return databaseInstances;
			}
			set	
			{
				databaseInstances = value;
			}
		}

		public class DescribeDatabaseInstances_DatabaseInstance
		{

			private string regionId;

			private string databaseInstanceId;

			private string databaseInstanceName;

			private string databaseInstanceEdition;

			private string databaseVersion;

			private string cpu;

			private string memory;

			private int? storage;

			private string privateConnection;

			private string publicConnection;

			private string databaseInstanceStatus;

			private string businessStatus;

			private string creationTime;

			private string expiredTime;

			private string chargeType;

			private string superAccountName;

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "DatabaseInstanceId")]
			public string DatabaseInstanceId
			{
				get
				{
					return databaseInstanceId;
				}
				set	
				{
					databaseInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "DatabaseInstanceName")]
			public string DatabaseInstanceName
			{
				get
				{
					return databaseInstanceName;
				}
				set	
				{
					databaseInstanceName = value;
				}
			}

			[JsonProperty(PropertyName = "DatabaseInstanceEdition")]
			public string DatabaseInstanceEdition
			{
				get
				{
					return databaseInstanceEdition;
				}
				set	
				{
					databaseInstanceEdition = value;
				}
			}

			[JsonProperty(PropertyName = "DatabaseVersion")]
			public string DatabaseVersion
			{
				get
				{
					return databaseVersion;
				}
				set	
				{
					databaseVersion = value;
				}
			}

			[JsonProperty(PropertyName = "Cpu")]
			public string Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
				}
			}

			[JsonProperty(PropertyName = "Memory")]
			public string Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
				}
			}

			[JsonProperty(PropertyName = "Storage")]
			public int? Storage
			{
				get
				{
					return storage;
				}
				set	
				{
					storage = value;
				}
			}

			[JsonProperty(PropertyName = "PrivateConnection")]
			public string PrivateConnection
			{
				get
				{
					return privateConnection;
				}
				set	
				{
					privateConnection = value;
				}
			}

			[JsonProperty(PropertyName = "PublicConnection")]
			public string PublicConnection
			{
				get
				{
					return publicConnection;
				}
				set	
				{
					publicConnection = value;
				}
			}

			[JsonProperty(PropertyName = "DatabaseInstanceStatus")]
			public string DatabaseInstanceStatus
			{
				get
				{
					return databaseInstanceStatus;
				}
				set	
				{
					databaseInstanceStatus = value;
				}
			}

			[JsonProperty(PropertyName = "BusinessStatus")]
			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			[JsonProperty(PropertyName = "CreationTime")]
			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			[JsonProperty(PropertyName = "ExpiredTime")]
			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			[JsonProperty(PropertyName = "ChargeType")]
			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			[JsonProperty(PropertyName = "SuperAccountName")]
			public string SuperAccountName
			{
				get
				{
					return superAccountName;
				}
				set	
				{
					superAccountName = value;
				}
			}
		}
	}
}
