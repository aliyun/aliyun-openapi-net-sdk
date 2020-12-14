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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetTaskListFilterResponseUnmarshaller
    {
        public static GetTaskListFilterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskListFilterResponse getTaskListFilterResponse = new GetTaskListFilterResponse();

			getTaskListFilterResponse.HttpResponse = _ctx.HttpResponse;
			getTaskListFilterResponse.ErrorMsg = _ctx.StringValue("GetTaskListFilter.ErrorMsg");
			getTaskListFilterResponse.RequestId = _ctx.StringValue("GetTaskListFilter.RequestId");
			getTaskListFilterResponse.ErrorCode = _ctx.StringValue("GetTaskListFilter.ErrorCode");
			getTaskListFilterResponse.Successful = _ctx.StringValue("GetTaskListFilter.Successful");

			GetTaskListFilterResponse.GetTaskListFilter__Object _object = new GetTaskListFilterResponse.GetTaskListFilter__Object();
			_object.NextPageToken = _ctx.StringValue("GetTaskListFilter.Object.NextPageToken");
			_object.TotalSize = _ctx.IntegerValue("GetTaskListFilter.Object.TotalSize");

			List<GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task> _object_result = new List<GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task>();
			for (int i = 0; i < _ctx.Length("GetTaskListFilter.Object.Result.Length"); i++) {
				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task task = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task();
				task.Id = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Id");
				task.CreatorId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].CreatorId");
				task.ExecutorId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].ExecutorId");
				task.ProjectId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].ProjectId");
				task.TaskListId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TaskListId");
				task.OrganizationId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].OrganizationId");
				task.StageId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].StageId");
				task.Visible = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Visible");
				task.Updated = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Updated");
				task.Created = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Created");
				task.IsArchived = _ctx.BooleanValue("GetTaskListFilter.Object.Result["+ i +"].IsArchived");
				task.IsDone = _ctx.BooleanValue("GetTaskListFilter.Object.Result["+ i +"].IsDone");
				task.IsTopInProject = _ctx.BooleanValue("GetTaskListFilter.Object.Result["+ i +"].IsTopInProject");
				task.Priority = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].Priority");
				task.Pos = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].Pos");
				task.StartDate = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].StartDate");
				task.DueDate = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].DueDate");
				task.Accomplished = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Accomplished");
				task.Note = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Note");
				task.Content = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Content");
				task.Recurrence = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Recurrence");
				task.SourceId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].SourceId");
				task.SourceDate = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].SourceDate");
				task.CommentsCount = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].CommentsCount");
				task.AttachmentsCount = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].AttachmentsCount");
				task.LikesCount = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].LikesCount");
				task.ObjectlinksCount = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].ObjectlinksCount");
				task.UniqueId = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].UniqueId");
				task.StoryPoint = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].StoryPoint");
				task.Progress = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].Progress");
				task.Rating = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].Rating");
				task.IsFavorite = _ctx.BooleanValue("GetTaskListFilter.Object.Result["+ i +"].IsFavorite");
				task.ScenariofFeldConfigId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].ScenariofFeldConfigId");
				task.ShareStatus = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].ShareStatus");
				task.SprintId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].SprintId");
				task.TaskFlowStatusId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TaskFlowStatusId");
				task.ObjectType = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].ObjectType");
				task.Source = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Source");
				task.UntilDate = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].UntilDate");
				task.TaskId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TaskId");
				task.Sprint = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Sprint");
				task.Parent = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Parent");
				task.TaskUniqueId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TaskUniqueId");

				List<string> task_ancestorIds = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].AncestorIds.Length"); j++) {
					task_ancestorIds.Add(_ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].AncestorIds["+ j +"]"));
				}
				task.AncestorIds = task_ancestorIds;

				List<string> task_labels = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].Labels.Length"); j++) {
					task_labels.Add(_ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Labels["+ j +"]"));
				}
				task.Labels = task_labels;

				List<string> task_tagIds = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].TagIds.Length"); j++) {
					task_tagIds.Add(_ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TagIds["+ j +"]"));
				}
				task.TagIds = task_tagIds;

				List<string> task_involveMembers = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].InvolveMembers.Length"); j++) {
					task_involveMembers.Add(_ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].InvolveMembers["+ j +"]"));
				}
				task.InvolveMembers = task_involveMembers;

				List<string> task_divisions = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].Divisions.Length"); j++) {
					task_divisions.Add(_ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Divisions["+ j +"]"));
				}
				task.Divisions = task_divisions;

				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_WorkTime workTime = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_WorkTime();
				workTime.TotalTime = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].WorkTime.TotalTime");
				workTime.UsedTime = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].WorkTime.UsedTime");
				workTime.Unit = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].WorkTime.Unit");
				task.WorkTime = workTime;

				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Badges badges = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Badges();
				badges.ObjectlinksCount = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].Badges.ObjectlinksCount");
				badges.CommentsCount = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].Badges.CommentsCount");
				badges.AttachmentsCount = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].Badges.AttachmentsCount");
				badges.LikesCount = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].Badges.LikesCount");
				task.Badges = badges;

				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_SubtaskCount subtaskCount = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_SubtaskCount();
				subtaskCount.Total = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].SubtaskCount.Total");
				subtaskCount.Done = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].SubtaskCount.Done");
				task.SubtaskCount = subtaskCount;

				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Reminder reminder = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Reminder();
				reminder.Type = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Reminder.Type");
				reminder.Date = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Reminder.Date");
				reminder.CreatorId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Reminder.CreatorId");

				List<string> reminder_members = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].Reminder.Members.Length"); j++) {
					reminder_members.Add(_ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Reminder.Members["+ j +"]"));
				}
				reminder.Members = reminder_members;

				List<string> reminder_rules = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].Reminder.Rules.Length"); j++) {
					reminder_rules.Add(_ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Reminder.Rules["+ j +"]"));
				}
				reminder.Rules = reminder_rules;
				task.Reminder = reminder;

				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Creator creator = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Creator();
				creator.Id = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Creator.Id");
				creator.Name = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Creator.Name");
				creator.AvatarUrl = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Creator.AvatarUrl");
				task.Creator = creator;

				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Stage stage = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Stage();
				stage.Id = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Stage.Id");
				stage.Name = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Stage.Name");
				task.Stage = stage;

				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Executor executor = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Executor();
				executor.Id = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Executor.Id");
				executor.Name = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Executor.Name");
				executor.AvatarUrl = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Executor.AvatarUrl");
				task.Executor = executor;

				GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_TaskFlowStatus taskFlowStatus = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_TaskFlowStatus();
				taskFlowStatus.Id = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TaskFlowStatus.Id");
				taskFlowStatus.Name = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TaskFlowStatus.Name");
				taskFlowStatus.Kind = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TaskFlowStatus.Kind");
				taskFlowStatus.Pos = _ctx.IntegerValue("GetTaskListFilter.Object.Result["+ i +"].TaskFlowStatus.Pos");
				taskFlowStatus.TaskFlowId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].TaskFlowStatus.TaskFlowId");
				task.TaskFlowStatus = taskFlowStatus;

				List<GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Customfield> task_customfields = new List<GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Customfield>();
				for (int j = 0; j < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].Customfields.Length"); j++) {
					GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Customfield customfield = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Customfield();
					customfield.CustomfieldId = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Customfields["+ j +"].CustomfieldId");
					customfield.Type = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Customfields["+ j +"].Type");
					customfield.Values = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Customfields["+ j +"].Values");

					List<GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Customfield.GetTaskListFilter_ValueItem> customfield_value = new List<GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Customfield.GetTaskListFilter_ValueItem>();
					for (int k = 0; k < _ctx.Length("GetTaskListFilter.Object.Result["+ i +"].Customfields["+ j +"].Value.Length"); k++) {
						GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Customfield.GetTaskListFilter_ValueItem valueItem = new GetTaskListFilterResponse.GetTaskListFilter__Object.GetTaskListFilter_Task.GetTaskListFilter_Customfield.GetTaskListFilter_ValueItem();
						valueItem.Id = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Customfields["+ j +"].Value["+ k +"].Id");
						valueItem.Title = _ctx.StringValue("GetTaskListFilter.Object.Result["+ i +"].Customfields["+ j +"].Value["+ k +"].Title");

						customfield_value.Add(valueItem);
					}
					customfield._Value = customfield_value;

					task_customfields.Add(customfield);
				}
				task.Customfields = task_customfields;

				_object_result.Add(task);
			}
			_object.Result = _object_result;
			getTaskListFilterResponse._Object = _object;
        
			return getTaskListFilterResponse;
        }
    }
}
