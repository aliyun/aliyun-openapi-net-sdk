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
	public class DescribeDBInstanceAttributeResponse : AcsResponse
	{
	    public List<DBInstanceAttribute> Items { get; set; }

	    public class DBInstanceAttribute{
	        public int? InsId { get; set; }

	        public string DBInstanceId { get; set; }

	        public string PayType { get; set; }

	        public string DBInstanceClassType { get; set; }

	        public DBInstanceTypeEnum? DBInstanceType { get; set; }

	        public string RegionId { get; set; }

	        public string ConnectionString { get; set; }

	        public string Port { get; set; }

	        public string Engine { get; set; }

	        public string EngineVersion { get; set; }

	        public string DBInstanceClass { get; set; }

	        public long? DBInstanceMemory { get; set; }

	        public int? DBInstanceStorage { get; set; }

	        public DBInstanceNetTypeEnum? DBInstanceNetType { get; set; }

	        public DBInstanceStatusEnum? DBInstanceStatus { get; set; }

	        public string DBInstanceDescription { get; set; }

	        public LockModeEnum? LockMode { get; set; }

	        public string LockReason { get; set; }

	        public string ReadDelayTime { get; set; }

	        public int? DBMaxQuantity { get; set; }

	        public int? AccountMaxQuantity { get; set; }

	        public string CreationTime { get; set; }

	        public string ExpireTime { get; set; }

	        public string MaintainTime { get; set; }

	        public string AvailabilityValue { get; set; }

	        public int? MaxIops { get; set; }

	        public int? MaxConnections { get; set; }

	        public string MasterInstanceId { get; set; }

	        public string IncrementSourceDBInstanceId { get; set; }

	        public string GuardDBInstanceId { get; set; }

	        public string TempDBInstanceId { get; set; }

	        public string SecurityIpList { get; set; }

	        public string ZoneId { get; set; }

	        public string InstanceNetworkType { get; set; }

	        public AccountTypeEnum? AccountType { get; set; }

	        public SupportUpgradeAccountTypeEnum? SupportUpgradeAccountType { get; set; }

	        public string VpcId { get; set; }

	        public ConnectionModeEnum? ConnectionMode { get; set; }

	        public List<ReadOnlyDBInstanceId> ReadOnlyDBInstanceIds { get; set; }

	        public enum DBInstanceTypeEnum {
			
					Guard,
					Primary,
					Readonly,
					Temp,
			}

			public enum DBInstanceNetTypeEnum {
			
					Intranet,
					Internet,
			}

			public enum DBInstanceStatusEnum {
			
					TempDBInstanceCreating,
					Running,
					Deleting,
					DBInstanceClassChanging,
					Creating,
					GuardDBInstanceCreating,
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

			public enum LockModeEnum {
			
					LockByExpiration,
					LockByRestoration,
					LockReadInstanceByDiskQuota,
					ManualLock,
					LockByDiskQuota,
					Unlock,
			}

			public enum AccountTypeEnum {
			
					Normal,
					Super,
			}

			public enum SupportUpgradeAccountTypeEnum {
			
					Yes,
					No,
			}

			public enum ConnectionModeEnum {
			
					Standard,
					Safe,
			}

			public class ReadOnlyDBInstanceId{
			    public string DBInstanceId { get; set; }
			}
		}
	}
}