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
	public class GetChangeSetResponse : AcsResponse
	{

		private string changeSetId;

		private string changeSetName;

		private string changeSetType;

		private string createTime;

		private string description;

		private bool? disableRollback;

		private string executionStatus;

		private string regionId;

		private string requestId;

		private string stackId;

		private string stackName;

		private string status;

		private string templateBody;

		private int? timeoutInMinutes;

		private string statusReason;

		private List<GetChangeSet_Parameter> parameters;

		private List<Dictionary<string, string>> changes;

		public string ChangeSetId
		{
			get
			{
				return changeSetId;
			}
			set	
			{
				changeSetId = value;
			}
		}

		public string ChangeSetName
		{
			get
			{
				return changeSetName;
			}
			set	
			{
				changeSetName = value;
			}
		}

		public string ChangeSetType
		{
			get
			{
				return changeSetType;
			}
			set	
			{
				changeSetType = value;
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

		public bool? DisableRollback
		{
			get
			{
				return disableRollback;
			}
			set	
			{
				disableRollback = value;
			}
		}

		public string ExecutionStatus
		{
			get
			{
				return executionStatus;
			}
			set	
			{
				executionStatus = value;
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

		public string StackName
		{
			get
			{
				return stackName;
			}
			set	
			{
				stackName = value;
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

		public int? TimeoutInMinutes
		{
			get
			{
				return timeoutInMinutes;
			}
			set	
			{
				timeoutInMinutes = value;
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

		public List<GetChangeSet_Parameter> Parameters
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

		public List<Dictionary<string, string>> Changes
		{
			get
			{
				return changes;
			}
			set	
			{
				changes = value;
			}
		}

		public class GetChangeSet_Parameter
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
