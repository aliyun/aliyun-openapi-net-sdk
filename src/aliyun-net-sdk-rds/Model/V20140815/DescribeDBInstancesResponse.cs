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
	    public int? PageNumber { get; set; }

	    public int? TotalRecordCount { get; set; }

	    public int? PageRecordCount { get; set; }

	    public List<DBInstance> Items { get; set; }

	    public class DBInstance{
	        public int? InsId { get; set; }

	        public string DBInstanceId { get; set; }

	        public string DBInstanceDescription { get; set; }

	        public string PayType { get; set; }

	        public DBInstanceTypeEnum? DBInstanceType { get; set; }

	        public string RegionId { get; set; }

	        public string ExpireTime { get; set; }

	        public DBInstanceStatusEnum? DBInstanceStatus { get; set; }

	        public string Engine { get; set; }

	        public DBInstanceNetTypeEnum? DBInstanceNetType { get; set; }

	        public ConnectionModeEnum? ConnectionMode { get; set; }

	        public LockModeEnum? LockMode { get; set; }

	        public string InstanceNetworkType { get; set; }

	        public string LockReason { get; set; }

	        public string ZoneId { get; set; }

	        public bool? MutriORsignle { get; set; }

	        public string CreateTime { get; set; }

	        public string EngineVersion { get; set; }

	        public string GuardDBInstanceId { get; set; }

	        public string TempDBInstanceId { get; set; }

	        public string MasterInstanceId { get; set; }

	        public string VpcId { get; set; }

	        public List<ReadOnlyDBInstanceId> ReadOnlyDBInstanceIds { get; set; }

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
			    public string DBInstanceId { get; set; }
			}
		}
	}
}