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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20170714
{
	public class ListNodesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListNodes_NodeInfo> nodes;

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

		public List<ListNodes_NodeInfo> Nodes
		{
			get
			{
				return nodes;
			}
			set	
			{
				nodes = value;
			}
		}

		public class ListNodes_NodeInfo
		{

			private string id;

			private string regionId;

			private string status;

			private bool? createdByEhpc;

			private string role;

			private string addTime;

			private bool? expired;

			private string expiredTime;

			private string spotStrategy;

			private string lockReason;

			private string imageOwnerAlias;

			private string imageId;

			private ListNodes_TotalResources totalResources;

			private ListNodes_UsedResources usedResources;

			public string Id
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

			public bool? CreatedByEhpc
			{
				get
				{
					return createdByEhpc;
				}
				set	
				{
					createdByEhpc = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}

			public string AddTime
			{
				get
				{
					return addTime;
				}
				set	
				{
					addTime = value;
				}
			}

			public bool? Expired
			{
				get
				{
					return expired;
				}
				set	
				{
					expired = value;
				}
			}

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

			public string SpotStrategy
			{
				get
				{
					return spotStrategy;
				}
				set	
				{
					spotStrategy = value;
				}
			}

			public string LockReason
			{
				get
				{
					return lockReason;
				}
				set	
				{
					lockReason = value;
				}
			}

			public string ImageOwnerAlias
			{
				get
				{
					return imageOwnerAlias;
				}
				set	
				{
					imageOwnerAlias = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public ListNodes_TotalResources TotalResources
			{
				get
				{
					return totalResources;
				}
				set	
				{
					totalResources = value;
				}
			}

			public ListNodes_UsedResources UsedResources
			{
				get
				{
					return usedResources;
				}
				set	
				{
					usedResources = value;
				}
			}

			public class ListNodes_TotalResources
			{

				private int? cpu;

				private int? memory;

				private int? gpu;

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

				public int? Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}

				public int? Gpu
				{
					get
					{
						return gpu;
					}
					set	
					{
						gpu = value;
					}
				}
			}

			public class ListNodes_UsedResources
			{

				private int? cpu;

				private int? memory;

				private int? gpu;

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

				public int? Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}

				public int? Gpu
				{
					get
					{
						return gpu;
					}
					set	
					{
						gpu = value;
					}
				}
			}
		}
	}
}