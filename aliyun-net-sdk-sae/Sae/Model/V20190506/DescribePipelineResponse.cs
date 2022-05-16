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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribePipelineResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribePipeline_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
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

		public string Code
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

		public DescribePipeline_Data Data
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

		public class DescribePipeline_Data
		{

			private bool? showBatch;

			private int? pipelineStatus;

			private int? currentPoint;

			private string currentStageId;

			private string pipelineName;

			private string nextPipelineId;

			private string pipelineId;

			private string coStatus;

			private List<DescribePipeline_Stage> stageList;

			public bool? ShowBatch
			{
				get
				{
					return showBatch;
				}
				set	
				{
					showBatch = value;
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

			public int? CurrentPoint
			{
				get
				{
					return currentPoint;
				}
				set	
				{
					currentPoint = value;
				}
			}

			public string CurrentStageId
			{
				get
				{
					return currentStageId;
				}
				set	
				{
					currentStageId = value;
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

			public string NextPipelineId
			{
				get
				{
					return nextPipelineId;
				}
				set	
				{
					nextPipelineId = value;
				}
			}

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

			public string CoStatus
			{
				get
				{
					return coStatus;
				}
				set	
				{
					coStatus = value;
				}
			}

			public List<DescribePipeline_Stage> StageList
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

			public class DescribePipeline_Stage
			{

				private int? status;

				private string stageId;

				private int? executorType;

				private string stageName;

				private List<DescribePipeline_Task> taskList;

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

				public int? ExecutorType
				{
					get
					{
						return executorType;
					}
					set	
					{
						executorType = value;
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

				public List<DescribePipeline_Task> TaskList
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

				public class DescribePipeline_Task
				{

					private int? status;

					private string stageId;

					private string errorMessage;

					private string errorCode;

					private string taskName;

					private int? errorIgnore;

					private string message;

					private bool? showManualIgnore;

					private string taskId;

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

					public int? ErrorIgnore
					{
						get
						{
							return errorIgnore;
						}
						set	
						{
							errorIgnore = value;
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

					public bool? ShowManualIgnore
					{
						get
						{
							return showManualIgnore;
						}
						set	
						{
							showManualIgnore = value;
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
				}
			}
		}
	}
}
