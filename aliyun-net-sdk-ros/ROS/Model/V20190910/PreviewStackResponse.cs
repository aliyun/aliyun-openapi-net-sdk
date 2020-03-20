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
	public class PreviewStackResponse : AcsResponse
	{

		private string requestId;

		private PreviewStack_Stack stack;

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

		public PreviewStack_Stack Stack
		{
			get
			{
				return stack;
			}
			set	
			{
				stack = value;
			}
		}

		public class PreviewStack_Stack
		{

			private string description;

			private bool? disableRollback;

			private string regionId;

			private string stackName;

			private string stackPolicyBody;

			private string templateDescription;

			private int? timeoutInMinutes;

			private List<PreviewStack_Parameter> parameters;

			private List<PreviewStack_Resource> resources;

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

			public string StackPolicyBody
			{
				get
				{
					return stackPolicyBody;
				}
				set	
				{
					stackPolicyBody = value;
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

			public List<PreviewStack_Parameter> Parameters
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

			public List<PreviewStack_Resource> Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}

			public class PreviewStack_Parameter
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

			public class PreviewStack_Resource
			{

				private string description;

				private string logicalResourceId;

				private string properties;

				private string resourceType;

				private string stack;

				private List<string> requiredBy;

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

				public string LogicalResourceId
				{
					get
					{
						return logicalResourceId;
					}
					set	
					{
						logicalResourceId = value;
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

				public string ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
					}
				}

				public string Stack
				{
					get
					{
						return stack;
					}
					set	
					{
						stack = value;
					}
				}

				public List<string> RequiredBy
				{
					get
					{
						return requiredBy;
					}
					set	
					{
						requiredBy = value;
					}
				}
			}
		}
	}
}
