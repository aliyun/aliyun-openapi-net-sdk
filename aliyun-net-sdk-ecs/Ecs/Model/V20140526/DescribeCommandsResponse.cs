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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeCommandsResponse : AcsResponse
	{

		private long? pageSize;

		private string requestId;

		private long? pageNumber;

		private long? totalCount;

		private List<DescribeCommands_Command> commands;

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeCommands_Command> Commands
		{
			get
			{
				return commands;
			}
			set	
			{
				commands = value;
			}
		}

		public class DescribeCommands_Command
		{

			private string creationTime;

			private string type;

			private long? timeout;

			private int? invokeTimes;

			private string commandId;

			private string workingDir;

			private string description;

			private int? version;

			private string provider;

			private string commandContent;

			private string category;

			private bool? latest;

			private string name;

			private bool? enableParameter;

			private List<DescribeCommands_ParameterDefinition> parameterDefinitions;

			private List<string> parameterNames;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public long? Timeout
			{
				get
				{
					return timeout;
				}
				set	
				{
					timeout = value;
				}
			}

			public int? InvokeTimes
			{
				get
				{
					return invokeTimes;
				}
				set	
				{
					invokeTimes = value;
				}
			}

			public string CommandId
			{
				get
				{
					return commandId;
				}
				set	
				{
					commandId = value;
				}
			}

			public string WorkingDir
			{
				get
				{
					return workingDir;
				}
				set	
				{
					workingDir = value;
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

			public int? Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string Provider
			{
				get
				{
					return provider;
				}
				set	
				{
					provider = value;
				}
			}

			public string CommandContent
			{
				get
				{
					return commandContent;
				}
				set	
				{
					commandContent = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public bool? Latest
			{
				get
				{
					return latest;
				}
				set	
				{
					latest = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public bool? EnableParameter
			{
				get
				{
					return enableParameter;
				}
				set	
				{
					enableParameter = value;
				}
			}

			public List<DescribeCommands_ParameterDefinition> ParameterDefinitions
			{
				get
				{
					return parameterDefinitions;
				}
				set	
				{
					parameterDefinitions = value;
				}
			}

			public List<string> ParameterNames
			{
				get
				{
					return parameterNames;
				}
				set	
				{
					parameterNames = value;
				}
			}

			public class DescribeCommands_ParameterDefinition
			{

				private bool? required;

				private string description;

				private string defaultValue;

				private string parameterName;

				private List<string> possibleValues;

				public bool? Required
				{
					get
					{
						return required;
					}
					set	
					{
						required = value;
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

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}

				public string ParameterName
				{
					get
					{
						return parameterName;
					}
					set	
					{
						parameterName = value;
					}
				}

				public List<string> PossibleValues
				{
					get
					{
						return possibleValues;
					}
					set	
					{
						possibleValues = value;
					}
				}
			}
		}
	}
}
