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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetK8sClusterResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private GetK8sCluster_ClusterPage clusterPage;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public GetK8sCluster_ClusterPage ClusterPage
		{
			get
			{
				return clusterPage;
			}
			set	
			{
				clusterPage = value;
			}
		}

		public class GetK8sCluster_ClusterPage
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalSize;

			private List<GetK8sCluster_Cluster> clusterList;

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
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

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public List<GetK8sCluster_Cluster> ClusterList
			{
				get
				{
					return clusterList;
				}
				set	
				{
					clusterList = value;
				}
			}

			public class GetK8sCluster_Cluster
			{

				private string clusterId;

				private int? clusterImportStatus;

				private string clusterName;

				private int? clusterStatus;

				private int? clusterType;

				private string regionId;

				private string vpcId;

				private string vswitchId;

				private string subNetCidr;

				private string csClusterStatus;

				private string csClusterId;

				private string description;

				private int? nodeNum;

				private int? cpu;

				private int? mem;

				private int? networkMode;

				public string ClusterId
				{
					get
					{
						return clusterId;
					}
					set	
					{
						clusterId = value;
					}
				}

				public int? ClusterImportStatus
				{
					get
					{
						return clusterImportStatus;
					}
					set	
					{
						clusterImportStatus = value;
					}
				}

				public string ClusterName
				{
					get
					{
						return clusterName;
					}
					set	
					{
						clusterName = value;
					}
				}

				public int? ClusterStatus
				{
					get
					{
						return clusterStatus;
					}
					set	
					{
						clusterStatus = value;
					}
				}

				public int? ClusterType
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

				public string SubNetCidr
				{
					get
					{
						return subNetCidr;
					}
					set	
					{
						subNetCidr = value;
					}
				}

				public string CsClusterStatus
				{
					get
					{
						return csClusterStatus;
					}
					set	
					{
						csClusterStatus = value;
					}
				}

				public string CsClusterId
				{
					get
					{
						return csClusterId;
					}
					set	
					{
						csClusterId = value;
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

				public int? NodeNum
				{
					get
					{
						return nodeNum;
					}
					set	
					{
						nodeNum = value;
					}
				}

				public int? Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				public int? Mem
				{
					get
					{
						return mem;
					}
					set	
					{
						mem = value;
					}
				}

				public int? NetworkMode
				{
					get
					{
						return networkMode;
					}
					set	
					{
						networkMode = value;
					}
				}
			}
		}
	}
}
