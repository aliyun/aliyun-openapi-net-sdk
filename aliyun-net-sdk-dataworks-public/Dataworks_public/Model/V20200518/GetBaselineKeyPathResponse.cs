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
	public class GetBaselineKeyPathResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private List<GetBaselineKeyPath_DataItem> data;

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

		public List<GetBaselineKeyPath_DataItem> Data
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

		public class GetBaselineKeyPath_DataItem
		{

			private long? instanceId;

			private long? projectId;

			private long? nodeId;

			private string nodeName;

			private long? bizdate;

			private int? inGroupId;

			private string owner;

			private int? prgType;

			private List<GetBaselineKeyPath_RunsItem> runs;

			private List<GetBaselineKeyPath_TopicsItem> topics;

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

			public int? PrgType
			{
				get
				{
					return prgType;
				}
				set	
				{
					prgType = value;
				}
			}

			public List<GetBaselineKeyPath_RunsItem> Runs
			{
				get
				{
					return runs;
				}
				set	
				{
					runs = value;
				}
			}

			public List<GetBaselineKeyPath_TopicsItem> Topics
			{
				get
				{
					return topics;
				}
				set	
				{
					topics = value;
				}
			}

			public class GetBaselineKeyPath_RunsItem
			{

				private long? absTime;

				private long? beginCast;

				private long? beginRunningTime;

				private long? beginWaitResTime;

				private long? beginWaitTimeTime;

				private long? bizdate;

				private long? cycTime;

				private long? endCast;

				private long? finishTime;

				private int? inGroupId;

				private long? instanceId;

				private long? nodeId;

				private string nodeName;

				private string owner;

				private long? projectId;

				private string status;

				public long? AbsTime
				{
					get
					{
						return absTime;
					}
					set	
					{
						absTime = value;
					}
				}

				public long? BeginCast
				{
					get
					{
						return beginCast;
					}
					set	
					{
						beginCast = value;
					}
				}

				public long? BeginRunningTime
				{
					get
					{
						return beginRunningTime;
					}
					set	
					{
						beginRunningTime = value;
					}
				}

				public long? BeginWaitResTime
				{
					get
					{
						return beginWaitResTime;
					}
					set	
					{
						beginWaitResTime = value;
					}
				}

				public long? BeginWaitTimeTime
				{
					get
					{
						return beginWaitTimeTime;
					}
					set	
					{
						beginWaitTimeTime = value;
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

				public long? CycTime
				{
					get
					{
						return cycTime;
					}
					set	
					{
						cycTime = value;
					}
				}

				public long? EndCast
				{
					get
					{
						return endCast;
					}
					set	
					{
						endCast = value;
					}
				}

				public long? FinishTime
				{
					get
					{
						return finishTime;
					}
					set	
					{
						finishTime = value;
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
			}

			public class GetBaselineKeyPath_TopicsItem
			{

				private long? instanceId;

				private long? topicId;

				private long? topicName;

				private long? addTime;

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

				public long? TopicName
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
			}
		}
	}
}
