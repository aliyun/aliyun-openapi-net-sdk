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
    public class DeleteTrainTaskResponseUnmarshaller
    {
        public static DeleteTrainTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteTrainTaskResponse deleteTrainTaskResponse = new DeleteTrainTaskResponse();

			deleteTrainTaskResponse.HttpResponse = _ctx.HttpResponse;
			deleteTrainTaskResponse.Message = _ctx.StringValue("DeleteTrainTask.Message");
			deleteTrainTaskResponse.RequestId = _ctx.StringValue("DeleteTrainTask.RequestId");
			deleteTrainTaskResponse.Code = _ctx.StringValue("DeleteTrainTask.Code");

			DeleteTrainTaskResponse.DeleteTrainTask_Data data = new DeleteTrainTaskResponse.DeleteTrainTask_Data();
			data.Id = _ctx.LongValue("DeleteTrainTask.Data.Id");
			data.GmtCreate = _ctx.LongValue("DeleteTrainTask.Data.GmtCreate");
			data.TaskName = _ctx.StringValue("DeleteTrainTask.Data.TaskName");
			data.Description = _ctx.StringValue("DeleteTrainTask.Data.Description");
			data.DatasetId = _ctx.LongValue("DeleteTrainTask.Data.DatasetId");
			data.DatasetName = _ctx.StringValue("DeleteTrainTask.Data.DatasetName");
			data.LabelId = _ctx.LongValue("DeleteTrainTask.Data.LabelId");
			data.LabelName = _ctx.StringValue("DeleteTrainTask.Data.LabelName");
			data.TrainMode = _ctx.StringValue("DeleteTrainTask.Data.TrainMode");
			data.TrainStatus = _ctx.StringValue("DeleteTrainTask.Data.TrainStatus");
			data.ModelId = _ctx.LongValue("DeleteTrainTask.Data.ModelId");
			data.ModelEffect = _ctx.StringValue("DeleteTrainTask.Data.ModelEffect");
			deleteTrainTaskResponse.Data = data;
        
			return deleteTrainTaskResponse;
        }
    }
}
