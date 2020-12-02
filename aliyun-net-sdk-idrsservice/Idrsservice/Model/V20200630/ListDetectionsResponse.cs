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
	public class ListDetectionsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<ListDetections_ErrorsItem> errors;

		private ListDetections_Data data;

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

		public List<ListDetections_ErrorsItem> Errors
		{
			get
			{
				return errors;
			}
			set	
			{
				errors = value;
			}
		}

		public ListDetections_Data Data
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

		public class ListDetections_ErrorsItem
		{

			private string field;

			private string message;

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
		}

		public class ListDetections_Data
		{

			private long? totalElements;

			private int? totalPages;

			private List<ListDetections_ItemsItem> items;

			public long? TotalElements
			{
				get
				{
					return totalElements;
				}
				set	
				{
					totalElements = value;
				}
			}

			public int? TotalPages
			{
				get
				{
					return totalPages;
				}
				set	
				{
					totalPages = value;
				}
			}

			public List<ListDetections_ItemsItem> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class ListDetections_ItemsItem
			{

				private string createdAt;

				private string departmentId;

				private string departmentName;

				private string id;

				private string recordingType;

				private string ruleId;

				private string ruleName;

				private string status;

				private List<ListDetections_TasksItem> tasks;

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

				public List<ListDetections_TasksItem> Tasks
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

				public class ListDetections_TasksItem
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
}
