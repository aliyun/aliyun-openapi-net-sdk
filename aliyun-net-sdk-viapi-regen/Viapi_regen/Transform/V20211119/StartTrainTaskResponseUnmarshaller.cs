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
    public class StartTrainTaskResponseUnmarshaller
    {
        public static StartTrainTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartTrainTaskResponse startTrainTaskResponse = new StartTrainTaskResponse();

			startTrainTaskResponse.HttpResponse = _ctx.HttpResponse;
			startTrainTaskResponse.Message = _ctx.StringValue("StartTrainTask.Message");
			startTrainTaskResponse.RequestId = _ctx.StringValue("StartTrainTask.RequestId");
			startTrainTaskResponse.Code = _ctx.StringValue("StartTrainTask.Code");

			StartTrainTaskResponse.StartTrainTask_Data data = new StartTrainTaskResponse.StartTrainTask_Data();
			data.Id = _ctx.LongValue("StartTrainTask.Data.Id");
			data.CheckResult = _ctx.StringValue("StartTrainTask.Data.CheckResult");
			data.GmtCreate = _ctx.LongValue("StartTrainTask.Data.GmtCreate");
			data.TaskName = _ctx.StringValue("StartTrainTask.Data.TaskName");
			data.Description = _ctx.StringValue("StartTrainTask.Data.Description");
			data.DatasetId = _ctx.LongValue("StartTrainTask.Data.DatasetId");
			data.DatasetName = _ctx.StringValue("StartTrainTask.Data.DatasetName");
			data.LabelId = _ctx.LongValue("StartTrainTask.Data.LabelId");
			data.LabelName = _ctx.StringValue("StartTrainTask.Data.LabelName");
			data.TrainMode = _ctx.StringValue("StartTrainTask.Data.TrainMode");
			data.TrainStatus = _ctx.StringValue("StartTrainTask.Data.TrainStatus");
			data.ModelId = _ctx.LongValue("StartTrainTask.Data.ModelId");
			data.ModelEffect = _ctx.StringValue("StartTrainTask.Data.ModelEffect");
			startTrainTaskResponse.Data = data;
        
			return startTrainTaskResponse;
        }
    }
}
