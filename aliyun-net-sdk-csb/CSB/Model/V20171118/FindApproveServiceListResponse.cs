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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class FindApproveServiceListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindApproveServiceList_Data data;

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

		public FindApproveServiceList_Data Data
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

		public class FindApproveServiceList_Data
		{

			private int? total;

			private int? pageNumber;

			private int? currentPage;

			private List<FindApproveServiceList_Service> serviceList;

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

			public List<FindApproveServiceList_Service> ServiceList
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

			public class FindApproveServiceList_Service
			{

				private bool? allVisiable;

				private string casTargets;

				private long? createTime;

				private long? csbId;

				private long? id;

				private string interfaceName;

				private long? modifiedTime;

				private string ownerId;

				private string principalName;

				private long? projectId;

				private string projectName;

				private int? qps;

				private string scope;

				private string serviceName;

				private string serviceVersion;

				private bool? skipAuth;

				private string statisticName;

				private int? status;

				private string userId;

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

				public long? ProjectId
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

				public int? Qps
				{
					get
					{
						return qps;
					}
					set	
					{
						qps = value;
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