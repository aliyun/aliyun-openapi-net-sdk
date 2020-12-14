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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetTaskListFilterResponse : AcsResponse
	{

		private string errorMsg;

		private string requestId;

		private string errorCode;

		private string successful;

		private GetTaskListFilter__Object _object;

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public string Successful
		{
			get
			{
				return successful;
			}
			set	
			{
				successful = value;
			}
		}

		public GetTaskListFilter__Object _Object
		{
			get
			{
				return _object;
			}
			set	
			{
				_object = value;
			}
		}

		public class GetTaskListFilter__Object
		{

			private string nextPageToken;

			private int? totalSize;

			private List<GetTaskListFilter_Task> result;

			public string NextPageToken
			{
				get
				{
					return nextPageToken;
				}
				set	
				{
					nextPageToken = value;
				}
			}

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
				}
			}

			public List<GetTaskListFilter_Task> Result
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

			public class GetTaskListFilter_Task
			{

				private string id;

				private string creatorId;

				private string executorId;

				private string projectId;

				private string taskListId;

				private string organizationId;

				private string stageId;

				private string visible;

				private string updated;

				private string created;

				private bool? isArchived;

				private bool? isDone;

				private bool? isTopInProject;

				private int? priority;

				private int? pos;

				private string startDate;

				private string dueDate;

				private string accomplished;

				private string note;

				private string content;

				private string recurrence;

				private string sourceId;

				private string sourceDate;

				private int? commentsCount;

				private int? attachmentsCount;

				private int? likesCount;

				private int? objectlinksCount;

				private int? uniqueId;

				private string storyPoint;

				private int? progress;

				private int? rating;

				private bool? isFavorite;

				private string scenariofFeldConfigId;

				private int? shareStatus;

				private string sprintId;

				private string taskFlowStatusId;

				private string objectType;

				private string source;

				private string untilDate;

				private string taskId;

				private string sprint;

				private string parent;

				private string taskUniqueId;

				private List<GetTaskListFilter_Customfield> customfields;

				private List<string> ancestorIds;

				private List<string> labels;

				private List<string> tagIds;

				private List<string> involveMembers;

				private List<string> divisions;

				private GetTaskListFilter_WorkTime workTime;

				private GetTaskListFilter_Badges badges;

				private GetTaskListFilter_SubtaskCount subtaskCount;

				private GetTaskListFilter_Reminder reminder;

				private GetTaskListFilter_Creator creator;

				private GetTaskListFilter_Stage stage;

				private GetTaskListFilter_Executor executor;

				private GetTaskListFilter_TaskFlowStatus taskFlowStatus;

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

				public string CreatorId
				{
					get
					{
						return creatorId;
					}
					set	
					{
						creatorId = value;
					}
				}

				public string ExecutorId
				{
					get
					{
						return executorId;
					}
					set	
					{
						executorId = value;
					}
				}

				public string ProjectId
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

				public string TaskListId
				{
					get
					{
						return taskListId;
					}
					set	
					{
						taskListId = value;
					}
				}

				public string OrganizationId
				{
					get
					{
						return organizationId;
					}
					set	
					{
						organizationId = value;
					}
				}

				public string StageId
				{
					get
					{
						return stageId;
					}
					set	
					{
						stageId = value;
					}
				}

				public string Visible
				{
					get
					{
						return visible;
					}
					set	
					{
						visible = value;
					}
				}

				public string Updated
				{
					get
					{
						return updated;
					}
					set	
					{
						updated = value;
					}
				}

				public string Created
				{
					get
					{
						return created;
					}
					set	
					{
						created = value;
					}
				}

				public bool? IsArchived
				{
					get
					{
						return isArchived;
					}
					set	
					{
						isArchived = value;
					}
				}

				public bool? IsDone
				{
					get
					{
						return isDone;
					}
					set	
					{
						isDone = value;
					}
				}

				public bool? IsTopInProject
				{
					get
					{
						return isTopInProject;
					}
					set	
					{
						isTopInProject = value;
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

				public int? Pos
				{
					get
					{
						return pos;
					}
					set	
					{
						pos = value;
					}
				}

				public string StartDate
				{
					get
					{
						return startDate;
					}
					set	
					{
						startDate = value;
					}
				}

				public string DueDate
				{
					get
					{
						return dueDate;
					}
					set	
					{
						dueDate = value;
					}
				}

				public string Accomplished
				{
					get
					{
						return accomplished;
					}
					set	
					{
						accomplished = value;
					}
				}

				public string Note
				{
					get
					{
						return note;
					}
					set	
					{
						note = value;
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

				public string Recurrence
				{
					get
					{
						return recurrence;
					}
					set	
					{
						recurrence = value;
					}
				}

				public string SourceId
				{
					get
					{
						return sourceId;
					}
					set	
					{
						sourceId = value;
					}
				}

				public string SourceDate
				{
					get
					{
						return sourceDate;
					}
					set	
					{
						sourceDate = value;
					}
				}

				public int? CommentsCount
				{
					get
					{
						return commentsCount;
					}
					set	
					{
						commentsCount = value;
					}
				}

				public int? AttachmentsCount
				{
					get
					{
						return attachmentsCount;
					}
					set	
					{
						attachmentsCount = value;
					}
				}

				public int? LikesCount
				{
					get
					{
						return likesCount;
					}
					set	
					{
						likesCount = value;
					}
				}

				public int? ObjectlinksCount
				{
					get
					{
						return objectlinksCount;
					}
					set	
					{
						objectlinksCount = value;
					}
				}

				public int? UniqueId
				{
					get
					{
						return uniqueId;
					}
					set	
					{
						uniqueId = value;
					}
				}

				public string StoryPoint
				{
					get
					{
						return storyPoint;
					}
					set	
					{
						storyPoint = value;
					}
				}

				public int? Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public int? Rating
				{
					get
					{
						return rating;
					}
					set	
					{
						rating = value;
					}
				}

				public bool? IsFavorite
				{
					get
					{
						return isFavorite;
					}
					set	
					{
						isFavorite = value;
					}
				}

				public string ScenariofFeldConfigId
				{
					get
					{
						return scenariofFeldConfigId;
					}
					set	
					{
						scenariofFeldConfigId = value;
					}
				}

				public int? ShareStatus
				{
					get
					{
						return shareStatus;
					}
					set	
					{
						shareStatus = value;
					}
				}

				public string SprintId
				{
					get
					{
						return sprintId;
					}
					set	
					{
						sprintId = value;
					}
				}

				public string TaskFlowStatusId
				{
					get
					{
						return taskFlowStatusId;
					}
					set	
					{
						taskFlowStatusId = value;
					}
				}

				public string ObjectType
				{
					get
					{
						return objectType;
					}
					set	
					{
						objectType = value;
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

				public string UntilDate
				{
					get
					{
						return untilDate;
					}
					set	
					{
						untilDate = value;
					}
				}

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public string Sprint
				{
					get
					{
						return sprint;
					}
					set	
					{
						sprint = value;
					}
				}

				public string Parent
				{
					get
					{
						return parent;
					}
					set	
					{
						parent = value;
					}
				}

				public string TaskUniqueId
				{
					get
					{
						return taskUniqueId;
					}
					set	
					{
						taskUniqueId = value;
					}
				}

				public List<GetTaskListFilter_Customfield> Customfields
				{
					get
					{
						return customfields;
					}
					set	
					{
						customfields = value;
					}
				}

				public List<string> AncestorIds
				{
					get
					{
						return ancestorIds;
					}
					set	
					{
						ancestorIds = value;
					}
				}

				public List<string> Labels
				{
					get
					{
						return labels;
					}
					set	
					{
						labels = value;
					}
				}

				public List<string> TagIds
				{
					get
					{
						return tagIds;
					}
					set	
					{
						tagIds = value;
					}
				}

				public List<string> InvolveMembers
				{
					get
					{
						return involveMembers;
					}
					set	
					{
						involveMembers = value;
					}
				}

				public List<string> Divisions
				{
					get
					{
						return divisions;
					}
					set	
					{
						divisions = value;
					}
				}

				public GetTaskListFilter_WorkTime WorkTime
				{
					get
					{
						return workTime;
					}
					set	
					{
						workTime = value;
					}
				}

				public GetTaskListFilter_Badges Badges
				{
					get
					{
						return badges;
					}
					set	
					{
						badges = value;
					}
				}

				public GetTaskListFilter_SubtaskCount SubtaskCount
				{
					get
					{
						return subtaskCount;
					}
					set	
					{
						subtaskCount = value;
					}
				}

				public GetTaskListFilter_Reminder Reminder
				{
					get
					{
						return reminder;
					}
					set	
					{
						reminder = value;
					}
				}

				public GetTaskListFilter_Creator Creator
				{
					get
					{
						return creator;
					}
					set	
					{
						creator = value;
					}
				}

				public GetTaskListFilter_Stage Stage
				{
					get
					{
						return stage;
					}
					set	
					{
						stage = value;
					}
				}

				public GetTaskListFilter_Executor Executor
				{
					get
					{
						return executor;
					}
					set	
					{
						executor = value;
					}
				}

				public GetTaskListFilter_TaskFlowStatus TaskFlowStatus
				{
					get
					{
						return taskFlowStatus;
					}
					set	
					{
						taskFlowStatus = value;
					}
				}

				public class GetTaskListFilter_Customfield
				{

					private string customfieldId;

					private string type;

					private string values;

					private List<GetTaskListFilter_ValueItem> _value;

					public string CustomfieldId
					{
						get
						{
							return customfieldId;
						}
						set	
						{
							customfieldId = value;
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

					public string Values
					{
						get
						{
							return values;
						}
						set	
						{
							values = value;
						}
					}

					public List<GetTaskListFilter_ValueItem> _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					public class GetTaskListFilter_ValueItem
					{

						private string id;

						private string title;

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

						public string Title
						{
							get
							{
								return title;
							}
							set	
							{
								title = value;
							}
						}
					}
				}

				public class GetTaskListFilter_WorkTime
				{

					private int? totalTime;

					private int? usedTime;

					private string unit;

					public int? TotalTime
					{
						get
						{
							return totalTime;
						}
						set	
						{
							totalTime = value;
						}
					}

					public int? UsedTime
					{
						get
						{
							return usedTime;
						}
						set	
						{
							usedTime = value;
						}
					}

					public string Unit
					{
						get
						{
							return unit;
						}
						set	
						{
							unit = value;
						}
					}
				}

				public class GetTaskListFilter_Badges
				{

					private int? objectlinksCount;

					private int? commentsCount;

					private int? attachmentsCount;

					private int? likesCount;

					public int? ObjectlinksCount
					{
						get
						{
							return objectlinksCount;
						}
						set	
						{
							objectlinksCount = value;
						}
					}

					public int? CommentsCount
					{
						get
						{
							return commentsCount;
						}
						set	
						{
							commentsCount = value;
						}
					}

					public int? AttachmentsCount
					{
						get
						{
							return attachmentsCount;
						}
						set	
						{
							attachmentsCount = value;
						}
					}

					public int? LikesCount
					{
						get
						{
							return likesCount;
						}
						set	
						{
							likesCount = value;
						}
					}
				}

				public class GetTaskListFilter_SubtaskCount
				{

					private int? total;

					private int? done;

					public int? Total
					{
						get
						{
							return total;
						}
						set	
						{
							total = value;
						}
					}

					public int? Done
					{
						get
						{
							return done;
						}
						set	
						{
							done = value;
						}
					}
				}

				public class GetTaskListFilter_Reminder
				{

					private string type;

					private string date;

					private string creatorId;

					private List<string> members;

					private List<string> rules;

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

					public string Date
					{
						get
						{
							return date;
						}
						set	
						{
							date = value;
						}
					}

					public string CreatorId
					{
						get
						{
							return creatorId;
						}
						set	
						{
							creatorId = value;
						}
					}

					public List<string> Members
					{
						get
						{
							return members;
						}
						set	
						{
							members = value;
						}
					}

					public List<string> Rules
					{
						get
						{
							return rules;
						}
						set	
						{
							rules = value;
						}
					}
				}

				public class GetTaskListFilter_Creator
				{

					private string id;

					private string name;

					private string avatarUrl;

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

					public string AvatarUrl
					{
						get
						{
							return avatarUrl;
						}
						set	
						{
							avatarUrl = value;
						}
					}
				}

				public class GetTaskListFilter_Stage
				{

					private string id;

					private string name;

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
				}

				public class GetTaskListFilter_Executor
				{

					private string id;

					private string name;

					private string avatarUrl;

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

					public string AvatarUrl
					{
						get
						{
							return avatarUrl;
						}
						set	
						{
							avatarUrl = value;
						}
					}
				}

				public class GetTaskListFilter_TaskFlowStatus
				{

					private string id;

					private string name;

					private string kind;

					private int? pos;

					private string taskFlowId;

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

					public string Kind
					{
						get
						{
							return kind;
						}
						set	
						{
							kind = value;
						}
					}

					public int? Pos
					{
						get
						{
							return pos;
						}
						set	
						{
							pos = value;
						}
					}

					public string TaskFlowId
					{
						get
						{
							return taskFlowId;
						}
						set	
						{
							taskFlowId = value;
						}
					}
				}
			}
		}
	}
}
