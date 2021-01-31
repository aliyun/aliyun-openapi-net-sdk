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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeServerlessClusterResponse : AcsResponse
	{

		private string requestId;

		private string vpcId;

		private string vSwitchId;

		private string instanceId;

		private string instanceName;

		private string mainVersion;

		private string status;

		private string clusterType;

		private string hasUser;

		private string lockMode;

		private string haType;

		private string payType;

		private string innerEndpoint;

		private string outerEndpoint;

		private string reserverMinQpsNum;

		private string reserverMaxQpsNum;

		private string autoRenew;

		private string createTime;

		private string expireTime;

		private string regionId;

		private string zoneId;

		private string updateStatus;

		private string isDeletionProtection;

		private string diskSize;

		private string cuSize;

		private string resourceGroupId;

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

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
			}
		}

		public string MainVersion
		{
			get
			{
				return mainVersion;
			}
			set	
			{
				mainVersion = value;
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

		public string ClusterType
		{
			get
			{
				return clusterType;
			}
			set	
			{
				clusterType = value;
			}
		}

		public string HasUser
		{
			get
			{
				return hasUser;
			}
			set	
			{
				hasUser = value;
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

		public string HaType
		{
			get
			{
				return haType;
			}
			set	
			{
				haType = value;
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

		public string InnerEndpoint
		{
			get
			{
				return innerEndpoint;
			}
			set	
			{
				innerEndpoint = value;
			}
		}

		public string OuterEndpoint
		{
			get
			{
				return outerEndpoint;
			}
			set	
			{
				outerEndpoint = value;
			}
		}

		public string ReserverMinQpsNum
		{
			get
			{
				return reserverMinQpsNum;
			}
			set	
			{
				reserverMinQpsNum = value;
			}
		}

		public string ReserverMaxQpsNum
		{
			get
			{
				return reserverMaxQpsNum;
			}
			set	
			{
				reserverMaxQpsNum = value;
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

		public string UpdateStatus
		{
			get
			{
				return updateStatus;
			}
			set	
			{
				updateStatus = value;
			}
		}

		public string IsDeletionProtection
		{
			get
			{
				return isDeletionProtection;
			}
			set	
			{
				isDeletionProtection = value;
			}
		}

		public string DiskSize
		{
			get
			{
				return diskSize;
			}
			set	
			{
				diskSize = value;
			}
		}

		public string CuSize
		{
			get
			{
				return cuSize;
			}
			set	
			{
				cuSize = value;
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
	}
}
