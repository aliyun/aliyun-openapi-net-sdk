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
    public class ModifyJobGroupResponseUnmarshaller
    {
        public static ModifyJobGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyJobGroupResponse modifyJobGroupResponse = new ModifyJobGroupResponse();

			modifyJobGroupResponse.HttpResponse = _ctx.HttpResponse;
			modifyJobGroupResponse.HttpStatusCode = _ctx.IntegerValue("ModifyJobGroup.HttpStatusCode");
			modifyJobGroupResponse.Code = _ctx.StringValue("ModifyJobGroup.Code");
			modifyJobGroupResponse.Message = _ctx.StringValue("ModifyJobGroup.Message");
			modifyJobGroupResponse.RequestId = _ctx.StringValue("ModifyJobGroup.RequestId");
			modifyJobGroupResponse.Success = _ctx.BooleanValue("ModifyJobGroup.Success");

			ModifyJobGroupResponse.ModifyJobGroup_JobGroup jobGroup = new ModifyJobGroupResponse.ModifyJobGroup_JobGroup();
			jobGroup.Status = _ctx.StringValue("ModifyJobGroup.JobGroup.Status");
			jobGroup.ScenarioId = _ctx.StringValue("ModifyJobGroup.JobGroup.ScenarioId");
			jobGroup.JobGroupId = _ctx.StringValue("ModifyJobGroup.JobGroup.JobGroupId");
			jobGroup.CreationTime = _ctx.LongValue("ModifyJobGroup.JobGroup.CreationTime");
			jobGroup.JobGroupName = _ctx.StringValue("ModifyJobGroup.JobGroup.JobGroupName");
			jobGroup.JobFilePath = _ctx.StringValue("ModifyJobGroup.JobGroup.JobFilePath");
			jobGroup.JobGroupDescription = _ctx.StringValue("ModifyJobGroup.JobGroup.JobGroupDescription");
			jobGroup.JobDataParsingTaskId = _ctx.StringValue("ModifyJobGroup.JobGroup.JobDataParsingTaskId");
			jobGroup.ScriptName = _ctx.StringValue("ModifyJobGroup.JobGroup.ScriptName");
			jobGroup.ScriptVersion = _ctx.StringValue("ModifyJobGroup.JobGroup.ScriptVersion");
			jobGroup.ModifyTime = _ctx.StringValue("ModifyJobGroup.JobGroup.ModifyTime");
			jobGroup.RingingDuration = _ctx.LongValue("ModifyJobGroup.JobGroup.RingingDuration");
			jobGroup.Priority = _ctx.StringValue("ModifyJobGroup.JobGroup.Priority");
			jobGroup.MinConcurrency = _ctx.LongValue("ModifyJobGroup.JobGroup.MinConcurrency");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifyJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(_ctx.StringValue("ModifyJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_ExportProgress exportProgress = new ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_ExportProgress();
			exportProgress.Status = _ctx.StringValue("ModifyJobGroup.JobGroup.ExportProgress.Status");
			exportProgress.FileHttpUrl = _ctx.StringValue("ModifyJobGroup.JobGroup.ExportProgress.FileHttpUrl");
			exportProgress.Progress = _ctx.StringValue("ModifyJobGroup.JobGroup.ExportProgress.Progress");
			jobGroup.ExportProgress = exportProgress;

			ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy strategy = new ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy();
			strategy.Type = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.Type");
			strategy.StrategyName = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.StrategyName");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("ModifyJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.FollowUpStrategy = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.EndTime = _ctx.LongValue("ModifyJobGroup.JobGroup.Strategy.EndTime");
			strategy.Customized = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.Customized");
			strategy.IsTemplate = _ctx.BooleanValue("ModifyJobGroup.JobGroup.Strategy.IsTemplate");
			strategy.StartTime = _ctx.LongValue("ModifyJobGroup.JobGroup.Strategy.StartTime");
			strategy.StrategyId = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.StrategyId");
			strategy.RoutingStrategy = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.MinAttemptInterval = _ctx.IntegerValue("ModifyJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.StrategyDescription = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.StrategyDescription");
			strategy.RepeatBy = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.RepeatBy");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifyJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy.ModifyJobGroup_TimeFrame> strategy_workingTime = new List<ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy.ModifyJobGroup_TimeFrame>();
			for (int i = 0; i < _ctx.Length("ModifyJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy.ModifyJobGroup_TimeFrame timeFrame = new ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_Strategy.ModifyJobGroup_TimeFrame();
				timeFrame.EndTime = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");
				timeFrame.BeginTime = _ctx.StringValue("ModifyJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;

			ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_RecallStrategy recallStrategy = new ModifyJobGroupResponse.ModifyJobGroup_JobGroup.ModifyJobGroup_RecallStrategy();
			recallStrategy.EmptyNumberIgnore = _ctx.BooleanValue("ModifyJobGroup.JobGroup.RecallStrategy.EmptyNumberIgnore");
			recallStrategy.InArrearsIgnore = _ctx.BooleanValue("ModifyJobGroup.JobGroup.RecallStrategy.InArrearsIgnore");
			recallStrategy.OutOfServiceIgnore = _ctx.BooleanValue("ModifyJobGroup.JobGroup.RecallStrategy.OutOfServiceIgnore");
			jobGroup.RecallStrategy = recallStrategy;
			modifyJobGroupResponse.JobGroup = jobGroup;
        
			return modifyJobGroupResponse;
        }
    }
}
