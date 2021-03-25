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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribePipelineResponseUnmarshaller
    {
        public static DescribePipelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePipelineResponse describePipelineResponse = new DescribePipelineResponse();

			describePipelineResponse.HttpResponse = _ctx.HttpResponse;
			describePipelineResponse.Message = _ctx.StringValue("DescribePipeline.Message");
			describePipelineResponse.RequestId = _ctx.StringValue("DescribePipeline.RequestId");
			describePipelineResponse.TraceId = _ctx.StringValue("DescribePipeline.TraceId");
			describePipelineResponse.ErrorCode = _ctx.StringValue("DescribePipeline.ErrorCode");
			describePipelineResponse.Code = _ctx.StringValue("DescribePipeline.Code");
			describePipelineResponse.Success = _ctx.BooleanValue("DescribePipeline.Success");

			DescribePipelineResponse.DescribePipeline_Data data = new DescribePipelineResponse.DescribePipeline_Data();
			data.PipelineStatus = _ctx.IntegerValue("DescribePipeline.Data.PipelineStatus");
			data.ShowBatch = _ctx.BooleanValue("DescribePipeline.Data.ShowBatch");
			data.CurrentPoint = _ctx.IntegerValue("DescribePipeline.Data.CurrentPoint");
			data.PipelineName = _ctx.StringValue("DescribePipeline.Data.PipelineName");
			data.PipelineId = _ctx.StringValue("DescribePipeline.Data.PipelineId");
			data.CurrentStageId = _ctx.StringValue("DescribePipeline.Data.CurrentStageId");
			data.CoStatus = _ctx.StringValue("DescribePipeline.Data.CoStatus");
			data.NextPipelineId = _ctx.StringValue("DescribePipeline.Data.NextPipelineId");

			List<DescribePipelineResponse.DescribePipeline_Data.DescribePipeline_Stage> data_stageList = new List<DescribePipelineResponse.DescribePipeline_Data.DescribePipeline_Stage>();
			for (int i = 0; i < _ctx.Length("DescribePipeline.Data.StageList.Length"); i++) {
				DescribePipelineResponse.DescribePipeline_Data.DescribePipeline_Stage stage = new DescribePipelineResponse.DescribePipeline_Data.DescribePipeline_Stage();
				stage.Status = _ctx.IntegerValue("DescribePipeline.Data.StageList["+ i +"].Status");
				stage.StageName = _ctx.StringValue("DescribePipeline.Data.StageList["+ i +"].StageName");
				stage.ExecutorType = _ctx.IntegerValue("DescribePipeline.Data.StageList["+ i +"].ExecutorType");
				stage.StageId = _ctx.StringValue("DescribePipeline.Data.StageList["+ i +"].StageId");

				List<DescribePipelineResponse.DescribePipeline_Data.DescribePipeline_Stage.DescribePipeline_Task> stage_taskList = new List<DescribePipelineResponse.DescribePipeline_Data.DescribePipeline_Stage.DescribePipeline_Task>();
				for (int j = 0; j < _ctx.Length("DescribePipeline.Data.StageList["+ i +"].TaskList.Length"); j++) {
					DescribePipelineResponse.DescribePipeline_Data.DescribePipeline_Stage.DescribePipeline_Task task = new DescribePipelineResponse.DescribePipeline_Data.DescribePipeline_Stage.DescribePipeline_Task();
					task.Status = _ctx.IntegerValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].Status");
					task.ErrorIgnore = _ctx.IntegerValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].ErrorIgnore");
					task.TaskId = _ctx.StringValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].TaskId");
					task.Message = _ctx.StringValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].Message");
					task.ShowManualIgnore = _ctx.BooleanValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].ShowManualIgnore");
					task.TaskName = _ctx.StringValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].TaskName");
					task.StageId = _ctx.StringValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].StageId");
					task.ErrorCode = _ctx.StringValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].ErrorCode");
					task.ErrorMessage = _ctx.StringValue("DescribePipeline.Data.StageList["+ i +"].TaskList["+ j +"].ErrorMessage");

					stage_taskList.Add(task);
				}
				stage.TaskList = stage_taskList;

				data_stageList.Add(stage);
			}
			data.StageList = data_stageList;
			describePipelineResponse.Data = data;
        
			return describePipelineResponse;
        }
    }
}
