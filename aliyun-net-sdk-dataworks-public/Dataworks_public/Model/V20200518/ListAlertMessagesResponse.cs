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
	public class ListAlertMessagesResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private ListAlertMessages_Data data;

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

		public ListAlertMessages_Data Data
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

		public class ListAlertMessages_Data
		{

			private string pageNumber;

			private string pageSize;

			private string totalCount;

			private List<ListAlertMessages_AlertMessagesItem> alertMessages;

			public string PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public string PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public string TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<ListAlertMessages_AlertMessagesItem> AlertMessages
			{
				get
				{
					return alertMessages;
				}
				set	
				{
					alertMessages = value;
				}
			}

			public class ListAlertMessages_AlertMessagesItem
			{

				private long? alertId;

				private long? alertTime;

				private string source;

				private long? remindId;

				private string remindName;

				private string alertUser;

				private string alertMethod;

				private string alertMessageStatus;

				private string content;

				private List<ListAlertMessages_InstancesItem> instances;

				private List<ListAlertMessages_TopicsItem> topics;

				private List<ListAlertMessages_NodesItem> nodes;

				private ListAlertMessages_SlaAlert slaAlert;

				public long? AlertId
				{
					get
					{
						return alertId;
					}
					set	
					{
						alertId = value;
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

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}

				public long? RemindId
				{
					get
					{
						return remindId;
					}
					set	
					{
						remindId = value;
					}
				}

				public string RemindName
				{
					get
					{
						return remindName;
					}
					set	
					{
						remindName = value;
					}
				}

				public string AlertUser
				{
					get
					{
						return alertUser;
					}
					set	
					{
						alertUser = value;
					}
				}

				public string AlertMethod
				{
					get
					{
						return alertMethod;
					}
					set	
					{
						alertMethod = value;
					}
				}

				public string AlertMessageStatus
				{
					get
					{
						return alertMessageStatus;
					}
					set	
					{
						alertMessageStatus = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public List<ListAlertMessages_InstancesItem> Instances
				{
					get
					{
						return instances;
					}
					set	
					{
						instances = value;
					}
				}

				public List<ListAlertMessages_TopicsItem> Topics
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

				public List<ListAlertMessages_NodesItem> Nodes
				{
					get
					{
						return nodes;
					}
					set	
					{
						nodes = value;
					}
				}

				public ListAlertMessages_SlaAlert SlaAlert
				{
					get
					{
						return slaAlert;
					}
					set	
					{
						slaAlert = value;
					}
				}

				public class ListAlertMessages_InstancesItem
				{

					private long? nodeId;

					private string nodeName;

					private long? projectId;

					private string status;

					private long? instanceId;

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
				}

				public class ListAlertMessages_TopicsItem
				{

					private long? nodeId;

					private long? instanceId;

					private long? topicId;

					private string topicName;

					private string topicOwner;

					private string topicStatus;

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

					public string TopicOwner
					{
						get
						{
							return topicOwner;
						}
						set	
						{
							topicOwner = value;
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
				}

				public class ListAlertMessages_NodesItem
				{

					private long? nodeId;

					private string nodeName;

					private string owner;

					private long? projectId;

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
				}

				public class ListAlertMessages_SlaAlert
				{

					private long? baselineId;

					private string baselineName;

					private string baselineOwner;

					private long? bizdate;

					private int? inGroupId;

					private long? projectId;

					private string status;

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

					public string BaselineOwner
					{
						get
						{
							return baselineOwner;
						}
						set	
						{
							baselineOwner = value;
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
			}
		}
	}
}
