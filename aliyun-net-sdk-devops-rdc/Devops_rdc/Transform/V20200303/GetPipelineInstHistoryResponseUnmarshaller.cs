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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetPipelineInstHistoryResponseUnmarshaller
    {
        public static GetPipelineInstHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPipelineInstHistoryResponse getPipelineInstHistoryResponse = new GetPipelineInstHistoryResponse();

			getPipelineInstHistoryResponse.HttpResponse = _ctx.HttpResponse;
			getPipelineInstHistoryResponse.RequestId = _ctx.StringValue("GetPipelineInstHistory.RequestId");
			getPipelineInstHistoryResponse.ErrorMessage = _ctx.StringValue("GetPipelineInstHistory.ErrorMessage");
			getPipelineInstHistoryResponse.Success = _ctx.BooleanValue("GetPipelineInstHistory.Success");
			getPipelineInstHistoryResponse.ErrorCode = _ctx.StringValue("GetPipelineInstHistory.ErrorCode");

			GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data data = new GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data();
			data.Total = _ctx.IntegerValue("GetPipelineInstHistory.Data.Total");

			List<GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst> data_dataList = new List<GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst>();
			for (int i = 0; i < _ctx.Length("GetPipelineInstHistory.Data.DataList.Length"); i++) {
				GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst pipelineInst = new GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst();
				pipelineInst.Status = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].Status");
				pipelineInst.CreateTime = _ctx.LongValue("GetPipelineInstHistory.Data.DataList["+ i +"].CreateTime");
				pipelineInst.StatusName = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].StatusName");
				pipelineInst.TriggerMode = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].TriggerMode");
				pipelineInst.PipelineConfigId = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].PipelineConfigId");
				pipelineInst.Deletion = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].Deletion");
				pipelineInst.Creator = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].Creator");
				pipelineInst.InstNumber = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].InstNumber");
				pipelineInst.Modifier = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].Modifier");
				pipelineInst.Packages = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].Packages");
				pipelineInst.FlowInstId = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstId");
				pipelineInst.PipelineId = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].PipelineId");
				pipelineInst.Id = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].Id");
				pipelineInst.ModifyTime = _ctx.LongValue("GetPipelineInstHistory.Data.DataList["+ i +"].ModifyTime");

				GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst.GetPipelineInstHistory_FlowInstance flowInstance = new GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst.GetPipelineInstHistory_FlowInstance();
				flowInstance.Status = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Status");
				flowInstance.Stages = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Stages");
				flowInstance.CreateTime = _ctx.LongValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.CreateTime");
				flowInstance.StatusName = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.StatusName");
				flowInstance.RunningStatus = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.RunningStatus");
				flowInstance.Creator = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Creator");
				flowInstance.StageTopo = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.StageTopo");
				flowInstance.Modifier = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Modifier");
				flowInstance.AutoDrivenStatus = _ctx.BooleanValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.AutoDrivenStatus");
				flowInstance.ResultStatus = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.ResultStatus");
				flowInstance.Id = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Id");
				flowInstance.SystemCode = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.SystemCode");
				flowInstance.ModifyTime = _ctx.LongValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.ModifyTime");
				flowInstance.SystemId = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.SystemId");

				GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst.GetPipelineInstHistory_FlowInstance.GetPipelineInstHistory_Result result = new GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst.GetPipelineInstHistory_FlowInstance.GetPipelineInstHistory_Result();
				result.EnginePipelineNumber = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.EnginePipelineNumber");
				result.MixFlowInstId = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.MixFlowInstId");
				result.EnginePipelineName = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.EnginePipelineName");
				result.EnginePipelineId = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.EnginePipelineId");
				result.EnginePipelineInstId = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.EnginePipelineInstId");
				result.TimeStamp = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.TimeStamp");
				result.TriggerMode = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.TriggerMode");
				result.Sources = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.Sources");
				result.Caches = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.Caches");
				result.DateTime = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Result.DateTime");
				flowInstance.Result = result;

				List<GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst.GetPipelineInstHistory_FlowInstance.GetPipelineInstHistory_Group> flowInstance_groups = new List<GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst.GetPipelineInstHistory_FlowInstance.GetPipelineInstHistory_Group>();
				for (int j = 0; j < _ctx.Length("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups.Length"); j++) {
					GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst.GetPipelineInstHistory_FlowInstance.GetPipelineInstHistory_Group group = new GetPipelineInstHistoryResponse.GetPipelineInstHistory_Data.GetPipelineInstHistory_PipelineInst.GetPipelineInstHistory_FlowInstance.GetPipelineInstHistory_Group();
					group.Status = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].Status");
					group.CreateTime = _ctx.LongValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].CreateTime");
					group.DeleteStatus = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].DeleteStatus");
					group.IdExtent = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].IdExtent");
					group.Creator = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].Creator");
					group.EndTime = _ctx.LongValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].EndTime");
					group.StartTime = _ctx.LongValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].StartTime");
					group.Modifier = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].Modifier");
					group.ResultStatus = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].ResultStatus");
					group.FlowInstId = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].FlowInstId");
					group.Name = _ctx.StringValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].Name");
					group.Id = _ctx.IntegerValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].Id");
					group.ModifyTime = _ctx.LongValue("GetPipelineInstHistory.Data.DataList["+ i +"].FlowInstance.Groups["+ j +"].ModifyTime");

					flowInstance_groups.Add(group);
				}
				flowInstance.Groups = flowInstance_groups;
				pipelineInst.FlowInstance = flowInstance;

				data_dataList.Add(pipelineInst);
			}
			data.DataList = data_dataList;
			getPipelineInstHistoryResponse.Data = data;
        
			return getPipelineInstHistoryResponse;
        }
    }
}
