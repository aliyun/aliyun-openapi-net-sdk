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
	public class DescribeDBInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private DescribeDBInstanceAttribute_DBInstance dBInstance;

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

		public DescribeDBInstanceAttribute_DBInstance DBInstance
		{
			get
			{
				return dBInstance;
			}
			set	
			{
				dBInstance = value;
			}
		}

		public class DescribeDBInstanceAttribute_DBInstance
		{

			private string type;

			private string status;

			private string rightsSeparationStatus;

			private int? dBNodeCount;

			private string expired;

			private string createTime;

			private string payType;

			private string port;

			private string lockMode;

			private string description;

			private string connectionString;

			private long? storageUsed;

			private string expireDate;

			private string commodityCode;

			private string maintainStartTime;

			private string dBInstanceType;

			private string dBNodeClass;

			private string latestMinorVersion;

			private string maintainEndTime;

			private string dBType;

			private bool? rightsSeparationEnabled;

			private string vPCId;

			private string minorVersion;

			private string regionId;

			private string network;

			private string dBVersion;

			private string vSwitchId;

			private string zoneId;

			private string engine;

			private int? kindCode;

			private string id;

			private string resourceGroupId;

			private int? cnNodeCount;

			private int? dnNodeCount;

			private string cnNodeClassCode;

			private string dnNodeClassCode;

			private string series;

			private string topologyType;

			private string primaryZone;

			private string secondaryZone;

			private string tertiaryZone;

			private bool? differentDNSpec;

			private string columnarInstanceName;

			private bool? canNotCreateColumnar;

			private List<DescribeDBInstanceAttribute_DBNode> dBNodes;

			private List<DescribeDBInstanceAttribute_ConnAddr> connAddrs;

			private List<DescribeDBInstanceAttribute_TagSetItem> tagSet;

			private List<string> readDBInstances;

			private List<string> columnarReadDBInstances;

			private List<string> lTSVersions;

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

			public string RightsSeparationStatus
			{
				get
				{
					return rightsSeparationStatus;
				}
				set	
				{
					rightsSeparationStatus = value;
				}
			}

			public int? DBNodeCount
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

			public string Expired
			{
				get
				{
					return expired;
				}
				set	
				{
					expired = value;
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

			public long? StorageUsed
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

			public string ExpireDate
			{
				get
				{
					return expireDate;
				}
				set	
				{
					expireDate = value;
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

			public string DBInstanceType
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

			public string LatestMinorVersion
			{
				get
				{
					return latestMinorVersion;
				}
				set	
				{
					latestMinorVersion = value;
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

			public bool? RightsSeparationEnabled
			{
				get
				{
					return rightsSeparationEnabled;
				}
				set	
				{
					rightsSeparationEnabled = value;
				}
			}

			public string VPCId
			{
				get
				{
					return vPCId;
				}
				set	
				{
					vPCId = value;
				}
			}

			public string MinorVersion
			{
				get
				{
					return minorVersion;
				}
				set	
				{
					minorVersion = value;
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

			public string Network
			{
				get
				{
					return network;
				}
				set	
				{
					network = value;
				}
			}

			public string DBVersion
			{
				get
				{
					return dBVersion;
				}
				set	
				{
					dBVersion = value;
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

			public int? KindCode
			{
				get
				{
					return kindCode;
				}
				set	
				{
					kindCode = value;
				}
			}

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

			public int? CnNodeCount
			{
				get
				{
					return cnNodeCount;
				}
				set	
				{
					cnNodeCount = value;
				}
			}

			public int? DnNodeCount
			{
				get
				{
					return dnNodeCount;
				}
				set	
				{
					dnNodeCount = value;
				}
			}

			public string CnNodeClassCode
			{
				get
				{
					return cnNodeClassCode;
				}
				set	
				{
					cnNodeClassCode = value;
				}
			}

			public string DnNodeClassCode
			{
				get
				{
					return dnNodeClassCode;
				}
				set	
				{
					dnNodeClassCode = value;
				}
			}

			public string Series
			{
				get
				{
					return series;
				}
				set	
				{
					series = value;
				}
			}

			public string TopologyType
			{
				get
				{
					return topologyType;
				}
				set	
				{
					topologyType = value;
				}
			}

			public string PrimaryZone
			{
				get
				{
					return primaryZone;
				}
				set	
				{
					primaryZone = value;
				}
			}

			public string SecondaryZone
			{
				get
				{
					return secondaryZone;
				}
				set	
				{
					secondaryZone = value;
				}
			}

			public string TertiaryZone
			{
				get
				{
					return tertiaryZone;
				}
				set	
				{
					tertiaryZone = value;
				}
			}

			public bool? DifferentDNSpec
			{
				get
				{
					return differentDNSpec;
				}
				set	
				{
					differentDNSpec = value;
				}
			}

			public string ColumnarInstanceName
			{
				get
				{
					return columnarInstanceName;
				}
				set	
				{
					columnarInstanceName = value;
				}
			}

			public bool? CanNotCreateColumnar
			{
				get
				{
					return canNotCreateColumnar;
				}
				set	
				{
					canNotCreateColumnar = value;
				}
			}

			public List<DescribeDBInstanceAttribute_DBNode> DBNodes
			{
				get
				{
					return dBNodes;
				}
				set	
				{
					dBNodes = value;
				}
			}

			public List<DescribeDBInstanceAttribute_ConnAddr> ConnAddrs
			{
				get
				{
					return connAddrs;
				}
				set	
				{
					connAddrs = value;
				}
			}

			public List<DescribeDBInstanceAttribute_TagSetItem> TagSet
			{
				get
				{
					return tagSet;
				}
				set	
				{
					tagSet = value;
				}
			}

			public List<string> ReadDBInstances
			{
				get
				{
					return readDBInstances;
				}
				set	
				{
					readDBInstances = value;
				}
			}

			public List<string> ColumnarReadDBInstances
			{
				get
				{
					return columnarReadDBInstances;
				}
				set	
				{
					columnarReadDBInstances = value;
				}
			}

			public List<string> LTSVersions
			{
				get
				{
					return lTSVersions;
				}
				set	
				{
					lTSVersions = value;
				}
			}

			public class DescribeDBInstanceAttribute_DBNode
			{

				private string computeNodeId;

				private string nodeClass;

				private string dataNodeId;

				private string zoneId;

				private string id;

				private string regionId;

				public string ComputeNodeId
				{
					get
					{
						return computeNodeId;
					}
					set	
					{
						computeNodeId = value;
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

				public string DataNodeId
				{
					get
					{
						return dataNodeId;
					}
					set	
					{
						dataNodeId = value;
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
			}

			public class DescribeDBInstanceAttribute_ConnAddr
			{

				private string type;

				private string vSwitchId;

				private long? port;

				private string vPCId;

				private string connectionString;

				private string vpcInstanceId;

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

				public long? Port
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

				public string VPCId
				{
					get
					{
						return vPCId;
					}
					set	
					{
						vPCId = value;
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

				public string VpcInstanceId
				{
					get
					{
						return vpcInstanceId;
					}
					set	
					{
						vpcInstanceId = value;
					}
				}
			}

			public class DescribeDBInstanceAttribute_TagSetItem
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
		}
	}
}
