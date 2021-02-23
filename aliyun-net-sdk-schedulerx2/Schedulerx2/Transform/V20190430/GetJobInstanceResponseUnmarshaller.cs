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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class GetJobInstanceResponseUnmarshaller
    {
        public static GetJobInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobInstanceResponse getJobInstanceResponse = new GetJobInstanceResponse();

			getJobInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getJobInstanceResponse.RequestId = _ctx.StringValue("GetJobInstance.RequestId");
			getJobInstanceResponse.Code = _ctx.IntegerValue("GetJobInstance.Code");
			getJobInstanceResponse.Message = _ctx.StringValue("GetJobInstance.Message");
			getJobInstanceResponse.Success = _ctx.BooleanValue("GetJobInstance.Success");

			GetJobInstanceResponse.GetJobInstance_Data data = new GetJobInstanceResponse.GetJobInstance_Data();

			GetJobInstanceResponse.GetJobInstance_Data.GetJobInstance_JobInstanceDetail jobInstanceDetail = new GetJobInstanceResponse.GetJobInstance_Data.GetJobInstance_JobInstanceDetail();
			jobInstanceDetail.InstanceId = _ctx.LongValue("GetJobInstance.Data.JobInstanceDetail.InstanceId");
			jobInstanceDetail.JobId = _ctx.LongValue("GetJobInstance.Data.JobInstanceDetail.JobId");
			jobInstanceDetail.Status = _ctx.IntegerValue("GetJobInstance.Data.JobInstanceDetail.Status");
			jobInstanceDetail.StartTime = _ctx.StringValue("GetJobInstance.Data.JobInstanceDetail.StartTime");
			jobInstanceDetail.EndTime = _ctx.StringValue("GetJobInstance.Data.JobInstanceDetail.EndTime");
			jobInstanceDetail.ScheduleTime = _ctx.StringValue("GetJobInstance.Data.JobInstanceDetail.ScheduleTime");
			jobInstanceDetail.DataTime = _ctx.StringValue("GetJobInstance.Data.JobInstanceDetail.DataTime");
			jobInstanceDetail.Executor = _ctx.StringValue("GetJobInstance.Data.JobInstanceDetail.Executor");
			jobInstanceDetail.WorkAddr = _ctx.StringValue("GetJobInstance.Data.JobInstanceDetail.WorkAddr");
			jobInstanceDetail.Result = _ctx.StringValue("GetJobInstance.Data.JobInstanceDetail.Result");
			jobInstanceDetail.Progress = _ctx.StringValue("GetJobInstance.Data.JobInstanceDetail.Progress");
			jobInstanceDetail.TimeType = _ctx.IntegerValue("GetJobInstance.Data.JobInstanceDetail.TimeType");
			jobInstanceDetail.TriggerType = _ctx.IntegerValue("GetJobInstance.Data.JobInstanceDetail.TriggerType");
			data.JobInstanceDetail = jobInstanceDetail;
			getJobInstanceResponse.Data = data;
        
			return getJobInstanceResponse;
        }
    }
}
