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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeChangeOrderResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribeChangeOrder_Data data;

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

		public DescribeChangeOrder_Data Data
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

		public class DescribeChangeOrder_Data
		{

			private int? status;

			private string description;

			private bool? supportAbortFreeze;

			private string createTime;

			private string changeOrderId;

			private string batchType;

			private string appName;

			private bool? auto;

			private string currentPipelineId;

			private string coTypeCode;

			private bool? supportRollback;

			private int? batchWaitTime;

			private string errorMessage;

			private string coType;

			private int? batchCount;

			private List<DescribeChangeOrder_Pipeline> pipelines;

			private List<string> coTargets;

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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public bool? SupportAbortFreeze
			{
				get
				{
					return supportAbortFreeze;
				}
				set	
				{
					supportAbortFreeze = value;
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

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public bool? Auto
			{
				get
				{
					return auto;
				}
				set	
				{
					auto = value;
				}
			}

			public string CurrentPipelineId
			{
				get
				{
					return currentPipelineId;
				}
				set	
				{
					currentPipelineId = value;
				}
			}

			public string CoTypeCode
			{
				get
				{
					return coTypeCode;
				}
				set	
				{
					coTypeCode = value;
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

			public int? BatchWaitTime
			{
				get
				{
					return batchWaitTime;
				}
				set	
				{
					batchWaitTime = value;
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

			public List<DescribeChangeOrder_Pipeline> Pipelines
			{
				get
				{
					return pipelines;
				}
				set	
				{
					pipelines = value;
				}
			}

			public List<string> CoTargets
			{
				get
				{
					return coTargets;
				}
				set	
				{
					coTargets = value;
				}
			}

			public class DescribeChangeOrder_Pipeline
			{

				private int? status;

				private string pipelineName;

				private int? parallelCount;

				private long? updateTime;

				private long? startTime;

				private string pipelineId;

				private int? batchType;

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

				public int? ParallelCount
				{
					get
					{
						return parallelCount;
					}
					set	
					{
						parallelCount = value;
					}
				}

				public long? UpdateTime
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

				public int? BatchType
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
			}
		}
	}
}
