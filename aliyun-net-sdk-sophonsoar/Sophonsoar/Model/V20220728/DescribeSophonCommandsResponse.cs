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
	public class DescribeSophonCommandsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSophonCommands_DataItem> data;

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

		public List<DescribeSophonCommands_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeSophonCommands_DataItem
		{

			private string name;

			private string displayName;

			private string commandEntity;

			private string commandTag;

			private string description;

			private string actionType;

			private string taskConfig;

			private List<DescribeSophonCommands_ParamConfigItem> paramConfig;

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

			public string CommandTag
			{
				get
				{
					return commandTag;
				}
				set	
				{
					commandTag = value;
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

			public List<DescribeSophonCommands_ParamConfigItem> ParamConfig
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

			public class DescribeSophonCommands_ParamConfigItem
			{

				private bool? necessary;

				private string field;

				private string _value;

				private string checkField;

				public bool? Necessary
				{
					get
					{
						return necessary;
					}
					set	
					{
						necessary = value;
					}
				}

				public string Field
				{
					get
					{
						return field;
					}
					set	
					{
						field = value;
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

				public string CheckField
				{
					get
					{
						return checkField;
					}
					set	
					{
						checkField = value;
					}
				}
			}
		}
	}
}
