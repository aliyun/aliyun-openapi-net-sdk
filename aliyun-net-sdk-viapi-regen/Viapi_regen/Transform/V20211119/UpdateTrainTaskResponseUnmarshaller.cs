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
    public class UpdateTrainTaskResponseUnmarshaller
    {
        public static UpdateTrainTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateTrainTaskResponse updateTrainTaskResponse = new UpdateTrainTaskResponse();

			updateTrainTaskResponse.HttpResponse = _ctx.HttpResponse;
			updateTrainTaskResponse.Message = _ctx.StringValue("UpdateTrainTask.Message");
			updateTrainTaskResponse.RequestId = _ctx.StringValue("UpdateTrainTask.RequestId");
			updateTrainTaskResponse.Code = _ctx.StringValue("UpdateTrainTask.Code");

			UpdateTrainTaskResponse.UpdateTrainTask_Data data = new UpdateTrainTaskResponse.UpdateTrainTask_Data();
			data.Id = _ctx.LongValue("UpdateTrainTask.Data.Id");
			data.GmtCreate = _ctx.LongValue("UpdateTrainTask.Data.GmtCreate");
			data.TaskName = _ctx.StringValue("UpdateTrainTask.Data.TaskName");
			data.Description = _ctx.StringValue("UpdateTrainTask.Data.Description");
			data.DatasetId = _ctx.LongValue("UpdateTrainTask.Data.DatasetId");
			data.DatasetName = _ctx.StringValue("UpdateTrainTask.Data.DatasetName");
			data.LabelId = _ctx.LongValue("UpdateTrainTask.Data.LabelId");
			data.LabelName = _ctx.StringValue("UpdateTrainTask.Data.LabelName");
			data.TrainMode = _ctx.StringValue("UpdateTrainTask.Data.TrainMode");
			data.AdvancedParameters = _ctx.StringValue("UpdateTrainTask.Data.AdvancedParameters");
			data.TrainStatus = _ctx.StringValue("UpdateTrainTask.Data.TrainStatus");
			data.ModelId = _ctx.LongValue("UpdateTrainTask.Data.ModelId");
			data.ModelEffect = _ctx.StringValue("UpdateTrainTask.Data.ModelEffect");
			updateTrainTaskResponse.Data = data;
        
			return updateTrainTaskResponse;
        }
    }
}
