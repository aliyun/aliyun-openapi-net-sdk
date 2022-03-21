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

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private ListAlertMessages_Data data;

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

				private long? remindId;

				private string alertMessageStatus;

				private string alertUser;

				private long? alertTime;

				private string alertMethod;

				private string source;

				private string content;

				private string remindName;

				private long? alertId;

				private List<ListAlertMessages_InstancesItem> instances;

				private List<ListAlertMessages_TopicsItem> topics;

				private List<ListAlertMessages_NodesItem> nodes;

				private ListAlertMessages_SlaAlert slaAlert;

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

					private string status;

					private long? instanceId;

					private string nodeName;

					private long? nodeId;

					private long? projectId;

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

				public class ListAlertMessages_TopicsItem
				{

					private string topicName;

					private long? instanceId;

					private long? topicId;

					private string topicOwner;

					private long? nodeId;

					private string topicStatus;

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

					private string owner;

					private string nodeName;

					private long? nodeId;

					private long? projectId;

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

					private string status;

					private string baselineOwner;

					private long? baselineId;

					private string baselineName;

					private long? bizdate;

					private long? projectId;

					private int? inGroupId;

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
				}
			}
		}
	}
}
