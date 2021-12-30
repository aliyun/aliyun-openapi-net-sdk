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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetPredictiveTaskDataResponseUnmarshaller
    {
        public static GetPredictiveTaskDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPredictiveTaskDataResponse getPredictiveTaskDataResponse = new GetPredictiveTaskDataResponse();

			getPredictiveTaskDataResponse.HttpResponse = _ctx.HttpResponse;
			getPredictiveTaskDataResponse.RequestId = _ctx.StringValue("GetPredictiveTaskData.RequestId");
			getPredictiveTaskDataResponse.HttpStatusCode = _ctx.LongValue("GetPredictiveTaskData.HttpStatusCode");
			getPredictiveTaskDataResponse.Code = _ctx.StringValue("GetPredictiveTaskData.Code");
			getPredictiveTaskDataResponse.Message = _ctx.StringValue("GetPredictiveTaskData.Message");
			getPredictiveTaskDataResponse.Success = _ctx.StringValue("GetPredictiveTaskData.Success");

			GetPredictiveTaskDataResponse.GetPredictiveTaskData_Data data = new GetPredictiveTaskDataResponse.GetPredictiveTaskData_Data();
			data.Abandoned = _ctx.BooleanValue("GetPredictiveTaskData.Data.Abandoned");
			data.ContactId = _ctx.StringValue("GetPredictiveTaskData.Data.ContactId");
			data.Answered = _ctx.BooleanValue("GetPredictiveTaskData.Data.Answered");
			data.Connected = _ctx.BooleanValue("GetPredictiveTaskData.Data.Connected");
			data.DialDuration = _ctx.LongValue("GetPredictiveTaskData.Data.DialDuration");
			data.EndTime = _ctx.LongValue("GetPredictiveTaskData.Data.EndTime");
			data.JobGroupId = _ctx.StringValue("GetPredictiveTaskData.Data.JobGroupId");
			data.QueueDuration = _ctx.LongValue("GetPredictiveTaskData.Data.QueueDuration");
			data.StartTime = _ctx.LongValue("GetPredictiveTaskData.Data.StartTime");
			data.TalkDuration = _ctx.LongValue("GetPredictiveTaskData.Data.TalkDuration");
			data.TaskId = _ctx.StringValue("GetPredictiveTaskData.Data.TaskId");
			getPredictiveTaskDataResponse.Data = data;
        
			return getPredictiveTaskDataResponse;
        }
    }
}
