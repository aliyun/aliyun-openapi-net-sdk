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
	public class ListNodesResponse : AcsResponse
	{

		private bool? success;

		private int? httpStatusCode;

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private ListNodes_Data data;

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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public ListNodes_Data Data
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

		public class ListNodes_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListNodes_NodesItem> nodes;

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

			public List<ListNodes_NodesItem> Nodes
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

			public class ListNodes_NodesItem
			{

				private long? nodeId;

				private string nodeName;

				private string cronExpress;

				private string schedulerType;

				private string programType;

				private string ownerId;

				private long? projectId;

				private bool? repeatability;

				private string paramValues;

				private string description;

				private string resGroupName;

				public long? NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public string CronExpress
				{
					get
					{
						return cronExpress;
					}
					set	
					{
						cronExpress = value;
					}
				}

				public string SchedulerType
				{
					get
					{
						return schedulerType;
					}
					set	
					{
						schedulerType = value;
					}
				}

				public string ProgramType
				{
					get
					{
						return programType;
					}
					set	
					{
						programType = value;
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

				public bool? Repeatability
				{
					get
					{
						return repeatability;
					}
					set	
					{
						repeatability = value;
					}
				}

				public string ParamValues
				{
					get
					{
						return paramValues;
					}
					set	
					{
						paramValues = value;
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

				public string ResGroupName
				{
					get
					{
						return resGroupName;
					}
					set	
					{
						resGroupName = value;
					}
				}
			}
		}
	}
}
