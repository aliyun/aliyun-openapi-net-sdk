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
    public class CreateTrainTaskResponseUnmarshaller
    {
        public static CreateTrainTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTrainTaskResponse createTrainTaskResponse = new CreateTrainTaskResponse();

			createTrainTaskResponse.HttpResponse = _ctx.HttpResponse;
			createTrainTaskResponse.Message = _ctx.StringValue("CreateTrainTask.Message");
			createTrainTaskResponse.RequestId = _ctx.StringValue("CreateTrainTask.RequestId");
			createTrainTaskResponse.Code = _ctx.StringValue("CreateTrainTask.Code");

			CreateTrainTaskResponse.CreateTrainTask_Data data = new CreateTrainTaskResponse.CreateTrainTask_Data();
			data.Id = _ctx.LongValue("CreateTrainTask.Data.Id");
			data.GmtCreate = _ctx.LongValue("CreateTrainTask.Data.GmtCreate");
			data.TaskName = _ctx.StringValue("CreateTrainTask.Data.TaskName");
			data.Description = _ctx.StringValue("CreateTrainTask.Data.Description");
			data.DatasetId = _ctx.LongValue("CreateTrainTask.Data.DatasetId");
			data.DatasetName = _ctx.StringValue("CreateTrainTask.Data.DatasetName");
			data.LabelId = _ctx.LongValue("CreateTrainTask.Data.LabelId");
			data.LabelName = _ctx.StringValue("CreateTrainTask.Data.LabelName");
			data.TrainMode = _ctx.StringValue("CreateTrainTask.Data.TrainMode");
			data.RelyOnTaskId = _ctx.LongValue("CreateTrainTask.Data.RelyOnTaskId");
			data.RelyOnTaskName = _ctx.StringValue("CreateTrainTask.Data.RelyOnTaskName");
			data.AdvancedParameters = _ctx.StringValue("CreateTrainTask.Data.AdvancedParameters");
			data.TrainStatus = _ctx.StringValue("CreateTrainTask.Data.TrainStatus");
			data.ModelId = _ctx.LongValue("CreateTrainTask.Data.ModelId");
			data.ModelEffect = _ctx.StringValue("CreateTrainTask.Data.ModelEffect");
			createTrainTaskResponse.Data = data;
        
			return createTrainTaskResponse;
        }
    }
}
