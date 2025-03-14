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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeExecutePlaybooksResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeExecutePlaybooks_Data> playbookMetrics;

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

		public List<DescribeExecutePlaybooks_Data> PlaybookMetrics
		{
			get
			{
				return playbookMetrics;
			}
			set	
			{
				playbookMetrics = value;
			}
		}

		public class DescribeExecutePlaybooks_Data
		{

			private string description;

			private string actionType;

			private string displayName;

			private string uuid;

			private string taskConfig;

			private string paramConfig;

			private string commandEntity;

			private string paramType;

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

			public string ActionType
			{
				get
				{
					return actionType;
				}
				set	
				{
					actionType = value;
				}
			}

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string TaskConfig
			{
				get
				{
					return taskConfig;
				}
				set	
				{
					taskConfig = value;
				}
			}

			public string ParamConfig
			{
				get
				{
					return paramConfig;
				}
				set	
				{
					paramConfig = value;
				}
			}

			public string CommandEntity
			{
				get
				{
					return commandEntity;
				}
				set	
				{
					commandEntity = value;
				}
			}

			public string ParamType
			{
				get
				{
					return paramType;
				}
				set	
				{
					paramType = value;
				}
			}
		}
	}
}
