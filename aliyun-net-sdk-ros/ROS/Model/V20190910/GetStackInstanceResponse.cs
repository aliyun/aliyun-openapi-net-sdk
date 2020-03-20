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

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class GetStackInstanceResponse : AcsResponse
	{

		private string requestId;

		private GetStackInstance_StackInstance stackInstance;

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

		public GetStackInstance_StackInstance StackInstance
		{
			get
			{
				return stackInstance;
			}
			set	
			{
				stackInstance = value;
			}
		}

		public class GetStackInstance_StackInstance
		{

			private string stackGroupName;

			private string stackGroupId;

			private string stackId;

			private string accountId;

			private string regionId;

			private string status;

			private string statusReason;

			private string stackDriftStatus;

			private string driftDetectionTime;

			private List<GetStackInstance_ParameterOverride> parameterOverrides;

			public string StackGroupName
			{
				get
				{
					return stackGroupName;
				}
				set	
				{
					stackGroupName = value;
				}
			}

			public string StackGroupId
			{
				get
				{
					return stackGroupId;
				}
				set	
				{
					stackGroupId = value;
				}
			}

			public string StackId
			{
				get
				{
					return stackId;
				}
				set	
				{
					stackId = value;
				}
			}

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
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

			public string StatusReason
			{
				get
				{
					return statusReason;
				}
				set	
				{
					statusReason = value;
				}
			}

			public string StackDriftStatus
			{
				get
				{
					return stackDriftStatus;
				}
				set	
				{
					stackDriftStatus = value;
				}
			}

			public string DriftDetectionTime
			{
				get
				{
					return driftDetectionTime;
				}
				set	
				{
					driftDetectionTime = value;
				}
			}

			public List<GetStackInstance_ParameterOverride> ParameterOverrides
			{
				get
				{
					return parameterOverrides;
				}
				set	
				{
					parameterOverrides = value;
				}
			}

			public class GetStackInstance_ParameterOverride
			{

				private string parameterKey;

				private string parameterValue;

				public string ParameterKey
				{
					get
					{
						return parameterKey;
					}
					set	
					{
						parameterKey = value;
					}
				}

				public string ParameterValue
				{
					get
					{
						return parameterValue;
					}
					set	
					{
						parameterValue = value;
					}
				}
			}
		}
	}
}
