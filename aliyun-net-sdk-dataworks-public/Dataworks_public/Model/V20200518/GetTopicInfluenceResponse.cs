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
	public class GetTopicInfluenceResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private GetTopicInfluence_Data data;

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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public GetTopicInfluence_Data Data
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

		public class GetTopicInfluence_Data
		{

			private long? topicId;

			private List<GetTopicInfluence_InfluencesItem> influences;

			public long? TopicId
			{
				get
				{
					return topicId;
				}
				set	
				{
					topicId = value;
				}
			}

			public List<GetTopicInfluence_InfluencesItem> Influences
			{
				get
				{
					return influences;
				}
				set	
				{
					influences = value;
				}
			}

			public class GetTopicInfluence_InfluencesItem
			{

				private long? baselineId;

				private long? bizdate;

				private int? inGroupId;

				private string baselineName;

				private string owner;

				private string status;

				private long? projectId;

				private int? priority;

				private long? buffer;

				public long? BaselineId
				{
					get
					{
						return baselineId;
					}
					set	
					{
						baselineId = value;
					}
				}

				public long? Bizdate
				{
					get
					{
						return bizdate;
					}
					set	
					{
						bizdate = value;
					}
				}

				public int? InGroupId
				{
					get
					{
						return inGroupId;
					}
					set	
					{
						inGroupId = value;
					}
				}

				public string BaselineName
				{
					get
					{
						return baselineName;
					}
					set	
					{
						baselineName = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
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

				public int? Priority
				{
					get
					{
						return priority;
					}
					set	
					{
						priority = value;
					}
				}

				public long? Buffer
				{
					get
					{
						return buffer;
					}
					set	
					{
						buffer = value;
					}
				}
			}
		}
	}
}
