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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeMountTargetsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeMountTargets_MountTarget> mountTargets;

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

		public List<DescribeMountTargets_MountTarget> MountTargets
		{
			get
			{
				return mountTargets;
			}
			set	
			{
				mountTargets = value;
			}
		}

		public class DescribeMountTargets_MountTarget
		{

			private string vpcId;

			private string status;

			private string mountTargetDomain;

			private string accessGroup;

			private string dualStackMountTargetDomain;

			private string vswId;

			private string networkType;

			private List<DescribeMountTargets_ClientMasterNode> clientMasterNodes;

			private List<DescribeMountTargets_Tag> tags;

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

			public string MountTargetDomain
			{
				get
				{
					return mountTargetDomain;
				}
				set	
				{
					mountTargetDomain = value;
				}
			}

			public string AccessGroup
			{
				get
				{
					return accessGroup;
				}
				set	
				{
					accessGroup = value;
				}
			}

			public string DualStackMountTargetDomain
			{
				get
				{
					return dualStackMountTargetDomain;
				}
				set	
				{
					dualStackMountTargetDomain = value;
				}
			}

			public string VswId
			{
				get
				{
					return vswId;
				}
				set	
				{
					vswId = value;
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

			public List<DescribeMountTargets_ClientMasterNode> ClientMasterNodes
			{
				get
				{
					return clientMasterNodes;
				}
				set	
				{
					clientMasterNodes = value;
				}
			}

			public List<DescribeMountTargets_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DescribeMountTargets_ClientMasterNode
			{

				private string ecsId;

				private string defaultPasswd;

				private string ecsIp;

				public string EcsId
				{
					get
					{
						return ecsId;
					}
					set	
					{
						ecsId = value;
					}
				}

				public string DefaultPasswd
				{
					get
					{
						return defaultPasswd;
					}
					set	
					{
						defaultPasswd = value;
					}
				}

				public string EcsIp
				{
					get
					{
						return ecsIp;
					}
					set	
					{
						ecsIp = value;
					}
				}
			}

			public class DescribeMountTargets_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
