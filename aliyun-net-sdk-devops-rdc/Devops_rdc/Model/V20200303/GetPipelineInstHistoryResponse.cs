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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetPipelineInstHistoryResponse : AcsResponse
	{

		private string requestId;

		private string errorMessage;

		private bool? success;

		private string errorCode;

		private GetPipelineInstHistory_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public GetPipelineInstHistory_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetPipelineInstHistory_Data
		{

			private int? total;

			private List<GetPipelineInstHistory_PipelineInst> dataList;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<GetPipelineInstHistory_PipelineInst> DataList
			{
				get
				{
					return dataList;
				}
				set	
				{
					dataList = value;
				}
			}

			public class GetPipelineInstHistory_PipelineInst
			{

				private string status;

				private long? createTime;

				private string statusName;

				private int? triggerMode;

				private int? pipelineConfigId;

				private string deletion;

				private string creator;

				private int? instNumber;

				private string modifier;

				private string packages;

				private int? flowInstId;

				private int? pipelineId;

				private int? id;

				private long? modifyTime;

				private GetPipelineInstHistory_FlowInstance flowInstance;

				public string Status
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

				public long? CreateTime
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

				public string StatusName
				{
					get
					{
						return statusName;
					}
					set	
					{
						statusName = value;
					}
				}

				public int? TriggerMode
				{
					get
					{
						return triggerMode;
					}
					set	
					{
						triggerMode = value;
					}
				}

				public int? PipelineConfigId
				{
					get
					{
						return pipelineConfigId;
					}
					set	
					{
						pipelineConfigId = value;
					}
				}

				public string Deletion
				{
					get
					{
						return deletion;
					}
					set	
					{
						deletion = value;
					}
				}

				public string Creator
				{
					get
					{
						return creator;
					}
					set	
					{
						creator = value;
					}
				}

				public int? InstNumber
				{
					get
					{
						return instNumber;
					}
					set	
					{
						instNumber = value;
					}
				}

				public string Modifier
				{
					get
					{
						return modifier;
					}
					set	
					{
						modifier = value;
					}
				}

				public string Packages
				{
					get
					{
						return packages;
					}
					set	
					{
						packages = value;
					}
				}

				public int? FlowInstId
				{
					get
					{
						return flowInstId;
					}
					set	
					{
						flowInstId = value;
					}
				}

				public int? PipelineId
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

				public int? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public long? ModifyTime
				{
					get
					{
						return modifyTime;
					}
					set	
					{
						modifyTime = value;
					}
				}

				public GetPipelineInstHistory_FlowInstance FlowInstance
				{
					get
					{
						return flowInstance;
					}
					set	
					{
						flowInstance = value;
					}
				}

				public class GetPipelineInstHistory_FlowInstance
				{

					private string status;

					private string stages;

					private long? createTime;

					private string statusName;

					private string runningStatus;

					private string creator;

					private string stageTopo;

					private string modifier;

					private bool? autoDrivenStatus;

					private string resultStatus;

					private int? id;

					private string systemCode;

					private long? modifyTime;

					private string systemId;

					private List<GetPipelineInstHistory_Group> groups;

					private GetPipelineInstHistory_Result result;

					public string Status
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

					public string Stages
					{
						get
						{
							return stages;
						}
						set	
						{
							stages = value;
						}
					}

					public long? CreateTime
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

					public string StatusName
					{
						get
						{
							return statusName;
						}
						set	
						{
							statusName = value;
						}
					}

					public string RunningStatus
					{
						get
						{
							return runningStatus;
						}
						set	
						{
							runningStatus = value;
						}
					}

					public string Creator
					{
						get
						{
							return creator;
						}
						set	
						{
							creator = value;
						}
					}

					public string StageTopo
					{
						get
						{
							return stageTopo;
						}
						set	
						{
							stageTopo = value;
						}
					}

					public string Modifier
					{
						get
						{
							return modifier;
						}
						set	
						{
							modifier = value;
						}
					}

					public bool? AutoDrivenStatus
					{
						get
						{
							return autoDrivenStatus;
						}
						set	
						{
							autoDrivenStatus = value;
						}
					}

					public string ResultStatus
					{
						get
						{
							return resultStatus;
						}
						set	
						{
							resultStatus = value;
						}
					}

					public int? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
						}
					}

					public string SystemCode
					{
						get
						{
							return systemCode;
						}
						set	
						{
							systemCode = value;
						}
					}

					public long? ModifyTime
					{
						get
						{
							return modifyTime;
						}
						set	
						{
							modifyTime = value;
						}
					}

					public string SystemId
					{
						get
						{
							return systemId;
						}
						set	
						{
							systemId = value;
						}
					}

					public List<GetPipelineInstHistory_Group> Groups
					{
						get
						{
							return groups;
						}
						set	
						{
							groups = value;
						}
					}

					public GetPipelineInstHistory_Result Result
					{
						get
						{
							return result;
						}
						set	
						{
							result = value;
						}
					}

					public class GetPipelineInstHistory_Group
					{

						private string status;

						private long? createTime;

						private string deleteStatus;

						private int? idExtent;

						private string creator;

						private long? endTime;

						private long? startTime;

						private string modifier;

						private string resultStatus;

						private int? flowInstId;

						private string name;

						private int? id;

						private long? modifyTime;

						public string Status
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

						public long? CreateTime
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

						public string DeleteStatus
						{
							get
							{
								return deleteStatus;
							}
							set	
							{
								deleteStatus = value;
							}
						}

						public int? IdExtent
						{
							get
							{
								return idExtent;
							}
							set	
							{
								idExtent = value;
							}
						}

						public string Creator
						{
							get
							{
								return creator;
							}
							set	
							{
								creator = value;
							}
						}

						public long? EndTime
						{
							get
							{
								return endTime;
							}
							set	
							{
								endTime = value;
							}
						}

						public long? StartTime
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

						public string Modifier
						{
							get
							{
								return modifier;
							}
							set	
							{
								modifier = value;
							}
						}

						public string ResultStatus
						{
							get
							{
								return resultStatus;
							}
							set	
							{
								resultStatus = value;
							}
						}

						public int? FlowInstId
						{
							get
							{
								return flowInstId;
							}
							set	
							{
								flowInstId = value;
							}
						}

						public string Name
						{
							get
							{
								return name;
							}
							set	
							{
								name = value;
							}
						}

						public int? Id
						{
							get
							{
								return id;
							}
							set	
							{
								id = value;
							}
						}

						public long? ModifyTime
						{
							get
							{
								return modifyTime;
							}
							set	
							{
								modifyTime = value;
							}
						}
					}

					public class GetPipelineInstHistory_Result
					{

						private int? enginePipelineNumber;

						private string mixFlowInstId;

						private string enginePipelineName;

						private int? enginePipelineId;

						private int? enginePipelineInstId;

						private string timeStamp;

						private string triggerMode;

						private string sources;

						private string caches;

						private string dateTime;

						public int? EnginePipelineNumber
						{
							get
							{
								return enginePipelineNumber;
							}
							set	
							{
								enginePipelineNumber = value;
							}
						}

						public string MixFlowInstId
						{
							get
							{
								return mixFlowInstId;
							}
							set	
							{
								mixFlowInstId = value;
							}
						}

						public string EnginePipelineName
						{
							get
							{
								return enginePipelineName;
							}
							set	
							{
								enginePipelineName = value;
							}
						}

						public int? EnginePipelineId
						{
							get
							{
								return enginePipelineId;
							}
							set	
							{
								enginePipelineId = value;
							}
						}

						public int? EnginePipelineInstId
						{
							get
							{
								return enginePipelineInstId;
							}
							set	
							{
								enginePipelineInstId = value;
							}
						}

						public string TimeStamp
						{
							get
							{
								return timeStamp;
							}
							set	
							{
								timeStamp = value;
							}
						}

						public string TriggerMode
						{
							get
							{
								return triggerMode;
							}
							set	
							{
								triggerMode = value;
							}
						}

						public string Sources
						{
							get
							{
								return sources;
							}
							set	
							{
								sources = value;
							}
						}

						public string Caches
						{
							get
							{
								return caches;
							}
							set	
							{
								caches = value;
							}
						}

						public string DateTime
						{
							get
							{
								return dateTime;
							}
							set	
							{
								dateTime = value;
							}
						}
					}
				}
			}
		}
	}
}
