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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryTaskResponseUnmarshaller
    {
        public static QueryTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTaskResponse queryTaskResponse = new QueryTaskResponse();

			queryTaskResponse.HttpResponse = _ctx.HttpResponse;
			queryTaskResponse.RequestId = _ctx.StringValue("QueryTask.RequestId");
			queryTaskResponse.Success = _ctx.BooleanValue("QueryTask.Success");
			queryTaskResponse.Code = _ctx.StringValue("QueryTask.Code");
			queryTaskResponse.ErrorMessage = _ctx.StringValue("QueryTask.ErrorMessage");

			QueryTaskResponse.QueryTask_Data data = new QueryTaskResponse.QueryTask_Data();
			data.JobId = _ctx.StringValue("QueryTask.Data.JobId");
			data.JobName = _ctx.StringValue("QueryTask.Data.JobName");
			data.TaskId = _ctx.StringValue("QueryTask.Data.TaskId");
			data.ProductKey = _ctx.StringValue("QueryTask.Data.ProductKey");
			data.DeviceName = _ctx.StringValue("QueryTask.Data.DeviceName");
			data.IotId = _ctx.StringValue("QueryTask.Data.IotId");
			data.Progress = _ctx.StringValue("QueryTask.Data.Progress");
			data.UtcQueueTime = _ctx.StringValue("QueryTask.Data.UtcQueueTime");
			data.UtcModified = _ctx.StringValue("QueryTask.Data.UtcModified");
			data.StatusDetail = _ctx.StringValue("QueryTask.Data.StatusDetail");
			data.Status = _ctx.StringValue("QueryTask.Data.Status");
			data.Message = _ctx.StringValue("QueryTask.Data.Message");
			queryTaskResponse.Data = data;
        
			return queryTaskResponse;
        }
    }
}
