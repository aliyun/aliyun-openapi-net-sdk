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
	public class ListNodesByOutputResponse : AcsResponse
	{

		private bool? success;

		private int? httpStatusCode;

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private List<ListNodesByOutput_OutputNodePair> data;

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

		public List<ListNodesByOutput_OutputNodePair> Data
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

		public class ListNodesByOutput_OutputNodePair
		{

			private string output;

			private List<ListNodesByOutput_Node> nodeList;

			public string Output
			{
				get
				{
					return output;
				}
				set	
				{
					output = value;
				}
			}

			public List<ListNodesByOutput_Node> NodeList
			{
				get
				{
					return nodeList;
				}
				set	
				{
					nodeList = value;
				}
			}

			public class ListNodesByOutput_Node
			{

				private long? nodeId;

				private string nodeName;

				private string ownerId;

				private string description;

				private string resGroupName;

				private string cronExpress;

				private bool? repeatability;

				private string programType;

				private long? projectId;

				private string schedulerType;

				private string paramValues;

				private int? priority;

				private long? baselineId;

				private int? repeatInterval;

				private string connection;

				private int? dqcType;

				private string dqcDescription;

				private long? relatedFlowId;

				private string fileType;

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

				public int? RepeatInterval
				{
					get
					{
						return repeatInterval;
					}
					set	
					{
						repeatInterval = value;
					}
				}

				public string Connection
				{
					get
					{
						return connection;
					}
					set	
					{
						connection = value;
					}
				}

				public int? DqcType
				{
					get
					{
						return dqcType;
					}
					set	
					{
						dqcType = value;
					}
				}

				public string DqcDescription
				{
					get
					{
						return dqcDescription;
					}
					set	
					{
						dqcDescription = value;
					}
				}

				public long? RelatedFlowId
				{
					get
					{
						return relatedFlowId;
					}
					set	
					{
						relatedFlowId = value;
					}
				}

				public string FileType
				{
					get
					{
						return fileType;
					}
					set	
					{
						fileType = value;
					}
				}
			}
		}
	}
}
