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
using Aliyun.Acs.videosearch.Model.V20200225;

namespace Aliyun.Acs.videosearch.Transform.V20200225
{
    public class GetTaskStatusResponseUnmarshaller
    {
        public static GetTaskStatusResponse Unmarshall(UnmarshallerContext context)
        {
			GetTaskStatusResponse getTaskStatusResponse = new GetTaskStatusResponse();

			getTaskStatusResponse.HttpResponse = context.HttpResponse;
			getTaskStatusResponse.RequestId = context.StringValue("GetTaskStatus.RequestId");
			getTaskStatusResponse.Data = context.IntegerValue("GetTaskStatus.Data");

			GetTaskStatusResponse.GetTaskStatus_TaskInfo taskInfo = new GetTaskStatusResponse.GetTaskStatus_TaskInfo();
			taskInfo.AnalysisUseTime = context.LongValue("GetTaskStatus.TaskInfo.AnalysisUseTime");
			taskInfo.Duration = context.FloatValue("GetTaskStatus.TaskInfo.Duration");
			taskInfo.ProcessResultOss = context.StringValue("GetTaskStatus.TaskInfo.ProcessResultOss");
			taskInfo.Resolution = context.StringValue("GetTaskStatus.TaskInfo.Resolution");
			taskInfo.Status = context.IntegerValue("GetTaskStatus.TaskInfo.Status");
			taskInfo.SubmitTime = context.LongValue("GetTaskStatus.TaskInfo.SubmitTime");
			taskInfo.FinishTime = context.LongValue("GetTaskStatus.TaskInfo.FinishTime");
			taskInfo.TaskId = context.LongValue("GetTaskStatus.TaskInfo.TaskId");
			taskInfo.ErrorInfo = context.StringValue("GetTaskStatus.TaskInfo.ErrorInfo");
			taskInfo.StorageInfo = context.IntegerValue("GetTaskStatus.TaskInfo.StorageInfo");
			taskInfo.Description = context.StringValue("GetTaskStatus.TaskInfo.Description");
			taskInfo.VideoId = context.StringValue("GetTaskStatus.TaskInfo.VideoId");
			taskInfo.VideoTags = context.StringValue("GetTaskStatus.TaskInfo.VideoTags");
			taskInfo.VideoUrl = context.StringValue("GetTaskStatus.TaskInfo.VideoUrl");
			taskInfo.QueryTags = context.StringValue("GetTaskStatus.TaskInfo.QueryTags");
			getTaskStatusResponse.TaskInfo = taskInfo;
        
			return getTaskStatusResponse;
        }
    }
}
