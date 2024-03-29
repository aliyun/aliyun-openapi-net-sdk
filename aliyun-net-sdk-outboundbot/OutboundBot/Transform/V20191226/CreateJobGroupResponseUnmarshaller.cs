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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class CreateJobGroupResponseUnmarshaller
    {
        public static CreateJobGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateJobGroupResponse createJobGroupResponse = new CreateJobGroupResponse();

			createJobGroupResponse.HttpResponse = _ctx.HttpResponse;
			createJobGroupResponse.HttpStatusCode = _ctx.IntegerValue("CreateJobGroup.HttpStatusCode");
			createJobGroupResponse.Code = _ctx.StringValue("CreateJobGroup.Code");
			createJobGroupResponse.Message = _ctx.StringValue("CreateJobGroup.Message");
			createJobGroupResponse.RequestId = _ctx.StringValue("CreateJobGroup.RequestId");
			createJobGroupResponse.Success = _ctx.BooleanValue("CreateJobGroup.Success");

			CreateJobGroupResponse.CreateJobGroup_JobGroup jobGroup = new CreateJobGroupResponse.CreateJobGroup_JobGroup();
			jobGroup.Status = _ctx.StringValue("CreateJobGroup.JobGroup.Status");
			jobGroup.ScenarioId = _ctx.StringValue("CreateJobGroup.JobGroup.ScenarioId");
			jobGroup.JobGroupId = _ctx.StringValue("CreateJobGroup.JobGroup.JobGroupId");
			jobGroup.CreationTime = _ctx.LongValue("CreateJobGroup.JobGroup.CreationTime");
			jobGroup.JobGroupName = _ctx.StringValue("CreateJobGroup.JobGroup.JobGroupName");
			jobGroup.JobFilePath = _ctx.StringValue("CreateJobGroup.JobGroup.JobFilePath");
			jobGroup.JobGroupDescription = _ctx.StringValue("CreateJobGroup.JobGroup.JobGroupDescription");
			jobGroup.JobDataParsingTaskId = _ctx.StringValue("CreateJobGroup.JobGroup.JobDataParsingTaskId");
			jobGroup.ScriptName = _ctx.StringValue("CreateJobGroup.JobGroup.ScriptName");
			jobGroup.ScriptVersion = _ctx.StringValue("CreateJobGroup.JobGroup.ScriptVersion");
			jobGroup.ModifyTime = _ctx.StringValue("CreateJobGroup.JobGroup.ModifyTime");
			jobGroup.RingingDuration = _ctx.LongValue("CreateJobGroup.JobGroup.RingingDuration");
			jobGroup.Priority = _ctx.StringValue("CreateJobGroup.JobGroup.Priority");
			jobGroup.MinConcurrency = _ctx.LongValue("CreateJobGroup.JobGroup.MinConcurrency");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(_ctx.StringValue("CreateJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_ExportProgress exportProgress = new CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_ExportProgress();
			exportProgress.Status = _ctx.StringValue("CreateJobGroup.JobGroup.ExportProgress.Status");
			exportProgress.FileHttpUrl = _ctx.StringValue("CreateJobGroup.JobGroup.ExportProgress.FileHttpUrl");
			exportProgress.Progress = _ctx.StringValue("CreateJobGroup.JobGroup.ExportProgress.Progress");
			jobGroup.ExportProgress = exportProgress;

			CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy strategy = new CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy();
			strategy.Type = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.Type");
			strategy.StrategyName = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyName");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("CreateJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.FollowUpStrategy = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.EndTime = _ctx.LongValue("CreateJobGroup.JobGroup.Strategy.EndTime");
			strategy.Customized = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.Customized");
			strategy.IsTemplate = _ctx.BooleanValue("CreateJobGroup.JobGroup.Strategy.IsTemplate");
			strategy.StartTime = _ctx.LongValue("CreateJobGroup.JobGroup.Strategy.StartTime");
			strategy.StrategyId = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyId");
			strategy.RoutingStrategy = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.MinAttemptInterval = _ctx.IntegerValue("CreateJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.StrategyDescription = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.StrategyDescription");
			strategy.RepeatBy = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.RepeatBy");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("CreateJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame> strategy_workingTime = new List<CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame>();
			for (int i = 0; i < _ctx.Length("CreateJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame timeFrame = new CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_Strategy.CreateJobGroup_TimeFrame();
				timeFrame.EndTime = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");
				timeFrame.BeginTime = _ctx.StringValue("CreateJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;

			CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_RecallStrategy recallStrategy = new CreateJobGroupResponse.CreateJobGroup_JobGroup.CreateJobGroup_RecallStrategy();
			recallStrategy.EmptyNumberIgnore = _ctx.BooleanValue("CreateJobGroup.JobGroup.RecallStrategy.EmptyNumberIgnore");
			recallStrategy.InArrearsIgnore = _ctx.BooleanValue("CreateJobGroup.JobGroup.RecallStrategy.InArrearsIgnore");
			recallStrategy.OutOfServiceIgnore = _ctx.BooleanValue("CreateJobGroup.JobGroup.RecallStrategy.OutOfServiceIgnore");
			jobGroup.RecallStrategy = recallStrategy;
			createJobGroupResponse.JobGroup = jobGroup;
        
			return createJobGroupResponse;
        }
    }
}
