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
	public class GetStackGroupResponse : AcsResponse
	{

		private string requestId;

		private GetStackGroup_StackGroup stackGroup;

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

		public GetStackGroup_StackGroup StackGroup
		{
			get
			{
				return stackGroup;
			}
			set	
			{
				stackGroup = value;
			}
		}

		public class GetStackGroup_StackGroup
		{

			private string stackGroupName;

			private string stackGroupId;

			private string status;

			private string description;

			private string templateBody;

			private string executionRoleName;

			private string administrationRoleName;

			private List<GetStackGroup_Parameter> parameters;

			private GetStackGroup_StackGroupDriftDetectionDetail stackGroupDriftDetectionDetail;

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

			public string TemplateBody
			{
				get
				{
					return templateBody;
				}
				set	
				{
					templateBody = value;
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

			public string AdministrationRoleName
			{
				get
				{
					return administrationRoleName;
				}
				set	
				{
					administrationRoleName = value;
				}
			}

			public List<GetStackGroup_Parameter> Parameters
			{
				get
				{
					return parameters;
				}
				set	
				{
					parameters = value;
				}
			}

			public GetStackGroup_StackGroupDriftDetectionDetail StackGroupDriftDetectionDetail
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

			public class GetStackGroup_Parameter
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

			public class GetStackGroup_StackGroupDriftDetectionDetail
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
