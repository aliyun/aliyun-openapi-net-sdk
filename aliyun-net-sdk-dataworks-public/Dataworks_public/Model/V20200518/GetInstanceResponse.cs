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
	public class GetInstanceResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private bool? success;

		private string errorCode;

		private GetInstance_Data data;

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

		public GetInstance_Data Data
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

		public class GetInstance_Data
		{

			private string status;

			private long? cycTime;

			private long? beginRunningTime;

			private long? finishTime;

			private string errorMessage;

			private long? createTime;

			private long? dagId;

			private int? priority;

			private string taskType;

			private string paramValues;

			private string connection;

			private long? baselineId;

			private int? dqcType;

			private string dagType;

			private long? businessId;

			private int? taskRerunTime;

			private long? modifyTime;

			private bool? repeatability;

			private long? repeatInterval;

			private long? instanceId;

			private long? beginWaitResTime;

			private long? relatedFlowId;

			private long? bizdate;

			private string nodeName;

			private long? beginWaitTimeTime;

			private string dqcDescription;

			private long? nodeId;

			private string createUser;

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

			public long? CycTime
			{
				get
				{
					return cycTime;
				}
				set	
				{
					cycTime = value;
				}
			}

			public long? BeginRunningTime
			{
				get
				{
					return beginRunningTime;
				}
				set	
				{
					beginRunningTime = value;
				}
			}

			public long? FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
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

			public long? DagId
			{
				get
				{
					return dagId;
				}
				set	
				{
					dagId = value;
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

			public string TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
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

			public string DagType
			{
				get
				{
					return dagType;
				}
				set	
				{
					dagType = value;
				}
			}

			public long? BusinessId
			{
				get
				{
					return businessId;
				}
				set	
				{
					businessId = value;
				}
			}

			public int? TaskRerunTime
			{
				get
				{
					return taskRerunTime;
				}
				set	
				{
					taskRerunTime = value;
				}
			}

			public long? ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
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

			public long? RepeatInterval
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

			public long? InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public long? BeginWaitResTime
			{
				get
				{
					return beginWaitResTime;
				}
				set	
				{
					beginWaitResTime = value;
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

			public long? Bizdate
			{
				get
				{
					return bizdate;
				}
				set	
				{
					bizdate = value;
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

			public long? BeginWaitTimeTime
			{
				get
				{
					return beginWaitTimeTime;
				}
				set	
				{
					beginWaitTimeTime = value;
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

			public string CreateUser
			{
				get
				{
					return createUser;
				}
				set	
				{
					createUser = value;
				}
			}
		}
	}
}
