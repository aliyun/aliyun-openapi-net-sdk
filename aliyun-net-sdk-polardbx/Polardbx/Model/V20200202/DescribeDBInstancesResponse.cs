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

			private string id;

			private string description;

			private string payType;

			private string createTime;

			private string expireTime;

			private bool? expired;

			private string regionId;

			private string zoneId;

			private string network;

			private string vPCId;

			private string engine;

			private string dBType;

			private string dBVersion;

			private string status;

			private string lockMode;

			private string lockReason;

			private int? nodeCount;

			private string nodeClass;

			private int? storageUsed;

			private string commodityCode;

			private string type;

			private List<DescribeDBInstances_PolarDBXNode> nodes;

			private List<string> readDBInstances;

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

			public int? StorageUsed
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

			public class DescribeDBInstances_PolarDBXNode
			{

				private string id;

				private string classCode;

				private string regionId;

				private string zoneId;

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
			}
		}
	}
}
