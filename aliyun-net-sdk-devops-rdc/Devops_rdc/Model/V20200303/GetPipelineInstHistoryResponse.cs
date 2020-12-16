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

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
	public class GetPipelineInstHistoryResponse : AcsResponse
	{

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private GetPipelineInstHistory_Data data;

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

				private string creator;

				private long? modifyTime;

				private int? pipelineConfigId;

				private string modifier;

				private long? createTime;

				private string packages;

				private int? pipelineId;

				private int? flowInstId;

				private int? instNumber;

				private string deletion;

				private string statusName;

				private int? id;

				private int? triggerMode;

				private string status;

				private GetPipelineInstHistory_FlowInstance flowInstance;

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

					private string creator;

					private long? modifyTime;

					private string systemId;

					private string stageTopo;

					private string modifier;

					private bool? autoDrivenStatus;

					private long? createTime;

					private string resultStatus;

					private string runningStatus;

					private string systemCode;

					private string stages;

					private string statusName;

					private int? id;

					private string status;

					private List<GetPipelineInstHistory_Group> groups;

					private GetPipelineInstHistory_Result result;

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

						private string creator;

						private long? modifyTime;

						private string modifier;

						private long? createTime;

						private int? flowInstId;

						private string resultStatus;

						private string deleteStatus;

						private string name;

						private long? startTime;

						private long? endTime;

						private int? id;

						private int? idExtent;

						private string status;

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
					}

					public class GetPipelineInstHistory_Result
					{

						private string sources;

						private string caches;

						private int? enginePipelineId;

						private string mixFlowInstId;

						private string enginePipelineName;

						private int? enginePipelineNumber;

						private string dateTime;

						private string timeStamp;

						private string triggerMode;

						private int? enginePipelineInstId;

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
					}
				}
			}
		}
	}
}
