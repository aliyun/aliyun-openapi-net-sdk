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
	public class DescribeDBInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalNumber;

		private List<DescribeDBInstances_DBInstance> dBInstances;

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

		public int? TotalNumber
		{
			get
			{
				return totalNumber;
			}
			set	
			{
				totalNumber = value;
			}
		}

		public List<DescribeDBInstances_DBInstance> DBInstances
		{
			get
			{
				return dBInstances;
			}
			set	
			{
				dBInstances = value;
			}
		}

		public class DescribeDBInstances_DBInstance
		{

			private string type;

			private string status;

			private string commodityCode;

			private string expireTime;

			private bool? expired;

			private string createTime;

			private string payType;

			private string lockReason;

			private string dBType;

			private string lockMode;

			private string vPCId;

			private string minorVersion;

			private string regionId;

			private string network;

			private string dBVersion;

			private string description;

			private string nodeClass;

			private long? storageUsed;

			private int? nodeCount;

			private string zoneId;

			private string engine;

			private string id;

			private string resourceGroupId;

			private string dBInstanceName;

			private int? dnNodeCount;

			private int? cnNodeCount;

			private string cnNodeClassCode;

			private string dnNodeClassCode;

			private string series;

			private bool? containBinlogX;

			private bool? supportBinlogX;

			private string cdcInstanceName;

			private string topologyType;

			private string tertiaryZone;

			private string primaryZone;

			private string secondaryZone;

			private string columnarInstanceName;

			private bool? isInGdn;

			private string gdnRole;

			private string cpuType;

			private List<DescribeDBInstances_PolarDBXNode> nodes;

			private List<DescribeDBInstances_TagSetItem> tagSet;

			private List<string> readDBInstances;

			private List<string> columnarReadDBInstances;

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

			public bool? Expired
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

			public int? NodeCount
			{
				get
				{
					return nodeCount;
				}
				set	
				{
					nodeCount = value;
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

			public bool? ContainBinlogX
			{
				get
				{
					return containBinlogX;
				}
				set	
				{
					containBinlogX = value;
				}
			}

			public bool? SupportBinlogX
			{
				get
				{
					return supportBinlogX;
				}
				set	
				{
					supportBinlogX = value;
				}
			}

			public string CdcInstanceName
			{
				get
				{
					return cdcInstanceName;
				}
				set	
				{
					cdcInstanceName = value;
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

			public bool? IsInGdn
			{
				get
				{
					return isInGdn;
				}
				set	
				{
					isInGdn = value;
				}
			}

			public string GdnRole
			{
				get
				{
					return gdnRole;
				}
				set	
				{
					gdnRole = value;
				}
			}

			public string CpuType
			{
				get
				{
					return cpuType;
				}
				set	
				{
					cpuType = value;
				}
			}

			public List<DescribeDBInstances_PolarDBXNode> Nodes
			{
				get
				{
					return nodes;
				}
				set	
				{
					nodes = value;
				}
			}

			public List<DescribeDBInstances_TagSetItem> TagSet
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

			public class DescribeDBInstances_PolarDBXNode
			{

				private string zoneId;

				private string id;

				private string classCode;

				private string regionId;

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

			public class DescribeDBInstances_TagSetItem
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
