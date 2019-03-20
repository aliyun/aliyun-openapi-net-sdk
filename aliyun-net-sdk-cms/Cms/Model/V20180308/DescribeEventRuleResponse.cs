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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class DescribeEventRuleResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private string requestId;

		private DescribeEventRule_Result result;

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public DescribeEventRule_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeEventRule_Result
		{

			private string description;

			private string name;

			private string eventType;

			private string groupId;

			private string state;

			private DescribeEventRule_EventPattern eventPattern;

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

			public string EventType
			{
				get
				{
					return eventType;
				}
				set	
				{
					eventType = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public DescribeEventRule_EventPattern EventPattern
			{
				get
				{
					return eventPattern;
				}
				set	
				{
					eventPattern = value;
				}
			}

			public class DescribeEventRule_EventPattern
			{

				private string product;

				private List<string> nameList;

				private List<string> statusList;

				private List<string> levelList;

				public string Product
				{
					get
					{
						return product;
					}
					set	
					{
						product = value;
					}
				}

				public List<string> NameList
				{
					get
					{
						return nameList;
					}
					set	
					{
						nameList = value;
					}
				}

				public List<string> StatusList
				{
					get
					{
						return statusList;
					}
					set	
					{
						statusList = value;
					}
				}

				public List<string> LevelList
				{
					get
					{
						return levelList;
					}
					set	
					{
						levelList = value;
					}
				}
			}
		}
	}
}
