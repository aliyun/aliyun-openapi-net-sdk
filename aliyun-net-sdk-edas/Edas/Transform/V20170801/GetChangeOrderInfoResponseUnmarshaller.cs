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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetChangeOrderInfoResponseUnmarshaller
    {
        public static GetChangeOrderInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetChangeOrderInfoResponse getChangeOrderInfoResponse = new GetChangeOrderInfoResponse();

			getChangeOrderInfoResponse.HttpResponse = _ctx.HttpResponse;
			getChangeOrderInfoResponse.Code = _ctx.IntegerValue("GetChangeOrderInfo.Code");
			getChangeOrderInfoResponse.Message = _ctx.StringValue("GetChangeOrderInfo.Message");
			getChangeOrderInfoResponse.RequestId = _ctx.StringValue("GetChangeOrderInfo.RequestId");

			GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo changeOrderInfo = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo();
			changeOrderInfo.ChangeOrderId = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.ChangeOrderId");
			changeOrderInfo.CreateUserId = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.CreateUserId");
			changeOrderInfo.Desc = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.Desc");
			changeOrderInfo.BatchCount = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.BatchCount");
			changeOrderInfo.BatchType = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.BatchType");
			changeOrderInfo.Status = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.Status");
			changeOrderInfo.CoType = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.CoType");
			changeOrderInfo.CreateTime = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.CreateTime");
			changeOrderInfo.SupportRollback = _ctx.BooleanValue("GetChangeOrderInfo.ChangeOrderInfo.SupportRollback");
			changeOrderInfo.ChangeOrderDescription = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.ChangeOrderDescription");

			GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_TrafficControl trafficControl = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_TrafficControl();
			trafficControl.Rules = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.TrafficControl.Rules");
			trafficControl.Routes = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.TrafficControl.Routes");
			trafficControl.Tips = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.TrafficControl.Tips");
			changeOrderInfo.TrafficControl = trafficControl;

			List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo> changeOrderInfo_pipelineInfoList = new List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo>();
			for (int i = 0; i < _ctx.Length("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList.Length"); i++) {
				GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo pipelineInfo = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo();
				pipelineInfo.PipelineId = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].PipelineId");
				pipelineInfo.PipelineName = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].PipelineName");
				pipelineInfo.PipelineStatus = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].PipelineStatus");
				pipelineInfo.StartTime = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StartTime");
				pipelineInfo.UpdateTime = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].UpdateTime");

				List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO> pipelineInfo_stageList = new List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO>();
				for (int j = 0; j < _ctx.Length("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList.Length"); j++) {
					GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO stageInfoDTO = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO();
					stageInfoDTO.StageId = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageId");
					stageInfoDTO.StageName = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageName");
					stageInfoDTO.Status = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].Status");

					GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO stageResultDTO = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO();

					GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_ServiceStage serviceStage = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_ServiceStage();
					serviceStage.StageId = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.ServiceStage.StageId");
					serviceStage.StageName = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.ServiceStage.StageName");
					serviceStage.Status = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.ServiceStage.Status");
					serviceStage.Message = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.ServiceStage.Message");
					stageResultDTO.ServiceStage = serviceStage;

					List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_InstanceDTO> stageResultDTO_instanceDTOList = new List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_InstanceDTO>();
					for (int k = 0; k < _ctx.Length("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList.Length"); k++) {
						GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_InstanceDTO instanceDTO = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_InstanceDTO();
						instanceDTO.InstanceName = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceName");
						instanceDTO.InstanceIp = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceIp");
						instanceDTO.Status = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].Status");
						instanceDTO.PodName = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].PodName");
						instanceDTO.PodStatus = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].PodStatus");

						List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_InstanceDTO.GetChangeOrderInfo_InstanceStageDTO> instanceDTO_instanceStageDTOList = new List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_InstanceDTO.GetChangeOrderInfo_InstanceStageDTO>();
						for (int l = 0; l < _ctx.Length("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceStageDTOList.Length"); l++) {
							GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_InstanceDTO.GetChangeOrderInfo_InstanceStageDTO instanceStageDTO = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageInfoDTO.GetChangeOrderInfo_StageResultDTO.GetChangeOrderInfo_InstanceDTO.GetChangeOrderInfo_InstanceStageDTO();
							instanceStageDTO.StageId = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceStageDTOList["+ l +"].StageId");
							instanceStageDTO.StageName = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceStageDTOList["+ l +"].StageName");
							instanceStageDTO.Status = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceStageDTOList["+ l +"].Status");
							instanceStageDTO.StageMessage = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceStageDTOList["+ l +"].StageMessage");
							instanceStageDTO.StartTime = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceStageDTOList["+ l +"].StartTime");
							instanceStageDTO.FinishTime = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageList["+ j +"].StageResultDTO.InstanceDTOList["+ k +"].InstanceStageDTOList["+ l +"].FinishTime");

							instanceDTO_instanceStageDTOList.Add(instanceStageDTO);
						}
						instanceDTO.InstanceStageDTOList = instanceDTO_instanceStageDTOList;

						stageResultDTO_instanceDTOList.Add(instanceDTO);
					}
					stageResultDTO.InstanceDTOList = stageResultDTO_instanceDTOList;
					stageInfoDTO.StageResultDTO = stageResultDTO;

					pipelineInfo_stageList.Add(stageInfoDTO);
				}
				pipelineInfo.StageList = pipelineInfo_stageList;

				List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageDetailDTO> pipelineInfo_stageDetailList = new List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageDetailDTO>();
				for (int j = 0; j < _ctx.Length("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList.Length"); j++) {
					GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageDetailDTO stageDetailDTO = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageDetailDTO();
					stageDetailDTO.StageId = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].StageId");
					stageDetailDTO.StageName = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].StageName");
					stageDetailDTO.StageStatus = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].StageStatus");

					List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageDetailDTO.GetChangeOrderInfo_TaskInfoDTO> stageDetailDTO_taskList = new List<GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageDetailDTO.GetChangeOrderInfo_TaskInfoDTO>();
					for (int k = 0; k < _ctx.Length("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList.Length"); k++) {
						GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageDetailDTO.GetChangeOrderInfo_TaskInfoDTO taskInfoDTO = new GetChangeOrderInfoResponse.GetChangeOrderInfo_ChangeOrderInfo.GetChangeOrderInfo_PipelineInfo.GetChangeOrderInfo_StageDetailDTO.GetChangeOrderInfo_TaskInfoDTO();
						taskInfoDTO.TaskName = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].TaskName");
						taskInfoDTO.TaskStatus = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].TaskStatus");
						taskInfoDTO.TaskMessage = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].TaskMessage");
						taskInfoDTO.TaskId = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].TaskId");
						taskInfoDTO.TaskErrorCode = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].TaskErrorCode");
						taskInfoDTO.TaskErrorMessage = _ctx.StringValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].TaskErrorMessage");
						taskInfoDTO.ShowManualIgnorance = _ctx.BooleanValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].ShowManualIgnorance");
						taskInfoDTO.TaskErrorIgnorance = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].TaskErrorIgnorance");
						taskInfoDTO.RetryType = _ctx.IntegerValue("GetChangeOrderInfo.ChangeOrderInfo.PipelineInfoList["+ i +"].StageDetailList["+ j +"].TaskList["+ k +"].RetryType");

						stageDetailDTO_taskList.Add(taskInfoDTO);
					}
					stageDetailDTO.TaskList = stageDetailDTO_taskList;

					pipelineInfo_stageDetailList.Add(stageDetailDTO);
				}
				pipelineInfo.StageDetailList = pipelineInfo_stageDetailList;

				changeOrderInfo_pipelineInfoList.Add(pipelineInfo);
			}
			changeOrderInfo.PipelineInfoList = changeOrderInfo_pipelineInfoList;
			getChangeOrderInfoResponse.ChangeOrderInfo = changeOrderInfo;
        
			return getChangeOrderInfoResponse;
        }
    }
}
