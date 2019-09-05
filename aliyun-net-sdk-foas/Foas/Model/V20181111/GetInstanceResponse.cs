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

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class GetInstanceResponse : AcsResponse
	{

		private string requestId;

		private GetInstance_Instance instance;

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

		public GetInstance_Instance Instance
		{
			get
			{
				return instance;
			}
			set	
			{
				instance = value;
			}
		}

		public class GetInstance_Instance
		{

			private long? id;

			private string projectName;

			private string jobName;

			private string actualState;

			private string expectState;

			private string jobType;

			private string apiType;

			private string code;

			private string properties;

			private string packages;

			private string starter;

			private long? startTime;

			private long? lastErrorTime;

			private string lastErrorMessage;

			private string lastOperator;

			private long? lastOperateTime;

			private string planJson;

			private string engineVersion;

			private string engineJobHandler;

			private long? inputDelay;

			private string clusterId;

			private string queueName;

			private long? endTime;

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

			public string JobName
			{
				get
				{
					return jobName;
				}
				set	
				{
					jobName = value;
				}
			}

			public string ActualState
			{
				get
				{
					return actualState;
				}
				set	
				{
					actualState = value;
				}
			}

			public string ExpectState
			{
				get
				{
					return expectState;
				}
				set	
				{
					expectState = value;
				}
			}

			public string JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
				}
			}

			public string ApiType
			{
				get
				{
					return apiType;
				}
				set	
				{
					apiType = value;
				}
			}

			public string Code
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

			public string Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
				}
			}

			public string Packages
			{
				get
				{
					return packages;
				}
				set	
				{
					packages = value;
				}
			}

			public string Starter
			{
				get
				{
					return starter;
				}
				set	
				{
					starter = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public long? LastErrorTime
			{
				get
				{
					return lastErrorTime;
				}
				set	
				{
					lastErrorTime = value;
				}
			}

			public string LastErrorMessage
			{
				get
				{
					return lastErrorMessage;
				}
				set	
				{
					lastErrorMessage = value;
				}
			}

			public string LastOperator
			{
				get
				{
					return lastOperator;
				}
				set	
				{
					lastOperator = value;
				}
			}

			public long? LastOperateTime
			{
				get
				{
					return lastOperateTime;
				}
				set	
				{
					lastOperateTime = value;
				}
			}

			public string PlanJson
			{
				get
				{
					return planJson;
				}
				set	
				{
					planJson = value;
				}
			}

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string EngineJobHandler
			{
				get
				{
					return engineJobHandler;
				}
				set	
				{
					engineJobHandler = value;
				}
			}

			public long? InputDelay
			{
				get
				{
					return inputDelay;
				}
				set	
				{
					inputDelay = value;
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

			public string QueueName
			{
				get
				{
					return queueName;
				}
				set	
				{
					queueName = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}
		}
	}
}
