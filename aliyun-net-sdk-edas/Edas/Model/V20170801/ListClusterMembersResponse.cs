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
	public class ListClusterMembersResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListClusterMembers_ClusterMemberPage clusterMemberPage;

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

		public ListClusterMembers_ClusterMemberPage ClusterMemberPage
		{
			get
			{
				return clusterMemberPage;
			}
			set	
			{
				clusterMemberPage = value;
			}
		}

		public class ListClusterMembers_ClusterMemberPage
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalSize;

			private List<ListClusterMembers_ClusterMember> clusterMemberList;

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

			public List<ListClusterMembers_ClusterMember> ClusterMemberList
			{
				get
				{
					return clusterMemberList;
				}
				set	
				{
					clusterMemberList = value;
				}
			}

			public class ListClusterMembers_ClusterMember
			{

				private string clusterMemberId;

				private string clusterId;

				private string ecuId;

				private string ecsId;

				private int? status;

				private long? createTime;

				private long? updateTime;

				public string ClusterMemberId
				{
					get
					{
						return clusterMemberId;
					}
					set	
					{
						clusterMemberId = value;
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

				public string EcuId
				{
					get
					{
						return ecuId;
					}
					set	
					{
						ecuId = value;
					}
				}

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

				public int? Status
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
			}
		}
	}
}
