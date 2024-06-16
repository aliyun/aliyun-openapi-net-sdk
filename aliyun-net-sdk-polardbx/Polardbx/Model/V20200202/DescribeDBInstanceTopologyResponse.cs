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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeDBInstanceTopologyResponse : AcsResponse
	{

		private string requestId;

		private DescribeDBInstanceTopology_Data data;

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

		public DescribeDBInstanceTopology_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeDBInstanceTopology_Data
		{

			private DescribeDBInstanceTopology_LogicInstanceTopology logicInstanceTopology;

			public DescribeDBInstanceTopology_LogicInstanceTopology LogicInstanceTopology
			{
				get
				{
					return logicInstanceTopology;
				}
				set	
				{
					logicInstanceTopology = value;
				}
			}

			public class DescribeDBInstanceTopology_LogicInstanceTopology
			{

				private string dBInstanceName;

				private string dBInstanceCreateTime;

				private string maintainStartTime;

				private string maintainEndTime;

				private string lockReason;

				private int? dBInstanceStatus;

				private int? lockMode;

				private string engineVersion;

				private int? dBInstanceStorage;

				private string dBInstanceConnType;

				private string dBInstanceId;

				private string engine;

				private string dBInstanceDescription;

				private string dBInstanceStatusDescription;

				private List<DescribeDBInstanceTopology_ItemsItem> items;

				private List<DescribeDBInstanceTopology_HistoryItemsItem> historyItems;

				public string DBInstanceName
				{
					get
					{
						return dBInstanceName;
					}
					set	
					{
						dBInstanceName = value;
					}
				}

				public string DBInstanceCreateTime
				{
					get
					{
						return dBInstanceCreateTime;
					}
					set	
					{
						dBInstanceCreateTime = value;
					}
				}

				public string MaintainStartTime
				{
					get
					{
						return maintainStartTime;
					}
					set	
					{
						maintainStartTime = value;
					}
				}

				public string MaintainEndTime
				{
					get
					{
						return maintainEndTime;
					}
					set	
					{
						maintainEndTime = value;
					}
				}

				public string LockReason
				{
					get
					{
						return lockReason;
					}
					set	
					{
						lockReason = value;
					}
				}

				public int? DBInstanceStatus
				{
					get
					{
						return dBInstanceStatus;
					}
					set	
					{
						dBInstanceStatus = value;
					}
				}

				public int? LockMode
				{
					get
					{
						return lockMode;
					}
					set	
					{
						lockMode = value;
					}
				}

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

				public int? DBInstanceStorage
				{
					get
					{
						return dBInstanceStorage;
					}
					set	
					{
						dBInstanceStorage = value;
					}
				}

				public string DBInstanceConnType
				{
					get
					{
						return dBInstanceConnType;
					}
					set	
					{
						dBInstanceConnType = value;
					}
				}

				public string DBInstanceId
				{
					get
					{
						return dBInstanceId;
					}
					set	
					{
						dBInstanceId = value;
					}
				}

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

				public string DBInstanceDescription
				{
					get
					{
						return dBInstanceDescription;
					}
					set	
					{
						dBInstanceDescription = value;
					}
				}

				public string DBInstanceStatusDescription
				{
					get
					{
						return dBInstanceStatusDescription;
					}
					set	
					{
						dBInstanceStatusDescription = value;
					}
				}

				public List<DescribeDBInstanceTopology_ItemsItem> Items
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

				public List<DescribeDBInstanceTopology_HistoryItemsItem> HistoryItems
				{
					get
					{
						return historyItems;
					}
					set	
					{
						historyItems = value;
					}
				}

				public class DescribeDBInstanceTopology_ItemsItem
				{

					private string dBInstanceCreateTime;

					private string dBInstanceName;

					private string characterType;

					private string maintainStartTime;

					private long? diskSize;

					private string maintainEndTime;

					private string lockReason;

					private int? dBInstanceStatus;

					private int? lockMode;

					private string engineVersion;

					private int? dBInstanceConnType;

					private int? maxConnections;

					private string dBInstanceId;

					private string engine;

					private int? maxIops;

					private string dBInstanceDescription;

					private string dBInstanceStatusDescription;

					private string region;

					private string azone;

					private string role;

					private bool? activated;

					private string status;

					private string nodeClass;

					private string version;

					private string phyInstanceName;

					private string storageUsed;

					private List<DescribeDBInstanceTopology_ConnectionIpItem> connectionIp;

					private List<DescribeDBInstanceTopology_AoneRoleMap> azoneRoleList;

					public string DBInstanceCreateTime
					{
						get
						{
							return dBInstanceCreateTime;
						}
						set	
						{
							dBInstanceCreateTime = value;
						}
					}

					public string DBInstanceName
					{
						get
						{
							return dBInstanceName;
						}
						set	
						{
							dBInstanceName = value;
						}
					}

					public string CharacterType
					{
						get
						{
							return characterType;
						}
						set	
						{
							characterType = value;
						}
					}

					public string MaintainStartTime
					{
						get
						{
							return maintainStartTime;
						}
						set	
						{
							maintainStartTime = value;
						}
					}

					public long? DiskSize
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

					public string MaintainEndTime
					{
						get
						{
							return maintainEndTime;
						}
						set	
						{
							maintainEndTime = value;
						}
					}

					public string LockReason
					{
						get
						{
							return lockReason;
						}
						set	
						{
							lockReason = value;
						}
					}

					public int? DBInstanceStatus
					{
						get
						{
							return dBInstanceStatus;
						}
						set	
						{
							dBInstanceStatus = value;
						}
					}

					public int? LockMode
					{
						get
						{
							return lockMode;
						}
						set	
						{
							lockMode = value;
						}
					}

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

					public int? DBInstanceConnType
					{
						get
						{
							return dBInstanceConnType;
						}
						set	
						{
							dBInstanceConnType = value;
						}
					}

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

					public string DBInstanceId
					{
						get
						{
							return dBInstanceId;
						}
						set	
						{
							dBInstanceId = value;
						}
					}

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

					public string DBInstanceDescription
					{
						get
						{
							return dBInstanceDescription;
						}
						set	
						{
							dBInstanceDescription = value;
						}
					}

					public string DBInstanceStatusDescription
					{
						get
						{
							return dBInstanceStatusDescription;
						}
						set	
						{
							dBInstanceStatusDescription = value;
						}
					}

					public string Region
					{
						get
						{
							return region;
						}
						set	
						{
							region = value;
						}
					}

					public string Azone
					{
						get
						{
							return azone;
						}
						set	
						{
							azone = value;
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

					public bool? Activated
					{
						get
						{
							return activated;
						}
						set	
						{
							activated = value;
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

					public string NodeClass
					{
						get
						{
							return nodeClass;
						}
						set	
						{
							nodeClass = value;
						}
					}

					public string Version
					{
						get
						{
							return version;
						}
						set	
						{
							version = value;
						}
					}

					public string PhyInstanceName
					{
						get
						{
							return phyInstanceName;
						}
						set	
						{
							phyInstanceName = value;
						}
					}

					public string StorageUsed
					{
						get
						{
							return storageUsed;
						}
						set	
						{
							storageUsed = value;
						}
					}

					public List<DescribeDBInstanceTopology_ConnectionIpItem> ConnectionIp
					{
						get
						{
							return connectionIp;
						}
						set	
						{
							connectionIp = value;
						}
					}

					public List<DescribeDBInstanceTopology_AoneRoleMap> AzoneRoleList
					{
						get
						{
							return azoneRoleList;
						}
						set	
						{
							azoneRoleList = value;
						}
					}

					public class DescribeDBInstanceTopology_ConnectionIpItem
					{

						private string port;

						private int? dBInstanceNetType;

						private string connectionString;

						public string Port
						{
							get
							{
								return port;
							}
							set	
							{
								port = value;
							}
						}

						public int? DBInstanceNetType
						{
							get
							{
								return dBInstanceNetType;
							}
							set	
							{
								dBInstanceNetType = value;
							}
						}

						public string ConnectionString
						{
							get
							{
								return connectionString;
							}
							set	
							{
								connectionString = value;
							}
						}
					}

					public class DescribeDBInstanceTopology_AoneRoleMap
					{

						private string azone;

						private string role;

						public string Azone
						{
							get
							{
								return azone;
							}
							set	
							{
								azone = value;
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
					}
				}

				public class DescribeDBInstanceTopology_HistoryItemsItem
				{

					private string characterType;

					private string role;

					private string dBInstanceName;

					private string dBInstanceId;

					private string region;

					private string azone;

					private bool? activated;

					private string phyInstanceName;

					public string CharacterType
					{
						get
						{
							return characterType;
						}
						set	
						{
							characterType = value;
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

					public string DBInstanceName
					{
						get
						{
							return dBInstanceName;
						}
						set	
						{
							dBInstanceName = value;
						}
					}

					public string DBInstanceId
					{
						get
						{
							return dBInstanceId;
						}
						set	
						{
							dBInstanceId = value;
						}
					}

					public string Region
					{
						get
						{
							return region;
						}
						set	
						{
							region = value;
						}
					}

					public string Azone
					{
						get
						{
							return azone;
						}
						set	
						{
							azone = value;
						}
					}

					public bool? Activated
					{
						get
						{
							return activated;
						}
						set	
						{
							activated = value;
						}
					}

					public string PhyInstanceName
					{
						get
						{
							return phyInstanceName;
						}
						set	
						{
							phyInstanceName = value;
						}
					}
				}
			}
		}
	}
}
