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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class ListAvailableClusterNodeResponse : AcsResponse
	{

		private int? code;

		private string errorMsg;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private long? totalCount;

		private List<ListAvailableClusterNode_ClusterNodeInfo> data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListAvailableClusterNode_ClusterNodeInfo> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListAvailableClusterNode_ClusterNodeInfo
		{

			private string oSName;

			private string businessCode;

			private string ecsConfiguration;

			private string ecsCpu;

			private string ecsEip;

			private string ecsExpiredTime;

			private string ecsLocalStorageCapacity;

			private string ecsMemory;

			private string ecsOsType;

			private string ecsPrivateIp;

			private string ecsPublicIp;

			private string ecsZone;

			private string instanceId;

			private string instanceName;

			private string instanceNetworkType;

			private string instanceType;

			private string internetMaxBandwidthIn;

			private string internetMaxBandwidthOut;

			private string regionId;

			private string vpcId;

			public string OSName
			{
				get
				{
					return oSName;
				}
				set	
				{
					oSName = value;
				}
			}

			public string BusinessCode
			{
				get
				{
					return businessCode;
				}
				set	
				{
					businessCode = value;
				}
			}

			public string EcsConfiguration
			{
				get
				{
					return ecsConfiguration;
				}
				set	
				{
					ecsConfiguration = value;
				}
			}

			public string EcsCpu
			{
				get
				{
					return ecsCpu;
				}
				set	
				{
					ecsCpu = value;
				}
			}

			public string EcsEip
			{
				get
				{
					return ecsEip;
				}
				set	
				{
					ecsEip = value;
				}
			}

			public string EcsExpiredTime
			{
				get
				{
					return ecsExpiredTime;
				}
				set	
				{
					ecsExpiredTime = value;
				}
			}

			public string EcsLocalStorageCapacity
			{
				get
				{
					return ecsLocalStorageCapacity;
				}
				set	
				{
					ecsLocalStorageCapacity = value;
				}
			}

			public string EcsMemory
			{
				get
				{
					return ecsMemory;
				}
				set	
				{
					ecsMemory = value;
				}
			}

			public string EcsOsType
			{
				get
				{
					return ecsOsType;
				}
				set	
				{
					ecsOsType = value;
				}
			}

			public string EcsPrivateIp
			{
				get
				{
					return ecsPrivateIp;
				}
				set	
				{
					ecsPrivateIp = value;
				}
			}

			public string EcsPublicIp
			{
				get
				{
					return ecsPublicIp;
				}
				set	
				{
					ecsPublicIp = value;
				}
			}

			public string EcsZone
			{
				get
				{
					return ecsZone;
				}
				set	
				{
					ecsZone = value;
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

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string InternetMaxBandwidthIn
			{
				get
				{
					return internetMaxBandwidthIn;
				}
				set	
				{
					internetMaxBandwidthIn = value;
				}
			}

			public string InternetMaxBandwidthOut
			{
				get
				{
					return internetMaxBandwidthOut;
				}
				set	
				{
					internetMaxBandwidthOut = value;
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
		}
	}
}
