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
	public class GetStackGroupOperationResponse : AcsResponse
	{

		private string requestId;

		private GetStackGroupOperation_StackGroupOperation stackGroupOperation;

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

		public GetStackGroupOperation_StackGroupOperation StackGroupOperation
		{
			get
			{
				return stackGroupOperation;
			}
			set	
			{
				stackGroupOperation = value;
			}
		}

		public class GetStackGroupOperation_StackGroupOperation
		{

			private string stackGroupName;

			private string stackGroupId;

			private string operationId;

			private string operationDescription;

			private string createTime;

			private string endTime;

			private string action;

			private string status;

			private bool? retainStacks;

			private string administratorRoleName;

			private string executionRoleName;

			private GetStackGroupOperation_OperationPreferences operationPreferences;

			private GetStackGroupOperation_StackGroupDriftDetectionDetail stackGroupDriftDetectionDetail;

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

			public string OperationId
			{
				get
				{
					return operationId;
				}
				set	
				{
					operationId = value;
				}
			}

			public string OperationDescription
			{
				get
				{
					return operationDescription;
				}
				set	
				{
					operationDescription = value;
				}
			}

			public string CreateTime
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

			public string EndTime
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

			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
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

			public bool? RetainStacks
			{
				get
				{
					return retainStacks;
				}
				set	
				{
					retainStacks = value;
				}
			}

			public string AdministratorRoleName
			{
				get
				{
					return administratorRoleName;
				}
				set	
				{
					administratorRoleName = value;
				}
			}

			public string ExecutionRoleName
			{
				get
				{
					return executionRoleName;
				}
				set	
				{
					executionRoleName = value;
				}
			}

			public GetStackGroupOperation_OperationPreferences OperationPreferences
			{
				get
				{
					return operationPreferences;
				}
				set	
				{
					operationPreferences = value;
				}
			}

			public GetStackGroupOperation_StackGroupDriftDetectionDetail StackGroupDriftDetectionDetail
			{
				get
				{
					return stackGroupDriftDetectionDetail;
				}
				set	
				{
					stackGroupDriftDetectionDetail = value;
				}
			}

			public class GetStackGroupOperation_OperationPreferences
			{

				private int? failureToleranceCount;

				private int? failureTolerancePercentage;

				private int? maxConcurrentCount;

				private int? maxConcurrentPercentage;

				private List<string> regionIdsOrder;

				public int? FailureToleranceCount
				{
					get
					{
						return failureToleranceCount;
					}
					set	
					{
						failureToleranceCount = value;
					}
				}

				public int? FailureTolerancePercentage
				{
					get
					{
						return failureTolerancePercentage;
					}
					set	
					{
						failureTolerancePercentage = value;
					}
				}

				public int? MaxConcurrentCount
				{
					get
					{
						return maxConcurrentCount;
					}
					set	
					{
						maxConcurrentCount = value;
					}
				}

				public int? MaxConcurrentPercentage
				{
					get
					{
						return maxConcurrentPercentage;
					}
					set	
					{
						maxConcurrentPercentage = value;
					}
				}

				public List<string> RegionIdsOrder
				{
					get
					{
						return regionIdsOrder;
					}
					set	
					{
						regionIdsOrder = value;
					}
				}
			}

			public class GetStackGroupOperation_StackGroupDriftDetectionDetail
			{

				private string driftDetectionTime;

				private string stackGroupDriftStatus;

				private string driftDetectionStatus;

				private int? driftedStackInstancesCount;

				private int? failedStackInstancesCount;

				private int? cancelledStackInstancesCount;

				private int? inProgressStackInstancesCount;

				private int? inSyncStackInstancesCount;

				private int? totalStackInstancesCount;

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

				public string StackGroupDriftStatus
				{
					get
					{
						return stackGroupDriftStatus;
					}
					set	
					{
						stackGroupDriftStatus = value;
					}
				}

				public string DriftDetectionStatus
				{
					get
					{
						return driftDetectionStatus;
					}
					set	
					{
						driftDetectionStatus = value;
					}
				}

				public int? DriftedStackInstancesCount
				{
					get
					{
						return driftedStackInstancesCount;
					}
					set	
					{
						driftedStackInstancesCount = value;
					}
				}

				public int? FailedStackInstancesCount
				{
					get
					{
						return failedStackInstancesCount;
					}
					set	
					{
						failedStackInstancesCount = value;
					}
				}

				public int? CancelledStackInstancesCount
				{
					get
					{
						return cancelledStackInstancesCount;
					}
					set	
					{
						cancelledStackInstancesCount = value;
					}
				}

				public int? InProgressStackInstancesCount
				{
					get
					{
						return inProgressStackInstancesCount;
					}
					set	
					{
						inProgressStackInstancesCount = value;
					}
				}

				public int? InSyncStackInstancesCount
				{
					get
					{
						return inSyncStackInstancesCount;
					}
					set	
					{
						inSyncStackInstancesCount = value;
					}
				}

				public int? TotalStackInstancesCount
				{
					get
					{
						return totalStackInstancesCount;
					}
					set	
					{
						totalStackInstancesCount = value;
					}
				}
			}
		}
	}
}
