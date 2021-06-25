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
    public class DescribeJobGroupResponseUnmarshaller
    {
        public static DescribeJobGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobGroupResponse describeJobGroupResponse = new DescribeJobGroupResponse();

			describeJobGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeJobGroupResponse.Code = _ctx.StringValue("DescribeJobGroup.Code");
			describeJobGroupResponse.HttpStatusCode = _ctx.IntegerValue("DescribeJobGroup.HttpStatusCode");
			describeJobGroupResponse.Message = _ctx.StringValue("DescribeJobGroup.Message");
			describeJobGroupResponse.RequestId = _ctx.StringValue("DescribeJobGroup.RequestId");
			describeJobGroupResponse.Success = _ctx.BooleanValue("DescribeJobGroup.Success");

			DescribeJobGroupResponse.DescribeJobGroup_JobGroup jobGroup = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup();
			jobGroup.CreationTime = _ctx.LongValue("DescribeJobGroup.JobGroup.CreationTime");
			jobGroup.JobDataParsingTaskId = _ctx.StringValue("DescribeJobGroup.JobGroup.JobDataParsingTaskId");
			jobGroup.JobFilePath = _ctx.StringValue("DescribeJobGroup.JobGroup.JobFilePath");
			jobGroup.JobGroupDescription = _ctx.StringValue("DescribeJobGroup.JobGroup.JobGroupDescription");
			jobGroup.JobGroupId = _ctx.StringValue("DescribeJobGroup.JobGroup.JobGroupId");
			jobGroup.JobGroupName = _ctx.StringValue("DescribeJobGroup.JobGroup.JobGroupName");
			jobGroup.ModifyTime = _ctx.StringValue("DescribeJobGroup.JobGroup.ModifyTime");
			jobGroup.ScenarioId = _ctx.StringValue("DescribeJobGroup.JobGroup.ScenarioId");
			jobGroup.ScriptId = _ctx.StringValue("DescribeJobGroup.JobGroup.ScriptId");
			jobGroup.ScriptName = _ctx.StringValue("DescribeJobGroup.JobGroup.ScriptName");
			jobGroup.ScriptVersion = _ctx.StringValue("DescribeJobGroup.JobGroup.ScriptVersion");
			jobGroup.Status = _ctx.StringValue("DescribeJobGroup.JobGroup.Status");

			List<string> jobGroup_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeJobGroup.JobGroup.CallingNumbers.Length"); i++) {
				jobGroup_callingNumbers.Add(_ctx.StringValue("DescribeJobGroup.JobGroup.CallingNumbers["+ i +"]"));
			}
			jobGroup.CallingNumbers = jobGroup_callingNumbers;

			DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_ExportProgress exportProgress = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_ExportProgress();
			exportProgress.FileHttpUrl = _ctx.StringValue("DescribeJobGroup.JobGroup.ExportProgress.FileHttpUrl");
			exportProgress.Progress = _ctx.StringValue("DescribeJobGroup.JobGroup.ExportProgress.Progress");
			exportProgress.Status = _ctx.StringValue("DescribeJobGroup.JobGroup.ExportProgress.Status");
			jobGroup.ExportProgress = exportProgress;

			DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress progress = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress();
			progress.Cancelled = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.Cancelled");
			progress.Duration = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.Duration");
			progress.Executing = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.Executing");
			progress.Failed = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.Failed");
			progress.Paused = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.Paused");
			progress.Scheduling = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.Scheduling");
			progress.StartTime = _ctx.LongValue("DescribeJobGroup.JobGroup.Progress.StartTime");
			progress.Status = _ctx.StringValue("DescribeJobGroup.JobGroup.Progress.Status");
			progress.TotalCompleted = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.TotalCompleted");
			progress.TotalJobs = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.TotalJobs");
			progress.TotalNotAnswered = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Progress.TotalNotAnswered");

			List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair> progress_briefs = new List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("DescribeJobGroup.JobGroup.Progress.Briefs.Length"); i++) {
				DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair keyValuePair = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("DescribeJobGroup.JobGroup.Progress.Briefs["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("DescribeJobGroup.JobGroup.Progress.Briefs["+ i +"].Value");

				progress_briefs.Add(keyValuePair);
			}
			progress.Briefs = progress_briefs;

			List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair> progress_categories = new List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("DescribeJobGroup.JobGroup.Progress.Categories.Length"); i++) {
				DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair keyValuePair = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Progress.DescribeJobGroup_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("DescribeJobGroup.JobGroup.Progress.Categories["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("DescribeJobGroup.JobGroup.Progress.Categories["+ i +"].Value");

				progress_categories.Add(keyValuePair);
			}
			progress.Categories = progress_categories;
			jobGroup.Progress = progress;

			DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy strategy = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy();
			strategy.Customized = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.Customized");
			strategy.EndTime = _ctx.LongValue("DescribeJobGroup.JobGroup.Strategy.EndTime");
			strategy.FollowUpStrategy = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.FollowUpStrategy");
			strategy.IsTemplate = _ctx.BooleanValue("DescribeJobGroup.JobGroup.Strategy.IsTemplate");
			strategy.MaxAttemptsPerDay = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Strategy.MaxAttemptsPerDay");
			strategy.MinAttemptInterval = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Strategy.MinAttemptInterval");
			strategy.RepeatBy = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.RepeatBy");
			strategy.RoutingStrategy = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.RoutingStrategy");
			strategy.StartTime = _ctx.LongValue("DescribeJobGroup.JobGroup.Strategy.StartTime");
			strategy.StrategyDescription = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.StrategyDescription");
			strategy.StrategyId = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.StrategyId");
			strategy.StrategyName = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.StrategyName");
			strategy.Type = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.Type");

			List<string> strategy_repeatDays = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeJobGroup.JobGroup.Strategy.RepeatDays.Length"); i++) {
				strategy_repeatDays.Add(_ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.RepeatDays["+ i +"]"));
			}
			strategy.RepeatDays = strategy_repeatDays;

			List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy.DescribeJobGroup_TimeFrame> strategy_workingTime = new List<DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy.DescribeJobGroup_TimeFrame>();
			for (int i = 0; i < _ctx.Length("DescribeJobGroup.JobGroup.Strategy.WorkingTime.Length"); i++) {
				DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy.DescribeJobGroup_TimeFrame timeFrame = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Strategy.DescribeJobGroup_TimeFrame();
				timeFrame.BeginTime = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].BeginTime");
				timeFrame.EndTime = _ctx.StringValue("DescribeJobGroup.JobGroup.Strategy.WorkingTime["+ i +"].EndTime");

				strategy_workingTime.Add(timeFrame);
			}
			strategy.WorkingTime = strategy_workingTime;
			jobGroup.Strategy = strategy;

			DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Result result = new DescribeJobGroupResponse.DescribeJobGroup_JobGroup.DescribeJobGroup_Result();
			result.NoInteractNum = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Result.NoInteractNum");
			result.FinishedNum = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Result.FinishedNum");
			result.ClientHangupNum = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Result.ClientHangupNum");
			result.TimeoutHangupNum = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Result.TimeoutHangupNum");
			result.UnrecognizedNum = _ctx.IntegerValue("DescribeJobGroup.JobGroup.Result.UnrecognizedNum");
			jobGroup.Result = result;
			describeJobGroupResponse.JobGroup = jobGroup;
        
			return describeJobGroupResponse;
        }
    }
}
