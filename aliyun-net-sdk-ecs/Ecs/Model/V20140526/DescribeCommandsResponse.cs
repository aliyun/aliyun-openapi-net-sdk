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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeCommandsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeCommands_Command> commands;

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

			private string commandId;

			private string name;

			private string type;

			private string description;

			private string commandContent;

			private string workingDir;

			private long? timeout;

			private int? invokeTimes;

			private string creationTime;

			private bool? enableParameter;

			private List<string> parameterNames;

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
		}
	}
}
