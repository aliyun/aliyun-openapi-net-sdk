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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstancesResponse : AcsResponse
	{

		private int? pageNumber;

		private int? totalRecordCount;

		private int? pageRecordCount;

		private List<DBInstance> items;

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

		public List<DBInstance> Items
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

		public class DBInstance{

			private int? insId;

			private string dBInstanceId;

			private string dBInstanceDescription;

			private string payType;

			private DBInstanceTypeEnum? dBInstanceType;

			private string regionId;

			private string expireTime;

			private DBInstanceStatusEnum? dBInstanceStatus;

			private string engine;

			private DBInstanceNetTypeEnum? dBInstanceNetType;

			private ConnectionModeEnum? connectionMode;

			private LockModeEnum? lockMode;

			private string instanceNetworkType;

			private string lockReason;

			private string zoneId;

			private bool? mutriORsignle;

			private string createTime;

			private string engineVersion;

			private string guardDBInstanceId;

			private string tempDBInstanceId;

			private string masterInstanceId;

			private string vpcId;

			private List<ReadOnlyDBInstanceId> readOnlyDBInstanceIds;

			public int? InsId
			{
				get
				{
					return insId;
				}
				set	
				{
					insId = value;
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

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public DBInstanceTypeEnum? DBInstanceType
			{
				get
				{
					return dBInstanceType;
				}
				set	
				{
					dBInstanceType = value;
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

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public DBInstanceStatusEnum? DBInstanceStatus
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

			public DBInstanceNetTypeEnum? DBInstanceNetType
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

			public ConnectionModeEnum? ConnectionMode
			{
				get
				{
					return connectionMode;
				}
				set	
				{
					connectionMode = value;
				}
			}

			public LockModeEnum? LockMode
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

			public string InstanceNetworkType
			{
				get
				{
					return instanceNetworkType;
				}
				set	
				{
					instanceNetworkType = value;
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

			public bool? MutriORsignle
			{
				get
				{
					return mutriORsignle;
				}
				set	
				{
					mutriORsignle = value;
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

			public string GuardDBInstanceId
			{
				get
				{
					return guardDBInstanceId;
				}
				set	
				{
					guardDBInstanceId = value;
				}
			}

			public string TempDBInstanceId
			{
				get
				{
					return tempDBInstanceId;
				}
				set	
				{
					tempDBInstanceId = value;
				}
			}

			public string MasterInstanceId
			{
				get
				{
					return masterInstanceId;
				}
				set	
				{
					masterInstanceId = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public List<ReadOnlyDBInstanceId> ReadOnlyDBInstanceIds
			{
				get
				{
					return readOnlyDBInstanceIds;
				}
				set	
				{
					readOnlyDBInstanceIds = value;
				}
			}

public enum DBInstanceTypeEnum {

					Shared,
					Guard,
					Primary,
					Readonly,
					Temp,
}

public enum DBInstanceStatusEnum {

					TempDBInstanceCreating,
					Running,
					Deleting,
					DBInstanceClassChanging,
					Creating,
					Rebooting,
					GuardSwitching,
					LingSwitching,
					Transing,
					TransingToOthers,
					ImportingFromOthers,
					EngineVersionUpgrading,
					DBInstanceNetTypeChanging,
					Importing,
					Restoring,
}

public enum DBInstanceNetTypeEnum {

					Intranet,
					Internet,
}

public enum ConnectionModeEnum {

					Standard,
					Safe,
}

public enum LockModeEnum {

					LockByExpiration,
					LockByRestoration,
					LockReadInstanceByDiskQuota,
					ManualLock,
					LockByDiskQuota,
					Unlock,
}

			public class ReadOnlyDBInstanceId{

				private string dBInstanceId;

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
			}
		}
	}
}