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
    public class GetJobInstanceListResponseUnmarshaller
    {
        public static GetJobInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobInstanceListResponse getJobInstanceListResponse = new GetJobInstanceListResponse();

			getJobInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			getJobInstanceListResponse.RequestId = _ctx.StringValue("GetJobInstanceList.RequestId");
			getJobInstanceListResponse.Code = _ctx.IntegerValue("GetJobInstanceList.Code");
			getJobInstanceListResponse.Message = _ctx.StringValue("GetJobInstanceList.Message");
			getJobInstanceListResponse.Success = _ctx.BooleanValue("GetJobInstanceList.Success");

			GetJobInstanceListResponse.GetJobInstanceList_Data data = new GetJobInstanceListResponse.GetJobInstanceList_Data();

			List<GetJobInstanceListResponse.GetJobInstanceList_Data.GetJobInstanceList_JobInstanceDetailsItem> data_jobInstanceDetails = new List<GetJobInstanceListResponse.GetJobInstanceList_Data.GetJobInstanceList_JobInstanceDetailsItem>();
			for (int i = 0; i < _ctx.Length("GetJobInstanceList.Data.JobInstanceDetails.Length"); i++) {
				GetJobInstanceListResponse.GetJobInstanceList_Data.GetJobInstanceList_JobInstanceDetailsItem jobInstanceDetailsItem = new GetJobInstanceListResponse.GetJobInstanceList_Data.GetJobInstanceList_JobInstanceDetailsItem();
				jobInstanceDetailsItem.InstanceId = _ctx.LongValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].InstanceId");
				jobInstanceDetailsItem.JobId = _ctx.LongValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].JobId");
				jobInstanceDetailsItem.Status = _ctx.IntegerValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].Status");
				jobInstanceDetailsItem.StartTime = _ctx.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].StartTime");
				jobInstanceDetailsItem.EndTime = _ctx.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].EndTime");
				jobInstanceDetailsItem.ScheduleTime = _ctx.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].ScheduleTime");
				jobInstanceDetailsItem.DataTime = _ctx.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].DataTime");
				jobInstanceDetailsItem.Executor = _ctx.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].Executor");
				jobInstanceDetailsItem.WorkAddr = _ctx.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].WorkAddr");
				jobInstanceDetailsItem.Result = _ctx.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].Result");
				jobInstanceDetailsItem.Progress = _ctx.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].Progress");
				jobInstanceDetailsItem.TimeType = _ctx.IntegerValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].TimeType");
				jobInstanceDetailsItem.TriggerType = _ctx.IntegerValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].TriggerType");

				data_jobInstanceDetails.Add(jobInstanceDetailsItem);
			}
			data.JobInstanceDetails = data_jobInstanceDetails;
			getJobInstanceListResponse.Data = data;
        
			return getJobInstanceListResponse;
        }
    }
}
