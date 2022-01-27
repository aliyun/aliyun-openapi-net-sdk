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
	public class GetStackResponse : AcsResponse
	{

		private string createTime;

		private string description;

		private bool? disableRollback;

		private string regionId;

		private string requestId;

		private string stackId;

		private string stackName;

		private string status;

		private string statusReason;

		private string templateDescription;

		private int? timeoutInMinutes;

		private string updateTime;

		private string parentStackId;

		private string stackDriftStatus;

		private string driftDetectionTime;

		private string ramRoleName;

		private string deletionProtection;

		private string rootStackId;

		private string stackType;

		private List<GetStack_Parameter> parameters;

		private List<GetStack_Tag> tags;

		private List<Dictionary<string, string>> outputs;

		private List<string> notificationURLs;

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

		public string TemplateDescription
		{
			get
			{
				return templateDescription;
			}
			set	
			{
				templateDescription = value;
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

		public string UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public string ParentStackId
		{
			get
			{
				return parentStackId;
			}
			set	
			{
				parentStackId = value;
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

		public string RamRoleName
		{
			get
			{
				return ramRoleName;
			}
			set	
			{
				ramRoleName = value;
			}
		}

		public string DeletionProtection
		{
			get
			{
				return deletionProtection;
			}
			set	
			{
				deletionProtection = value;
			}
		}

		public string RootStackId
		{
			get
			{
				return rootStackId;
			}
			set	
			{
				rootStackId = value;
			}
		}

		public string StackType
		{
			get
			{
				return stackType;
			}
			set	
			{
				stackType = value;
			}
		}

		public List<GetStack_Parameter> Parameters
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

		public List<GetStack_Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public List<Dictionary<string, string>> Outputs
		{
			get
			{
				return outputs;
			}
			set	
			{
				outputs = value;
			}
		}

		public List<string> NotificationURLs
		{
			get
			{
				return notificationURLs;
			}
			set	
			{
				notificationURLs = value;
			}
		}

		public class GetStack_Parameter
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

		public class GetStack_Tag
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}
	}
}
