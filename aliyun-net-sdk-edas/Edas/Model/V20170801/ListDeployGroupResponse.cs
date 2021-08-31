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
	public class ListDeployGroupResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListDeployGroup_DeployGroup> deployGroupList;

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

		public List<ListDeployGroup_DeployGroup> DeployGroupList
		{
			get
			{
				return deployGroupList;
			}
			set	
			{
				deployGroupList = value;
			}
		}

		public class ListDeployGroup_DeployGroup
		{

			private string groupId;

			private string groupName;

			private string appId;

			private string packageVersionId;

			private string appVersionId;

			private int? groupType;

			private string clusterId;

			private long? createTime;

			private long? updateTime;

			private string _nameSpace;

			private string clusterName;

			private long? lastUpdateTime;

			private string preStop;

			private string postStart;

			private string packageUrl;

			private string env;

			private string labels;

			private string selector;

			private string strategy;

			private string status;

			private string reversion;

			private string csClusterId;

			private string baseComponentMetaName;

			private string deploymentName;

			private string cpuLimit;

			private string memoryLimit;

			private string packagePublicUrl;

			private string packageVersion;

			private string cpuRequest;

			private string memoryRequest;

			private string vServerGroupId;

			private string vExtServerGroupId;

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string PackageVersionId
			{
				get
				{
					return packageVersionId;
				}
				set	
				{
					packageVersionId = value;
				}
			}

			public string AppVersionId
			{
				get
				{
					return appVersionId;
				}
				set	
				{
					appVersionId = value;
				}
			}

			public int? GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
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

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string _NameSpace
			{
				get
				{
					return _nameSpace;
				}
				set	
				{
					_nameSpace = value;
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

			public long? LastUpdateTime
			{
				get
				{
					return lastUpdateTime;
				}
				set	
				{
					lastUpdateTime = value;
				}
			}

			public string PreStop
			{
				get
				{
					return preStop;
				}
				set	
				{
					preStop = value;
				}
			}

			public string PostStart
			{
				get
				{
					return postStart;
				}
				set	
				{
					postStart = value;
				}
			}

			public string PackageUrl
			{
				get
				{
					return packageUrl;
				}
				set	
				{
					packageUrl = value;
				}
			}

			public string Env
			{
				get
				{
					return env;
				}
				set	
				{
					env = value;
				}
			}

			public string Labels
			{
				get
				{
					return labels;
				}
				set	
				{
					labels = value;
				}
			}

			public string Selector
			{
				get
				{
					return selector;
				}
				set	
				{
					selector = value;
				}
			}

			public string Strategy
			{
				get
				{
					return strategy;
				}
				set	
				{
					strategy = value;
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

			public string Reversion
			{
				get
				{
					return reversion;
				}
				set	
				{
					reversion = value;
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

			public string BaseComponentMetaName
			{
				get
				{
					return baseComponentMetaName;
				}
				set	
				{
					baseComponentMetaName = value;
				}
			}

			public string DeploymentName
			{
				get
				{
					return deploymentName;
				}
				set	
				{
					deploymentName = value;
				}
			}

			public string CpuLimit
			{
				get
				{
					return cpuLimit;
				}
				set	
				{
					cpuLimit = value;
				}
			}

			public string MemoryLimit
			{
				get
				{
					return memoryLimit;
				}
				set	
				{
					memoryLimit = value;
				}
			}

			public string PackagePublicUrl
			{
				get
				{
					return packagePublicUrl;
				}
				set	
				{
					packagePublicUrl = value;
				}
			}

			public string PackageVersion
			{
				get
				{
					return packageVersion;
				}
				set	
				{
					packageVersion = value;
				}
			}

			public string CpuRequest
			{
				get
				{
					return cpuRequest;
				}
				set	
				{
					cpuRequest = value;
				}
			}

			public string MemoryRequest
			{
				get
				{
					return memoryRequest;
				}
				set	
				{
					memoryRequest = value;
				}
			}

			public string VServerGroupId
			{
				get
				{
					return vServerGroupId;
				}
				set	
				{
					vServerGroupId = value;
				}
			}

			public string VExtServerGroupId
			{
				get
				{
					return vExtServerGroupId;
				}
				set	
				{
					vExtServerGroupId = value;
				}
			}
		}
	}
}
