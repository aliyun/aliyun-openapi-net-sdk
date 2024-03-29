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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeGroupedContainerInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGroupedContainerInstances_GroupedContainerInstance> groupedContainerInstanceList;

		private DescribeGroupedContainerInstances_PageInfo pageInfo;

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

		public List<DescribeGroupedContainerInstances_GroupedContainerInstance> GroupedContainerInstanceList
		{
			get
			{
				return groupedContainerInstanceList;
			}
			set	
			{
				groupedContainerInstanceList = value;
			}
		}

		public DescribeGroupedContainerInstances_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeGroupedContainerInstances_GroupedContainerInstance
		{

			private string riskLevel;

			private string hostIp;

			private string pod;

			private string riskStatus;

			private long? createTime;

			private string _namespace;

			private string custerState;

			private string instanceId;

			private string regionId;

			private string appName;

			private int? instanceCount;

			private string clusterType;

			private string clusterName;

			private string podIp;

			private int? vulCount;

			private int? alarmCount;

			private int? riskInstanceCount;

			private string clusterId;

			private string image;

			private string imageRepoNamespace;

			private string imageRepoName;

			private string imageRepoTag;

			private string imageDigest;

			private string imageUuid;

			private int? hcCount;

			public string RiskLevel
			{
				get
				{
					return riskLevel;
				}
				set	
				{
					riskLevel = value;
				}
			}

			public string HostIp
			{
				get
				{
					return hostIp;
				}
				set	
				{
					hostIp = value;
				}
			}

			public string Pod
			{
				get
				{
					return pod;
				}
				set	
				{
					pod = value;
				}
			}

			public string RiskStatus
			{
				get
				{
					return riskStatus;
				}
				set	
				{
					riskStatus = value;
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

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
				}
			}

			public string CusterState
			{
				get
				{
					return custerState;
				}
				set	
				{
					custerState = value;
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

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public int? InstanceCount
			{
				get
				{
					return instanceCount;
				}
				set	
				{
					instanceCount = value;
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

			public string PodIp
			{
				get
				{
					return podIp;
				}
				set	
				{
					podIp = value;
				}
			}

			public int? VulCount
			{
				get
				{
					return vulCount;
				}
				set	
				{
					vulCount = value;
				}
			}

			public int? AlarmCount
			{
				get
				{
					return alarmCount;
				}
				set	
				{
					alarmCount = value;
				}
			}

			public int? RiskInstanceCount
			{
				get
				{
					return riskInstanceCount;
				}
				set	
				{
					riskInstanceCount = value;
				}
			}

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

			public string Image
			{
				get
				{
					return image;
				}
				set	
				{
					image = value;
				}
			}

			public string ImageRepoNamespace
			{
				get
				{
					return imageRepoNamespace;
				}
				set	
				{
					imageRepoNamespace = value;
				}
			}

			public string ImageRepoName
			{
				get
				{
					return imageRepoName;
				}
				set	
				{
					imageRepoName = value;
				}
			}

			public string ImageRepoTag
			{
				get
				{
					return imageRepoTag;
				}
				set	
				{
					imageRepoTag = value;
				}
			}

			public string ImageDigest
			{
				get
				{
					return imageDigest;
				}
				set	
				{
					imageDigest = value;
				}
			}

			public string ImageUuid
			{
				get
				{
					return imageUuid;
				}
				set	
				{
					imageUuid = value;
				}
			}

			public int? HcCount
			{
				get
				{
					return hcCount;
				}
				set	
				{
					hcCount = value;
				}
			}
		}

		public class DescribeGroupedContainerInstances_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

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

			public int? TotalCount
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

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
