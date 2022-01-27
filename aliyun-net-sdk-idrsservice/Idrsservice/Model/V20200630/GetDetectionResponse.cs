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

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
	public class GetDetectionResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetDetection_Data data;

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

		public GetDetection_Data Data
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

		public class GetDetection_Data
		{

			private string createdAt;

			private string departmentId;

			private string departmentName;

			private string id;

			private string recordingType;

			private string ruleId;

			private string ruleName;

			private string status;

			private List<GetDetection_TasksItem> tasks;

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

			public string DepartmentId
			{
				get
				{
					return departmentId;
				}
				set	
				{
					departmentId = value;
				}
			}

			public string DepartmentName
			{
				get
				{
					return departmentName;
				}
				set	
				{
					departmentName = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string RecordingType
			{
				get
				{
					return recordingType;
				}
				set	
				{
					recordingType = value;
				}
			}

			public string RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
				}
			}

			public string RuleName
			{
				get
				{
					return ruleName;
				}
				set	
				{
					ruleName = value;
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

			public List<GetDetection_TasksItem> Tasks
			{
				get
				{
					return tasks;
				}
				set	
				{
					tasks = value;
				}
			}

			public class GetDetection_TasksItem
			{

				private string createdAt;

				private string id;

				private string status;

				private string videoMetaUrl;

				private string videoUrl;

				public string CreatedAt
				{
					get
					{
						return createdAt;
					}
					set	
					{
						createdAt = value;
					}
				}

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public string VideoMetaUrl
				{
					get
					{
						return videoMetaUrl;
					}
					set	
					{
						videoMetaUrl = value;
					}
				}

				public string VideoUrl
				{
					get
					{
						return videoUrl;
					}
					set	
					{
						videoUrl = value;
					}
				}
			}
		}
	}
}
