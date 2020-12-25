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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListFlowProjectClusterSettingResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<ListFlowProjectClusterSetting_ClusterSetting> clusterSettings;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<ListFlowProjectClusterSetting_ClusterSetting> ClusterSettings
		{
			get
			{
				return clusterSettings;
			}
			set	
			{
				clusterSettings = value;
			}
		}

		public class ListFlowProjectClusterSetting_ClusterSetting
		{

			private long? gmtCreate;

			private long? gmtModified;

			private string projectId;

			private string clusterId;

			private string k8sClusterId;

			private string clusterName;

			private string defaultUser;

			private string defaultQueue;

			private List<string> userList;

			private List<string> queueList;

			private List<string> hostList;

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
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

			public string K8sClusterId
			{
				get
				{
					return k8sClusterId;
				}
				set	
				{
					k8sClusterId = value;
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

			public string DefaultUser
			{
				get
				{
					return defaultUser;
				}
				set	
				{
					defaultUser = value;
				}
			}

			public string DefaultQueue
			{
				get
				{
					return defaultQueue;
				}
				set	
				{
					defaultQueue = value;
				}
			}

			public List<string> UserList
			{
				get
				{
					return userList;
				}
				set	
				{
					userList = value;
				}
			}

			public List<string> QueueList
			{
				get
				{
					return queueList;
				}
				set	
				{
					queueList = value;
				}
			}

			public List<string> HostList
			{
				get
				{
					return hostList;
				}
				set	
				{
					hostList = value;
				}
			}
		}
	}
}
