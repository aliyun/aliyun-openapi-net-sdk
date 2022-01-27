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
    public class DescribeGroupExecutingInfoResponseUnmarshaller
    {
        public static DescribeGroupExecutingInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupExecutingInfoResponse describeGroupExecutingInfoResponse = new DescribeGroupExecutingInfoResponse();

			describeGroupExecutingInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupExecutingInfoResponse.RequestId = _ctx.StringValue("DescribeGroupExecutingInfo.RequestId");
			describeGroupExecutingInfoResponse.Success = _ctx.BooleanValue("DescribeGroupExecutingInfo.Success");
			describeGroupExecutingInfoResponse.Code = _ctx.StringValue("DescribeGroupExecutingInfo.Code");
			describeGroupExecutingInfoResponse.Message = _ctx.StringValue("DescribeGroupExecutingInfo.Message");
			describeGroupExecutingInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeGroupExecutingInfo.HttpStatusCode");
			describeGroupExecutingInfoResponse.GroupId = _ctx.StringValue("DescribeGroupExecutingInfo.GroupId");
			describeGroupExecutingInfoResponse.InstanceId = _ctx.StringValue("DescribeGroupExecutingInfo.InstanceId");

			DescribeGroupExecutingInfoResponse.DescribeGroupExecutingInfo_ExecutingInfo executingInfo = new DescribeGroupExecutingInfoResponse.DescribeGroupExecutingInfo_ExecutingInfo();
			executingInfo.StartTime = _ctx.LongValue("DescribeGroupExecutingInfo.ExecutingInfo.StartTime");
			executingInfo.EndTime = _ctx.LongValue("DescribeGroupExecutingInfo.ExecutingInfo.EndTime");
			executingInfo.CallFailedNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.CallFailedNum");
			executingInfo.CallNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.CallNum");
			executingInfo.CreatorName = _ctx.StringValue("DescribeGroupExecutingInfo.ExecutingInfo.CreatorName");
			executingInfo.FinishedNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.FinishedNum");
			executingInfo.HangUpByClientNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.HangUpByClientNum");
			executingInfo.TransferByIntentNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.TransferByIntentNum");
			executingInfo.TransferByNoAnswer = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.TransferByNoAnswer");

			DescribeGroupExecutingInfoResponse.DescribeGroupExecutingInfo_ExecutingInfo.DescribeGroupExecutingInfo_JobsProgress jobsProgress = new DescribeGroupExecutingInfoResponse.DescribeGroupExecutingInfo_ExecutingInfo.DescribeGroupExecutingInfo_JobsProgress();
			jobsProgress.TotalJobs = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.JobsProgress.TotalJobs");
			jobsProgress.TotalCompletedNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.JobsProgress.TotalCompletedNum");
			jobsProgress.FailedNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.JobsProgress.FailedNum");
			jobsProgress.CancelledNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.JobsProgress.CancelledNum");
			jobsProgress.TotalNotAnsweredNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.JobsProgress.TotalNotAnsweredNum");
			jobsProgress.ExecutingNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.JobsProgress.ExecutingNum");
			jobsProgress.PausedNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.JobsProgress.PausedNum");
			jobsProgress.SchedulingNum = _ctx.IntegerValue("DescribeGroupExecutingInfo.ExecutingInfo.JobsProgress.SchedulingNum");
			executingInfo.JobsProgress = jobsProgress;
			describeGroupExecutingInfoResponse.ExecutingInfo = executingInfo;
        
			return describeGroupExecutingInfoResponse;
        }
    }
}
