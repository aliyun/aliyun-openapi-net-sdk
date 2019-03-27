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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class FindOrderableListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindOrderableList_Data data;

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

		public FindOrderableList_Data Data
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

		public class FindOrderableList_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private List<FindOrderableList_Service> serviceList;

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

			public List<FindOrderableList_Service> ServiceList
			{
				get
				{
					return serviceList;
				}
				set	
				{
					serviceList = value;
				}
			}

			public class FindOrderableList_Service
			{

				private string alias;

				private bool? allVisiable;

				private string approveUserId;

				private string casTargets;

				private long? createTime;

				private long? csbId;

				private long? id;

				private string interfaceName;

				private long? modifiedTime;

				private string ownerId;

				private string principalName;

				private string projectId;

				private string projectName;

				private string scope;

				private string serviceName;

				private string serviceVersion;

				private bool? skipAuth;

				private string statisticName;

				private int? status;

				private string userId;

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}

				public bool? AllVisiable
				{
					get
					{
						return allVisiable;
					}
					set	
					{
						allVisiable = value;
					}
				}

				public string ApproveUserId
				{
					get
					{
						return approveUserId;
					}
					set	
					{
						approveUserId = value;
					}
				}

				public string CasTargets
				{
					get
					{
						return casTargets;
					}
					set	
					{
						casTargets = value;
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

				public long? CsbId
				{
					get
					{
						return csbId;
					}
					set	
					{
						csbId = value;
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

				public string InterfaceName
				{
					get
					{
						return interfaceName;
					}
					set	
					{
						interfaceName = value;
					}
				}

				public long? ModifiedTime
				{
					get
					{
						return modifiedTime;
					}
					set	
					{
						modifiedTime = value;
					}
				}

				public string OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
					}
				}

				public string PrincipalName
				{
					get
					{
						return principalName;
					}
					set	
					{
						principalName = value;
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

				public string ProjectName
				{
					get
					{
						return projectName;
					}
					set	
					{
						projectName = value;
					}
				}

				public string Scope
				{
					get
					{
						return scope;
					}
					set	
					{
						scope = value;
					}
				}

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string ServiceVersion
				{
					get
					{
						return serviceVersion;
					}
					set	
					{
						serviceVersion = value;
					}
				}

				public bool? SkipAuth
				{
					get
					{
						return skipAuth;
					}
					set	
					{
						skipAuth = value;
					}
				}

				public string StatisticName
				{
					get
					{
						return statisticName;
					}
					set	
					{
						statisticName = value;
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

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}
			}
		}
	}
}
