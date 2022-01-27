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

namespace Aliyun.Acs.hitsdb.Model.V20170601
{
	public class DescribeHiTSDBInstanceResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private string instanceAlias;

		private string instanceDescription;

		private string regionId;

		private string zoneId;

		private string instanceStatus;

		private string chargeType;

		private string networkType;

		private string gmtCreated;

		private string gmtExpire;

		private string instanceClass;

		private string maxTimelineLimit;

		private string instanceStorage;

		private string instanceTps;

		private string reverseVpcIp;

		private string reverseVpcPort;

		private string vpcId;

		private string vswitchId;

		private string connectionString;

		private string publicConnectionString;

		private string autoRenew;

		private string engineType;

		private string cpuNumber;

		private string memSize;

		private int? series;

		private string rDSStatus;

		private string diskCategory;

		private string status;

		private string paymentType;

		private long? createTime;

		private long? expiredTime;

		private List<DescribeHiTSDBInstance_SecurityIp> securityIpList;

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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public string InstanceAlias
		{
			get
			{
				return instanceAlias;
			}
			set	
			{
				instanceAlias = value;
			}
		}

		public string InstanceDescription
		{
			get
			{
				return instanceDescription;
			}
			set	
			{
				instanceDescription = value;
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

		public string InstanceStatus
		{
			get
			{
				return instanceStatus;
			}
			set	
			{
				instanceStatus = value;
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
			}
		}

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
			}
		}

		public string GmtCreated
		{
			get
			{
				return gmtCreated;
			}
			set	
			{
				gmtCreated = value;
			}
		}

		public string GmtExpire
		{
			get
			{
				return gmtExpire;
			}
			set	
			{
				gmtExpire = value;
			}
		}

		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
			}
		}

		public string MaxTimelineLimit
		{
			get
			{
				return maxTimelineLimit;
			}
			set	
			{
				maxTimelineLimit = value;
			}
		}

		public string InstanceStorage
		{
			get
			{
				return instanceStorage;
			}
			set	
			{
				instanceStorage = value;
			}
		}

		public string InstanceTps
		{
			get
			{
				return instanceTps;
			}
			set	
			{
				instanceTps = value;
			}
		}

		public string ReverseVpcIp
		{
			get
			{
				return reverseVpcIp;
			}
			set	
			{
				reverseVpcIp = value;
			}
		}

		public string ReverseVpcPort
		{
			get
			{
				return reverseVpcPort;
			}
			set	
			{
				reverseVpcPort = value;
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

		public string VswitchId
		{
			get
			{
				return vswitchId;
			}
			set	
			{
				vswitchId = value;
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

		public string AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
			}
		}

		public string EngineType
		{
			get
			{
				return engineType;
			}
			set	
			{
				engineType = value;
			}
		}

		public string CpuNumber
		{
			get
			{
				return cpuNumber;
			}
			set	
			{
				cpuNumber = value;
			}
		}

		public string MemSize
		{
			get
			{
				return memSize;
			}
			set	
			{
				memSize = value;
			}
		}

		public int? Series
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

		public string RDSStatus
		{
			get
			{
				return rDSStatus;
			}
			set	
			{
				rDSStatus = value;
			}
		}

		public string DiskCategory
		{
			get
			{
				return diskCategory;
			}
			set	
			{
				diskCategory = value;
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

		public string PaymentType
		{
			get
			{
				return paymentType;
			}
			set	
			{
				paymentType = value;
			}
		}

		public long? CreateTime
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

		public long? ExpiredTime
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

		public List<DescribeHiTSDBInstance_SecurityIp> SecurityIpList
		{
			get
			{
				return securityIpList;
			}
			set	
			{
				securityIpList = value;
			}
		}

		public class DescribeHiTSDBInstance_SecurityIp
		{

			private string ip;

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}
		}
	}
}
