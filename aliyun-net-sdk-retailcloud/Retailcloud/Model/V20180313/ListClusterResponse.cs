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
	public class ListClusterResponse : AcsResponse
	{

		private int? code;

		private string errorMsg;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private long? totalCount;

		private List<ListCluster_ClusterInfo> data;

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

		public List<ListCluster_ClusterInfo> Data
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

		public class ListCluster_ClusterInfo
		{

			private string businessCode;

			private string clusterTitle;

			private string createStatus;

			private string envType;

			private long? id;

			private string instanceId;

			private string keyPair;

			private string netPlug;

			private string password;

			private string podCIDR;

			private string regionId;

			private string regionName;

			private string serviceCIDR;

			private string status;

			private string vpcId;

			private string workLoadCpu;

			private string workLoadMem;

			private List<string> ecsIds;

			private List<string> vswitchIds;

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

			public string ClusterTitle
			{
				get
				{
					return clusterTitle;
				}
				set	
				{
					clusterTitle = value;
				}
			}

			public string CreateStatus
			{
				get
				{
					return createStatus;
				}
				set	
				{
					createStatus = value;
				}
			}

			public string EnvType
			{
				get
				{
					return envType;
				}
				set	
				{
					envType = value;
				}
			}

			public long? Id
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

			public string KeyPair
			{
				get
				{
					return keyPair;
				}
				set	
				{
					keyPair = value;
				}
			}

			public string NetPlug
			{
				get
				{
					return netPlug;
				}
				set	
				{
					netPlug = value;
				}
			}

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
				}
			}

			public string PodCIDR
			{
				get
				{
					return podCIDR;
				}
				set	
				{
					podCIDR = value;
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

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public string ServiceCIDR
			{
				get
				{
					return serviceCIDR;
				}
				set	
				{
					serviceCIDR = value;
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

			public string WorkLoadCpu
			{
				get
				{
					return workLoadCpu;
				}
				set	
				{
					workLoadCpu = value;
				}
			}

			public string WorkLoadMem
			{
				get
				{
					return workLoadMem;
				}
				set	
				{
					workLoadMem = value;
				}
			}

			public List<string> EcsIds
			{
				get
				{
					return ecsIds;
				}
				set	
				{
					ecsIds = value;
				}
			}

			public List<string> VswitchIds
			{
				get
				{
					return vswitchIds;
				}
				set	
				{
					vswitchIds = value;
				}
			}
		}
	}
}
