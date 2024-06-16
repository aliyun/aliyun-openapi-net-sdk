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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeMarketingActivityResponse : AcsResponse
	{

		private string requestId;

		private long? aliUid;

		private string regionId;

		private string bid;

		private List<DescribeMarketingActivity_ItemsItem> items;

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

		[JsonProperty(PropertyName = "AliUid")]
		public long? AliUid
		{
			get
			{
				return aliUid;
			}
			set	
			{
				aliUid = value;
			}
		}

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

		[JsonProperty(PropertyName = "Bid")]
		public string Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeMarketingActivity_ItemsItem> Items
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

		public class DescribeMarketingActivity_ItemsItem
		{

			private string instanceId;

			private string instanceName;

			private string classCode;

			private int? diskSize;

			private long? memory;

			private string cpu;

			private string category;

			private string storageType;

			private string classGroup;

			private int? maxIombps;

			private int? maxIops;

			private int? maxConnections;

			private string upgradeClassCode;

			private int? upgradeDiskSize;

			private long? upgradeMemory;

			private string upgradeCpu;

			private string upgradeCategory;

			private string upgradeStorageType;

			private string upgradeClassGroup;

			private int? upgradeMaxIombps;

			private int? upgradeMaxIops;

			private int? upgradeMaxConnections;

			private string upgradeDescContent;

			private string upgradeReferencePrice;

			private string chargeType;

			private string engine;

			private string engineVersion;

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceName")]
			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			[JsonProperty(PropertyName = "ClassCode")]
			public string ClassCode
			{
				get
				{
					return classCode;
				}
				set	
				{
					classCode = value;
				}
			}

			[JsonProperty(PropertyName = "DiskSize")]
			public int? DiskSize
			{
				get
				{
					return diskSize;
				}
				set	
				{
					diskSize = value;
				}
			}

			[JsonProperty(PropertyName = "Memory")]
			public long? Memory
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

			[JsonProperty(PropertyName = "Category")]
			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			[JsonProperty(PropertyName = "StorageType")]
			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
				}
			}

			[JsonProperty(PropertyName = "ClassGroup")]
			public string ClassGroup
			{
				get
				{
					return classGroup;
				}
				set	
				{
					classGroup = value;
				}
			}

			[JsonProperty(PropertyName = "MaxIombps")]
			public int? MaxIombps
			{
				get
				{
					return maxIombps;
				}
				set	
				{
					maxIombps = value;
				}
			}

			[JsonProperty(PropertyName = "MaxIops")]
			public int? MaxIops
			{
				get
				{
					return maxIops;
				}
				set	
				{
					maxIops = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConnections")]
			public int? MaxConnections
			{
				get
				{
					return maxConnections;
				}
				set	
				{
					maxConnections = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeClassCode")]
			public string UpgradeClassCode
			{
				get
				{
					return upgradeClassCode;
				}
				set	
				{
					upgradeClassCode = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeDiskSize")]
			public int? UpgradeDiskSize
			{
				get
				{
					return upgradeDiskSize;
				}
				set	
				{
					upgradeDiskSize = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeMemory")]
			public long? UpgradeMemory
			{
				get
				{
					return upgradeMemory;
				}
				set	
				{
					upgradeMemory = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeCpu")]
			public string UpgradeCpu
			{
				get
				{
					return upgradeCpu;
				}
				set	
				{
					upgradeCpu = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeCategory")]
			public string UpgradeCategory
			{
				get
				{
					return upgradeCategory;
				}
				set	
				{
					upgradeCategory = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeStorageType")]
			public string UpgradeStorageType
			{
				get
				{
					return upgradeStorageType;
				}
				set	
				{
					upgradeStorageType = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeClassGroup")]
			public string UpgradeClassGroup
			{
				get
				{
					return upgradeClassGroup;
				}
				set	
				{
					upgradeClassGroup = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeMaxIombps")]
			public int? UpgradeMaxIombps
			{
				get
				{
					return upgradeMaxIombps;
				}
				set	
				{
					upgradeMaxIombps = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeMaxIops")]
			public int? UpgradeMaxIops
			{
				get
				{
					return upgradeMaxIops;
				}
				set	
				{
					upgradeMaxIops = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeMaxConnections")]
			public int? UpgradeMaxConnections
			{
				get
				{
					return upgradeMaxConnections;
				}
				set	
				{
					upgradeMaxConnections = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeDescContent")]
			public string UpgradeDescContent
			{
				get
				{
					return upgradeDescContent;
				}
				set	
				{
					upgradeDescContent = value;
				}
			}

			[JsonProperty(PropertyName = "UpgradeReferencePrice")]
			public string UpgradeReferencePrice
			{
				get
				{
					return upgradeReferencePrice;
				}
				set	
				{
					upgradeReferencePrice = value;
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

			[JsonProperty(PropertyName = "Engine")]
			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			[JsonProperty(PropertyName = "EngineVersion")]
			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}
		}
	}
}
