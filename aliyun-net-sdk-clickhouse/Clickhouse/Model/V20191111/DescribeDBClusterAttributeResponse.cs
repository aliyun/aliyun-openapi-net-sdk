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

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
	public class DescribeDBClusterAttributeResponse : AcsResponse
	{

		private string requestId;

		private DescribeDBClusterAttribute_DBCluster dBCluster;

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

		public DescribeDBClusterAttribute_DBCluster DBCluster
		{
			get
			{
				return dBCluster;
			}
			set	
			{
				dBCluster = value;
			}
		}

		public class DescribeDBClusterAttribute_DBCluster
		{

			private string vpcId;

			private int? supportBackup;

			private int? supportOss;

			private string encryptionType;

			private long? dBNodeCount;

			private string maintainTime;

			private string createTime;

			private string payType;

			private string publicConnectionString;

			private string storageType;

			private int? port;

			private string lockMode;

			private string bid;

			private string engineVersion;

			private string isExpired;

			private string vpcCloudInstanceId;

			private string dBClusterId;

			private string connectionString;

			private string encryptionKey;

			private string dBClusterType;

			private string commodityCode;

			private string expireTime;

			private long? dBNodeStorage;

			private string dBNodeClass;

			private string aliUid;

			private string lockReason;

			private string regionId;

			private string publicPort;

			private string vSwitchId;

			private string dBClusterStatus;

			private string dBClusterNetworkType;

			private string dBClusterDescription;

			private string zoneId;

			private string category;

			private string engine;

			private bool? supportMysqlPort;

			private bool? supportHttpsPort;

			private string controlVersion;

			private string publicIpAddr;

			private string vpcIpAddr;

			private string engineMinorVersion;

			private string engineLatestMinorVersion;

			private bool? maintainAutoType;

			private string extStorageType;

			private int? extStorageSize;

			private string resourceGroupId;

			private string zookeeperClass;

			private string appointmentRestartTime;

			private string zoneIdVswitchMap;

			private string availableUpgradeMajorVersion;

			private string appointmentRestartNodeTime;

			private string appointmentRestartNodeList;

			private string appointmentElectZookeeperTime;

			private bool? appointmentElectZookeeperDisableWrite;

			private List<DescribeDBClusterAttribute_Tag> tags;

			private DescribeDBClusterAttribute_ScaleOutStatus scaleOutStatus;

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

			public int? SupportBackup
			{
				get
				{
					return supportBackup;
				}
				set	
				{
					supportBackup = value;
				}
			}

			public int? SupportOss
			{
				get
				{
					return supportOss;
				}
				set	
				{
					supportOss = value;
				}
			}

			public string EncryptionType
			{
				get
				{
					return encryptionType;
				}
				set	
				{
					encryptionType = value;
				}
			}

			public long? DBNodeCount
			{
				get
				{
					return dBNodeCount;
				}
				set	
				{
					dBNodeCount = value;
				}
			}

			public string MaintainTime
			{
				get
				{
					return maintainTime;
				}
				set	
				{
					maintainTime = value;
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

			public string PublicConnectionString
			{
				get
				{
					return publicConnectionString;
				}
				set	
				{
					publicConnectionString = value;
				}
			}

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

			public int? Port
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

			public string LockMode
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

			public string IsExpired
			{
				get
				{
					return isExpired;
				}
				set	
				{
					isExpired = value;
				}
			}

			public string VpcCloudInstanceId
			{
				get
				{
					return vpcCloudInstanceId;
				}
				set	
				{
					vpcCloudInstanceId = value;
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

			public string EncryptionKey
			{
				get
				{
					return encryptionKey;
				}
				set	
				{
					encryptionKey = value;
				}
			}

			public string DBClusterType
			{
				get
				{
					return dBClusterType;
				}
				set	
				{
					dBClusterType = value;
				}
			}

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
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

			public long? DBNodeStorage
			{
				get
				{
					return dBNodeStorage;
				}
				set	
				{
					dBNodeStorage = value;
				}
			}

			public string DBNodeClass
			{
				get
				{
					return dBNodeClass;
				}
				set	
				{
					dBNodeClass = value;
				}
			}

			public string AliUid
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

			public string PublicPort
			{
				get
				{
					return publicPort;
				}
				set	
				{
					publicPort = value;
				}
			}

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

			public string DBClusterStatus
			{
				get
				{
					return dBClusterStatus;
				}
				set	
				{
					dBClusterStatus = value;
				}
			}

			public string DBClusterNetworkType
			{
				get
				{
					return dBClusterNetworkType;
				}
				set	
				{
					dBClusterNetworkType = value;
				}
			}

			public string DBClusterDescription
			{
				get
				{
					return dBClusterDescription;
				}
				set	
				{
					dBClusterDescription = value;
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

			public bool? SupportMysqlPort
			{
				get
				{
					return supportMysqlPort;
				}
				set	
				{
					supportMysqlPort = value;
				}
			}

			public bool? SupportHttpsPort
			{
				get
				{
					return supportHttpsPort;
				}
				set	
				{
					supportHttpsPort = value;
				}
			}

			public string ControlVersion
			{
				get
				{
					return controlVersion;
				}
				set	
				{
					controlVersion = value;
				}
			}

			public string PublicIpAddr
			{
				get
				{
					return publicIpAddr;
				}
				set	
				{
					publicIpAddr = value;
				}
			}

			public string VpcIpAddr
			{
				get
				{
					return vpcIpAddr;
				}
				set	
				{
					vpcIpAddr = value;
				}
			}

			public string EngineMinorVersion
			{
				get
				{
					return engineMinorVersion;
				}
				set	
				{
					engineMinorVersion = value;
				}
			}

			public string EngineLatestMinorVersion
			{
				get
				{
					return engineLatestMinorVersion;
				}
				set	
				{
					engineLatestMinorVersion = value;
				}
			}

			public bool? MaintainAutoType
			{
				get
				{
					return maintainAutoType;
				}
				set	
				{
					maintainAutoType = value;
				}
			}

			public string ExtStorageType
			{
				get
				{
					return extStorageType;
				}
				set	
				{
					extStorageType = value;
				}
			}

			public int? ExtStorageSize
			{
				get
				{
					return extStorageSize;
				}
				set	
				{
					extStorageSize = value;
				}
			}

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

			public string ZookeeperClass
			{
				get
				{
					return zookeeperClass;
				}
				set	
				{
					zookeeperClass = value;
				}
			}

			public string AppointmentRestartTime
			{
				get
				{
					return appointmentRestartTime;
				}
				set	
				{
					appointmentRestartTime = value;
				}
			}

			public string ZoneIdVswitchMap
			{
				get
				{
					return zoneIdVswitchMap;
				}
				set	
				{
					zoneIdVswitchMap = value;
				}
			}

			public string AvailableUpgradeMajorVersion
			{
				get
				{
					return availableUpgradeMajorVersion;
				}
				set	
				{
					availableUpgradeMajorVersion = value;
				}
			}

			public string AppointmentRestartNodeTime
			{
				get
				{
					return appointmentRestartNodeTime;
				}
				set	
				{
					appointmentRestartNodeTime = value;
				}
			}

			public string AppointmentRestartNodeList
			{
				get
				{
					return appointmentRestartNodeList;
				}
				set	
				{
					appointmentRestartNodeList = value;
				}
			}

			public string AppointmentElectZookeeperTime
			{
				get
				{
					return appointmentElectZookeeperTime;
				}
				set	
				{
					appointmentElectZookeeperTime = value;
				}
			}

			public bool? AppointmentElectZookeeperDisableWrite
			{
				get
				{
					return appointmentElectZookeeperDisableWrite;
				}
				set	
				{
					appointmentElectZookeeperDisableWrite = value;
				}
			}

			public List<DescribeDBClusterAttribute_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public DescribeDBClusterAttribute_ScaleOutStatus ScaleOutStatus
			{
				get
				{
					return scaleOutStatus;
				}
				set	
				{
					scaleOutStatus = value;
				}
			}

			public class DescribeDBClusterAttribute_Tag
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

			public class DescribeDBClusterAttribute_ScaleOutStatus
			{

				private string progress;

				private string ratio;

				public string Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public string Ratio
				{
					get
					{
						return ratio;
					}
					set	
					{
						ratio = value;
					}
				}
			}
		}
	}
}
