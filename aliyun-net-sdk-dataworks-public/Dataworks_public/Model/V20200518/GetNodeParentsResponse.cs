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
	public class GetNodeParentsResponse : AcsResponse
	{

		private bool? success;

		private int? httpStatusCode;

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private GetNodeParents_Data data;

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

		public GetNodeParents_Data Data
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

		public class GetNodeParents_Data
		{

			private List<GetNodeParents_NodesItem> nodes;

			public List<GetNodeParents_NodesItem> Nodes
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

			public class GetNodeParents_NodesItem
			{

				private long? nodeId;

				private string nodeName;

				private string cronExpress;

				private string schedulerType;

				private string programType;

				private string ownerId;

				private long? projectId;

				private bool? repeatability;

				private int? priority;

				private long? baselineId;

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

				public int? Priority
				{
					get
					{
						return priority;
					}
					set	
					{
						priority = value;
					}
				}

				public long? BaselineId
				{
					get
					{
						return baselineId;
					}
					set	
					{
						baselineId = value;
					}
				}
			}
		}
	}
}
