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
	public class GetTopicResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private GetTopic_Data data;

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

		public GetTopic_Data Data
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

		public class GetTopic_Data
		{

			private string owner;

			private string topicName;

			private string baselineStatus;

			private long? projectId;

			private long? nextAlertTime;

			private long? instanceId;

			private long? fixTime;

			private int? baselineInGroupId;

			private long? baselineBuffer;

			private string topicType;

			private string topicStatus;

			private long? happenTime;

			private long? dealTime;

			private string dealUser;

			private string baselineName;

			private long? baselineId;

			private string nodeName;

			private long? alertTime;

			private long? buffer;

			private string assigner;

			private long? topicId;

			private long? addTime;

			private long? nodeId;

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

			public string TopicName
			{
				get
				{
					return topicName;
				}
				set	
				{
					topicName = value;
				}
			}

			public string BaselineStatus
			{
				get
				{
					return baselineStatus;
				}
				set	
				{
					baselineStatus = value;
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

			public long? NextAlertTime
			{
				get
				{
					return nextAlertTime;
				}
				set	
				{
					nextAlertTime = value;
				}
			}

			public long? InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public long? FixTime
			{
				get
				{
					return fixTime;
				}
				set	
				{
					fixTime = value;
				}
			}

			public int? BaselineInGroupId
			{
				get
				{
					return baselineInGroupId;
				}
				set	
				{
					baselineInGroupId = value;
				}
			}

			public long? BaselineBuffer
			{
				get
				{
					return baselineBuffer;
				}
				set	
				{
					baselineBuffer = value;
				}
			}

			public string TopicType
			{
				get
				{
					return topicType;
				}
				set	
				{
					topicType = value;
				}
			}

			public string TopicStatus
			{
				get
				{
					return topicStatus;
				}
				set	
				{
					topicStatus = value;
				}
			}

			public long? HappenTime
			{
				get
				{
					return happenTime;
				}
				set	
				{
					happenTime = value;
				}
			}

			public long? DealTime
			{
				get
				{
					return dealTime;
				}
				set	
				{
					dealTime = value;
				}
			}

			public string DealUser
			{
				get
				{
					return dealUser;
				}
				set	
				{
					dealUser = value;
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

			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
				}
			}

			public long? AlertTime
			{
				get
				{
					return alertTime;
				}
				set	
				{
					alertTime = value;
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

			public string Assigner
			{
				get
				{
					return assigner;
				}
				set	
				{
					assigner = value;
				}
			}

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

			public long? AddTime
			{
				get
				{
					return addTime;
				}
				set	
				{
					addTime = value;
				}
			}

			public long? NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}
		}
	}
}
