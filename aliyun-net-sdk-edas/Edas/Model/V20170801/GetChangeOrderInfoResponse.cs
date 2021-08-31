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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetChangeOrderInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetChangeOrderInfo_ChangeOrderInfo changeOrderInfo;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetChangeOrderInfo_ChangeOrderInfo ChangeOrderInfo
		{
			get
			{
				return changeOrderInfo;
			}
			set	
			{
				changeOrderInfo = value;
			}
		}

		public class GetChangeOrderInfo_ChangeOrderInfo
		{

			private string changeOrderId;

			private string createUserId;

			private string desc;

			private int? batchCount;

			private string batchType;

			private int? status;

			private string coType;

			private string createTime;

			private bool? supportRollback;

			private string changeOrderDescription;

			private List<GetChangeOrderInfo_PipelineInfo> pipelineInfoList;

			private GetChangeOrderInfo_TrafficControl trafficControl;

			public string ChangeOrderId
			{
				get
				{
					return changeOrderId;
				}
				set	
				{
					changeOrderId = value;
				}
			}

			public string CreateUserId
			{
				get
				{
					return createUserId;
				}
				set	
				{
					createUserId = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}

			public int? BatchCount
			{
				get
				{
					return batchCount;
				}
				set	
				{
					batchCount = value;
				}
			}

			public string BatchType
			{
				get
				{
					return batchType;
				}
				set	
				{
					batchType = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string CoType
			{
				get
				{
					return coType;
				}
				set	
				{
					coType = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public bool? SupportRollback
			{
				get
				{
					return supportRollback;
				}
				set	
				{
					supportRollback = value;
				}
			}

			public string ChangeOrderDescription
			{
				get
				{
					return changeOrderDescription;
				}
				set	
				{
					changeOrderDescription = value;
				}
			}

			public List<GetChangeOrderInfo_PipelineInfo> PipelineInfoList
			{
				get
				{
					return pipelineInfoList;
				}
				set	
				{
					pipelineInfoList = value;
				}
			}

			public GetChangeOrderInfo_TrafficControl TrafficControl
			{
				get
				{
					return trafficControl;
				}
				set	
				{
					trafficControl = value;
				}
			}

			public class GetChangeOrderInfo_PipelineInfo
			{

				private string pipelineId;

				private string pipelineName;

				private int? pipelineStatus;

				private string startTime;

				private string updateTime;

				private List<GetChangeOrderInfo_StageInfoDTO> stageList;

				private List<GetChangeOrderInfo_StageDetailDTO> stageDetailList;

				public string PipelineId
				{
					get
					{
						return pipelineId;
					}
					set	
					{
						pipelineId = value;
					}
				}

				public string PipelineName
				{
					get
					{
						return pipelineName;
					}
					set	
					{
						pipelineName = value;
					}
				}

				public int? PipelineStatus
				{
					get
					{
						return pipelineStatus;
					}
					set	
					{
						pipelineStatus = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public List<GetChangeOrderInfo_StageInfoDTO> StageList
				{
					get
					{
						return stageList;
					}
					set	
					{
						stageList = value;
					}
				}

				public List<GetChangeOrderInfo_StageDetailDTO> StageDetailList
				{
					get
					{
						return stageDetailList;
					}
					set	
					{
						stageDetailList = value;
					}
				}

				public class GetChangeOrderInfo_StageInfoDTO
				{

					private string stageId;

					private string stageName;

					private int? status;

					private GetChangeOrderInfo_StageResultDTO stageResultDTO;

					public string StageId
					{
						get
						{
							return stageId;
						}
						set	
						{
							stageId = value;
						}
					}

					public string StageName
					{
						get
						{
							return stageName;
						}
						set	
						{
							stageName = value;
						}
					}

					public int? Status
					{
						get
						{
							return status;
						}
						set	
						{
							status = value;
						}
					}

					public GetChangeOrderInfo_StageResultDTO StageResultDTO
					{
						get
						{
							return stageResultDTO;
						}
						set	
						{
							stageResultDTO = value;
						}
					}

					public class GetChangeOrderInfo_StageResultDTO
					{

						private List<GetChangeOrderInfo_InstanceDTO> instanceDTOList;

						private GetChangeOrderInfo_ServiceStage serviceStage;

						public List<GetChangeOrderInfo_InstanceDTO> InstanceDTOList
						{
							get
							{
								return instanceDTOList;
							}
							set	
							{
								instanceDTOList = value;
							}
						}

						public GetChangeOrderInfo_ServiceStage ServiceStage
						{
							get
							{
								return serviceStage;
							}
							set	
							{
								serviceStage = value;
							}
						}

						public class GetChangeOrderInfo_InstanceDTO
						{

							private string instanceName;

							private string instanceIp;

							private int? status;

							private string podName;

							private string podStatus;

							private List<GetChangeOrderInfo_InstanceStageDTO> instanceStageDTOList;

							public string InstanceName
							{
								get
								{
									return instanceName;
								}
								set	
								{
									instanceName = value;
								}
							}

							public string InstanceIp
							{
								get
								{
									return instanceIp;
								}
								set	
								{
									instanceIp = value;
								}
							}

							public int? Status
							{
								get
								{
									return status;
								}
								set	
								{
									status = value;
								}
							}

							public string PodName
							{
								get
								{
									return podName;
								}
								set	
								{
									podName = value;
								}
							}

							public string PodStatus
							{
								get
								{
									return podStatus;
								}
								set	
								{
									podStatus = value;
								}
							}

							public List<GetChangeOrderInfo_InstanceStageDTO> InstanceStageDTOList
							{
								get
								{
									return instanceStageDTOList;
								}
								set	
								{
									instanceStageDTOList = value;
								}
							}

							public class GetChangeOrderInfo_InstanceStageDTO
							{

								private string stageId;

								private string stageName;

								private int? status;

								private string stageMessage;

								private string startTime;

								private string finishTime;

								public string StageId
								{
									get
									{
										return stageId;
									}
									set	
									{
										stageId = value;
									}
								}

								public string StageName
								{
									get
									{
										return stageName;
									}
									set	
									{
										stageName = value;
									}
								}

								public int? Status
								{
									get
									{
										return status;
									}
									set	
									{
										status = value;
									}
								}

								public string StageMessage
								{
									get
									{
										return stageMessage;
									}
									set	
									{
										stageMessage = value;
									}
								}

								public string StartTime
								{
									get
									{
										return startTime;
									}
									set	
									{
										startTime = value;
									}
								}

								public string FinishTime
								{
									get
									{
										return finishTime;
									}
									set	
									{
										finishTime = value;
									}
								}
							}
						}

						public class GetChangeOrderInfo_ServiceStage
						{

							private string stageId;

							private string stageName;

							private int? status;

							private string message;

							public string StageId
							{
								get
								{
									return stageId;
								}
								set	
								{
									stageId = value;
								}
							}

							public string StageName
							{
								get
								{
									return stageName;
								}
								set	
								{
									stageName = value;
								}
							}

							public int? Status
							{
								get
								{
									return status;
								}
								set	
								{
									status = value;
								}
							}

							public string Message
							{
								get
								{
									return message;
								}
								set	
								{
									message = value;
								}
							}
						}
					}
				}

				public class GetChangeOrderInfo_StageDetailDTO
				{

					private string stageId;

					private string stageName;

					private int? stageStatus;

					private List<GetChangeOrderInfo_TaskInfoDTO> taskList;

					public string StageId
					{
						get
						{
							return stageId;
						}
						set	
						{
							stageId = value;
						}
					}

					public string StageName
					{
						get
						{
							return stageName;
						}
						set	
						{
							stageName = value;
						}
					}

					public int? StageStatus
					{
						get
						{
							return stageStatus;
						}
						set	
						{
							stageStatus = value;
						}
					}

					public List<GetChangeOrderInfo_TaskInfoDTO> TaskList
					{
						get
						{
							return taskList;
						}
						set	
						{
							taskList = value;
						}
					}

					public class GetChangeOrderInfo_TaskInfoDTO
					{

						private string taskName;

						private string taskStatus;

						private string taskMessage;

						private string taskId;

						private string taskErrorCode;

						private string taskErrorMessage;

						private bool? showManualIgnorance;

						private int? taskErrorIgnorance;

						private int? retryType;

						public string TaskName
						{
							get
							{
								return taskName;
							}
							set	
							{
								taskName = value;
							}
						}

						public string TaskStatus
						{
							get
							{
								return taskStatus;
							}
							set	
							{
								taskStatus = value;
							}
						}

						public string TaskMessage
						{
							get
							{
								return taskMessage;
							}
							set	
							{
								taskMessage = value;
							}
						}

						public string TaskId
						{
							get
							{
								return taskId;
							}
							set	
							{
								taskId = value;
							}
						}

						public string TaskErrorCode
						{
							get
							{
								return taskErrorCode;
							}
							set	
							{
								taskErrorCode = value;
							}
						}

						public string TaskErrorMessage
						{
							get
							{
								return taskErrorMessage;
							}
							set	
							{
								taskErrorMessage = value;
							}
						}

						public bool? ShowManualIgnorance
						{
							get
							{
								return showManualIgnorance;
							}
							set	
							{
								showManualIgnorance = value;
							}
						}

						public int? TaskErrorIgnorance
						{
							get
							{
								return taskErrorIgnorance;
							}
							set	
							{
								taskErrorIgnorance = value;
							}
						}

						public int? RetryType
						{
							get
							{
								return retryType;
							}
							set	
							{
								retryType = value;
							}
						}
					}
				}
			}

			public class GetChangeOrderInfo_TrafficControl
			{

				private string rules;

				private string routes;

				private string tips;

				public string Rules
				{
					get
					{
						return rules;
					}
					set	
					{
						rules = value;
					}
				}

				public string Routes
				{
					get
					{
						return routes;
					}
					set	
					{
						routes = value;
					}
				}

				public string Tips
				{
					get
					{
						return tips;
					}
					set	
					{
						tips = value;
					}
				}
			}
		}
	}
}
