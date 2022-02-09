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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListConnectionsResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private ListConnections_Data data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public ListConnections_Data Data
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

		public class ListConnections_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListConnections_ConnectionsItem> connections;

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

			public List<ListConnections_ConnectionsItem> Connections
			{
				get
				{
					return connections;
				}
				set	
				{
					connections = value;
				}
			}

			public class ListConnections_ConnectionsItem
			{

				private int? status;

				private string connectionType;

				private int? projectId;

				private string subType;

				private string gmtModified;

				private int? envType;

				private int? connectStatus;

				private int? sequence;

				private string description;

				private string gmtCreate;

				private bool? defaultEngine;

				private bool? shared;

				private string _operator;

				private string name;

				private string content;

				private int? id;

				private int? bindingCalcEngineId;

				private long? tenantId;

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

				public string ConnectionType
				{
					get
					{
						return connectionType;
					}
					set	
					{
						connectionType = value;
					}
				}

				public int? ProjectId
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

				public string SubType
				{
					get
					{
						return subType;
					}
					set	
					{
						subType = value;
					}
				}

				public string GmtModified
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

				public int? EnvType
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

				public int? ConnectStatus
				{
					get
					{
						return connectStatus;
					}
					set	
					{
						connectStatus = value;
					}
				}

				public int? Sequence
				{
					get
					{
						return sequence;
					}
					set	
					{
						sequence = value;
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

				public string GmtCreate
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

				public bool? DefaultEngine
				{
					get
					{
						return defaultEngine;
					}
					set	
					{
						defaultEngine = value;
					}
				}

				public bool? Shared
				{
					get
					{
						return shared;
					}
					set	
					{
						shared = value;
					}
				}

				public string _Operator
				{
					get
					{
						return _operator;
					}
					set	
					{
						_operator = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public int? Id
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

				public int? BindingCalcEngineId
				{
					get
					{
						return bindingCalcEngineId;
					}
					set	
					{
						bindingCalcEngineId = value;
					}
				}

				public long? TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}
			}
		}
	}
}
