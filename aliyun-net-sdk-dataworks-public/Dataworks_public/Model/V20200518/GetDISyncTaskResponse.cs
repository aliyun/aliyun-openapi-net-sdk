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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetDISyncTaskResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private GetDISyncTask_Data data;

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

		public GetDISyncTask_Data Data
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

		public class GetDISyncTask_Data
		{

			private string code;

			private string status;

			private string message;

			private GetDISyncTask_SolutionDetail solutionDetail;

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

			public GetDISyncTask_SolutionDetail SolutionDetail
			{
				get
				{
					return solutionDetail;
				}
				set	
				{
					solutionDetail = value;
				}
			}

			public class GetDISyncTask_SolutionDetail
			{

				private string status;

				private string type;

				private string startTime;

				private string creatorName;

				private long? projectId;

				private string sourceType;

				private string processContent;

				private string name;

				private string processExtra;

				private string submitTime;

				private long? id;

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

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string CreatorName
				{
					get
					{
						return creatorName;
					}
					set	
					{
						creatorName = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}

				public string ProcessContent
				{
					get
					{
						return processContent;
					}
					set	
					{
						processContent = value;
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

				public string ProcessExtra
				{
					get
					{
						return processExtra;
					}
					set	
					{
						processExtra = value;
					}
				}

				public string SubmitTime
				{
					get
					{
						return submitTime;
					}
					set	
					{
						submitTime = value;
					}
				}

				public long? Id
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
			}
		}
	}
}
