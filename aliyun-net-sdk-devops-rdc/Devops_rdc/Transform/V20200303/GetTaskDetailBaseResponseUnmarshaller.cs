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
    public class GetTaskDetailBaseResponseUnmarshaller
    {
        public static GetTaskDetailBaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskDetailBaseResponse getTaskDetailBaseResponse = new GetTaskDetailBaseResponse();

			getTaskDetailBaseResponse.HttpResponse = _ctx.HttpResponse;
			getTaskDetailBaseResponse.Successful = _ctx.BooleanValue("GetTaskDetailBase.Successful");
			getTaskDetailBaseResponse.ErrorCode = _ctx.StringValue("GetTaskDetailBase.ErrorCode");
			getTaskDetailBaseResponse.ErrorMsg = _ctx.StringValue("GetTaskDetailBase.ErrorMsg");
			getTaskDetailBaseResponse.RequestId = _ctx.StringValue("GetTaskDetailBase.RequestId");

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object _object = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object();
			_object.Parent = _ctx.StringValue("GetTaskDetailBase.Object.Parent");
			_object.DueDate = _ctx.StringValue("GetTaskDetailBase.Object.DueDate");
			_object.Sprint = _ctx.StringValue("GetTaskDetailBase.Object.Sprint");
			_object.Rating = _ctx.IntegerValue("GetTaskDetailBase.Object.Rating");
			_object.SourceId = _ctx.StringValue("GetTaskDetailBase.Object.SourceId");
			_object.Source = _ctx.StringValue("GetTaskDetailBase.Object.Source");
			_object.StageId = _ctx.StringValue("GetTaskDetailBase.Object.StageId");
			_object.ObjectType = _ctx.StringValue("GetTaskDetailBase.Object.ObjectType");
			_object.TaskflowstatusId = _ctx.StringValue("GetTaskDetailBase.Object.TaskflowstatusId");
			_object.LikesCount = _ctx.IntegerValue("GetTaskDetailBase.Object.LikesCount");
			_object.Accomplished = _ctx.StringValue("GetTaskDetailBase.Object.Accomplished");
			_object.ObjectlinksCount = _ctx.IntegerValue("GetTaskDetailBase.Object.ObjectlinksCount");
			_object.CreatorId = _ctx.StringValue("GetTaskDetailBase.Object.CreatorId");
			_object.Visible = _ctx.StringValue("GetTaskDetailBase.Object.Visible");
			_object.StoryPoint = _ctx.StringValue("GetTaskDetailBase.Object.StoryPoint");
			_object.Created = _ctx.StringValue("GetTaskDetailBase.Object.Created");
			_object.Priority = _ctx.IntegerValue("GetTaskDetailBase.Object.Priority");
			_object.Recurrence = _ctx.StringValue("GetTaskDetailBase.Object.Recurrence");
			_object.UntilDate = _ctx.StringValue("GetTaskDetailBase.Object.UntilDate");
			_object.Id = _ctx.StringValue("GetTaskDetailBase.Object.Id");
			_object.Updated = _ctx.StringValue("GetTaskDetailBase.Object.Updated");
			_object.StartDate = _ctx.StringValue("GetTaskDetailBase.Object.StartDate");
			_object.UniqueId = _ctx.IntegerValue("GetTaskDetailBase.Object.UniqueId");
			_object.IsFavorite = _ctx.BooleanValue("GetTaskDetailBase.Object.IsFavorite");
			_object.Note = _ctx.StringValue("GetTaskDetailBase.Object.Note");
			_object.IsArchived = _ctx.BooleanValue("GetTaskDetailBase.Object.IsArchived");
			_object.Content = _ctx.StringValue("GetTaskDetailBase.Object.Content");
			_object.SourceDate = _ctx.StringValue("GetTaskDetailBase.Object.SourceDate");
			_object.AttachmentsCount = _ctx.IntegerValue("GetTaskDetailBase.Object.AttachmentsCount");
			_object.ScenariofieldconfigId = _ctx.StringValue("GetTaskDetailBase.Object.ScenariofieldconfigId");
			_object.IsTopInProject = _ctx.BooleanValue("GetTaskDetailBase.Object.IsTopInProject");
			_object.ExecutorId = _ctx.StringValue("GetTaskDetailBase.Object.ExecutorId");
			_object.OrganizationId = _ctx.StringValue("GetTaskDetailBase.Object.OrganizationId");
			_object.IsDone = _ctx.BooleanValue("GetTaskDetailBase.Object.IsDone");
			_object.TaskId = _ctx.StringValue("GetTaskDetailBase.Object.TaskId");
			_object.CommentsCount = _ctx.IntegerValue("GetTaskDetailBase.Object.CommentsCount");
			_object.Organization = _ctx.StringValue("GetTaskDetailBase.Object.Organization");
			_object.Progress = _ctx.IntegerValue("GetTaskDetailBase.Object.Progress");
			_object.SprintId = _ctx.StringValue("GetTaskDetailBase.Object.SprintId");
			_object.ProjectId = _ctx.StringValue("GetTaskDetailBase.Object.ProjectId");
			_object.ShareStatus = _ctx.IntegerValue("GetTaskDetailBase.Object.ShareStatus");

			List<string> _object_divisions = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Divisions.Length"); i++) {
				_object_divisions.Add(_ctx.StringValue("GetTaskDetailBase.Object.Divisions["+ i +"]"));
			}
			_object.Divisions = _object_divisions;

			List<string> _object_ancestors = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Ancestors.Length"); i++) {
				_object_ancestors.Add(_ctx.StringValue("GetTaskDetailBase.Object.Ancestors["+ i +"]"));
			}
			_object.Ancestors = _object_ancestors;

			List<string> _object_labels = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Labels.Length"); i++) {
				_object_labels.Add(_ctx.StringValue("GetTaskDetailBase.Object.Labels["+ i +"]"));
			}
			_object.Labels = _object_labels;

			List<string> _object_tagIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.TagIds.Length"); i++) {
				_object_tagIds.Add(_ctx.StringValue("GetTaskDetailBase.Object.TagIds["+ i +"]"));
			}
			_object.TagIds = _object_tagIds;

			List<string> _object_ancestorIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.AncestorIds.Length"); i++) {
				_object_ancestorIds.Add(_ctx.StringValue("GetTaskDetailBase.Object.AncestorIds["+ i +"]"));
			}
			_object.AncestorIds = _object_ancestorIds;

			List<string> _object_involveMembers = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.InvolveMembers.Length"); i++) {
				_object_involveMembers.Add(_ctx.StringValue("GetTaskDetailBase.Object.InvolveMembers["+ i +"]"));
			}
			_object.InvolveMembers = _object_involveMembers;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Scenariofieldconfig scenariofieldconfig = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Scenariofieldconfig();
			scenariofieldconfig.Name = _ctx.StringValue("GetTaskDetailBase.Object.Scenariofieldconfig.Name");
			scenariofieldconfig.Icon = _ctx.StringValue("GetTaskDetailBase.Object.Scenariofieldconfig.Icon");
			scenariofieldconfig.ProTemplateConfigType = _ctx.StringValue("GetTaskDetailBase.Object.Scenariofieldconfig.ProTemplateConfigType");
			scenariofieldconfig.Id = _ctx.StringValue("GetTaskDetailBase.Object.Scenariofieldconfig.Id");
			_object.Scenariofieldconfig = scenariofieldconfig;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Executor executor = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Executor();
			executor.AvatarUrl = _ctx.StringValue("GetTaskDetailBase.Object.Executor.AvatarUrl");
			executor.Name = _ctx.StringValue("GetTaskDetailBase.Object.Executor.Name");
			executor.Id = _ctx.StringValue("GetTaskDetailBase.Object.Executor.Id");
			_object.Executor = executor;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Tasklist tasklist = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Tasklist();
			tasklist.Id = _ctx.StringValue("GetTaskDetailBase.Object.Tasklist.Id");
			tasklist.Title = _ctx.StringValue("GetTaskDetailBase.Object.Tasklist.Title");
			_object.Tasklist = tasklist;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Taskflowstatus taskflowstatus = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Taskflowstatus();
			taskflowstatus.Kind = _ctx.StringValue("GetTaskDetailBase.Object.Taskflowstatus.Kind");
			taskflowstatus.TaskflowId = _ctx.StringValue("GetTaskDetailBase.Object.Taskflowstatus.TaskflowId");
			taskflowstatus.Name = _ctx.StringValue("GetTaskDetailBase.Object.Taskflowstatus.Name");
			taskflowstatus.Id = _ctx.StringValue("GetTaskDetailBase.Object.Taskflowstatus.Id");
			_object.Taskflowstatus = taskflowstatus;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Creator creator = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Creator();
			creator.Name = _ctx.StringValue("GetTaskDetailBase.Object.Creator.Name");
			creator.Id = _ctx.StringValue("GetTaskDetailBase.Object.Creator.Id");
			_object.Creator = creator;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Reminder reminder = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Reminder();
			reminder.Date = _ctx.StringValue("GetTaskDetailBase.Object.Reminder.Date");
			reminder.Method = _ctx.StringValue("GetTaskDetailBase.Object.Reminder.Method");
			reminder.CreatorId = _ctx.StringValue("GetTaskDetailBase.Object.Reminder.CreatorId");
			reminder.Type = _ctx.StringValue("GetTaskDetailBase.Object.Reminder.Type");

			List<string> reminder_memberRoles = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Reminder.MemberRoles.Length"); i++) {
				reminder_memberRoles.Add(_ctx.StringValue("GetTaskDetailBase.Object.Reminder.MemberRoles["+ i +"]"));
			}
			reminder.MemberRoles = reminder_memberRoles;

			List<string> reminder_members = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Reminder.Members.Length"); i++) {
				reminder_members.Add(_ctx.StringValue("GetTaskDetailBase.Object.Reminder.Members["+ i +"]"));
			}
			reminder.Members = reminder_members;

			List<string> reminder_rules = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Reminder.Rules.Length"); i++) {
				reminder_rules.Add(_ctx.StringValue("GetTaskDetailBase.Object.Reminder.Rules["+ i +"]"));
			}
			reminder.Rules = reminder_rules;
			_object.Reminder = reminder;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_SubtaskCount subtaskCount = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_SubtaskCount();
			subtaskCount.Total = _ctx.IntegerValue("GetTaskDetailBase.Object.SubtaskCount.Total");
			subtaskCount.Done = _ctx.IntegerValue("GetTaskDetailBase.Object.SubtaskCount.Done");
			_object.SubtaskCount = subtaskCount;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_WorkTime workTime = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_WorkTime();
			workTime.UsedTime = _ctx.IntegerValue("GetTaskDetailBase.Object.WorkTime.UsedTime");
			workTime.Unit = _ctx.StringValue("GetTaskDetailBase.Object.WorkTime.Unit");
			workTime.TotalTime = _ctx.IntegerValue("GetTaskDetailBase.Object.WorkTime.TotalTime");
			_object.WorkTime = workTime;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Badges badges = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Badges();
			badges.LikesCount = _ctx.IntegerValue("GetTaskDetailBase.Object.Badges.LikesCount");
			badges.AttachmentsCount = _ctx.IntegerValue("GetTaskDetailBase.Object.Badges.AttachmentsCount");
			badges.CommentsCount = _ctx.IntegerValue("GetTaskDetailBase.Object.Badges.CommentsCount");
			badges.ObjectlinksCount = _ctx.IntegerValue("GetTaskDetailBase.Object.Badges.ObjectlinksCount");
			_object.Badges = badges;

			GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Stage stage = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Stage();
			stage.Name = _ctx.StringValue("GetTaskDetailBase.Object.Stage.Name");
			stage.Id = _ctx.StringValue("GetTaskDetailBase.Object.Stage.Id");
			_object.Stage = stage;

			List<GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Customfield> _object_customfields = new List<GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Customfield>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Customfields.Length"); i++) {
				GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Customfield customfield = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Customfield();
				customfield.CustomfieldId = _ctx.StringValue("GetTaskDetailBase.Object.Customfields["+ i +"].CustomfieldId");
				customfield.Type = _ctx.StringValue("GetTaskDetailBase.Object.Customfields["+ i +"].Type");

				List<string> customfield_values = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskDetailBase.Object.Customfields["+ i +"].Values.Length"); j++) {
					customfield_values.Add(_ctx.StringValue("GetTaskDetailBase.Object.Customfields["+ i +"].Values["+ j +"]"));
				}
				customfield.Values = customfield_values;

				List<GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Customfield.GetTaskDetailBase_ValueInfo> customfield_value = new List<GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Customfield.GetTaskDetailBase_ValueInfo>();
				for (int j = 0; j < _ctx.Length("GetTaskDetailBase.Object.Customfields["+ i +"].Value.Length"); j++) {
					GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Customfield.GetTaskDetailBase_ValueInfo valueInfo = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Customfield.GetTaskDetailBase_ValueInfo();
					valueInfo.Id = _ctx.StringValue("GetTaskDetailBase.Object.Customfields["+ i +"].Value["+ j +"].Id");
					valueInfo.Title = _ctx.StringValue("GetTaskDetailBase.Object.Customfields["+ i +"].Value["+ j +"].Title");

					customfield_value.Add(valueInfo);
				}
				customfield._Value = customfield_value;

				_object_customfields.Add(customfield);
			}
			_object.Customfields = _object_customfields;

			List<GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Subtask> _object_subtasks = new List<GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Subtask>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Subtasks.Length"); i++) {
				GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Subtask subtask = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Subtask();
				subtask.Id = _ctx.StringValue("GetTaskDetailBase.Object.Subtasks["+ i +"].Id");
				subtask.Content = _ctx.StringValue("GetTaskDetailBase.Object.Subtasks["+ i +"].Content");

				_object_subtasks.Add(subtask);
			}
			_object.Subtasks = _object_subtasks;

			List<GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Involver> _object_involvers = new List<GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Involver>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailBase.Object.Involvers.Length"); i++) {
				GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Involver involver = new GetTaskDetailBaseResponse.GetTaskDetailBase__Object.GetTaskDetailBase_Involver();
				involver.Name = _ctx.StringValue("GetTaskDetailBase.Object.Involvers["+ i +"].Name");
				involver.Id = _ctx.StringValue("GetTaskDetailBase.Object.Involvers["+ i +"].Id");

				_object_involvers.Add(involver);
			}
			_object.Involvers = _object_involvers;
			getTaskDetailBaseResponse._Object = _object;
        
			return getTaskDetailBaseResponse;
        }
    }
}
