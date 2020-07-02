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
	public class GetBaselineStatusResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private GetBaselineStatus_Data data;

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

		public GetBaselineStatus_Data Data
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

		public class GetBaselineStatus_Data
		{

			private string baselineName;

			private long? baselineId;

			private long? bizdate;

			private string owner;

			private long? expTime;

			private long? finishTime;

			private long? endCast;

			private long? slaTime;

			private int? priority;

			private long? projectId;

			private float? buffer;

			private string status;

			private string finishStatus;

			private int? inGroupId;

			private GetBaselineStatus_LastInstance lastInstance;

			private GetBaselineStatus_BlockInstance blockInstance;

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

			public long? ExpTime
			{
				get
				{
					return expTime;
				}
				set	
				{
					expTime = value;
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

			public long? SlaTime
			{
				get
				{
					return slaTime;
				}
				set	
				{
					slaTime = value;
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

			public float? Buffer
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

			public string FinishStatus
			{
				get
				{
					return finishStatus;
				}
				set	
				{
					finishStatus = value;
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

			public GetBaselineStatus_LastInstance LastInstance
			{
				get
				{
					return lastInstance;
				}
				set	
				{
					lastInstance = value;
				}
			}

			public GetBaselineStatus_BlockInstance BlockInstance
			{
				get
				{
					return blockInstance;
				}
				set	
				{
					blockInstance = value;
				}
			}

			public class GetBaselineStatus_LastInstance
			{

				private long? instanceId;

				private string status;

				private long? projectId;

				private string owner;

				private long? nodeId;

				private long? finishTime;

				private long? endCast;

				private string nodeName;

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
			}

			public class GetBaselineStatus_BlockInstance
			{

				private long? instanceId;

				private string status;

				private long? projectId;

				private string owner;

				private long? nodeId;

				private long? finishTime;

				private long? endCast;

				private string nodeName;

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
			}
		}
	}
}
