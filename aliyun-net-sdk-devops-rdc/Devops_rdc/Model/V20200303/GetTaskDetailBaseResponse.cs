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
	public class GetTaskDetailBaseResponse : AcsResponse
	{

		private bool? successful;

		private string errorCode;

		private string errorMsg;

		private string requestId;

		private GetTaskDetailBase__Object _object;

		public bool? Successful
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

		public GetTaskDetailBase__Object _Object
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

		public class GetTaskDetailBase__Object
		{

			private string parent;

			private string dueDate;

			private string sprint;

			private int? rating;

			private string sourceId;

			private string source;

			private string stageId;

			private string objectType;

			private string taskflowstatusId;

			private int? likesCount;

			private string accomplished;

			private int? objectlinksCount;

			private string creatorId;

			private string visible;

			private string storyPoint;

			private string created;

			private int? priority;

			private string recurrence;

			private string untilDate;

			private string id;

			private string updated;

			private string startDate;

			private int? uniqueId;

			private bool? isFavorite;

			private string note;

			private bool? isArchived;

			private string content;

			private string sourceDate;

			private int? attachmentsCount;

			private string scenariofieldconfigId;

			private bool? isTopInProject;

			private string executorId;

			private string organizationId;

			private bool? isDone;

			private string taskId;

			private int? commentsCount;

			private string organization;

			private int? progress;

			private string sprintId;

			private string projectId;

			private int? shareStatus;

			private List<GetTaskDetailBase_Customfield> customfields;

			private List<GetTaskDetailBase_Subtask> subtasks;

			private List<GetTaskDetailBase_Involver> involvers;

			private List<string> divisions;

			private List<string> ancestors;

			private List<string> labels;

			private List<string> tagIds;

			private List<string> ancestorIds;

			private List<string> involveMembers;

			private GetTaskDetailBase_Scenariofieldconfig scenariofieldconfig;

			private GetTaskDetailBase_Executor executor;

			private GetTaskDetailBase_Tasklist tasklist;

			private GetTaskDetailBase_Taskflowstatus taskflowstatus;

			private GetTaskDetailBase_Creator creator;

			private GetTaskDetailBase_Reminder reminder;

			private GetTaskDetailBase_SubtaskCount subtaskCount;

			private GetTaskDetailBase_WorkTime workTime;

			private GetTaskDetailBase_Badges badges;

			private GetTaskDetailBase_Stage stage;

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

			public string TaskflowstatusId
			{
				get
				{
					return taskflowstatusId;
				}
				set	
				{
					taskflowstatusId = value;
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

			public string ScenariofieldconfigId
			{
				get
				{
					return scenariofieldconfigId;
				}
				set	
				{
					scenariofieldconfigId = value;
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

			public string Organization
			{
				get
				{
					return organization;
				}
				set	
				{
					organization = value;
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

			public List<GetTaskDetailBase_Customfield> Customfields
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

			public List<GetTaskDetailBase_Subtask> Subtasks
			{
				get
				{
					return subtasks;
				}
				set	
				{
					subtasks = value;
				}
			}

			public List<GetTaskDetailBase_Involver> Involvers
			{
				get
				{
					return involvers;
				}
				set	
				{
					involvers = value;
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

			public List<string> Ancestors
			{
				get
				{
					return ancestors;
				}
				set	
				{
					ancestors = value;
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

			public GetTaskDetailBase_Scenariofieldconfig Scenariofieldconfig
			{
				get
				{
					return scenariofieldconfig;
				}
				set	
				{
					scenariofieldconfig = value;
				}
			}

			public GetTaskDetailBase_Executor Executor
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

			public GetTaskDetailBase_Tasklist Tasklist
			{
				get
				{
					return tasklist;
				}
				set	
				{
					tasklist = value;
				}
			}

			public GetTaskDetailBase_Taskflowstatus Taskflowstatus
			{
				get
				{
					return taskflowstatus;
				}
				set	
				{
					taskflowstatus = value;
				}
			}

			public GetTaskDetailBase_Creator Creator
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

			public GetTaskDetailBase_Reminder Reminder
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

			public GetTaskDetailBase_SubtaskCount SubtaskCount
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

			public GetTaskDetailBase_WorkTime WorkTime
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

			public GetTaskDetailBase_Badges Badges
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

			public GetTaskDetailBase_Stage Stage
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

			public class GetTaskDetailBase_Customfield
			{

				private string customfieldId;

				private string type;

				private List<GetTaskDetailBase_ValueInfo> _value;

				private List<string> values;

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

				public List<GetTaskDetailBase_ValueInfo> _Value
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

				public List<string> Values
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

				public class GetTaskDetailBase_ValueInfo
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

			public class GetTaskDetailBase_Subtask
			{

				private string id;

				private string content;

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
			}

			public class GetTaskDetailBase_Involver
			{

				private string name;

				private string id;

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
			}

			public class GetTaskDetailBase_Scenariofieldconfig
			{

				private string name;

				private string icon;

				private string proTemplateConfigType;

				private string id;

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

				public string Icon
				{
					get
					{
						return icon;
					}
					set	
					{
						icon = value;
					}
				}

				public string ProTemplateConfigType
				{
					get
					{
						return proTemplateConfigType;
					}
					set	
					{
						proTemplateConfigType = value;
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
			}

			public class GetTaskDetailBase_Executor
			{

				private string avatarUrl;

				private string name;

				private string id;

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
			}

			public class GetTaskDetailBase_Tasklist
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

			public class GetTaskDetailBase_Taskflowstatus
			{

				private string kind;

				private string taskflowId;

				private string name;

				private string id;

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

				public string TaskflowId
				{
					get
					{
						return taskflowId;
					}
					set	
					{
						taskflowId = value;
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
			}

			public class GetTaskDetailBase_Creator
			{

				private string name;

				private string id;

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
			}

			public class GetTaskDetailBase_Reminder
			{

				private string date;

				private string method;

				private string creatorId;

				private string type;

				private List<string> memberRoles;

				private List<string> members;

				private List<string> rules;

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

				public string Method
				{
					get
					{
						return method;
					}
					set	
					{
						method = value;
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

				public List<string> MemberRoles
				{
					get
					{
						return memberRoles;
					}
					set	
					{
						memberRoles = value;
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

			public class GetTaskDetailBase_SubtaskCount
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

			public class GetTaskDetailBase_WorkTime
			{

				private int? usedTime;

				private string unit;

				private int? totalTime;

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
			}

			public class GetTaskDetailBase_Badges
			{

				private int? likesCount;

				private int? attachmentsCount;

				private int? commentsCount;

				private int? objectlinksCount;

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
			}

			public class GetTaskDetailBase_Stage
			{

				private string name;

				private string id;

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
			}
		}
	}
}
