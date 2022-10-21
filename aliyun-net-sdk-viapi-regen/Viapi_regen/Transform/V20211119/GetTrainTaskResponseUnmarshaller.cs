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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class GetTrainTaskResponseUnmarshaller
    {
        public static GetTrainTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTrainTaskResponse getTrainTaskResponse = new GetTrainTaskResponse();

			getTrainTaskResponse.HttpResponse = _ctx.HttpResponse;
			getTrainTaskResponse.Message = _ctx.StringValue("GetTrainTask.Message");
			getTrainTaskResponse.RequestId = _ctx.StringValue("GetTrainTask.RequestId");
			getTrainTaskResponse.Code = _ctx.StringValue("GetTrainTask.Code");

			GetTrainTaskResponse.GetTrainTask_Data data = new GetTrainTaskResponse.GetTrainTask_Data();
			data.Id = _ctx.LongValue("GetTrainTask.Data.Id");
			data.GmtCreate = _ctx.LongValue("GetTrainTask.Data.GmtCreate");
			data.TaskName = _ctx.StringValue("GetTrainTask.Data.TaskName");
			data.Description = _ctx.StringValue("GetTrainTask.Data.Description");
			data.DatasetId = _ctx.LongValue("GetTrainTask.Data.DatasetId");
			data.DatasetName = _ctx.StringValue("GetTrainTask.Data.DatasetName");
			data.LabelId = _ctx.LongValue("GetTrainTask.Data.LabelId");
			data.LabelName = _ctx.StringValue("GetTrainTask.Data.LabelName");
			data.TrainMode = _ctx.StringValue("GetTrainTask.Data.TrainMode");
			data.TrainStatus = _ctx.StringValue("GetTrainTask.Data.TrainStatus");
			data.ModelId = _ctx.LongValue("GetTrainTask.Data.ModelId");
			data.ModelEffect = _ctx.StringValue("GetTrainTask.Data.ModelEffect");
			data.FailureReason = _ctx.StringValue("GetTrainTask.Data.FailureReason");
			data.TrainUseTime = _ctx.LongValue("GetTrainTask.Data.TrainUseTime");
			getTrainTaskResponse.Data = data;
        
			return getTrainTaskResponse;
        }
    }
}
