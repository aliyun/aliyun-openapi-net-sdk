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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetDetectionResponseUnmarshaller
    {
        public static GetDetectionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDetectionResponse getDetectionResponse = new GetDetectionResponse();

			getDetectionResponse.HttpResponse = _ctx.HttpResponse;
			getDetectionResponse.Code = _ctx.StringValue("GetDetection.Code");
			getDetectionResponse.Message = _ctx.StringValue("GetDetection.Message");
			getDetectionResponse.RequestId = _ctx.StringValue("GetDetection.RequestId");

			GetDetectionResponse.GetDetection_Data data = new GetDetectionResponse.GetDetection_Data();
			data.CreatedAt = _ctx.StringValue("GetDetection.Data.CreatedAt");
			data.DepartmentId = _ctx.StringValue("GetDetection.Data.DepartmentId");
			data.DepartmentName = _ctx.StringValue("GetDetection.Data.DepartmentName");
			data.Id = _ctx.StringValue("GetDetection.Data.Id");
			data.RecordingType = _ctx.StringValue("GetDetection.Data.RecordingType");
			data.RuleId = _ctx.StringValue("GetDetection.Data.RuleId");
			data.RuleName = _ctx.StringValue("GetDetection.Data.RuleName");
			data.Status = _ctx.StringValue("GetDetection.Data.Status");

			List<GetDetectionResponse.GetDetection_Data.GetDetection_TasksItem> data_tasks = new List<GetDetectionResponse.GetDetection_Data.GetDetection_TasksItem>();
			for (int i = 0; i < _ctx.Length("GetDetection.Data.Tasks.Length"); i++) {
				GetDetectionResponse.GetDetection_Data.GetDetection_TasksItem tasksItem = new GetDetectionResponse.GetDetection_Data.GetDetection_TasksItem();
				tasksItem.CreatedAt = _ctx.StringValue("GetDetection.Data.Tasks["+ i +"].CreatedAt");
				tasksItem.Id = _ctx.StringValue("GetDetection.Data.Tasks["+ i +"].Id");
				tasksItem.Status = _ctx.StringValue("GetDetection.Data.Tasks["+ i +"].Status");
				tasksItem.VideoMetaUrl = _ctx.StringValue("GetDetection.Data.Tasks["+ i +"].VideoMetaUrl");
				tasksItem.VideoUrl = _ctx.StringValue("GetDetection.Data.Tasks["+ i +"].VideoUrl");

				data_tasks.Add(tasksItem);
			}
			data.Tasks = data_tasks;
			getDetectionResponse.Data = data;
        
			return getDetectionResponse;
        }
    }
}
