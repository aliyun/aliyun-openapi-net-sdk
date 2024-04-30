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
	public class DescribeResourceDetailsResponse : AcsResponse
	{

		private string requestId;

		private string region;

		private string instanceStorageType;

		private long? dbInstanceStorage;

		private long? diskUsed;

		private long? backupSize;

		private string vpcId;

		private string vSwitchId;

		private string securityIPList;

		private string dbProxyInstanceName;

		private string resourceGroupId;

		private long? backupLogSize;

		private long? backupDataSize;

		private List<DescribeResourceDetails_RdsEcsSecurityGroupRelItem> rdsEcsSecurityGroupRel;

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

		[JsonProperty(PropertyName = "Region")]
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

		[JsonProperty(PropertyName = "InstanceStorageType")]
		public string InstanceStorageType
		{
			get
			{
				return instanceStorageType;
			}
			set	
			{
				instanceStorageType = value;
			}
		}

		[JsonProperty(PropertyName = "DbInstanceStorage")]
		public long? DbInstanceStorage
		{
			get
			{
				return dbInstanceStorage;
			}
			set	
			{
				dbInstanceStorage = value;
			}
		}

		[JsonProperty(PropertyName = "DiskUsed")]
		public long? DiskUsed
		{
			get
			{
				return diskUsed;
			}
			set	
			{
				diskUsed = value;
			}
		}

		[JsonProperty(PropertyName = "BackupSize")]
		public long? BackupSize
		{
			get
			{
				return backupSize;
			}
			set	
			{
				backupSize = value;
			}
		}

		[JsonProperty(PropertyName = "VpcId")]
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

		[JsonProperty(PropertyName = "VSwitchId")]
		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
			}
		}

		[JsonProperty(PropertyName = "SecurityIPList")]
		public string SecurityIPList
		{
			get
			{
				return securityIPList;
			}
			set	
			{
				securityIPList = value;
			}
		}

		[JsonProperty(PropertyName = "DbProxyInstanceName")]
		public string DbProxyInstanceName
		{
			get
			{
				return dbProxyInstanceName;
			}
			set	
			{
				dbProxyInstanceName = value;
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
			}
		}

		[JsonProperty(PropertyName = "BackupLogSize")]
		public long? BackupLogSize
		{
			get
			{
				return backupLogSize;
			}
			set	
			{
				backupLogSize = value;
			}
		}

		[JsonProperty(PropertyName = "BackupDataSize")]
		public long? BackupDataSize
		{
			get
			{
				return backupDataSize;
			}
			set	
			{
				backupDataSize = value;
			}
		}

		[JsonProperty(PropertyName = "RdsEcsSecurityGroupRel")]
		public List<DescribeResourceDetails_RdsEcsSecurityGroupRelItem> RdsEcsSecurityGroupRel
		{
			get
			{
				return rdsEcsSecurityGroupRel;
			}
			set	
			{
				rdsEcsSecurityGroupRel = value;
			}
		}

		public class DescribeResourceDetails_RdsEcsSecurityGroupRelItem
		{

			private string securityGroupName;

			[JsonProperty(PropertyName = "SecurityGroupName")]
			public string SecurityGroupName
			{
				get
				{
					return securityGroupName;
				}
				set	
				{
					securityGroupName = value;
				}
			}
		}
	}
}
