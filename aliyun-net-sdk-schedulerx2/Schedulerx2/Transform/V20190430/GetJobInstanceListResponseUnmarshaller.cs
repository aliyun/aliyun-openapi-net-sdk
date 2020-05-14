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
        public static GetJobInstanceListResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobInstanceListResponse getJobInstanceListResponse = new GetJobInstanceListResponse();

			getJobInstanceListResponse.HttpResponse = context.HttpResponse;
			getJobInstanceListResponse.RequestId = context.StringValue("GetJobInstanceList.RequestId");
			getJobInstanceListResponse.Code = context.IntegerValue("GetJobInstanceList.Code");
			getJobInstanceListResponse.Message = context.StringValue("GetJobInstanceList.Message");
			getJobInstanceListResponse.Success = context.BooleanValue("GetJobInstanceList.Success");

			GetJobInstanceListResponse.GetJobInstanceList_Data data = new GetJobInstanceListResponse.GetJobInstanceList_Data();

			List<GetJobInstanceListResponse.GetJobInstanceList_Data.GetJobInstanceList_JobInstanceDetailsItem> data_jobInstanceDetails = new List<GetJobInstanceListResponse.GetJobInstanceList_Data.GetJobInstanceList_JobInstanceDetailsItem>();
			for (int i = 0; i < context.Length("GetJobInstanceList.Data.JobInstanceDetails.Length"); i++) {
				GetJobInstanceListResponse.GetJobInstanceList_Data.GetJobInstanceList_JobInstanceDetailsItem jobInstanceDetailsItem = new GetJobInstanceListResponse.GetJobInstanceList_Data.GetJobInstanceList_JobInstanceDetailsItem();
				jobInstanceDetailsItem.InstanceId = context.LongValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].InstanceId");
				jobInstanceDetailsItem.JobId = context.LongValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].JobId");
				jobInstanceDetailsItem.Status = context.IntegerValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].Status");
				jobInstanceDetailsItem.StartTime = context.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].StartTime");
				jobInstanceDetailsItem.EndTime = context.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].EndTime");
				jobInstanceDetailsItem.ScheduleTime = context.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].ScheduleTime");
				jobInstanceDetailsItem.DataTime = context.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].DataTime");
				jobInstanceDetailsItem.Executor = context.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].Executor");
				jobInstanceDetailsItem.WorkAddr = context.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].WorkAddr");
				jobInstanceDetailsItem.Result = context.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].Result");
				jobInstanceDetailsItem.Progress = context.StringValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].Progress");
				jobInstanceDetailsItem.TimeType = context.IntegerValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].TimeType");
				jobInstanceDetailsItem.TriggerType = context.IntegerValue("GetJobInstanceList.Data.JobInstanceDetails["+ i +"].TriggerType");

				data_jobInstanceDetails.Add(jobInstanceDetailsItem);
			}
			data.JobInstanceDetails = data_jobInstanceDetails;
			getJobInstanceListResponse.Data = data;
        
			return getJobInstanceListResponse;
        }
    }
}
