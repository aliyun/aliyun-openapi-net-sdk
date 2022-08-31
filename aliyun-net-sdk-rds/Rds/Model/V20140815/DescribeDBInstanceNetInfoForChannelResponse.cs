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
	public class DescribeDBInstanceNetInfoForChannelResponse : AcsResponse
	{

		private string instanceNetworkType;

		private string requestId;

		private List<DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo> dBInstanceNetInfos;

		[JsonProperty(PropertyName = "InstanceNetworkType")]
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

		[JsonProperty(PropertyName = "DBInstanceNetInfos")]
		public List<DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo> DBInstanceNetInfos
		{
			get
			{
				return dBInstanceNetInfos;
			}
			set	
			{
				dBInstanceNetInfos = value;
			}
		}

		public class DescribeDBInstanceNetInfoForChannel_DBInstanceNetInfo
		{

			private string upgradeable;

			private string expiredTime;

			private string iPType;

			private string port;

			private string vPCId;

			private string availability;

			private string vSwitchId;

			private string connectionStringType;

			private string connectionString;

			private string maxDelayTime;

			private string iPAddress;

			private string distributionType;

			private List<DescribeDBInstanceNetInfoForChannel_SecurityIPGroup> securityIPGroups;

			private List<DescribeDBInstanceNetInfoForChannel_DBInstanceWeight> dBInstanceWeights;

			[JsonProperty(PropertyName = "Upgradeable")]
			public string Upgradeable
			{
				get
				{
					return upgradeable;
				}
				set	
				{
					upgradeable = value;
				}
			}

			[JsonProperty(PropertyName = "ExpiredTime")]
			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			[JsonProperty(PropertyName = "IPType")]
			public string IPType
			{
				get
				{
					return iPType;
				}
				set	
				{
					iPType = value;
				}
			}

			[JsonProperty(PropertyName = "Port")]
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

			[JsonProperty(PropertyName = "VPCId")]
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

			[JsonProperty(PropertyName = "Availability")]
			public string Availability
			{
				get
				{
					return availability;
				}
				set	
				{
					availability = value;
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

			[JsonProperty(PropertyName = "ConnectionStringType")]
			public string ConnectionStringType
			{
				get
				{
					return connectionStringType;
				}
				set	
				{
					connectionStringType = value;
				}
			}

			[JsonProperty(PropertyName = "ConnectionString")]
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

			[JsonProperty(PropertyName = "MaxDelayTime")]
			public string MaxDelayTime
			{
				get
				{
					return maxDelayTime;
				}
				set	
				{
					maxDelayTime = value;
				}
			}

			[JsonProperty(PropertyName = "IPAddress")]
			public string IPAddress
			{
				get
				{
					return iPAddress;
				}
				set	
				{
					iPAddress = value;
				}
			}

			[JsonProperty(PropertyName = "DistributionType")]
			public string DistributionType
			{
				get
				{
					return distributionType;
				}
				set	
				{
					distributionType = value;
				}
			}

			[JsonProperty(PropertyName = "SecurityIPGroups")]
			public List<DescribeDBInstanceNetInfoForChannel_SecurityIPGroup> SecurityIPGroups
			{
				get
				{
					return securityIPGroups;
				}
				set	
				{
					securityIPGroups = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceWeights")]
			public List<DescribeDBInstanceNetInfoForChannel_DBInstanceWeight> DBInstanceWeights
			{
				get
				{
					return dBInstanceWeights;
				}
				set	
				{
					dBInstanceWeights = value;
				}
			}

			public class DescribeDBInstanceNetInfoForChannel_SecurityIPGroup
			{

				private string securityIPs;

				private string securityIPGroupName;

				[JsonProperty(PropertyName = "SecurityIPs")]
				public string SecurityIPs
				{
					get
					{
						return securityIPs;
					}
					set	
					{
						securityIPs = value;
					}
				}

				[JsonProperty(PropertyName = "SecurityIPGroupName")]
				public string SecurityIPGroupName
				{
					get
					{
						return securityIPGroupName;
					}
					set	
					{
						securityIPGroupName = value;
					}
				}
			}

			public class DescribeDBInstanceNetInfoForChannel_DBInstanceWeight
			{

				private string availability;

				private string weight;

				private string dBInstanceId;

				private string dBInstanceType;

				[JsonProperty(PropertyName = "Availability")]
				public string Availability
				{
					get
					{
						return availability;
					}
					set	
					{
						availability = value;
					}
				}

				[JsonProperty(PropertyName = "Weight")]
				public string Weight
				{
					get
					{
						return weight;
					}
					set	
					{
						weight = value;
					}
				}

				[JsonProperty(PropertyName = "DBInstanceId")]
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

				[JsonProperty(PropertyName = "DBInstanceType")]
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
			}
		}
	}
}
